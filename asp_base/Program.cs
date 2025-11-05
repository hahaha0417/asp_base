using asp_base;

// ------------------------------------------
// 初始化環境
// ------------------------------------------


hahaha.Initial_Environment();

ha.Log_Program!.LogDebug("初始化環境");
// ------------------------------------------
// 初始化
// ------------------------------------------
ha.Log_Program!.LogDebug("初始化");
hahaha.Initial();
// ------------------------------------------
// 初始化 UI
// ------------------------------------------
ha.Log_Program!.LogDebug("初始化UI");
hahaha.Initial_UI();

// ------------------------------------------
// 
// ------------------------------------------
// ------------------------------------------

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();


// ------------------------------------------
// 
// ------------------------------------------
ha.Log_Program!.LogDebug("關閉");
hahaha.Close();
// ------------------------------------------
// 
// ------------------------------------------