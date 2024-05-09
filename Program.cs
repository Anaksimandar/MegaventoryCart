using MegaventoryCart.Services.InventoryLocation;
using MegaventoryCart.Services.InventoryLocationService;
using MegaventoryCart.Services.ProductClient;
using MegaventoryCart.Services.ProductService;
using MegaventoryCart.Services.ProductSupplierRelationship;
using MegaventoryCart.Services.RestService;
using MegaventoryCart.Services.SupplierClient;
using MegaventoryCart.Services.SupplierClientService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ISupplierClientService, SupplierClientService>();
builder.Services.AddScoped<IInventoryLocationService, InventoryLocationService>();
builder.Services.AddScoped<IProductClientRelationshipService, ProductClientRelationshipService>();
builder.Services.AddScoped<IProductSupplierRelationshipService, ProductSupplierRelationshipService>();
builder.Services.AddScoped<IRestService, RestService>();

builder.Services.AddHttpClient();


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
