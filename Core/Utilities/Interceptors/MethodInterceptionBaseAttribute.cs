using Castle.DynamicProxy;

namespace Core.Utilities.Interceptors
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)] //Bu attribute'ı classlara veya methodlara ekleyebilirsin. Birden fazla ekleyebilirsin. Inherit edilen noktada bu attribute çalışsın.
    public abstract class MethodInterceptionBaseAttribute : Attribute, IInterceptor
    {
        public int Priority { get; set; } //hangi attribute önce çalışsın

        public virtual void Intercept(IInvocation invocation)
        {

        }
    }


}
