using Castle.DynamicProxy;
using System.Reflection;

namespace Core.Utilities.Interceptors
{
    public class AspectInterceptorSelector : IInterceptorSelector
    {
        public IInterceptor[] SelectInterceptors(Type type, MethodInfo method, IInterceptor[] interceptors)
        {
            var classAttributes = type.GetCustomAttributes<MethodInterceptionBaseAttribute> //class'ın attributelerini oku
                (true).ToList();
            var methodAttributes = type.GetMethod(method.Name) //metodun attributelerini oku
                .GetCustomAttributes<MethodInterceptionBaseAttribute>(true);
            classAttributes.AddRange(methodAttributes); //ve onları listeye koy
            //classAttributes.Add(new ExceptionLogAspect(typeof(FileLogger))); //otomatik olarak sistemdeki bütün metodları loga dahil et.

            return classAttributes.OrderBy(x => x.Priority).ToArray(); //fakat onların çalışma sıralarını da önceliğe göre sırala
        }
    }


}
