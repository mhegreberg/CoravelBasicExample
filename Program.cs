using Coravel;
Console.WriteLine("Starting Program");

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddScheduler();
        services.AddTransient<Worker>();
    })
    .Build();
host.Services.UseScheduler(scheduler =>
        {
            var jobschedule = scheduler.Schedule<Worker>();
            jobschedule.DailyAtHour(7)
                       .RunOnceAtStart();
        });

await host.RunAsync();

