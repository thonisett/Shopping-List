using Shopping_List.ViewModel;

namespace Shopping_List;


public partial class MainPage : ContentPage
{
    public MainPage(MainPageViewModel vm) 
    {
        InitializeComponent();
        BindingContext = vm;
    }

}