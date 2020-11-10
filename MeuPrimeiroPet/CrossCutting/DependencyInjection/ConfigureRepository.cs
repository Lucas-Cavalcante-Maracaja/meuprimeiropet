using Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            

            services.AddDbContext<MyContext>(options =>
              options.UseSqlServer("Server=localhost;Database=MeuPrimeiroPet;Trusted_Connection=True;MultipleActiveResultSets=true"));
        }
    }
}
