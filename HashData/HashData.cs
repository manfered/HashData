﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HashData
{
    public class HashData
    {
        public static byte[] ComputeHashSha1(byte[] toBeHashed)
        {
            using(var sha1 = SHA1.Create())
            {
                return sha1.ComputeHash(toBeHashed);
            }
        }

        public static byte[] ComputeHashSha256(byte[] toBeHashed)
        {
            using(var sha256 = SHA256.Create())
            {
                return sha256.ComputeHash(toBeHashed);
            }
        }

        public static byte[] ComputeHashSha512(byte[] toBeHashed)
        {
            using(var sha512 = SHA512.Create())
            {
                return sha512.ComputeHash(toBeHashed);
            }
        }

        public static byte[] ComputeHashMd5(byte[] toBeHashed)
        {
            using(var Md5 = MD5.Create())
            {
                return Md5.ComputeHash(toBeHashed);
            }
        }
    }
}
