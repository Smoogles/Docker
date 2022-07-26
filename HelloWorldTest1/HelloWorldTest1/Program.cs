﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using System;

namespace HelloWorldTest1
{
    public class Startup
    {
        public void Configure(IApplicationBuilder applicationBuilder, IHostingEnvironment hostingEnvironment)
        {
            applicationBuilder.Run(async context =>
            {
                await context.Response.WriteAsync("Hello World");
            });
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            WebHost.CreateDefaultBuilder()
            .UseStartup<Startup>()
            .UseKestrel()
            .UseUrls("http://0.0.0.0:5050")
            .Build()
            .Run();
        }
    }
}
}
