using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace Shopping_List.ViewModel
{
    public partial class CreateListViewModel : ObservableObject
    {


        [ObservableProperty]
        private ObservableCollection<string> items = new();

        [ObservableProperty]
        string shoppingItem;

        [RelayCommand]
        public void AddToList()
        {
            Items.Add(ShoppingItem);
            ShoppingItem = string.Empty;
        }
    }
}



