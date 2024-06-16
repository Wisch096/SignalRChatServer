using SignalRWebpack.Hubs;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSignalR();
builder.Services.AddCors();

var app = builder.Build();

app.MapHub<ChatHub>("/chat");

app.UseCors(policy =>
{
    policy.WithOrigins("http://localhost:4200")
          .AllowAnyHeader()
          .AllowAnyMethod()
          .AllowCredentials();
});
    
app.Run();