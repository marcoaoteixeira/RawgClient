using Nameless.RawgClient.Domains.Creators.Requests;

namespace Nameless.RawgClient.Domains {
    public class CreatorsTests : TestClassBase {
        [Test]
        public async Task Call_QueryAsync_With_GetCreatorsRequest_Should_Return_GetCreatorsResponse_With_Results() {
            // arrange
            var sut = CreateSut("Resources\\get-creators.json");

            // act
            var actual = await sut.QueryAsync(new GetCreatorsRequest(), CancellationToken.None);

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
        public async Task Call_QueryAsync_With_GetCreatorDetailsRequest_Should_Return_GetCreatorDetailsResponse_With_Result() {
            // arrange
            const int id = 2551;
            const string name = "John Romero";
            var sut = CreateSut("Resources\\get-creator-details.json");

            // act
            var actual = await sut.QueryAsync(new GetCreatorDetailsRequest(id), CancellationToken.None);

            // assert
            Assert.Multiple(() => {
                Assert.That(actual, Is.Not.Null);
                Assert.That(actual.Count, Is.GreaterThanOrEqualTo(1));
                Assert.That(actual.Results, Is.Not.Empty);

                if (actual.Results.Length <= 0) {
                    return;
                }

                var first = actual.Results.First();
                Assert.That(first.Id, Is.EqualTo(id));
                Assert.That(first.Name, Is.EqualTo(name));
            });
        }
    }
}
