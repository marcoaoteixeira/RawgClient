using System.ComponentModel;

namespace Nameless.RawgClient.Infrastructure {
    public enum OrderingOptions {
        [Description("")]
        None,

        [Description("name")]
        Name,
        
        [Description("released")]
        Released,

        [Description("added")]
        Added,

        [Description("created")]
        Created,

        [Description("updated")]
        Updated,

        [Description("rating")]
        Rating,

        [Description("metacritic")]
        Metacritic
    }
}
