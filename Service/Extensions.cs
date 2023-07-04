using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public static class Extensions
    {
        public static void AddGitHubIntegrations( this IServiceCollection services,Action<GitHubIntegrationOptions>configure)
        {
            services.Configure(configure);  
            services.AddScoped<IGitHubService, GitHubService>();
        } 
    }
}
