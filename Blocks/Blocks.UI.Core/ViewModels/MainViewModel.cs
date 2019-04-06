using System;
using System.Collections.Generic;
using System.Text;

namespace Blocks.UI.Core.ViewModels
{
    public class MainViewModel
    {
        public string Greeting { get; } = $"Hello from {nameof(MainViewModel)}";

        public MenuViewModel Menu { get; } = new MenuViewModel(); 
    }
}
