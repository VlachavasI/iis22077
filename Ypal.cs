using System;

public class Ypal
{
    public Ypal() { }

    public Ypal(int id, string name, string email)
    {
        YpalID = id;
        YpalName = name;
        YpalEmail = email;
    }

    public int YpalID { get; set; }
    public string YpalName { get; set; }
    public string YpalEmail { get; set; }

    public override string ToString()
    {
        return $"Υπάλληλος: {{ID: {YpalID}, Όνομα: {YpalName}, Email: {YpalEmail}}}";
    }
}