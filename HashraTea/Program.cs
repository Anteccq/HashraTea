using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using ConsoleAppFramework;
using Microsoft.Extensions.Hosting;

namespace HashraTea
{
    class Program : ConsoleAppBase
    {
        static async Task Main(string[] args)
        {
            await Host.CreateDefaultBuilder().RunConsoleAppFrameworkAsync<Program>(args);
        }

        [Command("sha256")]
        public async Task Sha256([Option(0)] string filePath) =>
            await HashAsync(new SHA256CryptoServiceProvider(), filePath);

        [Command("md5")]
        public async Task Md5([Option(0)] string filePath) => 
            await HashAsync(new MD5CryptoServiceProvider(), filePath);

        private static async Task HashAsync(HashAlgorithm alg, string filePath)
        {
            try
            {
                var path = Path.GetFullPath(filePath);
                var data = await File.ReadAllBytesAsync(path);
                var hash = alg.ComputeHash(data);
                WriteBytes(hash);
            }
            catch
            {
                Console.WriteLine("HashTea: File not Found.");
            }

        }

        private static void WriteBytes(IEnumerable<byte> bytes)
        {
            Console.WriteLine(string.Join("", bytes.Select(x => $"{x:x2}")));
        }
    }
}
