namespace ex1
{
    public class Startup{
        public void ConfigureServices(IServiceCollection services){

        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env){
            app.UseStatusCodePages();
            app.UseRouting();
            app.UseEndpoints(endPoints =>{
                endPoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Home Page");
                });
                 endPoints.MapGet("/about", async context =>
                {
                    await context.Response.WriteAsync("Page About");
                });
            });
            app.Map("/abc", app1 => {
                app1.Run(async (context)=>{
                    await context.Response.WriteAsync("Hello World ABC");
                });
            });
            // app.Run(async context =>
            // {
            //     await context.Response.WriteAsync("Hello World!");
            // });

        }
    }
}