using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

using NavFromScratchApp.Pages;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace NavFromScratchApp
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            NavView.SelectionChanged += NavigationView_SelectionChanged;
        }

        private void NavigationView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            if (args.SelectedItemContainer != null)
            {
                string selectedTag = args.SelectedItemContainer.Tag.ToString();
                switch (selectedTag)
                {
                    case "home":
                        ContentFrame.Navigate(typeof(HomePage));
                        break;
                    case "settings":
                        ContentFrame.Navigate(typeof(SettingsPage));
                        break;
                    case "vender":
                        ContentFrame.Navigate(typeof(Vender));
                        break;
                }
            }

        }
    }
}
