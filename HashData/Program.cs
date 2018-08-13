using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashData
{
    class Program
    {
        static void Main(string[] args)
        {
            const string firstMessage = "123456";
            const string secondMessage = "Second Message To Hash";

            Console.WriteLine("Secure HashData");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine();
            Console.WriteLine($"First Message : {firstMessage}");
            Console.WriteLine($"Second Message : {secondMessage}");
            Console.WriteLine();

            var md5HashedMessage = HashData.ComputeHashMd5(Encoding.UTF8.GetBytes(firstMessage));
            var md5HashedMessage2 = HashData.ComputeHashMd5(Encoding.UTF8.GetBytes(secondMessage));

            var sha1HashedMessage = HashData.ComputeHashSha1(Encoding.UTF8.GetBytes(firstMessage));
            var sha1HashedMessage2 = HashData.ComputeHashSha1(Encoding.UTF8.GetBytes(secondMessage));

            var sha256HashedMessage = HashData.ComputeHashSha256(Encoding.UTF8.GetBytes(firstMessage));
            var sha256HashedMessage2 = HashData.ComputeHashSha256(Encoding.UTF8.GetBytes(secondMessage));

            var sha512HashedMessage = HashData.ComputeHashSha512(Encoding.UTF8.GetBytes(firstMessage));
            var sha512HashedMessage2 = HashData.ComputeHashSha512(Encoding.UTF8.GetBytes(secondMessage));

            Console.WriteLine();
            Console.WriteLine("MD5 Hashes");
            Console.WriteLine();
            Console.WriteLine($"Message 1 hash = {Convert.ToBase64String(md5HashedMessage)}");
            Console.WriteLine($"Message 1 hash = {Convert.ToString(md5HashedMessage)}");
            Console.WriteLine($"Message 1 hash = {Encoding.UTF8.GetString(md5HashedMessage)}");
            Console.WriteLine($"Message 1 hash = {Encoding.Unicode.GetString(md5HashedMessage)}");
            Console.WriteLine($"Message 2 hash = {Convert.ToBase64String(md5HashedMessage2)}");
            Console.WriteLine();
            Console.WriteLine("Sha1 Hashes");
            Console.WriteLine($"Message 1 hash = {Convert.ToBase64String(sha1HashedMessage)}");
            Console.WriteLine($"Message 2 hash = {Convert.ToBase64String(sha1HashedMessage2)}");
            Console.WriteLine();
            Console.WriteLine("Sha256 Hashes");
            Console.WriteLine($"Message 1 hash = {Convert.ToBase64String(sha256HashedMessage)}");
            Console.WriteLine($"Message 2 hash = {Convert.ToBase64String(sha256HashedMessage2)}");
            Console.WriteLine();
            Console.WriteLine("Sha512 Hashes");
            Console.WriteLine($"Message 1 hash = {Convert.ToBase64String(sha512HashedMessage)}");
            Console.WriteLine($"Message 2 hash = {Convert.ToBase64String(sha512HashedMessage2)}");

            Console.ReadLine();

        }
    }
}
