var builder = WebApplication.CreateBuilder(args);

// Agregamos el controlador y el cliente HTTP externo
builder.Services.AddControllers();
builder.Services.AddHttpClient("ExternalAPI", client =>
{
    client.BaseAddress = new Uri("https://fakestoreapi.com/");
});

var app = builder.Build();
app.MapControllers();
app.Run();

