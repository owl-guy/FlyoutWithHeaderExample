using System.Windows.Input;

namespace FlyoutWithHeaderExample
{
    public partial class AppShell : Shell
    {
        public ICommand TestCommand => new Command(() =>
        {
            this.DisplayAlert("Test", "Test", "Cancel");
        });

        public AppShell()
        {
            InitializeComponent();
            BindingContext = this;
        }
    }
}
