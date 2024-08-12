namespace Nameless.RawgClient.Common {
    public static class Endpoints {
        public static class CreatorRoles {
            /// <summary>
            /// GetEndpoint a list of creator positions (jobs).
            /// </summary>
            public const string GetCreatorRoles = "/api/creator-roles";
        }

        public static class Creators {
            /// <summary>
            /// GetEndpoint a list of game creators.
            /// </summary>
            public const string GetCreators = "/api/creators";

#if NET8_0_OR_GREATER
            /// <summary>
            /// GetEndpoint details of the creator.
            /// </summary>
            public static readonly CompositeFormat GetCreatorDetails = CompositeFormat.Parse("/api/creators/{0}");
#else
            /// <summary>
            /// GetEndpoint details of the creator.
            /// </summary>
            public const string GetCreatorDetails = "/api/creators/{0}";
#endif
        }

        public static class Developers {
            /// <summary>
            /// GetEndpoint a list of game developers.
            /// </summary>
            public const string GetDevelopers = "/api/developers";

#if NET8_0_OR_GREATER
            /// <summary>
            /// GetEndpoint details of the developer.
            /// </summary>
            public static readonly CompositeFormat GetDeveloperDetails = CompositeFormat.Parse("/api/developers/{0}");
#else
            /// <summary>
            /// GetEndpoint details of the developer.
            /// </summary>
            public const string GetDeveloperDetails = "/api/developers/{0}";
#endif
        }

        public static class Games {
            /// <summary>
            /// GetEndpoint a list of games.
            /// </summary>
            public const string GetGames = "/api/games";

#if NET8_0_OR_GREATER
            /// <summary>
            /// GetEndpoint a list of DLC's for the game, GOTY and other editions, companion apps, etc.
            /// </summary>
            public static readonly CompositeFormat GetGameAdditions = CompositeFormat.Parse("/api/games/{0}/additions");

            /// <summary>
            /// GetEndpoint a list of individual creators that were part of the development team.
            /// </summary>
            public static readonly CompositeFormat GetGameDevelopmentTeam = CompositeFormat.Parse("/api/games/{0}/development-team");

            /// <summary>
            /// GetEndpoint a list of games that are part of the same series.
            /// </summary>
            public static readonly CompositeFormat GetGameSeries = CompositeFormat.Parse("/api/games/{0}/game-series");

            /// <summary>
            /// GetEndpoint a list of parent games for DLC's and editions.
            /// </summary>
            public static readonly CompositeFormat GetGameParentGames = CompositeFormat.Parse("/api/games/{0}/parent-games");

            /// <summary>
            /// GetEndpoint screenshots for the game.
            /// </summary>
            public static readonly CompositeFormat GetGameScreenshots = CompositeFormat.Parse("/api/games/{0}/screenshots");

            /// <summary>
            /// GetEndpoint links to the stores that sell the game.
            /// </summary>
            public static readonly CompositeFormat GetGameStores = CompositeFormat.Parse("/api/games/{0}/stores");

            /// <summary>
            /// GetEndpoint details of the game.
            /// </summary>
            public static readonly CompositeFormat GetGameDetails = CompositeFormat.Parse("/api/games/{0}");

            /// <summary>
            /// GetEndpoint a list of game achievements.
            /// </summary>
            public static readonly CompositeFormat GetGameAchievements = CompositeFormat.Parse("/api/games/{0}/achievements");

            /// <summary>
            /// GetEndpoint a list of game trailers.
            /// </summary>
            public static readonly CompositeFormat GetGameMovies = CompositeFormat.Parse("/api/games/{0}/movies");

            /// <summary>
            /// GetEndpoint a list of most recent posts from the game's subreddit.
            /// </summary>
            public static readonly CompositeFormat GetGameReddit = CompositeFormat.Parse("/api/games/{0}/reddit");

            /// <summary>
            /// GetEndpoint a list of visually similar games, available only for business and enterprise API users.
            /// </summary>
            public static readonly CompositeFormat GetGameSuggested = CompositeFormat.Parse("/api/games/{0}/suggested");

            /// <summary>
            /// GetEndpoint streams on Twitch associated with the game, available only for business and enterprise API users.
            /// </summary>
            public static readonly CompositeFormat GetGameTwitch = CompositeFormat.Parse("/api/games/{0}/twitch");

            /// <summary>
            /// GetEndpoint videos from YouTube associated with the game, available only for business and enterprise API users.
            /// </summary>
            public static readonly CompositeFormat GetGameYouTube = CompositeFormat.Parse("/api/games/{0}/youtube");
#else
            /// <summary>
            /// GetEndpoint a list of DLC's for the game, GOTY and other editions, companion apps, etc.
            /// </summary>
            public const string GetGameAdditions = "/api/games/{0}/additions";

            /// <summary>
            /// GetEndpoint a list of individual creators that were part of the development team.
            /// </summary>
            public const string GetGameDevelopmentTeam = "/api/games/{0}/development-team";

            /// <summary>
            /// GetEndpoint a list of games that are part of the same series.
            /// </summary>
            public const string GetGameSeries = "/api/games/{0}/game-series";

            /// <summary>
            /// GetEndpoint a list of parent games for DLC's and editions.
            /// </summary>
            public const string GetGameParentGames = "/api/games/{0}/parent-games";

            /// <summary>
            /// GetEndpoint screenshots for the game.
            /// </summary>
            public const string GetGameScreenshots = "/api/games/{0}/screenshots";

            /// <summary>
            /// GetEndpoint links to the stores that sell the game.
            /// </summary>
            public const string GetGameStores = "/api/games/{0}/stores";

            /// <summary>
            /// GetEndpoint details of the game.
            /// </summary>
            public const string GetGameDetails = "/api/games/{0}";

            /// <summary>
            /// GetEndpoint a list of game achievements.
            /// </summary>
            public const string GetGameAchievements = "/api/games/{0}/achievements";

            /// <summary>
            /// GetEndpoint a list of game trailers.
            /// </summary>
            public const string GetGameMovies = "/api/games/{0}/movies";

            /// <summary>
            /// GetEndpoint a list of most recent posts from the game's subreddit.
            /// </summary>
            public const string GetGameReddit = "/api/games/{0}/reddit";

            /// <summary>
            /// GetEndpoint a list of visually similar games, available only for business and enterprise API users.
            /// </summary>
            public const string GetGameSuggested = "/api/games/{0}/suggested";

            /// <summary>
            /// GetEndpoint streams on Twitch associated with the game, available only for business and enterprise API users.
            /// </summary>
            public const string GetGameTwitch = "/api/games/{0}/twitch";

            /// <summary>
            /// GetEndpoint videos from YouTube associated with the game, available only for business and enterprise API users.
            /// </summary>
            public const string GetGameYouTube = "/api/games/{0}/youtube";
#endif
        }

        public static class Genres {
            /// <summary>
            /// GetEndpoint a list of video game genres.
            /// </summary>
            public const string GetGenres = "/api/genres";

#if NET8_0_OR_GREATER
            /// <summary>
            /// GetEndpoint details of the genre.
            /// </summary>
            public static readonly CompositeFormat GetGenreDetails = CompositeFormat.Parse("/api/genres/{0}");
#else
            /// <summary>
            /// GetEndpoint details of the genre.
            /// </summary>
            public const string GetGenreDetails = "/api/genres/{0}";
#endif
        }

        public static class Platforms {
            /// <summary>
            /// GetEndpoint a list of video game platforms.
            /// </summary>
            public const string GetPlatforms = "/api/platforms";

            /// <summary>
            /// GetEndpoint a list of parent platforms.
            /// </summary>
            public const string GetParentPlatforms = "/api/platforms/list/parents";

#if NET8_0_OR_GREATER
            /// <summary>
            /// GetEndpoint details of the platform.
            /// </summary>
            public static readonly CompositeFormat GetPlatformDetails = CompositeFormat.Parse("/api/platforms/{0}");
#else
            /// <summary>
            /// GetEndpoint details of the platform.
            /// </summary>
            public const string GetPlatformDetails = "/api/platforms/{0}";
#endif
        }

        public static class Publishers {
            /// <summary>
            /// GetEndpoint a list of video game publishers.
            /// </summary>
            public const string GetPublishers = "/api/publishers";

#if NET8_0_OR_GREATER
            /// <summary>
            /// GetEndpoint details of the publisher.
            /// </summary>
            public static readonly CompositeFormat GetPublisherDetails = CompositeFormat.Parse("/api/publishers/{0}");
#else
            /// <summary>
            /// GetEndpoint details of the publisher.
            /// </summary>            
            public const string GetPublisherDetails = "/api/publishers/{0}";
#endif
        }

        public static class Stores {
            /// <summary>
            /// GetEndpoint a list of video game storefronts.
            /// </summary>
            public const string GetStores = "/api/stores";

#if NET8_0_OR_GREATER
            /// <summary>
            /// GetEndpoint details of the store.
            /// </summary>
            public static readonly CompositeFormat GetStoreDetails = CompositeFormat.Parse("/api/stores/{0}");
#else
            /// <summary>
            /// GetEndpoint details of the store.
            /// </summary>
            public const string GetStoreDetails = "/api/stores/{0}";
#endif
        }

        public static class Tags {
            /// <summary>
            /// GetEndpoint a list of tags.
            /// </summary>
            public const string GetTags = "/api/tags";

#if NET8_0_OR_GREATER
            /// <summary>
            /// GetEndpoint details of the tag.
            /// </summary>
            public static readonly CompositeFormat GetTagDetails = CompositeFormat.Parse("/api/tags/{0}");
#else
            /// <summary>
            /// GetEndpoint details of the tag.
            /// </summary>
            public const string GetTagDetails = "/api/tags/{0}";
#endif
        }
    }
}
