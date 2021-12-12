using ManagerEasyHashSha256.Abstract;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerEasyHashSha256.Injection
{
    public static class ManagerEasyHashSha256Extension
    {
        /// <summary>
        /// Agrega la injeccion de dependencias
        /// </summary>
        /// <param name="services"></param>
        public static void AddManagerEasyHashSha256(this IServiceCollection services)
        {
            services.AddScoped<IManagerEasyHashSha256Provider, ManagerEasyHashSha256Provider>();
        }
    }
}
