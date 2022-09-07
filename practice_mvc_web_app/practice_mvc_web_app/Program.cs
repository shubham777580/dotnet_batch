//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.
//builder.Services.AddControllersWithViews();

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Home/Error");
//    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//    app.UseHsts();
//}

//app.UseHttpsRedirection();
//app.UseStaticFiles();

//app.UseRouting();

//app.UseAuthorization();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");

//app.Run();

static void Main()
{
    // The Three Parts of a LINQ Query:
    // 1. Data source.
    int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

    // 2. Query creation.
    // numQuery is an IEnumerable<int>
    var numQuery =
        from num in numbers
        where (num % 2) == 0
        select num;

    // 3. Query execution.
    foreach (int num in numQuery)
    {
        Console.Write("{0,1} ", num);
    }
}