var builder = WebApplication.CreateBuilder(args);

#region �̿�`�J
// Add services to the container.  
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

// Generate Swagger quick API Testing page
builder.Services.AddSwaggerGen();
#endregion

var app = builder.Build();

#region ���ε{���޹D����

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// ���ѳ]�w
app.UseHttpsRedirection();

// �Ұ�API���v�޲z
app.UseAuthorization();

// Api mapping API���ѬM�g
app.MapControllers();

#endregion

// ���ε{���Ұ�
app.Run();
