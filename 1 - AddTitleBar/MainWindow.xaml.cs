using Microsoft.UI;
using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace _1___AddTitleBar
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        private TitleBar _titleBar = new TitleBar();
        
        public MainWindow()
        {
            this.InitializeComponent();
            SetTitleBarColors();
        }

        private void SetTitleBarColors()
        {
            if (AppWindowTitleBar.IsCustomizationSupported())
            {
                var titleBar = AppWindow.TitleBar;
                titleBar.ForegroundColor = Colors.White;
                titleBar.BackgroundColor = ColorHelper.FromArgb(0xff, 0xb0, 0x0e, 0x25);
                titleBar.ButtonForegroundColor = Colors.White;
                titleBar.ButtonBackgroundColor = ColorHelper.FromArgb(0xff, 0xb0, 0x0e, 0x25);
                titleBar.ButtonHoverForegroundColor = Colors.White;
                titleBar.ButtonHoverBackgroundColor = ColorHelper.FromArgb(0xff, 0x82, 0x03, 0x1c);
                titleBar.ButtonPressedForegroundColor = Colors.White;
                titleBar.ButtonPressedBackgroundColor = ColorHelper.FromArgb(0xff, 0x82, 0x03, 0x1c);

                titleBar.InactiveForegroundColor = Colors.Black;
                titleBar.InactiveBackgroundColor = ColorHelper.FromArgb(0xff, 0xfe, 0xc1, 0xc1);
                titleBar.ButtonInactiveForegroundColor = Colors.Black;
                titleBar.ButtonInactiveBackgroundColor = ColorHelper.FromArgb(0xff, 0xfe, 0xc1, 0xc1);
            }
        }

        private void TitleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            if (sender is ToggleSwitch titleSwitch)
            {
                if (titleSwitch.IsOn)
                {
                    TitleGrid.Children.Add(_titleBar);
                }
                else
                {
                    TitleGrid.Children.Remove(_titleBar);
                }
            }
        }
    }
}
