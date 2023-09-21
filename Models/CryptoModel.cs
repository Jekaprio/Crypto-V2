using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows;

public class CryptoModel
{
    private readonly HttpClient _httpClientCoinCap;
   

    public CryptoModel()
    {
        _httpClientCoinCap = new HttpClient();
        _httpClientCoinCap.BaseAddress = new Uri("https://api.coincap.io/v2/assets");
    }

   
    public async Task<string> GetCoinCapdataAsync()
    {
        try
        {
            HttpResponseMessage response = await _httpClientCoinCap.GetAsync("https://api.coincap.io/v2/assets");
            response.EnsureSuccessStatusCode();
            string data = await response.Content.ReadAsStringAsync();
            return data;
        }
        catch(HttpRequestException ex)
        {        
            return ex.Message;
        }
    }
  
}


    


