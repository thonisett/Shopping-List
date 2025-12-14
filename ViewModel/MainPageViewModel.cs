using CommunityToolkit.Mvvm.Collections;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Shopping_List.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;




namespace Shopping_List.ViewModel
{
    public partial class MainPageViewModel : ObservableObject
    {
        [RelayCommand]
        public async Task CreateList()
        {
            await Shell.Current.GoToAsync(nameof(CreateListView));
        }


    }
}

