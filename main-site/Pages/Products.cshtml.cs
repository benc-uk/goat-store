using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using GoatStore.Models;

namespace GoatStore.Pages
{
  public class ProductsModel : PageModel
  {
    private IConfiguration config;
    private SqlConnection conn;

    public IList<Goat> Goats { get; private set; }

    public ProductsModel(IConfiguration configuration)
    {
      config = configuration;
    }

    public void OnGet()
    {
      Goats = new List<Goat>();

      // This is a terrible/primitive way to get data from a database, but it works 
      // Please do not write code like this. Thanks
      using (conn = new SqlConnection(config.GetConnectionString("MainDatabase")))
      {
        try
        {
          conn.Open();
          SqlCommand cmd = conn.CreateCommand();
          cmd.CommandText = "SELECT * from products";
          SqlDataReader reader = cmd.ExecuteReader();

          while (reader.Read())
          {
            Goat goat = new Goat();
            goat.Id = reader.GetInt32(0);
            goat.Name = reader.GetString(1);
            goat.Description = reader.GetString(2);
            goat.Image = reader.GetString(3);
            Goats.Add(goat);
          }
        }
        finally
        {
          conn.Close();
          conn.Dispose();
        }
      }
    }
  }
}