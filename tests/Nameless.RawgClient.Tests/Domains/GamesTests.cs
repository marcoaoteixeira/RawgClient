using Nameless.RawgClient.Domains.Games.Requests;
using Nameless.RawgClient.Domains.Games.Responses;

namespace Nameless.RawgClient.Domains {
    public class GamesTests : TestClassBase {
        [Test]
        public async Task Call_QueryAsync_With_GetGamesRequest_Should_Return_GetGamesResponse_With_Results() {
            // arrange
            var sut = CreateSut("Resources\\get-games.json");

            // act
            var actual = await sut.QueryAsync(new GetGamesRequest(), CancellationToken.None);

            // assert
            Assert.Multiple(() => {
                Assert.That(actual, Is.InstanceOf<GetGamesResponse>());
                Assert.That(actual.Count, Is.GreaterThanOrEqualTo(1));
                Assert.That(actual.Results, Is.Not.Empty);

                var first = actual.Results.First();
                Assert.That(first.Name, Is.Not.Empty);
            });
        }

        [Test]
        public async Task Call_QueryAsync_With_GetGameDetailsRequest_Should_Return_GetGameDetailsResponse_With_Result() {
            // arrange
            const int id = 3498;
            const string name = "Grand Theft Auto V";
            var sut = CreateSut("Resources\\get-game-details.json");

            // act
            var actual = await sut.QueryAsync(new GetGameDetailsRequest(id), CancellationToken.None);

            // assert
            Assert.Multiple(() => {
                Assert.That(actual, Is.InstanceOf<GetGameDetailsResponse>());
                Assert.That(actual.Count, Is.GreaterThanOrEqualTo(1));
                Assert.That(actual.Results, Is.Not.Empty);

                var first = actual.Results.First();
                Assert.That(first.Id, Is.EqualTo(id));
                Assert.That(first.Name, Is.EqualTo(name));
            });
        }
    }
}
