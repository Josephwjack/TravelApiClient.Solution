

namespace TravelClient.Models
{
  public class User 
  {
    public int UserId { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public static string Token { get; set; }

    public User(string username, string password)
    {
      Username = username;
      Password = password;
    }

   
  }
}