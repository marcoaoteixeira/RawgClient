using Nameless.RawgClient.Domains.Genres.Requests;
using Nameless.RawgClient.Domains.Genres.Responses;

namespace Nameless.RawgClient.Domains {
    public class GenresTests : TestClassBase {
        [Test]
        public async Task Call_QueryAsync_With_GetGenresRequest_Should_Return_GetGenresResponse_With_Results() {
            // arrange
            var sut = CreateSut("Resources\\get-genres.json");

            // act
            var actual = await sut.QueryAsync(new GetGenresRequest(), CancellationToken.None);

            // assert
            Assert.Multiple(() => {
                Assert.That(actual, Is.InstanceOf<GetGenresResponse>());
                Assert.That(actual.Count, Is.GreaterThanOrEqualTo(1));
                Assert.That(actual.Results, Is.Not.Empty);

                var first = actual.Results.First();
                Assert.That(first.Name, Is.Not.Empty);
            });
        }

        [Test]
        public async Task Call_QueryAsync_With_GetGenreDetailsRequest_Should_Return_GetGenreDetailsResponse_With_Result() {
            // arrange
            const int id = 51;
            const string name = "Indie";
            var sut = CreateSut("Resources\\get-genre-details.json");

            // act
            var actual = await sut.QueryAsync(new GetGenreDetailsRequest(id), CancellationToken.None);

            // assert
            Assert.Multiple(() => {
                Assert.That(actual, Is.InstanceOf<GetGenreDetailsResponse>());
                Assert.That(actual.Count, Is.GreaterThanOrEqualTo(1));
                Assert.That(actual.Results, Is.Not.Empty);

                var first = actual.Results.First();
                Assert.That(first.Id, Is.EqualTo(id));
                Assert.That(first.Name, Is.EqualTo(name));
            });
        }
    }
}
