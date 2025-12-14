using Shopping_List.Views;

namespace Shopping_List
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(CreateListView), typeof(CreateListView));

        }
    }
}
