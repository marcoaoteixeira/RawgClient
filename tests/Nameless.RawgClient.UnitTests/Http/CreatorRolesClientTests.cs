using Nameless.RawgClient.Contracts.Http.CreatorRoles;
using Nameless.RawgClient.Contracts.Http.CreatorRoles.Requests;

namespace Nameless.RawgClient.Http {
    public class CreatorRolesClientTests {
        [Test]
        public async Task GetCreatorRoles_Should_Return_A_List_Of_Creator_Roles() {
            var sut = StartUp.GetService<ICreatorRoleHttpClient>();
            var response = await sut.GetCreatorRolesAsync(
                new GetCreatorRolesRequest(),
                CancellationToken.None
            );

            Assert.Multiple(() => {
                Assert.That(response, Is.Not.Null);
                Assert.That(response.Succeeded, Is.True, message: response.Error);
                Assert.That(response.Results, Is.Not.Empty);

                var first = response.Results.First();
                Assert.That(first.Name, Is.Not.Empty);
            });
        }
    }
}
