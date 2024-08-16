using Nameless.RawgClient.Domains.Tags.Requests;

namespace Nameless.RawgClient.Domains {
    public class TagsTests : TestClassBase {
        [Test]
        public async Task Call_QueryAsync_With_GetTagsRequest_Should_Return_GetTagsResponse_With_Results() {
            // arrange
            var sut = CreateSut("Resources\\get-tags.json");

            // act
            var actual = await sut.QueryAsync(new GetTagsRequest(), CancellationToken.None);

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
        public async Task Call_QueryAsync_With_GetTagDetailsRequest_Should_Return_GetTagDetailsResponse_With_Result() {
            // arrange
            const int id = 31;
            const string name = "Singleplayer";
            var sut = CreateSut("Resources\\get-tag-details.json");

            // act
            var actual = await sut.QueryAsync(new GetTagDetailsRequest(id), CancellationToken.None);

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
