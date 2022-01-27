using Microsoft.AspNetCore.Mvc;
using MyProjectWeb.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MyProjectWeb.Controllers
{
  public class StockController : Controller
  {
    private static readonly HttpClient _httpClient;

    static StockController()
    {
      _httpClient = new HttpClient();
      _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(REDACTED);
    }

    [Microsoft.AspNetCore.Mvc.HttpGet]
    public IActionResult News()
    {
      var resp = GetNews().Result;
      StockNews newsFeed = JsonConvert.DeserializeObject<StockNews>(resp);
      return View(newsFeed);
    }

    [Microsoft.AspNetCore.Mvc.HttpGet]
    public IActionResult Prices()
    {
      var resp = GetPrices().Result;
      StockPrices pricesFeed = JsonConvert.DeserializeObject<StockPrices>(resp);
      return View(pricesFeed);
    }

    public async Task<string> GetPrices()
    {
      var result = await GetExternalResponse("https://doubloon-api.herokuapp.com/stocks/prices");
      return new string(result);
    }

    public async Task<string> GetNews()
    {
      var result = await GetExternalResponse("https://doubloon-api.herokuapp.com/stocks/news");
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
