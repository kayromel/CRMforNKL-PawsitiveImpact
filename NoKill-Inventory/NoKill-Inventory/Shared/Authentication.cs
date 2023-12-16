using System.IO.Enumeration;

namespace NoKill_Inventory.Shared;

using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

public class Authentication
{
    // private Dictionary<string, string> users = new Dictionary<string, string>();
    //
    // public Authentication()
    // {
    //     // Hash passwords before storing them
    //     users["user1"] = HashPassword("password1");
    //     users["user2"] = HashPassword("password2");
    // }
    //
    // public bool AuthenticateUser(string username, string password)
    // {
    //     if (users.TryGetValue(username, out var storedPasswordHash))
    //     {
    //         return VerifyPassword(password, storedPasswordHash);
    //     }
    //
    //     return false;
    // }
    //
    // private string HashPassword(string password)
    // {
    //     using (var sha256 = SHA256.Create())
    //     {
    //         var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
    //         return Convert.ToBase64String(hashedBytes);
    //     }
    // }
    //
    // private bool VerifyPassword(string enteredPassword, string storedPasswordHash)
    // {
    //     return storedPasswordHash == HashPassword(enteredPassword);
    // }
}