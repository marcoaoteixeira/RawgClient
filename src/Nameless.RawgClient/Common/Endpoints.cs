namespace Nameless.RawgClient.Common {
    public static class Endpoints {
        public static class CreatorRoles {
            /// <summary>
            /// Gets a list of creator positions (jobs).
            /// </summary>
            public const string GetCreatorRoles = "/api/creator-roles";
        }

        public static class Creators {
            /// <summary>
            /// Gets a list of game creators.
            /// </summary>
            public const string GetCreators = "/api/creators";

            /// <summary>
            /// Gets details of the creator.
            /// </summary>
            public const string GetCreatorDetails = "/api/creators/{0}";
        }

        public static class Developers {
            /// <summary>
            /// Gets a list of game developers.
            /// </summary>
            public const string GetDevelopers = "/api/developers";

            /// <summary>
            /// Gets details of the developer.
            /// </summary>
            public const string GetDeveloperDetails = "/api/developers/{0}";
        }

        public static class Games {
            /// <summary>
            /// Gets a list of games.
            /// </summary>
            public const string GetGames = "/api/games";

            /// <summary>
            /// Gets a list of DLC's for the game, GOTY and other editions, companion apps, etc.
            /// </summary>
            public const string GetGameAdditions = "/api/games/{0}/additions";

            /// <summary>
            /// Gets a list of individual creators that were part of the development team.
            /// </summary>
            public const string GetGameDevelopmentTeam = "/api/games/{0}/development-team";

            /// <summary>
            /// Gets a list of games that are part of the same series.
            /// </summary>
            public const string GetGameSeries = "/api/games/{0}/game-series";

            /// <summary>
            /// Gets a list of parent games for DLC's and editions.
            /// </summary>
            public const string GetGameParentGames = "/api/games/{0}/parent-games";

            /// <summary>
            /// Gets screenshots for the game.
            /// </summary>
            public const string GetGameScreenshots = "/api/games/{0}/screenshots";

            /// <summary>
            /// Gets links to the stores that sell the game.
            /// </summary>
            public const string GetGameStores = "/api/games/{0}/stores";

            /// <summary>
            /// Gets details of the game.
            /// </summary>
            public const string GetGameDetails = "/api/games/{0}";

            /// <summary>
            /// Gets a list of game achievements.
            /// </summary>
            public const string GetGameAchievements = "/api/games/{0}/achievements";

            /// <summary>
            /// Gets a list of game trailers.
            /// </summary>
            public const string GetGameTrailers = "/api/games/{0}/movies";

            /// <summary>
            /// Gets a list of most recent posts from the game's subreddit.
            /// </summary>
            public const string GetGameRedditPosts = "/api/games/{0}/reddit";

            /// <summary>
            /// Gets a list of visually similar games, available only for business and enterprise API users.
            /// </summary>
            public const string GetGameSuggestions = "/api/games/{0}/suggested";

            /// <summary>
            /// Gets streams on Twitch associated with the game, available only for business and enterprise API users.
            /// </summary>
            public const string GetGameTwitchStreams = "/api/games/{0}/twitch";

            /// <summary>
            /// Gets videos from YouTube associated with the game, available only for business and enterprise API users.
            /// </summary>
            public const string GetGameYouTubeChannels = "/api/games/{0}/youtube";
        }

        public static class Genres {
            /// <summary>
            /// Gets a list of video game genres.
            /// </summary>
            public const string GetGenres = "/api/genres";

            /// <summary>
            /// Gets details of the genre.
            /// </summary>
            public const string GetGenreDetails = "/api/genres/{0}";
        }

        public static class Platforms {
            /// <summary>
            /// Gets a list of video game platforms.
            /// </summary>
            public const string GetPlatforms = "/api/platforms";

            /// <summary>
            /// Gets a list of parent platforms.
            /// </summary>
            public const string GetParentPlatforms = "/api/platforms/list/parents";

            /// <summary>
            /// Gets details of the platform.
            /// </summary>
            public const string GetPlatformDetails = "/api/platforms/{0}";
        }

        public static class Publishers {
            /// <summary>
            /// Gets a list of video game publishers.
            /// </summary>
            public const string GetPublishers = "/api/publishers";

            /// <summary>
            /// Gets details of the publisher.
            /// </summary>            
            public const string GetPublisherDetails = "/api/publishers/{0}";
        }

        public static class Stores {
            /// <summary>
            /// Gets a list of video game storefronts.
            /// </summary>
            public const string GetStores = "/api/stores";

            /// <summary>
            /// Gets details of the store.
            /// </summary>
            public const string GetStoreDetails = "/api/stores/{0}";
        }

        public static class Tags {
            /// <summary>
            /// Gets a list of tags.
            /// </summary>
            public const string GetTags = "/api/tags";

            /// <summary>
            /// Gets details of the tag.
            /// </summary>
            public const string GetTagDetails = "/api/tags/{0}";
        }
    }
}
