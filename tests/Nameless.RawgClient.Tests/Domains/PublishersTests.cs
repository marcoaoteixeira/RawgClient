using Nameless.RawgClient.Domains.Publishers.Requests;
using Nameless.RawgClient.Domains.Publishers.Responses;

namespace Nameless.RawgClient.Domains {
    public class PublishersTests : TestClassBase {
        [Test]
        public async Task Call_QueryAsync_With_GetPublishersRequest_Should_Return_GetPublishersResponse_With_Results() {
            // arrange
            var sut = CreateSut("Resources\\get-publishers.json");

            // act
            var actual = await sut.QueryAsync(new GetPublishersRequest(), CancellationToken.None);

            // assert
            Assert.Multiple(() => {
                Assert.That(actual, Is.InstanceOf<GetPublishersResponse>());
                Assert.That(actual.Count, Is.GreaterThanOrEqualTo(1));
                Assert.That(actual.Results, Is.Not.Empty);

                var first = actual.Results.First();
                Assert.That(first.Name, Is.Not.Empty);
            });
        }

        [Test]
        public async Task Call_QueryAsync_With_GetPublisherDetailsRequest_Should_Return_GetPublisherDetailsResponse_With_Result() {
            // arrange
            const int id = 354;
            const string name = "Electronic Arts";
            var sut = CreateSut("Resources\\get-publisher-details.json");

            // act
            var actual = await sut.QueryAsync(new GetPublisherDetailsRequest(id), CancellationToken.None);

            // assert
            Assert.Multiple(() => {
                Assert.That(actual, Is.InstanceOf<GetPublisherDetailsResponse>());
                Assert.That(actual.Count, Is.GreaterThanOrEqualTo(1));
                Assert.That(actual.Results, Is.Not.Empty);

                var first = actual.Results.First();
                Assert.That(first.Id, Is.EqualTo(id));
                Assert.That(first.Name, Is.EqualTo(name));
            });
        }
    }
}
