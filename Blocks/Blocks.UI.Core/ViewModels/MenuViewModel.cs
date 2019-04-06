using System;
using System.Collections.Generic;
using System.Text;

namespace Blocks.UI.Core.ViewModels
{
    public class MenuViewModel
    {
        public string Header { get; set; }

        public List<MenuItemViewModel> Items { get; } = new List<MenuItemViewModel>
        {
            new MenuItemViewModel { Text = "Relative Panel" },
            new MenuItemViewModel { Text = "Stack Panel" }
        };

    }
}
