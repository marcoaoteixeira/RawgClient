using System.Globalization;
using Nameless.RawgClient.Common;
using Nameless.RawgClient.Domains.CreatorRoles.Requests;
using Nameless.RawgClient.Domains.Creators.Requests;
using Nameless.RawgClient.Domains.Developers.Requests;
using Nameless.RawgClient.Domains.Genres.Requests;
using Nameless.RawgClient.Domains.Platforms.Requests;
using Nameless.RawgClient.Domains.Publishers.Requests;
using Nameless.RawgClient.Domains.Stores.Requests;
using Nameless.RawgClient.Domains.Tags.Requests;

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

                //GetGamesRequest => Endpoints.Games.GetGames,
                //GetGameDetailsRequest inner => string.Format(CultureInfo.CurrentCulture, Endpoints.Games.GetGameDetails, inner.Id),
                //GetGameDetailsRequest inner => string.Format(CultureInfo.CurrentCulture, Endpoints.Games.GetGameDetails, inner.Id),

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
