using System.Globalization;
using Nameless.RawgClient.Common;
using Nameless.RawgClient.Requests.CreatorRoles;
using Nameless.RawgClient.Requests.Creators;
using Nameless.RawgClient.Requests.Developers;
using Nameless.RawgClient.Requests.Games;
using Nameless.RawgClient.Requests.Genres;
using Nameless.RawgClient.Requests.Platforms;
using Nameless.RawgClient.Requests.Publishers;
using Nameless.RawgClient.Requests.Stores;
using Nameless.RawgClient.Requests.Tags;

namespace Nameless.RawgClient.Infrastructure.Impl {
    /// <summary>
    /// Implementation of <see cref="IEndpointProvider"/>
    /// </summary>
    public class EndpointProvider : IEndpointProvider {
        /*** Yep, I know. It's ugly but gets the job done. ***/

        /// <inheritdoc />
        public string GetEndpoint(Request request)
            => request switch {
                GetCreatorRolesRequest => Endpoints.CreatorRoles.GetCreatorRoles,

                GetCreatorsRequest => Endpoints.Creators.GetCreators,
                GetCreatorDetailsRequest inner => string.Format(CultureInfo.CurrentCulture, Endpoints.Creators.GetCreatorDetails, inner.Id),

                GetDevelopersRequest => Endpoints.Developers.GetDevelopers,
                GetDeveloperDetailsRequest inner => string.Format(CultureInfo.CurrentCulture, Endpoints.Developers.GetDeveloperDetails, inner.Id),

                GetGameAchievementsRequest inner => string.Format(CultureInfo.CurrentCulture, Endpoints.Games.GetGameAchievements, inner.Id),
                GetGameAdditionsRequest inner => string.Format(CultureInfo.CurrentCulture, Endpoints.Games.GetGameAdditions, inner.Id),
                GetGameDetailsRequest inner => string.Format(CultureInfo.CurrentCulture, Endpoints.Games.GetGameDetails, inner.Id),
                GetGameDevelopmentTeamRequest inner => string.Format(CultureInfo.CurrentCulture, Endpoints.Games.GetGameDevelopmentTeam, inner.Id),
                GetGameRedditPostsRequest inner => string.Format(CultureInfo.CurrentCulture, Endpoints.Games.GetGameRedditPosts, inner.Id),
                GetGameScreenshotsRequest inner => string.Format(CultureInfo.CurrentCulture, Endpoints.Games.GetGameScreenshots, inner.Id),
                GetGameSeriesRequest inner => string.Format(CultureInfo.CurrentCulture, Endpoints.Games.GetGameSeries, inner.Id),
                GetGamesRequest => Endpoints.Games.GetGames,
                GetGameSuggestionsRequest inner => string.Format(CultureInfo.CurrentCulture, Endpoints.Games.GetGameSuggestions, inner.Id),
                GetGameTrailersRequest inner => string.Format(CultureInfo.CurrentCulture, Endpoints.Games.GetGameTrailers, inner.Id),
                GetGameTwitchStreamsRequest inner => string.Format(CultureInfo.CurrentCulture, Endpoints.Games.GetGameTwitchStreams, inner.Id),
                GetGameYouTubeChannelsRequest inner => string.Format(CultureInfo.CurrentCulture, Endpoints.Games.GetGameYouTubeChannels, inner.Id),

                GetGenresRequest => Endpoints.Genres.GetGenres,
                GetGenreDetailsRequest inner => string.Format(CultureInfo.CurrentCulture, Endpoints.Genres.GetGenreDetails, inner.Id),

                GetPlatformsRequest => Endpoints.Platforms.GetPlatforms,
                GetPlatformDetailsRequest inner => string.Format(CultureInfo.CurrentCulture, Endpoints.Platforms.GetPlatformDetails, inner.Id),
                GetParentPlatformsRequest => Endpoints.Platforms.GetParentPlatforms,

                GetPublishersRequest => Endpoints.Publishers.GetPublishers,
                GetPublisherDetailsRequest inner => string.Format(CultureInfo.CurrentCulture, Endpoints.Publishers.GetPublisherDetails, inner.Id),

                GetStoresRequest => Endpoints.Stores.GetStores,
                GetStoreDetailsRequest inner => string.Format(CultureInfo.CurrentCulture, Endpoints.Stores.GetStoreDetails, inner.Id),

                GetTagsRequest => Endpoints.Tags.GetTags,
                GetTagDetailsRequest inner => string.Format(CultureInfo.CurrentCulture, Endpoints.Tags.GetTagDetails, inner.Id),

                _ => throw new InvalidOperationException("Missing case for request.")
            };
    }
}
