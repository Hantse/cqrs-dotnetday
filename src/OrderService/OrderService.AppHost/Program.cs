var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.OrderService_ApiService>("apiservice");

builder.AddProject<Projects.OrderService_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
