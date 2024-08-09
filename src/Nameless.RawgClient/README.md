# RAWG Client .NET

This is a simple client for querying [RAWG](https://rawg.io) gaming database API. The main motive to create this client was because I was building a small microservices, as an exercise, (kind of [Blockbuster](https://en.wikipedia.org/wiki/Blockbuster_(retailer))) of a gaming rental store.

## Getting started

Really simple, just add this NuGet package to your project:

``` powershell
dotnet add package Nameless.RawgClient
```

From here, you can register it using `Microsoft.Extensions.DependencyInjection`:

``` csharp
// If you have your ApiKey set in the configuration file
// using the key "RawgOptions"

services.AddHttpClient(); // Important
services.RegisterRawgClient();
```
or
``` csharp
// Or if you don't want to use configuration files
// you still can set your RAWG API key using the
// 'configure' parameter.

services.AddHttpClient(); // Important
services.RegisterRawgClient(configure => {
    configure.ApiKey = "YOUR_API_KEY";
});
```

### Prerequisites

No prerequisites.

## Usage

Examples about how to use your package by providing code snippets/example images, or samples links on GitHub if applicable. 

- Provide sample code using code snippets
- Include screenshots, diagrams, or other visual help users better understand how to use your package

## Additional documentation

Provide links to more resources: List links such as detailed documentation, tutorial videos, blog posts, or any other relevant documentation to help users get the most out of your package.

## Feedback

Where and how users can leave feedback?

- Links to a GitHub repository where could open issues, Twitter, a Discord channel, bug tracker, or other platforms where a package consumer can connect with the package author.