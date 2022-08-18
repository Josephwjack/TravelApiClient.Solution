using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace TravelClient.Models
{
  public class User 
  {
    public int UserId { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Token { get; set; }

    public static void Post(User user)
    {
      string jsonUser = JsonConvert.SerializeObject(user);
      var apiCallTask = ApiHelper.Post(jsonUser);
    }
  }
}