using ManagerEasyHashSha256.Abstract;
using ManagerEasyHashSha256.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ManagerEasyHashSha256
{
    public class ManagerEasyHashSha256Provider : IManagerEasyHashSha256Provider
    {
        public string GetHash(HashSha256DataDto hashSha256DataDto)
        {
            if (string.IsNullOrEmpty(hashSha256DataDto.InputString))
                throw new ArgumentException("Se debe enviar un valor de entrada a encriptar");

            if(string.IsNullOrEmpty(hashSha256DataDto.ClientSecret))
                throw new ArgumentException("No se ha configurado el client secret para la encriptación");

            UTF8Encoding encoding = new UTF8Encoding();

            using (var hash = new HMACSHA256(encoding.GetBytes(hashSha256DataDto.ClientSecret)))
            {
                byte[] stream = hash.ComputeHash(encoding.GetBytes(hashSha256DataDto.InputString));

                string textHash = string.Concat(stream.Select(b => b.ToString("x2")));

                return textHash;
            }
        }
    }
}
