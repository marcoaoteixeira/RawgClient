using Nameless.RawgClient.Domains.CreatorRoles.Requests;

namespace Nameless.RawgClient.Domains {
    public class CreatorRolesTests : TestClassBase {
        [Test]
        public async Task Call_QueryAsync_With_GetCreatorRolesRequest_Should_Return_GetCreatorRolesResponse_With_Results() {
            // arrange
            var sut = CreateSut("Resources\\get-creator-roles.json");

            // act
            var actual = await sut.QueryAsync(new GetCreatorRolesRequest(), CancellationToken.None);

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
    }
}
