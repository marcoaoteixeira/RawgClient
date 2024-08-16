using System.Globalization;
using System.Reflection;
using Nameless.RawgClient.Common;
using Nameless.RawgClient.Infrastructure.Impl;
using Nameless.RawgClient.Requests.CreatorRoles;
using Nameless.RawgClient.Requests.Creators;
using Nameless.RawgClient.Requests.Developers;
using Nameless.RawgClient.Requests.Games;
using Nameless.RawgClient.Requests.Genres;
using Nameless.RawgClient.Requests.Platforms;
using Nameless.RawgClient.Requests.Publishers;
using Nameless.RawgClient.Requests.Stores;
using Nameless.RawgClient.Requests.Tags;

namespace Nameless.RawgClient.Infrastructure {
    public class EndpointProviderTests {
        private const int DefaultId = 1;

        [Test]
        public void GetEndpoint_Should_Return_Correct_Endpoints_For_Requests() {
            // arrange
            var expected = CreateExpectedResult();
            var requestImplementations = GetRequestImplementations();
            var sut = new EndpointProvider();

            // act
            var actual = new Dictionary<MemberInfo, string>();

            foreach (var requestType in requestImplementations) {
                var request = CreateRequestInstance(requestType);
                var endpoint = sut.GetEndpoint(request);

                actual[requestType] = endpoint;
            }

            // assert
            Assert.That(actual, Is.EquivalentTo(expected));
        }

        private static IEnumerable<Type> GetRequestImplementations()
            => typeof(IEndpointProvider).Assembly
                                        .GetExportedTypes()
                                        .Where(type => type is { IsAbstract: false, IsInterface: false } &&
                                                       typeof(Request).IsAssignableFrom(type));

        private static Dictionary<MemberInfo, string> CreateExpectedResult() {
            return new Dictionary<MemberInfo, string> {
                { typeof(GetCreatorRolesRequest), Endpoints.CreatorRoles.GetCreatorRoles },

                { typeof(GetCreatorDetailsRequest), string.Format(CultureInfo.CurrentCulture, Endpoints.Creators.GetCreatorDetails, DefaultId) },
                { typeof(GetCreatorsRequest), Endpoints.Creators.GetCreators },

                { typeof(GetDeveloperDetailsRequest), string.Format(CultureInfo.CurrentCulture, Endpoints.Developers.GetDeveloperDetails, DefaultId) },
                { typeof(GetDevelopersRequest), Endpoints.Developers.GetDevelopers },

                { typeof(GetGameAchievementsRequest), string.Format(CultureInfo.CurrentCulture, Endpoints.Games.GetGameAchievements, DefaultId) },
                { typeof(GetGameAdditionsRequest), string.Format(CultureInfo.CurrentCulture, Endpoints.Games.GetGameAdditions, DefaultId) },
                { typeof(GetGameDetailsRequest), string.Format(CultureInfo.CurrentCulture, Endpoints.Games.GetGameDetails, DefaultId) },
                { typeof(GetGameDevelopmentTeamRequest), string.Format(CultureInfo.CurrentCulture, Endpoints.Games.GetGameDevelopmentTeam, DefaultId) },
                { typeof(GetGameRedditPostsRequest), string.Format(CultureInfo.CurrentCulture, Endpoints.Games.GetGameRedditPosts, DefaultId) },
                { typeof(GetGameScreenshotsRequest), string.Format(CultureInfo.CurrentCulture, Endpoints.Games.GetGameScreenshots, DefaultId) },
                { typeof(GetGameSeriesRequest), string.Format(CultureInfo.CurrentCulture, Endpoints.Games.GetGameSeries, DefaultId) },
                { typeof(GetGamesRequest), Endpoints.Games.GetGames },
                { typeof(GetGameSuggestionsRequest), string.Format(CultureInfo.CurrentCulture, Endpoints.Games.GetGameSuggestions, DefaultId) },
                { typeof(GetGameTrailersRequest), string.Format(CultureInfo.CurrentCulture, Endpoints.Games.GetGameTrailers, DefaultId) },
                { typeof(GetGameTwitchStreamsRequest), string.Format(CultureInfo.CurrentCulture, Endpoints.Games.GetGameTwitchStreams, DefaultId) },
                { typeof(GetGameYouTubeChannelsRequest), string.Format(CultureInfo.CurrentCulture, Endpoints.Games.GetGameYouTubeChannels, DefaultId) },

                { typeof(GetGenreDetailsRequest), string.Format(CultureInfo.CurrentCulture, Endpoints.Genres.GetGenreDetails, DefaultId) },
                { typeof(GetGenresRequest), Endpoints.Genres.GetGenres },

                { typeof(GetParentPlatformsRequest), Endpoints.Platforms.GetParentPlatforms },
                { typeof(GetPlatformDetailsRequest), string.Format(CultureInfo.CurrentCulture, Endpoints.Platforms.GetPlatformDetails, DefaultId) },
                { typeof(GetPlatformsRequest), Endpoints.Platforms.GetPlatforms },

                { typeof(GetPublisherDetailsRequest), string.Format(CultureInfo.CurrentCulture, Endpoints.Publishers.GetPublisherDetails, DefaultId) },
                { typeof(GetPublishersRequest), Endpoints.Publishers.GetPublishers },

                { typeof(GetStoreDetailsRequest), string.Format(CultureInfo.CurrentCulture, Endpoints.Stores.GetStoreDetails, DefaultId) },
                { typeof(GetStoresRequest), Endpoints.Stores.GetStores },

                { typeof(GetTagDetailsRequest), string.Format(CultureInfo.CurrentCulture, Endpoints.Tags.GetTagDetails, DefaultId) },
                { typeof(GetTagsRequest), Endpoints.Tags.GetTags },
            };
        }

