using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace FlyoutMenu.Main
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

        private void SplitView_PaneClosing(SplitView sender, SplitViewPaneClosingEventArgs args)
        {
            args.Cancel = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.SplitView.IsPaneOpen = false;
        }

        private void BtnOpenPane_Click(object sender, RoutedEventArgs e)
        {
            this.SplitView.IsPaneOpen = true;
        }
    }
}
