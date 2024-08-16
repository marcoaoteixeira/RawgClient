using Nameless.RawgClient.Domains.Developers.Requests;

namespace Nameless.RawgClient.Domains {
    public class DevelopersTests : TestClassBase {
        [Test]
        public async Task Call_QueryAsync_With_GetDevelopersRequest_Should_Return_GetDevelopersResponse_With_Results() {
            // arrange
            var sut = CreateSut("Resources\\get-developers.json");

            // act
            var actual = await sut.QueryAsync(new GetDevelopersRequest(), CancellationToken.None);

            // assert
            Assert.Multiple(() => {
                Assert.That(actual, Is.Not.Null);
                Assert.That(actual.Count, Is.GreaterThanOrEqualTo(1));
                Assert.That(actual.Results, Is.Not.Empty);

                if (actual.Results.Length <= 0) {
                    return;
                }

                var first = actual.Results.First();
                Assert.That(first.Name, Is.Not.Empty);
            });
        }

        [Test]
        public async Task Call_QueryAsync_With_GetDeveloperDetailsRequest_Should_Return_GetDeveloperDetailsResponse_With_Result() {
            // arrange
            const int id = 405;
            const string name = "Ubisoft";
            var sut = CreateSut("Resources\\get-developer-details.json");

            // act
            var actual = await sut.QueryAsync(new GetDeveloperDetailsRequest(id), CancellationToken.None);

            // assert
            Assert.Multiple(() => {
                Assert.That(actual, Is.Not.Null);
                Assert.That(actual.Count, Is.GreaterThanOrEqualTo(1));
                Assert.That(actual.Results, Is.Not.Empty);

                var first = actual.Results.First();
                Assert.That(first.Id, Is.EqualTo(id));
                Assert.That(first.Name, Is.EqualTo(name));
            });
        }
    }
}
