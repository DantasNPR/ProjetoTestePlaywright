using Microsoft.Extensions.Configuration;

namespace ProjetoTestePlaywright.Config
{
    public static class ConfigurationManager
    {
        public static TestSettings Settings { get; }

        static ConfigurationManager()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("Config/appsettings.json", optional: false)
                .AddEnvironmentVariables()
                .Build();

            Settings = configuration
                .GetSection("TestSettings")
                .Get<TestSettings>()
                ?? throw new InvalidOperationException(
                    "Não foi possível carregar as configurações dos testes.");
        }
    }
}