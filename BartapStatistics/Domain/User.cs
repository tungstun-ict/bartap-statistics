﻿namespace BartapStatistics.Domain;

public class User
{
    public Guid Id { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public string Mail { get; set; }
    
    public string FirstName { get; set; }
    public string LastName { get; set; }
}