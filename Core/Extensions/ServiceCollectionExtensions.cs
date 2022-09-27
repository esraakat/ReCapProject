using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Extensions
{
    //extension metodu yazabilmen için o class'ın static olması gerekiyor.
    public static class ServiceCollectionExtensions
    {
        //Api'mizin servis bağımlılılarını eklediğimiz koleksiyondur.
        public static IServiceCollection AddDependencyResolvers
            (this IServiceCollection serviceCollection, ICoreModule[] modules) //istediğim kadar core module eklerim
        {
            foreach (var module in modules)
            {
                module.Load(serviceCollection);
            }
            return ServiceTool.Create(serviceCollection);
        }
    }
}
