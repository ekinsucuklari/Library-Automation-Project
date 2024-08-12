using System.IO;
using System.Security.Cryptography;
using System.Text;
using System;

public static class Security
{
    public static string CreateNewRandomString()//Create new random password with 8 chars

    {

        int length = 6;

        byte[] rgb = new byte[length];

        RNGCryptoServiceProvider rngCrypt = new RNGCryptoServiceProvider();

        rngCrypt.GetBytes(rgb);

        return Convert.ToBase64String(rgb);

    }



    public static string HashPassword(string strPassword, string strSalt = "")

    {

        using (var sha = new SHA256Managed())

        {

            // Convert the string to a byte array first, to be processed

            byte[] textBytes = Encoding.UTF8.GetBytes(strPassword + strSalt);

            byte[] hashBytes = sha.ComputeHash(textBytes);



            // Convert back to a string, removing the '-' that BitConverter adds

            string hash = BitConverter

                .ToString(hashBytes)

                .Replace("-", String.Empty);



            return hash;

        }

    }
}

