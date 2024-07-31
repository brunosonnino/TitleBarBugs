using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace _2___TitleBarHeight
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public string[] TitleBarHeights = ["Standard", "Tall", "Collapsed"];
        public MainWindow()
        {
            this.InitializeComponent();
            ExtendsContentIntoTitleBar = true;
        }

        private void TitleBarHeight_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is RadioButtons radioButtons)
            {
                AppWindow.TitleBar.PreferredHeightOption = radioButtons.SelectedIndex switch
                {
                    1 => TitleBarHeightOption.Tall,
                    2 => TitleBarHeightOption.Collapsed,
                    _ => TitleBarHeightOption.Standard
                };
            }
        }

        private void HideIcon_Switched(object sender, RoutedEventArgs e)
        {
            if (sender is ToggleSwitch toggleSwitch)
            {
                AppWindow.TitleBar.IconShowOptions = toggleSwitch.IsOn ? IconShowOptions.HideIconAndSystemMenu : IconShowOptions.ShowIconAndSystemMenu;
            }
        }
    }
}
