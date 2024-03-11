using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask_InterfaceAbstraction.Auth
{
 
public class User : IAccount
{
    public int Id { get; }
    public string Fullname { get; }
    public string Email { get; }
    private string Password { get; }

    public User(int id, string fullname, string email, string password)
    {
        Id = id;
        Fullname = fullname;
        Email = email;

        while (!PasswordChecker(password))
        {
            Console.WriteLine("Sifre duzgun deyil tekrar cehd edin");
            Console.Write("Password daxil edin: ");
            password = Console.ReadLine();
        }
        Password = password;
    }

    public bool PasswordChecker(string password)
    {
        if (password.Length < 8)
        {
           
            Console.WriteLine("Sifre en az 8 reqem ve herf olmalidir.");
            return false;
        }
        if (!ContainsUpperCase(password))
        {
            Console.WriteLine("========================================");
            Console.WriteLine("Sifre en az bir boyuk herf olmalidir");
            return false;
        }
        if (!ContainsLowerCase(password))
        {
            Console.WriteLine("========================================");
            Console.WriteLine("Şifre en az  bir balaca herf olmalidir");
            return false;
        }
        if (!ContainsDigit(password))
        {
            Console.WriteLine("========================================");
            Console.WriteLine("Sifre en bir reqem olamlidir");
            return false;
        }

        return true;
    }

    private bool ContainsUpperCase(string password)
    {
        foreach (char c in password)
        {
            if (char.IsUpper(c))
            {
                return true;
            }
        }
        return false;
    }

    private bool ContainsLowerCase(string password)
    {
        foreach (char c in password)
        {
            if (char.IsLower(c))
            {
                return true;
            }
        }
        return false;
    }

    private bool ContainsDigit(string password)
    {
        foreach (char c in password)
        {
            if (char.IsDigit(c))
            {
                return true;
            }
        }
        return false;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Id: {Id}, Fullname: {Fullname}, Email: {Email}");
    }
}
}
