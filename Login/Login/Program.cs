using System;

class Login
{
    public bool LoginUser(string username, string password)
    {
        return username == "admin" && password == "123456";
    }
}