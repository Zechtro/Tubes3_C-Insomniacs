using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;

class Encrypt
{
    private static BigInteger n = 3337;
    private static BigInteger e = 79;

    public static String encrypt(String originalString)
    {
        string original = originalString;

        List<BigInteger> decimalAscii = new List<BigInteger>();
        foreach (char c in original)
        {
            decimalAscii.Add((int)c);
        }

        List<BigInteger> encrypted = new List<BigInteger>();
        foreach (BigInteger asciiValue in decimalAscii)
        {
            BigInteger encryptedValue = BigInteger.ModPow(asciiValue, e, n);
            encrypted.Add(encryptedValue);
        }

        String encryptedString = string.Join(" ", encrypted);
        return encryptedString;
    }
}
