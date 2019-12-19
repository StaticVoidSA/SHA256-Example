using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ConsoleSHA2
{
    class Program
    {
        static byte[] calculateHash(string source)
        {
            // Convert input string into bytes and back
            ASCIIEncoding converter = new ASCIIEncoding();
            byte[] sourceBytes = converter.GetBytes(source);

            HashAlgorithm hasher = SHA256.Create();
            byte[] hash = hasher.ComputeHash(sourceBytes);
            return hash;
        }

        static void showHash(string source)
        {
            Console.Write("Hash for {0} is: ", source);

            byte[] hash = calculateHash(source);

            foreach (byte b in hash)
            {
                Console.Write("{0:X} ", b);
            }

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            showHash("First hash string");
            showHash("Second hash string");
            showHash("Third hash string");

            Console.ReadLine();
        }
    }
}
