using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows;

public class CryptoModel
{
    private readonly HttpClient _httpClientCoinCap;

    public CryptoModel()
    {
        _httpClientCoinCap = new HttpClient();
        _httpClientCoinCap.BaseAddress = new Uri("https://api.coincap.io/v2/");
    }

    public async Task<List<CryptoData>> GetTop10CryptoDataAsync()
    {
        try
        {
            HttpResponseMessage response = await _httpClientCoinCap.GetAsync("assets?limit=10");
            response.EnsureSuccessStatusCode();
            string data = await response.Content.ReadAsStringAsync();
            var cryptoData = JsonConvert.DeserializeObject<CryptoDataList>(data);
            return cryptoData.Data;
        }
        catch (HttpRequestException ex)
        {
            throw ex;
        }
    }

    public async Task<List<CryptoData>> GetAllCryptoDataAsync()
    {
        try
        {
            HttpResponseMessage response = await _httpClientCoinCap.GetAsync("assets");
            response.EnsureSuccessStatusCode();
            string data = await response.Content.ReadAsStringAsync();
            var cryptoData = JsonConvert.DeserializeObject<CryptoDataList>(data);
            return cryptoData.Data;
        }
        catch (HttpRequestException ex)
        {
            throw ex;
        }
    }

    public async Task<CryptoData> SearchCryptoByNameOrSymbol(string searchTerm)
    {
        if (string.IsNullOrWhiteSpace(searchTerm))
            return null;

        try
        {
            HttpResponseMessage response = await _httpClientCoinCap.GetAsync($"assets/{searchTerm}");
            response.EnsureSuccessStatusCode();
            string data = await response.Content.ReadAsStringAsync();
            var cryptoData = JsonConvert.DeserializeObject<CryptoData>(data);
            return cryptoData;
        }
        catch (HttpRequestException ex)
        {
            throw ex;
        }
    }

    public class CryptoDataList
    {
        [JsonProperty("data")]
        public List<CryptoData> Data { get; set; }
    }

    public class CryptoData
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("priceUsd")]
        public string PriceUsd { get; set; }

        [JsonProperty("supply")]
        public string Supply { get; set; }

        [JsonProperty("changePercent24Hr")]
        public string ChangePercent24Hr { get; set; }

        [JsonProperty("explorer")]
        public string explorer { get;set; }
         
        
    }
}




