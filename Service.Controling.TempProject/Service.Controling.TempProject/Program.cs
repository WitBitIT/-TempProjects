using Temp.Service.Controling.APi;

var builder = WebApplication.CreateBuilder(args);
Startup startup = new(builder.Configuration);

#pragma warning disable CS0612 // Typ lub składowa jest przestarzała
startup.ConfigureService(builder.Services);
#pragma warning restore CS0612 // Typ lub składowa jest przestarzała


var app = builder.Build();


app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    options.RoutePrefix = "";
});

app.UseSwagger(options =>
{
    options.SerializeAsV2 = true;
});

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthentication();

app.UseHttpsRedirection();
// dla potzreb rozwojowych na produkcji wylaczyc
app.UseCors(options => options.AllowAnyOrigin());

app.UseAuthorization();

app.UseRouting();

app.MapControllers();

app.Run();
