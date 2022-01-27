using System.ComponentModel.DataAnnotations;

namespace MyProjectWeb.Models
{


  public class StockNews
  {
    public Meta meta { get; set; }
    public Datum[] data { get; set; }
  }

  public class Meta
  {
    public int found { get; set; }
    public int returned { get; set; }
    public int limit { get; set; }
    public int page { get; set; }
  }

  public class Datum
  {
    public string uuid { get; set; }
    public string title { get; set; }
    public string description { get; set; }
    public string keywords { get; set; }
    public string snippet { get; set; }
    public string url { get; set; }
    public string image_url { get; set; }
    public string language { get; set; }
    public DateTime published_at { get; set; }
    public string source { get; set; }
    public object relevance_score { get; set; }
    public Entity[] entities { get; set; }
    public Similar[] similar { get; set; }
  }

  public class Entity
  {
    public string symbol { get; set; }
    public string name { get; set; }
    public string exchange { get; set; }
    public string exchange_long { get; set; }
    public string country { get; set; }
    public string type { get; set; }
    public string industry { get; set; }
    public float match_score { get; set; }
    public float? sentiment_score { get; set; }
    public Highlight[] highlights { get; set; }
  }

  public class Highlight
  {
    public string highlight { get; set; }
    public float sentiment { get; set; }
    public string highlighted_in { get; set; }
  }

  public class Similar
  {
    public string uuid { get; set; }
    public string title { get; set; }
    public string description { get; set; }
    public string keywords { get; set; }
    public string snippet { get; set; }
    public string url { get; set; }
    public string image_url { get; set; }
    public string language { get; set; }
    public DateTime published_at { get; set; }
    public string source { get; set; }
    public object relevance_score { get; set; }
    public Entity1[] entities { get; set; }
  }

  public class Entity1
  {
    public string symbol { get; set; }
    public string name { get; set; }
    public string exchange { get; set; }
    public string exchange_long { get; set; }
    public string country { get; set; }
    public string type { get; set; }
    public string industry { get; set; }
    public float match_score { get; set; }
    public float sentiment_score { get; set; }
    public Highlight1[] highlights { get; set; }
  }

  public class Highlight1
  {
    public string highlight { get; set; }
    public float sentiment { get; set; }
    public string highlighted_in { get; set; }
  }


}
