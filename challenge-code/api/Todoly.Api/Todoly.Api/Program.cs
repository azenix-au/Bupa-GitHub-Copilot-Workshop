using Microsoft.EntityFrameworkCore;
using Todoly.Api;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<TodoContext>(opt => opt.UseSqlite("Data Source=todo.db"));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
     {
         options.AddPolicy("AllowAll",
             builder =>
             {
                 builder
                 .AllowAnyOrigin() 
                 .AllowAnyMethod()
                 .AllowAnyHeader();
             });
     });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowAll");

app.UseHttpsRedirection();

app.MapGet("/todoitems", async (TodoContext db) =>

    await db.TodoItems.ToListAsync());

app.MapGet("/todoitems/complete", async (TodoContext db) =>
    await db.TodoItems.Where(t => t.IsComplete).ToListAsync());

app.MapGet("/todoitems/{id}", async (int id, TodoContext db) =>
    await db.TodoItems.FindAsync(id)
        is TodoItem todo
            ? Results.Ok(todo)
            : Results.NotFound());

app.MapPost("/todoitems", async (TodoItem todoItem, TodoContext db) =>
{
    db.TodoItems.Add(todoItem);
    await db.SaveChangesAsync();

    return Results.Created($"/todoitems/{todoItem.Id}", todoItem);
});

app.MapPut("/todoitems/{id}", async ([FromRoute]int id, TodoItem todoItem, TodoContext db) =>
{
    if (id != todoItem.Id)
    {
        return Results.BadRequest("Resource ID does not match body");
    }

    db.Update(todoItem);
    await db.SaveChangesAsync();
    return Results.NoContent();
});

app.MapDelete("/todoitems/{id}", async (int id, TodoContext db) =>
{
    var todoItem = await db.TodoItems.FindAsync(id);
    if (todoItem is null)
    {
        return Results.NotFound();
    }

    db.TodoItems.Remove(todoItem);
    await db.SaveChangesAsync();
    return Results.NoContent();
});


if (app.Environment.IsDevelopment())
{
    // initialize db on startup in development
    using var scope = app.Services.CreateScope();
    var db = scope.ServiceProvider.GetService<TodoContext>();
    db?.Database.Migrate();
}


app.Run();
