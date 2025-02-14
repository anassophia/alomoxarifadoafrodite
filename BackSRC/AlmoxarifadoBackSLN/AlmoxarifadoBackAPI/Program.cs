using AlmoxarifadoBackAPI.Repositorio;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<Context>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));
//builder.Services.AddScoped<CategoriaRepositorio>();
builder.Services.AddScoped<ICategoriaRepositorio, CategoriaRepositorio>();
<<<<<<< HEAD
builder.Services.AddScoped<IEntradaRepositorio, EntradaRepositorio>();
builder.Services.AddScoped<IFornecedorRepositorio, FornecedorRepositorio>();
builder.Services.AddScoped<IItenEntradaRepositorio, ItenEntradaRepositorio>();
builder.Services.AddScoped<IItenSaidaRepositorio, ItenSaidaRepositorio>();
builder.Services.AddScoped<lProdutoRepositorio, ProdutoRepositorio>();
builder.Services.AddScoped<ISaidaRepositorio, SaidaRepositorio>();
builder.Services.AddScoped<ISecretariaRepositorio, SecretariaRepositorio>();
=======
builder.Services.AddScoped<IProdutoRepositorio, ProdutoRepositorio>();

>>>>>>> upstream/feature/entrada

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
