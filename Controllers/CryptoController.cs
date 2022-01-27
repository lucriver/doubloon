using Microsoft.AspNetCore.Mvc;
using MyProjectWeb.Models;
using Newtonsoft.Json;

namespace MyProjectWeb.Controllers
{
  public class CryptoController : Controller
  {
    private static readonly HttpClient _httpClient;
    static CryptoController()
    {
      _httpClient = new HttpClient();
      _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(REDACTED);
    }


    [Microsoft.AspNetCore.Mvc.HttpGet]
    public IActionResult News()
    {
      var resp = GetNews().Result;
      CryptoNews newsFeed = JsonConvert.DeserializeObject<CryptoNews>(resp);
      return View(newsFeed);
    }

    [Microsoft.AspNetCore.Mvc.HttpGet]
    public IActionResult Prices()
    {
      var resp = GetPrices().Result;
      CryptoPrices pricesFeed = JsonConvert.DeserializeObject<CryptoPrices>(resp);
      return View(pricesFeed);
    }

    public async Task<string> GetNews()
    {
      var result = await GetExternalResponse("https://doubloon-api.herokuapp.com/crypto/news");
      return new string(result);
    }

    public async Task<string> GetPrices()
    {
      var result = await GetExternalResponse("https://doubloon-api.herokuapp.com/crypto/prices");
      return new string(result);
    }

    private async Task<string> GetExternalResponse(string url)
    {
      HttpResponseMessage response = await _httpClient.GetAsync(url);
      response.EnsureSuccessStatusCode();
      var result = await response.Content.ReadAsStringAsync();
      return result;
    }
  }
}
