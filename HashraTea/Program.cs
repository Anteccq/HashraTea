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
        public async Task Sha256([Option(0)] string filePath)
        {
            var path = Path.GetFullPath(filePath);
            var data = await File.ReadAllBytesAsync(path);
            var crypto = new SHA256CryptoServiceProvider();
            var hash = crypto.ComputeHash(data);
            WriteBytes(hash);
        }

        [Command("md5")]
        public async Task Md5([Option(0)] string filePath)
        {
            var path = Path.GetFullPath(filePath);
            var data = await File.ReadAllBytesAsync(path);
            var crypto = new MD5CryptoServiceProvider();
            var hash = crypto.ComputeHash(data);
            WriteBytes(hash);
        }

        private static void WriteBytes(IEnumerable<byte> bytes)
        {
            Console.WriteLine(string.Join("", bytes.Select(x => $"{x:x2}")));
        }
    }
}
