using System.Net;
using Microsoft.Extensions.DependencyInjection;
using TarkovDevData.Services;
using TarkovDevData.Services.Interfaces;

namespace TarkovDevData.Extensions;

public static class TarkovDevDataExtensions {
  public static void AddTarkovDevData(this IServiceCollection services) {
    services.AddHttpClient<ITarkovDevDataService, TarkovDevDataService>(
        client => {
          client.BaseAddress =
              new Uri(Constants.TarkovDevUrl, UriKind.Absolute);
          client.Timeout = TimeSpan.FromSeconds(30);
          client.DefaultRequestVersion = HttpVersion.Version20;
          client.DefaultRequestHeaders.Add("User-Agent", "EFTToolsAPI");
        });
  }
}