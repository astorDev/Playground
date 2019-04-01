using System;
using System.Collections.Generic;
using System.Text;

using Blocks.UI.Core.ViewModels;

using Microsoft.Extensions.DependencyInjection;

namespace Blocks.UI.Core
{
    public static class CompositionRoot
    {
        public static IServiceProvider ServiceProvider;

        static CompositionRoot()
        {
            var services = new ServiceCollection();
            services.AddTransient<MainViewModel>();

            ServiceProvider = services.BuildServiceProvider();
        }
    }
}
