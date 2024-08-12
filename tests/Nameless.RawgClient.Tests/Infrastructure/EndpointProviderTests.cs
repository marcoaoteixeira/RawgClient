using System.Globalization;
using System.Reflection;
using Nameless.RawgClient.Common;
using Nameless.RawgClient.Domains.CreatorRoles.Requests;
using Nameless.RawgClient.Domains.Creators.Requests;
using Nameless.RawgClient.Domains.Developers.Requests;
using Nameless.RawgClient.Domains.Genres.Requests;
using Nameless.RawgClient.Domains.Platforms.Requests;
using Nameless.RawgClient.Domains.Publishers.Requests;
using Nameless.RawgClient.Domains.Stores.Requests;
using Nameless.RawgClient.Domains.Tags.Requests;
using Nameless.RawgClient.Infrastructure.Impl;

namespace Nameless.RawgClient.Infrastructure {
    public class EndpointProviderTests {
        private const int DefaultId = 1;

        [Test]
        public void GetEndpoint_Should_Return_Correct_Endpoints_For_Requests() {
            // arrange
            var expected = new Dictionary<MemberInfo, string> {
                { typeof(GetCreatorRolesRequest), Endpoints.CreatorRoles.GetCreatorRoles },
                { typeof(GetCreatorsRequest), Endpoints.Creators.GetCreators },
                { typeof(GetCreatorDetailsRequest), string.Format(CultureInfo.CurrentCulture, Endpoints.Creators.GetCreatorDetails, DefaultId) },
                { typeof(GetDevelopersRequest), Endpoints.Developers.GetDevelopers },
                { typeof(GetDeveloperDetailsRequest), string.Format(CultureInfo.CurrentCulture, Endpoints.Developers.GetDeveloperDetails, DefaultId) },
                { typeof(GetGenresRequest), Endpoints.Genres.GetGenres },
                { typeof(GetGenreDetailsRequest), string.Format(CultureInfo.CurrentCulture, Endpoints.Genres.GetGenreDetails, DefaultId) },
                { typeof(GetPlatformsRequest), Endpoints.Platforms.GetPlatforms },
                { typeof(GetPlatformDetailsRequest), string.Format(CultureInfo.CurrentCulture, Endpoints.Platforms.GetPlatformDetails, DefaultId) },
                { typeof(GetParentPlatformsRequest), Endpoints.Platforms.GetParentPlatforms },
                { typeof(GetPublishersRequest), Endpoints.Publishers.GetPublishers },
                { typeof(GetPublisherDetailsRequest), string.Format(CultureInfo.CurrentCulture, Endpoints.Publishers.GetPublisherDetails, DefaultId) },
                { typeof(GetStoresRequest), Endpoints.Stores.GetStores },
                { typeof(GetStoreDetailsRequest), string.Format(CultureInfo.CurrentCulture, Endpoints.Stores.GetStoreDetails, DefaultId) },
                { typeof(GetTagsRequest), Endpoints.Tags.GetTags },
                { typeof(GetTagDetailsRequest), string.Format(CultureInfo.CurrentCulture, Endpoints.Tags.GetTagDetails, DefaultId) },
            };
            var sut = new EndpointProvider();

            // act
            var actual = new Dictionary<MemberInfo, string>();
            foreach (var requestType in expected.Keys) {
                var request = CreateRequestInstance(requestType);
                var endpoint = sut.GetEndpoint(request);

                actual[requestType] = endpoint;
            }

            // assert
            Assert.That(actual, Is.EquivalentTo(expected));
        }

        private static Request CreateRequestInstance(MemberInfo requestType) {
            return requestType.Name switch {
                nameof(GetCreatorRolesRequest) => new GetCreatorRolesRequest(),
                nameof(GetCreatorsRequest) => new GetCreatorsRequest(),
                nameof(GetCreatorDetailsRequest) => new GetCreatorDetailsRequest(DefaultId),
                nameof(GetDevelopersRequest) => new GetDevelopersRequest(),
                nameof(GetDeveloperDetailsRequest) => new GetDeveloperDetailsRequest(DefaultId),
                nameof(GetGenresRequest) => new GetGenresRequest(),
                nameof(GetGenreDetailsRequest) => new GetGenreDetailsRequest(DefaultId),
                nameof(GetPlatformsRequest) => new GetPlatformsRequest(),
                nameof(GetPlatformDetailsRequest) => new GetPlatformDetailsRequest(DefaultId),
                nameof(GetParentPlatformsRequest) => new GetParentPlatformsRequest(),
                nameof(GetPublishersRequest) => new GetPublishersRequest(),
                nameof(GetPublisherDetailsRequest) => new GetPublisherDetailsRequest(DefaultId),
                nameof(GetStoresRequest) => new GetStoresRequest(),
                nameof(GetStoreDetailsRequest) => new GetStoreDetailsRequest(DefaultId),
                nameof(GetTagsRequest) => new GetTagsRequest(),
                nameof(GetTagDetailsRequest) => new GetTagDetailsRequest(DefaultId),
                _ => throw new InvalidOperationException($"Missing request type {requestType.Name}")
            };
        }
    }
}
