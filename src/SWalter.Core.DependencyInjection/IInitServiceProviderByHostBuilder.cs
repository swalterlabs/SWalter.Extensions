using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace SWalter.Core.DependencyInjection;

/// <inheritdoc />
public interface IInitServiceProviderByHostBuilder : IValueFor<Action<HostBuilderContext, IServiceCollection>, IServiceProvider>;