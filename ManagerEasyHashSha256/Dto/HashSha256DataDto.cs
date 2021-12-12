using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerEasyHashSha256.Dto
{
    /// <summary>
    /// Datos necesarios para encriptar
    /// </summary>
    public class HashSha256DataDto
    {
        /// <summary>
        /// Valor a encriptar en sah256
        /// </summary>
        public string InputString { get; set; }

        /// <summary>
        /// Valor secreto con el que se encriptara
        /// </summary>
        public string ClientSecret { get; set; }
    }
}
