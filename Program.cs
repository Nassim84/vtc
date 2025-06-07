using MonBackendVTC.Services;

var builder = WebApplication.CreateBuilder(args);

// Autoriser CORS
builder.Services.AddCors(options =>
{
	options.AddPolicy("AllowAll", policy =>
	{
		policy
			.AllowAnyOrigin()
			.AllowAnyHeader()
			.AllowAnyMethod();
	});
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSingleton<EmailService>();

var app = builder.Build();

app.UseCors("AllowAll"); 

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
