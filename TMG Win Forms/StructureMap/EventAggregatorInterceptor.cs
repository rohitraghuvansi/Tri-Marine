using System;
using TMG.EventAggregator;
using StructureMap;
using StructureMap.Interceptors;

namespace TMG.WinForms
{
	public class EventAggregatorInterceptor : TypeInterceptor
	{
		public object Process(object target, IContext context)
		{
			IEventPublisher eventPublisher = context.GetInstance<IEventPublisher>();
			eventPublisher.RegisterHandlers(target);
			return target;
		}
		public bool MatchesType(Type type)
		{
			bool matchesType = type.ImplementsInterfaceTemplate(typeof(IEventHandler<>));          
			return matchesType;
		}
	}
    public static class TypeExtensions
    {
        public static bool ImplementsInterfaceTemplate(this Type pluggedType, Type templateType)
        {           
            foreach (var interfaceType in pluggedType.GetInterfaces())
            {
                if (interfaceType.IsGenericType && interfaceType.GetGenericTypeDefinition() == templateType)
                {
                    return true;
                }
            }
            return false;
        }
    }
}