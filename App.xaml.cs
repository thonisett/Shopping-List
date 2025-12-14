using Microsoft.Extensions.DependencyInjection;
using Shopping_List.Views;

namespace Shopping_List
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(CreateListView), typeof(CreateListView));

        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}