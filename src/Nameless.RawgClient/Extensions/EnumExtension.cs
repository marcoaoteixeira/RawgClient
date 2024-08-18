using System.ComponentModel;
using System.Reflection;

namespace Nameless.RawgClient {
    internal static class EnumExtension {
        internal static string GetDescription(this Enum self) {
            var attr = self.GetType()
                           .GetField(self.ToString())?
                           .GetCustomAttribute<DescriptionAttribute>();

            return attr is not null ? attr.Description : string.Empty;
        }
    }
}
