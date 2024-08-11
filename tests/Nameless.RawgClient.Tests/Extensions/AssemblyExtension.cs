using System.Reflection;

namespace Nameless.RawgClient {
    internal static class AssemblyExtension {
        internal static string GetDirectoryPath(this Assembly self, params string[] combineWith) {
            var location = $"file://{self.Location}";
            var uri = new UriBuilder(location);
            var path = Uri.UnescapeDataString(uri.Path);

            var result = Path.GetDirectoryName(path)!;

            return combineWith.Length > 0
                ? Path.Combine(combineWith.Prepend(result).ToArray())
                : result;
        }
    }
}
