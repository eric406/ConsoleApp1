var builder = WebApplication.CreateBuilder(args);

#region 依賴注入
// Add services to the container.  
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

// Generate Swagger quick API Testing page
builder.Services.AddSwaggerGen();
#endregion

var app = builder.Build();

#region 應用程式管道順序

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// 路由設定
app.UseHttpsRedirection();

// 啟動API授權管理
app.UseAuthorization();

// Api mapping API路由映射
app.MapControllers();

#endregion

// 應用程式啟動
app.Run();
