using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Name_Case_Normalizer.Services.NameNormalizeService;

namespace Name_Case_Normalizer
{
	internal static class Program
	{
		public static IServiceProvider? ServiceProvider { get; private set; }

		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			ApplicationConfiguration.Initialize();
			var host = CreateHostBuilder().Build();
			ServiceProvider = host.Services;
			Application.Run(ServiceProvider.GetRequiredService<FormNameCaseNormalizer>());
		}
		static IHostBuilder CreateHostBuilder()
		{
			return Host.CreateDefaultBuilder()
				.ConfigureServices((context, services) =>
				{
					services.AddTransient<INameNormalizeService, NameNormalizeService>();
					services.AddTransient<FormNameCaseNormalizer>();
				});
		}
	}
}