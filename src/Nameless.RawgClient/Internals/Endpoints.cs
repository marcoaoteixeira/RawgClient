namespace Nameless.RawgClient {
    internal static class Endpoints {
        internal static class CreatorRoles {
            /// <summary>
            /// GetEndpoint a list of creator positions (jobs).
            /// </summary>
            internal const string GetCreatorRoles = "/api/creator-roles";
        }

        internal static class Creators {
            /// <summary>
            /// GetEndpoint a list of game creators.
            /// </summary>
            internal const string GetCreators = "/api/creators";

#if NET8_0_OR_GREATER
            /// <summary>
            /// GetEndpoint details of the creator.
            /// </summary>
            internal static readonly CompositeFormat GetCreatorDetails = CompositeFormat.Parse("/api/creators/{0}");
#else
            /// <summary>
            /// GetEndpoint details of the creator.
            /// </summary>
            internal const string GetCreatorDetails = "/api/creators/{0}";
#endif
        }

        internal static class Developers {
            /// <summary>
            /// GetEndpoint a list of game developers.
            /// </summary>
            internal const string GetDevelopers = "/api/developers";

#if NET8_0_OR_GREATER
            /// <summary>
            /// GetEndpoint details of the developer.
            /// </summary>
            internal static readonly CompositeFormat GetDeveloperDetails = CompositeFormat.Parse("/api/developers/{0}");
#else
            /// <summary>
            /// GetEndpoint details of the developer.
            /// </summary>
            internal const string GetDeveloperDetails = "/api/developers/{0}";
#endif
        }

        internal static class Games {
            /// <summary>
            /// GetEndpoint a list of games.
            /// </summary>
            internal const string GetGames = "/api/games";

#if NET8_0_OR_GREATER
            /// <summary>
            /// GetEndpoint a list of DLC's for the game, GOTY and other editions, companion apps, etc.
            /// </summary>
            internal static readonly CompositeFormat GetGameAdditions = CompositeFormat.Parse("/api/games/{0}/additions");

            /// <summary>
            /// GetEndpoint a list of individual creators that were part of the development team.
            /// </summary>
            internal static readonly CompositeFormat GetGameDevelopmentTeam = CompositeFormat.Parse("/api/games/{0}/development-team");

            /// <summary>
            /// GetEndpoint a list of games that are part of the same series.
            /// </summary>
            internal static readonly CompositeFormat GetGameSeries = CompositeFormat.Parse("/api/games/{0}/game-series");

            /// <summary>
            /// GetEndpoint a list of parent games for DLC's and editions.
            /// </summary>
            internal static readonly CompositeFormat GetGameParentGames = CompositeFormat.Parse("/api/games/{0}/parent-games");

            /// <summary>
            /// GetEndpoint screenshots for the game.
            /// </summary>
            internal static readonly CompositeFormat GetGameScreenshots = CompositeFormat.Parse("/api/games/{0}/screenshots");

            /// <summary>
            /// GetEndpoint links to the stores that sell the game.
            /// </summary>
            internal static readonly CompositeFormat GetGameStores = CompositeFormat.Parse("/api/games/{0}/stores");

            /// <summary>
            /// GetEndpoint details of the game.
            /// </summary>
            internal static readonly CompositeFormat GetGameDetails = CompositeFormat.Parse("/api/games/{0}");

            /// <summary>
            /// GetEndpoint a list of game achievements.
            /// </summary>
            internal static readonly CompositeFormat GetGameAchievements = CompositeFormat.Parse("/api/games/{0}/achievements");

            /// <summary>
            /// GetEndpoint a list of game trailers.
            /// </summary>
            internal static readonly CompositeFormat GetGameMovies = CompositeFormat.Parse("/api/games/{0}/movies");

            /// <summary>
            /// GetEndpoint a list of most recent posts from the game's subreddit.
            /// </summary>
            internal static readonly CompositeFormat GetGameReddit = CompositeFormat.Parse("/api/games/{0}/reddit");

            /// <summary>
            /// GetEndpoint a list of visually similar games, available only for business and enterprise API users.
            /// </summary>
            internal static readonly CompositeFormat GetGameSuggested = CompositeFormat.Parse("/api/games/{0}/suggested");

            /// <summary>
            /// GetEndpoint streams on Twitch associated with the game, available only for business and enterprise API users.
            /// </summary>
            internal static readonly CompositeFormat GetGameTwitch = CompositeFormat.Parse("/api/games/{0}/twitch");

            /// <summary>
            /// GetEndpoint videos from YouTube associated with the game, available only for business and enterprise API users.
            /// </summary>
            internal static readonly CompositeFormat GetGameYouTube = CompositeFormat.Parse("/api/games/{0}/youtube");
#else
            /// <summary>
            /// GetEndpoint a list of DLC's for the game, GOTY and other editions, companion apps, etc.
            /// </summary>
            internal const string GetGameAdditions = "/api/games/{0}/additions";

            /// <summary>
            /// GetEndpoint a list of individual creators that were part of the development team.
            /// </summary>
            internal const string GetGameDevelopmentTeam = "/api/games/{0}/development-team";

            /// <summary>
            /// GetEndpoint a list of games that are part of the same series.
            /// </summary>
            internal const string GetGameSeries = "/api/games/{0}/game-series";

            /// <summary>
            /// GetEndpoint a list of parent games for DLC's and editions.
            /// </summary>
            internal const string GetGameParentGames = "/api/games/{0}/parent-games";

            /// <summary>
            /// GetEndpoint screenshots for the game.
            /// </summary>
            internal const string GetGameScreenshots = "/api/games/{0}/screenshots";

            /// <summary>
            /// GetEndpoint links to the stores that sell the game.
            /// </summary>
            internal const string GetGameStores = "/api/games/{0}/stores";

            /// <summary>
            /// GetEndpoint details of the game.
            /// </summary>
            internal const string GetGameDetails = "/api/games/{0}";

            /// <summary>
            /// GetEndpoint a list of game achievements.
            /// </summary>
            internal const string GetGameAchievements = "/api/games/{0}/achievements";

            /// <summary>
            /// GetEndpoint a list of game trailers.
            /// </summary>
            internal const string GetGameMovies = "/api/games/{0}/movies";

            /// <summary>
            /// GetEndpoint a list of most recent posts from the game's subreddit.
            /// </summary>
            internal const string GetGameReddit = "/api/games/{0}/reddit";

            /// <summary>
            /// GetEndpoint a list of visually similar games, available only for business and enterprise API users.
            /// </summary>
            internal const string GetGameSuggested = "/api/games/{0}/suggested";

            /// <summary>
            /// GetEndpoint streams on Twitch associated with the game, available only for business and enterprise API users.
            /// </summary>
            internal const string GetGameTwitch = "/api/games/{0}/twitch";

            /// <summary>
            /// GetEndpoint videos from YouTube associated with the game, available only for business and enterprise API users.
            /// </summary>
            internal const string GetGameYouTube = "/api/games/{0}/youtube";
#endif
        }

        internal static class Genres {
            /// <summary>
            /// GetEndpoint a list of video game genres.
            /// </summary>
            internal const string GetGenres = "/api/genres";

#if NET8_0_OR_GREATER
            /// <summary>
            /// GetEndpoint details of the genre.
            /// </summary>
            internal static readonly CompositeFormat GetGenreDetails = CompositeFormat.Parse("/api/genres/{0}");
#else
            /// <summary>
            /// GetEndpoint details of the genre.
            /// </summary>
            internal const string GetGenreDetails = "/api/genres/{0}";
#endif
        }

        internal static class Platforms {
            /// <summary>
            /// GetEndpoint a list of video game platforms.
            /// </summary>
            internal const string GetPlatforms = "/api/platforms";

            /// <summary>
            /// GetEndpoint a list of parent platforms.
            /// </summary>
            internal const string GetParentPlatforms = "/api/platforms/list/parents";

#if NET8_0_OR_GREATER
            /// <summary>
            /// GetEndpoint details of the platform.
            /// </summary>
            internal static readonly CompositeFormat GetPlatformDetails = CompositeFormat.Parse("/api/platforms/{0}");
#else
            /// <summary>
            /// GetEndpoint details of the platform.
            /// </summary>
            internal const string GetPlatformDetails = "/api/platforms/{0}";
#endif
        }

        internal static class Publishers {
            /// <summary>
            /// GetEndpoint a list of video game publishers.
            /// </summary>
            internal const string GetPublishers = "/api/publishers";

#if NET8_0_OR_GREATER
            /// <summary>
            /// GetEndpoint details of the publisher.
            /// </summary>
            internal static readonly CompositeFormat GetPublisherDetails = CompositeFormat.Parse("/api/publishers/{0}");
#else
            /// <summary>
            /// GetEndpoint details of the publisher.
            /// </summary>            
            internal const string GetPublisherDetails = "/api/publishers/{0}";
#endif
        }

        internal static class Stores {
            /// <summary>
            /// GetEndpoint a list of video game storefronts.
            /// </summary>
            internal const string GetStores = "/api/stores";

#if NET8_0_OR_GREATER
            /// <summary>
            /// GetEndpoint details of the store.
            /// </summary>
            internal static readonly CompositeFormat GetStoreDetails = CompositeFormat.Parse("/api/stores/{0}");
#else
            /// <summary>
            /// GetEndpoint details of the store.
            /// </summary>
            internal const string GetStoreDetails = "/api/stores/{0}";
#endif
        }

        internal static class Tags {
            /// <summary>
            /// GetEndpoint a list of tags.
            /// </summary>
            internal const string GetTags = "/api/tags";

#if NET8_0_OR_GREATER
            /// <summary>
            /// GetEndpoint details of the tag.
            /// </summary>
            internal static readonly CompositeFormat GetTagDetails = CompositeFormat.Parse("/api/tags/{0}");
#else
            /// <summary>
            /// GetEndpoint details of the tag.
            /// </summary>
            internal const string GetTagDetails = "/api/tags/{0}";
#endif
        }
    }
}
