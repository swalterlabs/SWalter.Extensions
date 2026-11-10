namespace SWalter.Core.DependencyInjection;

/// <inheritdoc />
public interface IHandleAppStartup<TOut> : ITaskOfValueFor<IServiceProvider, TOut>;