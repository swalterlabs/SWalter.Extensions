using Microsoft.Extensions.DependencyInjection;

namespace SWalter.Core.DependencyInjection;

/// <inheritdoc />
// ReSharper disable once UnusedType.Global
public interface IConfigureServiceCollection : IRunFor<IServiceCollection>;