"""IdeaSoftApi MCP sunucuları için güvenli örnek Python istemcisi."""

from __future__ import annotations

import argparse
import asyncio
import json
import os
from pathlib import Path
from typing import Any

from mcp import Client, StdioServerParameters


EXPECTED_TOOLS = {
    "ideasoft_status",
    "ideasoft_authorization_url",
    "ideasoft_list",
    "ideasoft_get",
    "ideasoft_request",
    "ideasoft_webhook_list",
    "ideasoft_webhook_create",
    "ideasoft_webhook_update",
    "ideasoft_webhook_delete",
    "ideasoft_verify_webhook",
    "ideasoft_capabilities",
    "ideasoft_migration_checklist",
}

EXPECTED_RESOURCES = {
    "ideasoft://guide/capabilities",
    "ideasoft://guide/security",
    "ideasoft://guide/migration",
}

SAFE_WINDOWS_ENVIRONMENT = {
    "APPDATA",
    "HOMEDRIVE",
    "HOMEPATH",
    "LOCALAPPDATA",
    "PATH",
    "PATHEXT",
    "PROCESSOR_ARCHITECTURE",
    "PROGRAMFILES",
    "SYSTEMDRIVE",
    "SYSTEMROOT",
    "TEMP",
    "TMP",
    "USERNAME",
    "USERPROFILE",
}

SAFE_POSIX_ENVIRONMENT = {"HOME", "LOGNAME", "PATH", "SHELL", "TERM", "USER"}


def main() -> None:
    raise SystemExit(asyncio.run(run()))


async def run() -> int:
    parser = argparse.ArgumentParser(description="IdeaSoftApi MCP çevrimdışı bağlantı örneği")
    parser.add_argument("--server", choices=("python", "dotnet"), default="python")
    args = parser.parse_args()

    try:
        root = find_repository_root()
        parameters = create_server_parameters(args.server, root)
        passed = 0

        async with Client(parameters, read_timeout_seconds=60) as client:
            tools = await client.list_tools()
            check({tool.name for tool in tools.tools} == EXPECTED_TOOLS, f"12 araç bulundu ({args.server} sunucusu)")
            passed += 1

            resources = await client.list_resources()
            check({str(resource.uri) for resource in resources.resources} == EXPECTED_RESOURCES, "3 rehber kaynağı bulundu")
            passed += 1

            capabilities = await client.call_tool("ideasoft_capabilities")
            capabilities_json = structured_json(capabilities)
            check(not capabilities.is_error and "IdeaSoftApi MCP" in capabilities_json, "Yerel yetenek bilgisi okundu")
            passed += 1

            status = await client.call_tool("ideasoft_status")
            status_data = status.structured_content
            check(
                not status.is_error
                and isinstance(status_data, dict)
                and get_case_insensitive(status_data, "writesEnabled") is False
                and get_case_insensitive(status_data, "secretsAreReturned") is False
                and get_case_insensitive(status_data, "accessTokenConfigured") is False,
                "Secret aktarılmadan güvenli durum bilgisi alındı",
            )
            passed += 1

            migration = await client.call_tool("ideasoft_migration_checklist")
            migration_data = migration.structured_content
            check(
                not migration.is_error
                and isinstance(migration_data, dict)
                and bool(get_case_insensitive(migration_data, "steps"))
                and bool(get_case_insensitive(migration_data, "safetyRules")),
                "Taşıma kontrol listesi okundu",
            )
            passed += 1

            security = await client.read_resource("ideasoft://guide/security")
            security_text = json.dumps(security.model_dump(mode="json"), ensure_ascii=False)
            check("secret" in security_text.lower() and "yazma" in security_text.lower(), "Güvenlik kaynağı okundu")
            passed += 1

        print(f"Sonuç: {passed}/6 test başarılı. İstemci=Python, Sunucu={args.server}")
        return 0
    except Exception as exception:  # Hata zinciri secret içermeyen yerel doğrulama mesajlarından oluşur.
        print(f"[BAŞARISIZ] {format_error(exception)}")
        return 1


def create_server_parameters(server: str, root: Path) -> StdioServerParameters:
    if server == "python":
        return StdioServerParameters(
            command="uv",
            args=["run", "--offline", "--project", str(root / "IdeaSoftApi.Mcp.Python"), "ideasoftapi-mcp"],
            cwd=str(root),
            env=safe_environment(),
        )

    return StdioServerParameters(
        command="dotnet",
        args=["run", "--project", str(root / "IdeaSoftApi.Mcp.DotNet"), "-c", "Release", "--no-build"],
        cwd=str(root),
        env=safe_environment(),
    )


def safe_environment() -> dict[str, str]:
    allowed = SAFE_WINDOWS_ENVIRONMENT if os.name == "nt" else SAFE_POSIX_ENVIRONMENT
    environment = {name: value for name, value in os.environ.items() if name.upper() in allowed}
    environment["DOTNET_NOLOGO"] = "1"
    environment["Logging__LogLevel__Default"] = "Warning"
    environment["NO_COLOR"] = "1"
    return environment


def find_repository_root() -> Path:
    starts = (Path.cwd(), Path(__file__).resolve())
    for start in starts:
        for directory in (start, *start.parents):
            if (directory / "IdeaSoftApiIntegration.sln").is_file():
                return directory
    raise FileNotFoundError("IdeaSoftApiIntegration.sln bulunamadı.")


def structured_json(result: Any) -> str:
    if result.structured_content is None:
        raise RuntimeError("Araç yapılandırılmış sonuç döndürmedi.")
    return json.dumps(result.structured_content, ensure_ascii=False, default=str)


def get_case_insensitive(values: dict[str, Any], name: str) -> Any:
    return next((value for key, value in values.items() if key.lower() == name.lower()), None)


def format_error(exception: BaseException) -> str:
    if isinstance(exception, BaseExceptionGroup):
        return " | ".join(format_error(item) for item in exception.exceptions)
    return str(exception)


def check(condition: bool, description: str) -> None:
    if not condition:
        raise RuntimeError(description)
    print(f"[BAŞARILI] {description}")
