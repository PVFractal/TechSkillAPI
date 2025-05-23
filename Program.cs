using TechSkillAPI;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();


app.MapGet("/skillsuggestion", (string skill) =>
{
    Skills svc = new Skills();
    var suggestion = svc.SuggestSkill(skill);
    return Results.Ok(suggestion);
})
.WithName("GetSkillSuggestion");

app.Run();
