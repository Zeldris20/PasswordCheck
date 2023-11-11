using System;
using Microsoft.AspNetCore.Identity;

class Program
{
    static void Main()
    {
        Console.WriteLine("Password Strength Checker");

        Console.Write("Enter your password: ");
        string password = Console.ReadLine();

        var passwordHasher = new PasswordHasher<string>();
        var passwordHash = passwordHasher.HashPassword(null, password);

        Console.WriteLine($"Password Hash: {passwordHash}");

        var passwordVerificationResult = passwordHasher.VerifyHashedPassword(null, passwordHash, password);

        Console.WriteLine($"Password Verification Result: {passwordVerificationResult}");
    }
}
