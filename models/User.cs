namespace EventApp1.Models;

public class User
{
    public int Id { get; set; }
    public string name { get; set; }
    public string surname { get; set; }
    public int UserTypeId { get; set; }
    public int CompanyId { get; set; }
    public string email { get; set; }
    public string login { get; set; }
    public string password { get; set; }
    public string passwordSalt { get; set; }

    
    
    
}