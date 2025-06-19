var builder = DistributedApplication.CreateBuilder(args);

var backEnd = builder
    .AddProject<Projects.Portfolio_Api>("backend")
    .WithExternalHttpEndpoints();

var frontEnd = builder
    .AddNpmApp("frontend", "../frontend/portfolio.web", "dev")
    .WithReference(backEnd)
    .WaitFor(backEnd)
    .WithHttpEndpoint(env: "PORT")
    .WithExternalHttpEndpoints()
    .PublishAsDockerFile();

builder.Build().Run();
