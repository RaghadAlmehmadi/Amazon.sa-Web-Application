using System.Collections.Generic;
using Amazon.Models;
public class User
{
    public int UserID { get; set; }
    public required string Name { get; set; }
    public required string Email { get; set; }

    public List<Order> Orders { get; set; } = new List<Order>();
}

