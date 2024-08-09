using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Moq;

namespace Nameless.RawgClient {
    [SetUpFixture]
    public class StartUp {
        private static ServiceProvider? _provider;

        private static ServiceProvider GetServiceProvider()
            => _provider ?? throw new ArgumentNullException(nameof(_provider));

        public static T GetService<T>() where T : class
            => GetServiceProvider().GetRequiredService<T>();

        [OneTimeSetUp]
        public void OneTimeSetup() {
            var serviceCollection = new ServiceCollection();
            var configurationMock = new Mock<IConfiguration>();
            var configurationRoot = Mock.Of<IConfigurationRoot>();

            configurationMock.Setup(mock => mock.GetSection(It.IsAny<string>()))
                             .Returns(new ConfigurationSection(configurationRoot, string.Empty));

            serviceCollection.AddSingleton(configurationMock.Object);
            serviceCollection.RegisterRawgClient(opts => opts.ApiKey = "2ad101e9699643f5baf3e803083df4c6");

            _provider = serviceCollection.BuildServiceProvider();
        }

        [OneTimeTearDown]
        public void OneTimeTearDown() {
            _provider?.Dispose();
        }
    }
}
