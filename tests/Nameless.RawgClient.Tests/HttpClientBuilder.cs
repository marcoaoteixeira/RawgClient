using System.Net;
using System.Text;
using Moq;
using Moq.Protected;

namespace Nameless.RawgClient {
    public sealed class HttpClientBuilder {
        private string _content = string.Empty;
        private HttpStatusCode _statusCode = HttpStatusCode.OK;
        private string? _errorReason;

        public HttpClientBuilder WithFileContent(string resourceFilePath) {
            var fullPath = typeof(HttpClientBuilder).Assembly
                                                    .GetDirectoryPath(resourceFilePath);
            _content = File.ReadAllText(fullPath);
            return this;
        }

        public HttpClientBuilder WithContent(string content) {
            _content = content;
            return this;
        }

        public HttpClientBuilder WithHttpStatus(HttpStatusCode statusCode) {
            _statusCode = statusCode;
            return this;
        }

        public HttpClientBuilder WithErrorReason(string errorReason) {
            _errorReason = errorReason;
            return this;
        }

        public HttpClient Build() {
            var httpMessageHandlerMock = new Mock<HttpMessageHandler>();
            var httpResponseMessage = new HttpResponseMessage(_statusCode) {
                Content = new StringContent(_content, Encoding.UTF8),
                ReasonPhrase = _errorReason
            };

            httpMessageHandlerMock
                .Protected()
                .Setup<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.IsAny<HttpRequestMessage>(),
                    ItExpr.IsAny<CancellationToken>()
                )
                .ReturnsAsync(httpResponseMessage)
                .Verifiable();

            return new HttpClient(httpMessageHandlerMock.Object) {
                BaseAddress = new Uri("https://api.rawg.io")
            };
        }
    }
}
