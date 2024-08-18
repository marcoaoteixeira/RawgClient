# RAWG Client for .NET

A basic client to query [RAWG](https://rawg.io) game database.

The main motive behind this client was because I was building a small microservices, as an exercise, (kind of [Blockbuster](https://en.wikipedia.org/wiki/Blockbuster_(retailer))) of a gaming rental store. And there were not a single client for this API. So, let's build one, why not?

## Getting started

Really simple, just add this NuGet package to your project:

``` powershell
dotnet add package Nameless.RawgClient
```

From here, you should register it using `Microsoft.Extensions.DependencyInjection`:

``` csharp
// If you have your ApiKey set in the configuration file
// using the key "RawgOptions"

services.RegisterRawgClient();
```
or
``` csharp
// Or if you don't want to use configuration files
// you still can set your RAWG API key using the
// 'configure' parameter.

services.RegisterRawgClient(configure => {
    configure.ApiKey = "YOUR_API_KEY";
});
```

If you don't like `Microsoft.Extensions.DependencyInjection` and wanna use another DI container, what you'll need is:

- Register `IRawg` service and its implementation with these services:
    - `System.Net.Http.HttpClient`
    - `Nameless.RawgClient.Infrastructure.IEndpointProvider` (default implementation: `Nameless.RawgClient.Infrastructure.Impl.EndpointProvider`)
    - `Microsoft.Extensions.Logging.ILogger<IRawg>`

Oh, there is a (static) class with all endpoints for RAWG API.

- `Nameless.RawgClient.Common.Endpoints`

### Prerequisites

No prerequisites.

## Usage

Please, refer to the sample in "sample" folder. I think it's a quite nice start.

## Additional documentation

There are no documentation for this client, sorry. Well, if you think documentation are those comments on code and methods, well, then it's documented =P

## Feedback

I'd really appreciate it if you like to give a feedback. If you think that something is off or smelly, let me know or just create a pull request and I'll check. :v: