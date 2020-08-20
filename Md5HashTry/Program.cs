using System;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using Md5HashTryCs;


namespace Md5HashTry

{ 
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.Write(args[i] + ":   " + Md5Hash.ComputeMD5Checksum(args[i]));
            }
            Console.ReadLine();
        }
    }
}
