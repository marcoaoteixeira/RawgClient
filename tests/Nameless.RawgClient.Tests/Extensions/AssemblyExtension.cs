using System.Reflection;

namespace Nameless.RawgClient {
    internal static class AssemblyExtension {
        internal static string GetDirectoryPath(this Assembly self, params string[] combineWith) {
            var location = $"file://{self.Location}";
            var uri = new UriBuilder(location);
            var uriPath = Uri.UnescapeDataString(uri.Path);
            var directoryPath = Path.GetDirectoryName(uriPath)!;

            var result = combineWith.Length > 0
                ? Path.Combine(combineWith.Prepend(directoryPath)
                                          .ToArray())
                : directoryPath;

            return result.Replace(Path.AltDirectorySeparatorChar, Path.DirectorySeparatorChar);
        }
    }
}