        private static Request CreateRequestInstance(MemberInfo requestType) {
            return requestType.Name switch {
                nameof(GetCreatorRolesRequest) => new GetCreatorRolesRequest(),

                nameof(GetCreatorDetailsRequest) => new GetCreatorDetailsRequest(DefaultId),
                nameof(GetCreatorsRequest) => new GetCreatorsRequest(),

                nameof(GetDeveloperDetailsRequest) => new GetDeveloperDetailsRequest(DefaultId),
                nameof(GetDevelopersRequest) => new GetDevelopersRequest(),

                nameof(GetGameAchievementsRequest) => new GetGameAchievementsRequest(DefaultId),
                nameof(GetGameAdditionsRequest) => new GetGameAdditionsRequest(DefaultId),
                nameof(GetGameDetailsRequest) => new GetGameDetailsRequest(DefaultId),
                nameof(GetGameDevelopmentTeamRequest) => new GetGameDevelopmentTeamRequest(DefaultId),
                nameof(GetGameRedditPostsRequest) => new GetGameRedditPostsRequest(DefaultId),
                nameof(GetGameScreenshotsRequest) => new GetGameScreenshotsRequest(DefaultId),
                nameof(GetGameSeriesRequest) => new GetGameSeriesRequest(DefaultId),
                nameof(GetGamesRequest) => new GetGamesRequest(),
                nameof(GetGameSuggestionsRequest) => new GetGameSuggestionsRequest(DefaultId),
                nameof(GetGameTrailersRequest) => new GetGameTrailersRequest(DefaultId),
                nameof(GetGameTwitchStreamsRequest) => new GetGameTwitchStreamsRequest(DefaultId),
                nameof(GetGameYouTubeChannelsRequest) => new GetGameYouTubeChannelsRequest(DefaultId),

                nameof(GetGenreDetailsRequest) => new GetGenreDetailsRequest(DefaultId),
                nameof(GetGenresRequest) => new GetGenresRequest(),

                nameof(GetParentPlatformsRequest) => new GetParentPlatformsRequest(),
                nameof(GetPlatformDetailsRequest) => new GetPlatformDetailsRequest(DefaultId),
                nameof(GetPlatformsRequest) => new GetPlatformsRequest(),

                nameof(GetPublisherDetailsRequest) => new GetPublisherDetailsRequest(DefaultId),
                nameof(GetPublishersRequest) => new GetPublishersRequest(),

                nameof(GetStoreDetailsRequest) => new GetStoreDetailsRequest(DefaultId),
                nameof(GetStoresRequest) => new GetStoresRequest(),

                nameof(GetTagDetailsRequest) => new GetTagDetailsRequest(DefaultId),
                nameof(GetTagsRequest) => new GetTagsRequest(),

                _ => throw new InvalidOperationException($"Missing instantiation logic for request {requestType.Name}")
            };
        }
    }
}
