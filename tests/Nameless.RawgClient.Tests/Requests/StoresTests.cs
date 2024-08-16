using Nameless.RawgClient.Requests.Stores;

namespace Nameless.RawgClient.Requests {
    public class StoresTests : TestClassBase {
        [Test]
        public async Task Call_QueryAsync_With_GetStoresRequest_Should_Return_GetStoresResponse_With_Results() {
            // arrange
            var sut = CreateSut("Resources\\get-stores.json");

            // act
            var actual = await sut.QueryAsync(new GetStoresRequest(), CancellationToken.None);

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
        public async Task Call_QueryAsync_With_GetStoreDetailsRequest_Should_Return_GetStoreDetailsResponse_With_Result() {
            // arrange
            const int id = 1;
            const string name = "Steam";
            var sut = CreateSut("Resources\\get-store-details.json");

            // act
            var actual = await sut.QueryAsync(new GetStoreDetailsRequest(id), CancellationToken.None);

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
                Assert.That(first.Domain, Is.Not.Null);
            });
        }
    }
}
