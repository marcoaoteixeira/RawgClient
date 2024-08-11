using Nameless.RawgClient.Domains.Platforms.Requests;
using Nameless.RawgClient.Domains.Platforms.Responses;

namespace Nameless.RawgClient.Domains {
    public class PlatformsTests : TestClassBase {
        [Test]
        public async Task Call_QueryAsync_With_GetPlatformsRequest_Should_Return_GetPlatformsResponse_With_Results() {
            // arrange
            var sut = CreateSut("Resources\\get-platforms.json");

            // act
            var actual = await sut.QueryAsync(new GetPlatformsRequest(), CancellationToken.None);

            // assert
            Assert.Multiple(() => {
                Assert.That(actual, Is.InstanceOf<GetPlatformsResponse>());
                Assert.That(actual.Count, Is.GreaterThanOrEqualTo(1));
                Assert.That(actual.Results, Is.Not.Empty);

                var first = actual.Results.First();
                Assert.That(first.Name, Is.Not.Empty);
            });
        }

        [Test]
        public async Task Call_QueryAsync_With_GetPlatformDetailsRequest_Should_Return_GetPlatformDetailsResponse_With_Result() {
            // arrange
            const int id = 4;
            const string name = "PC";
            var sut = CreateSut("Resources\\get-platform-details.json");

            // act
            var actual = await sut.QueryAsync(new GetPlatformDetailsRequest(id), CancellationToken.None);

            // assert
            Assert.Multiple(() => {
                Assert.That(actual, Is.InstanceOf<GetPlatformDetailsResponse>());
                Assert.That(actual.Count, Is.GreaterThanOrEqualTo(1));
                Assert.That(actual.Results, Is.Not.Empty);

                var first = actual.Results.First();
                Assert.That(first.Id, Is.EqualTo(id));
                Assert.That(first.Name, Is.EqualTo(name));
            });
        }

        [Test]
        public async Task Call_QueryAsync_With_GetParentPlatformsRequest_Should_Return_GetParentPlatformsResponse_With_Results() {
            // arrange
            const int id = 1;
            const string name = "PC";
            var sut = CreateSut("Resources\\get-parent-platforms.json");

            // act
            var actual = await sut.QueryAsync(new GetParentPlatformsRequest(), CancellationToken.None);

            // assert
            Assert.Multiple(() => {
                Assert.That(actual, Is.InstanceOf<GetParentPlatformsResponse>());
                Assert.That(actual.Count, Is.GreaterThanOrEqualTo(1));
                Assert.That(actual.Results, Is.Not.Empty);

                var first = actual.Results.First();
                Assert.That(first.Id, Is.EqualTo(id));
                Assert.That(first.Name, Is.EqualTo(name));
            });
        }
    }
}
