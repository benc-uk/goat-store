using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using GoatStore.Models;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GoatStore.Pages
{
  public class OrdersModel : PageModel
  {
    //private IConfiguration config;
    private string ApiEndpoint;

    public IList<Order> Orders { get; private set; }

    public OrdersModel(IConfiguration configuration)
    {
      // config = configuration;
      Orders = new List<Order>();
      ApiEndpoint = configuration["API_ENDPOINT_ORDERS"];

      if(ApiEndpoint == null || ApiEndpoint.Length == 0) { throw new Exception("API Endpoint is not set!!"); }
      Console.WriteLine("### Orders API endpoint is: " + ApiEndpoint);
    }

    public async Task<IActionResult> OnGetAsync()
    {
      HttpClient client = new HttpClient();
      
      string apiResultString = await client.GetStringAsync(ApiEndpoint + "/orders");
      Orders = JsonConvert.DeserializeObject<List<Order>>(apiResultString);
      return Page();
    }
  }
}