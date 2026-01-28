using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Collections.Generic;

class Program
{
    // 16 bytes = 128-bit key
    private static readonly byte[] Key = Encoding.UTF8.GetBytes("1234567812345678");
    private static readonly byte[] IV = Encoding.UTF8.GetBytes("8765432187654321");

    static void Main()
    {
        string filePath = "secure_employees.csv";

        // Sample data
        var employees = new List<(int Id, string Name, string Email, double Salary)>
        {
            (1, "Alice", "alice@gmail.com", 50000),
            (2, "Bob", "bob@yahoo.com", 60000),
            (3, "Charlie", "charlie@company.com", 70000)
        };

        // WRITE encrypted CSV
        WriteEncryptedCsv(filePath, employees);

        // READ & decrypt CSV
        ReadDecryptedCsv(filePath);
    }

    // ------------------ WRITE ------------------
    static void WriteEncryptedCsv(string path, List<(int Id, string Name, string Email, double Salary)> data)
    {
        using StreamWriter sw = new StreamWriter(path);

        sw.WriteLine("Id,Name,Email,Salary");

        foreach (var e in data)
        {
            string encEmail = Encrypt(e.Email);
            string encSalary = Encrypt(e.Salary.ToString());

            sw.WriteLine($"{e.Id},{e.Name},{encEmail},{encSalary}");
        }

        Console.WriteLine("Encrypted CSV written successfully ✅");
    }

    // ------------------ READ ------------------
    static void ReadDecryptedCsv(string path)
    {
        var lines = File.ReadAllLines(path);

        Console.WriteLine("\nDecrypted Data:");

        for (int i = 1; i < lines.Length; i++)
        {
            var d = lines[i].Split(',');

            string email = Decrypt(d[2]);
            string salary = Decrypt(d[3]);

            Console.WriteLine($"Id: {d[0]}, Name: {d[1]}, Email: {email}, Salary: {salary}");
        }
    }

    // ------------------ ENCRYPT ------------------
    static string Encrypt(string text)
    {
        using Aes aes = Aes.Create();
        aes.Key = Key;
        aes.IV = IV;

        using var encryptor = aes.CreateEncryptor();
        byte[] inputBytes = Encoding.UTF8.GetBytes(text);
        byte[] encryptedBytes = encryptor.TransformFinalBlock(inputBytes, 0, inputBytes.Length);

        return Convert.ToBase64String(encryptedBytes);
    }

    // ------------------ DECRYPT ------------------
    static string Decrypt(string cipherText)
    {
        using Aes aes = Aes.Create();
        aes.Key = Key;
        aes.IV = IV;

        using var decryptor = aes.CreateDecryptor();
        byte[] cipherBytes = Convert.FromBase64String(cipherText);
        byte[] decryptedBytes = decryptor.TransformFinalBlock(cipherBytes, 0, cipherBytes.Length);

        return Encoding.UTF8.GetString(decryptedBytes);
    }
}
