using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

using Blocks.UI.Core;
using Blocks.UI.Core.ViewModels;

using Microsoft.Extensions.DependencyInjection;
using Blocks.UI.Uwp.Pages;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Blocks.UI.Uwp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void RelativePanelMenuItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.ContentFrame.Navigate(typeof(RelativePanelPage));
        }

        private void StackPanelMenuItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.ContentFrame.Navigate(typeof(StackPanelPage));
        }

        private void GridMenuItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.ContentFrame.Navigate(typeof(GridPage));
        }

        private void VariableSizedWrapGridMenuItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.ContentFrame.Navigate(typeof(VariableSizedWrapGridPage));
        }

        private void CanvasMenuItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.ContentFrame.Navigate(typeof(CanvasPage));
        }

    }
}
