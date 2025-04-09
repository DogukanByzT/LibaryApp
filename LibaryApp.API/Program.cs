using LibraryApp.Infrastructure.Mapper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// AutoMapper servisini burada ekleyin
builder.Services.AddAutoMapper(typeof(MappingProfile));

// Diðer servisleri eklemeye devam edin
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
