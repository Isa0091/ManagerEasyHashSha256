using ManagerEasyHashSha256.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerEasyHashSha256.Abstract
{
    /// <summary>
    /// Maneja los metodos a implementar para el hash en SHA256
    /// </summary>
    public interface IManagerEasyHashSha256Provider
    {
        /// <summary>
        /// Obtengo el hash en Sha256
        /// </summary>
        /// <param name="hashSha256DataDto"></param>
        /// <returns></returns>
        string GetHash(HashSha256DataDto hashSha256DataDto);
    }
}
