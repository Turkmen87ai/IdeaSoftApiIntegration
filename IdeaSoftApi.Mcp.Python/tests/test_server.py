import asyncio
import unittest

from ideasoftapi_mcp.server import mcp


class ServerContractTests(unittest.TestCase):
    def test_expected_tools_are_registered(self):
        tools = asyncio.run(mcp.list_tools())
        names = {tool.name for tool in tools}
        self.assertEqual(12, len(names))
        self.assertIn("ideasoft_request", names)
        self.assertIn("ideasoft_verify_webhook", names)
        list_tool = next(tool for tool in tools if tool.name == "ideasoft_list")
        delete_tool = next(tool for tool in tools if tool.name == "ideasoft_webhook_delete")
        self.assertTrue(list_tool.annotations.read_only_hint)
        self.assertTrue(delete_tool.annotations.destructive_hint)

    def test_expected_resources_are_registered(self):
        resources = asyncio.run(mcp.list_resources())
        uris = {str(resource.uri) for resource in resources}
        self.assertEqual(
            {
                "ideasoft://guide/capabilities",
                "ideasoft://guide/security",
                "ideasoft://guide/migration",
            },
            uris,
        )


if __name__ == "__main__":
    unittest.main()
