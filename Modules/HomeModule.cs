using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Carter;
using Microsoft.Extensions.Configuration;

namespace CarterAPI.Modules
{
    public class HomeModule : CarterModule
    {
        public HomeModule(IConfiguration conf)
        {
            Get("/", (req, res) => res.WriteAsync("Hello from Carter! " + conf.GetValue<string>("Title")));
        }
    }
}