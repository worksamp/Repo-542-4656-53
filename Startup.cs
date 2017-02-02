using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace HelloWeb
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            //addeded during testing
            app.Run(context =>
            {
                return context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
