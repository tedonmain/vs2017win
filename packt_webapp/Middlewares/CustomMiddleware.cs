﻿using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;

namespace packt_webapp.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class CustomMiddleware
    {
        private readonly RequestDelegate _next;

        //private readonly MyConfiguration _myconfig;

        //public CustomMiddleware(RequestDelegate next, IOptions<MyConfiguration> myconfig)
        public CustomMiddleware(RequestDelegate next)
        {
            _next = next;
        //    _myconfig = myconfig.Value;
        }

        public async Task Invoke(HttpContext httpContext)
        {

            //Debug.WriteLine($" ---> Request asked for {httpContext.Request.Path} from {_myconfig.Firstname} {_myconfig.Lastname}");
            Debug.WriteLine("I like gorgonzona cheese");
            Debug.WriteLine($" ---> Request asked for {httpContext.Request.Path}");
            await _next.Invoke(httpContext);

            //return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    //public static class MiddlewareExtensions
    //{
    //	public static IApplicationBuilder UseMiddlewareClassTemplate(this IApplicationBuilder builder)
    //	{
    //		return builder.UseMiddleware<CustomMiddleware>();
    //	}
    //}
}
