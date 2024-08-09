using Nameless.RawgClient.Contracts.Http.Creators;
using Nameless.RawgClient.Contracts.Http.Creators.Requests;

namespace Nameless.RawgClient.Http {
    public class CreatorsClientTests {
        [Test]
        public async Task GetCreators_Should_Return_A_List_Of_Creators() {
            var sut = StartUp.GetService<ICreatorHttpClient>();
            var response = await sut.GetCreatorsAsync(
                new GetCreatorsRequest {
                    PageNumber = 2,
                    PageSize = 1000
                },
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

        [Test]
        public async Task GetCreatorDetails_Should_Return_Details_About_Creator() {
            const int johnRomeroCreatorId = 2551;

            var sut = StartUp.GetService<ICreatorHttpClient>();
            var response = await sut.GetCreatorDetailsAsync(
                new GetCreatorDetailsRequest(Id: johnRomeroCreatorId),
                CancellationToken.None
            );

            Assert.Multiple(() => {
                Assert.That(response, Is.Not.Null);
                Assert.That(response.Succeeded, Is.True, message: response.Error);
                Assert.That(response.Results, Is.Not.Null);
                Assert.That(response.Results.First().Name, Is.EqualTo("John Romero"));
            });
        }
    }
}
