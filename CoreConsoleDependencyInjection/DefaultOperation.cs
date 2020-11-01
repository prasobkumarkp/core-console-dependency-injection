using System;
namespace CoreConsoleDependencyInjection
{
    public class DefaultOperation : ITransientOperation, IScopedOperation, ISingletonOperation
    {
        public string OprationId { get => Guid.NewGuid().ToString()[^4..]; }
    }
}
