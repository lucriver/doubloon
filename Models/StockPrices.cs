using System.ComponentModel.DataAnnotations;

namespace MyProjectWeb.Models
{

  public class StockPrices
  {
    public Prices[] values { get; set; }
  }

  public class Prices
  {
    public string T { get; set; }
    public float v { get; set; }
    public float vw { get; set; }
    public float o { get; set; }
    public float c { get; set; }
    public float h { get; set; }
    public float l { get; set; }
    public int n { get; set; }
  }




}
