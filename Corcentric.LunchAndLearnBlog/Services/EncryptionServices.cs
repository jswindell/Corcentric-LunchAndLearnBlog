using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace Corcentric.LunchAndLearnBlog.Services
{
    public class EncryptionServices
    {
        private static int m_publicKey = -999;
        private static int m_privateKey = -999;

        public static int publicKey
        {
            get
            {
                return m_publicKey;
            }
        }

        public static int privateKey
        {
            get
            {
                return m_privateKey;
            }
        }

        public static void initializeKeys()
        {
            if (m_publicKey == -999 && m_privateKey == -999)
            {
                const string url = "http://primes.utm.edu/lists/small/10000.txt";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());

                string[] stringSeperators = new string[] { "      ", "     ", "    ", "   ", "  ", " " };
                List<ulong> primeNumbers = new List<ulong>();
                while (!reader.EndOfStream)
                {
                    string nextLine = reader.ReadLine();
                    string[] dataEntries = nextLine.Split(stringSeperators, StringSplitOptions.RemoveEmptyEntries);

                    if (dataEntries.Length == 10)
                    {
                        for (int counter = 0; counter < dataEntries.Length; counter++)
                        {
                            if (int.Parse(dataEntries[counter]) > 10 && int.Parse(dataEntries[counter]) < 100)
                            {
                                primeNumbers.Add(ulong.Parse(dataEntries[counter]));
                            }
                        }
                    }
                }

                reader.Dispose();
                response.Close();

                Random randomNumberGenerator = new Random();
                ulong firstPrime = primeNumbers[randomNumberGenerator.Next(primeNumbers.Count)], secondPrime = primeNumbers[randomNumberGenerator.Next(primeNumbers.Count)];

                while (firstPrime == secondPrime)
                {
                    secondPrime = primeNumbers[randomNumberGenerator.Next(primeNumbers.Count)];
                }

                //Test values; these *MUST* be deleted
                firstPrime = 61;
                secondPrime = 53;

                ulong nModulus = firstPrime * secondPrime;
                ulong eulerTotient = (firstPrime - 1) * (secondPrime - 1);

                //ulong coprimeNumber = eulerTotient - 1;
                ulong coprimeNumber = 7;

                while (GCD(coprimeNumber, eulerTotient) > 1)
                {
                    //coprimeNumber--;
                    coprimeNumber++;
                }

                ulong d = coprimeNumber % eulerTotient;
                d = getModularInverse(coprimeNumber, eulerTotient);
                ulong testEncrypt = numToPower(5UL, (ulong)coprimeNumber) % nModulus;
                ulong testDecrypt = numToPower((ulong)testEncrypt, (ulong)d) % nModulus;

                m_publicKey = 999;
                m_privateKey = 999;
            }
        }

        //  The purpose of this is to find what multiplied by a_xVar will get one of a_modulusVar.
        //public static ulong getModularInverse(ulong a_xVar, ulong a_modulusVar)
        //{

        //    for (ulong i = 1; i <= a_modulusVar; i++)
        //    {
        //        if ((a_xVar * i) % a_modulusVar == 1)
        //            return i;
        //    }

        //    return 0;
        //}

        // Taken from http://rosettacode.org/wiki/Modular_inverse
        // This has not been tested.
        public static ulong getModularInverse(ulong a_xVar, ulong a_modulusVar)
        {
            ulong a = a_xVar;
            ulong b = a_modulusVar;
            ulong b0 = b, t, q;
            ulong x0 = 0, x1 = 1;
            if (b == 1) return 1;
            while (a > 1)
            {
                q = a / b;
                t = b;
                b = a % b;
                a = t;
                t = x0;
                x0 = x1 - q * x0;
                x1 = t;
            }
            if (x1 < 0) x1 += b0;
            return x1;
        }

        public static int GCD(int a, int b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }

        public static ulong GCD(ulong a, ulong b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }

        public static ulong numToPower(ulong a_num, ulong a_exponent)
        {
            ulong returnValue = 1;
            for (ulong counter = 0; counter < a_exponent; counter++)
            {
                returnValue *= a_num;
            }

            return returnValue;
        }

    }
}
