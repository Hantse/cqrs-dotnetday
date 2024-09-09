# cqrs-dotnetday

# Install MediatR
First step install MediatR package and FluentValidation

# Data access
Data can be acces using IOrderRepository
It's a simple static list

# Create Query
Create a query (in CQRS/Queries) to get all orders

# Create Query Handler
Use previous query to create handler and return a static list of order OrderItemResponse
can be found in Contracts/Response

# Call
From Program.cs dispatch event to query all Orders

app.MapGet("/orders", () =>
{
    return Results.Ok();
});

# Create Command
Create a command (in CQRS/Commands) to create new Order

# Create Query Handler
Use previous command to create handler and id of created item

# Call
From Program.cs dispatch event to create new Order

app.MapPost("/orders", () =>
{
    return Results.Ok();
});

# Create Pipeline
Create basic pipeline, doing console log on every request received

# Register Pipeline
services.AddTransient(typeof(IPipelineBehavior<,>), typeof(LoggingBehavior<,>));

