using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;

class Decrypt
{
    private static BigInteger d = 1019;
    private static BigInteger n = 3337;

    public static String decrypt(String encryptedString)
    {
        List<String> listEncryptedString = encryptedString.Split(' ').ToList();
        List<BigInteger> decrypted = new List<BigInteger>();
        foreach (String encryptedValue in listEncryptedString)
        {
            BigInteger decryptedValue = BigInteger.ModPow(BigInteger.Parse((string) encryptedValue), d, n);
            decrypted.Add(decryptedValue);
        }

        String decryptedString = string.Join("", decrypted.Select(value => (char)value));
        return decryptedString;
    }
}
