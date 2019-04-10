namespace MyApp.Client

open Microsoft.AspNetCore.Blazor.Builder
open Microsoft.AspNetCore.Blazor.Hosting
open Microsoft.Extensions.DependencyInjection
open Bolero.Remoting.Client

type Startup() =

    member __.ConfigureServices(services: IServiceCollection) =
        services.AddRemoting()

    member __.Configure(app: IBlazorApplicationBuilder) =
        app.AddComponent<Main.MyApp>("#main")

module Program =

    [<EntryPoint>]
    let Main args =
        BlazorWebAssemblyHost.CreateDefaultBuilder()
            .UseBlazorStartup<Startup>()
            .Build()
            .Run()
        0
