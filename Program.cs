// See https://aka.ms/new-console-template for more information

using Sentry;

Console.WriteLine("Hello, World!");


SentrySdk.Init(options =>
{
    options.Dsn = "https://994992a438f24c53b34eed2ccc2afb85@o4505409036943360.ingest.sentry.io/4505504306102272";
});

SentrySdk.CaptureMessage("lol, wut?");