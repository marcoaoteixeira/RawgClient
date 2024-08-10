namespace Nameless.RawgClient.Common {
    internal static class Endpoints {
        internal static class CreatorRoles {
            internal const string GetCreatorRoles = "/api/creator-roles";
        }

        internal static class Creators {
            internal const string GetCreators = "/api/creators";

#if NET8_0_OR_GREATER
        internal static readonly CompositeFormat GetCreatorDetails = CompositeFormat.Parse("/api/creators/{0}");
#else
            internal const string GetCreatorDetails = "/api/creators/{0}";
#endif
        }

        internal static class Developers {
            internal const string GetDevelopers = "/api/developers";

#if NET8_0_OR_GREATER
        internal static readonly CompositeFormat GetDeveloperDetails = CompositeFormat.Parse("/api/developers/{0}");
#else
            internal const string GetDeveloperDetails = "/api/developers/{0}";
#endif
        }

        internal static class Genres {
            internal const string GetGenres = "/api/genres";

#if NET8_0_OR_GREATER
        internal static readonly CompositeFormat GetGenreDetails = CompositeFormat.Parse("/api/genres/{0}");
#else
            internal const string GetGenreDetails = "/api/genres/{0}";
#endif
        }

        internal static class Publishers {
            internal const string GetPublishers = "/api/publishers";

#if NET8_0_OR_GREATER
        internal static readonly CompositeFormat GetPublisherDetails = CompositeFormat.Parse("/api/publishers/{0}");
#else
            internal const string GetPublisherDetails = "/api/publishers/{0}";
#endif
        }

        internal static class Tags {
            internal const string GetTags = "/api/tags";

#if NET8_0_OR_GREATER
            internal static readonly CompositeFormat GetTagDetails = CompositeFormat.Parse("/api/tags/{0}");
#else
            internal const string GetTagDetails = "/api/tags/{0}";
#endif
        }

        internal static class Stores {
            internal const string GetStores = "/api/stores";

#if NET8_0_OR_GREATER
            internal static readonly CompositeFormat GetStoreDetails = CompositeFormat.Parse("/api/stores/{0}");
#else
            internal const string GetStoreDetails = "/api/stores/{0}";
#endif
        }
    }
}
