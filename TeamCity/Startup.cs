using Microsoft.Owin;
using Owin;
using System;

[assembly: OwinStartupAttribute(typeof(TeamCity.Startup))]
namespace TeamCity
{
    
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
           
        }
    }
}