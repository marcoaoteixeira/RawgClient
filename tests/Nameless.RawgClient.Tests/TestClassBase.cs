using System.Net;
using Microsoft.Extensions.Logging.Abstractions;
using Moq;
using Nameless.RawgClient.Common;
using Nameless.RawgClient.Impl;
using Nameless.RawgClient.Infrastructure;

namespace Nameless.RawgClient {
    public abstract class TestClassBase {
        /// <summary>
        /// Will create an instance for the current implementation of <see cref="IRawg"/>
        /// with the given content from file. HTTP Status OK.
        /// </summary>
        /// <param name="contentFileRelativePath">The relative path to the file.</param>
        /// <returns>An instance of <see cref="IRawg"/></returns>
        public IRawg CreateSut(string contentFileRelativePath) {
            var httpClient = CreateHttpClient(contentFileRelativePath);
            var endpointProvider = CreateEndpointProviderMock().Object;
            var logger = NullLogger<Rawg>.Instance;

            return new Rawg(httpClient, endpointProvider, logger);
        }

        private static HttpClient CreateHttpClient(string contentFileRelativePath)
            => new HttpClientBuilder().WithFileContent(contentFileRelativePath)
                                      .Build();

        private static HttpClient CreateHttpClientWithFail()
            => new HttpClientBuilder().WithContent("Fail to load resource.")
                                      .WithErrorReason("Fail to load resource.")
                                      .WithHttpStatus(HttpStatusCode.InternalServerError)
                                      .Build();

        private static Mock<IEndpointProvider> CreateEndpointProviderMock() {
            var endpointProviderMock = new Mock<IEndpointProvider>();
            endpointProviderMock.Setup(mock => mock.GetEndpoint(It.IsAny<Request>()))
                                .Returns("this-is-a-fake-endpoint");
            return endpointProviderMock;
        }
    }
}
