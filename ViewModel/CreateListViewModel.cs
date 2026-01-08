using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Shopping_List.Views;


namespace Shopping_List.ViewModel
{
    public partial class CreateListViewModel
    {
        [RelayCommand]
        public async Task AddToList()
        {
            await Shell.Current.GoToAsync(nameof(CreateListView));
        }


    }
}
