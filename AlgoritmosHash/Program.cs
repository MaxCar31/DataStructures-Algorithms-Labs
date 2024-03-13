uusing System;
using System.Security.Cryptography;
using System.Text;

//MAX CARRIÓN

class Program
{
    static void Main()
    {
        string texto = "12345";

        // MD5
        string hashMD5 = CalculateMD5(texto);
        Console.WriteLine("Texto en claro: " + texto);
        Console.WriteLine("Hash MD5: " + hashMD5);
        Console.WriteLine();

        // SHA-1
        string hashSHA1 = CalculateSHA1(texto);
        Console.WriteLine("Texto en claro: " + texto);
        Console.WriteLine("Hash SHA-1: " + hashSHA1);
        Console.WriteLine();

        // SHA-256
        string hashSHA256 = CalculateSHA256(texto);
        Console.WriteLine("Texto en claro: " + texto);
        Console.WriteLine("Hash SHA-256: " + hashSHA256);
        Console.WriteLine();

        // SHA-3
        string hashSHA3 = CalculateSHA3(texto);
        Console.WriteLine("Texto en claro: " + texto);
        Console.WriteLine("Hash SHA-3: " + hashSHA3);
        Console.WriteLine();

        // BLAKE2
        string hashBLAKE2 = CalculateBLAKE2(texto);
        Console.WriteLine("Texto en claro: " + texto);
        Console.WriteLine("Hash BLAKE2: " + hashBLAKE2);
    }

    static string CalculateMD5(string input)
    {
        using (MD5 md5 = MD5.Create())
        {
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("x2"));
            }
            return sb.ToString();
        }
    }

    static string CalculateSHA1(string input)
    {
        using (SHA1 sha1 = SHA1.Create())
        {
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);
            byte[] hashBytes = sha1.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("x2"));
            }
            return sb.ToString();
        }
    }

    static string CalculateSHA256(string input)
    {
        using (SHA256 sha256 = SHA256.Create())
        {
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);
            byte[] hashBytes = sha256.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("x2"));
            }
            return sb.ToString();
        }
    }

    static string CalculateSHA3(string input)
    {
        using (SHA3 sha3 = SHA3.Create())
        {
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);
            byte[] hashBytes = sha3.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("x2"));
            }
            return sb.ToString();
        }
    }

    static string CalculateBLAKE2(string input)
    {
        using (Blake2Sharp.Blake2B blake2 = new Blake2Sharp.Blake2B())
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
    byte[] hashBytes = blake2.ComputeHash(inputBytes);

        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < hashBytes.Length; i++)
        {
            sb.Append(hashBytes[i].ToString("x2"));
        }
        return sb.ToString();
    }
}

}
