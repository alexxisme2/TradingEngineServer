using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TradingEngineServer.Core;
using var engine = TradingEngineServerHostBuilder.BuildTradingEngineServer();
TradingEngineServerServiceProvider.serviceProvider = engine.Services;
{
    using var scope = TradingEngineServerServiceProvider.serviceProvider.CreateScope();
    await engine.RunAsync().ConfigureAwait(false);
}