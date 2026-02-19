using System.Linq;
using ContactListApplication_RM.Models;
using ContactListApplication_RM.ViewModels;

namespace ContactListApplication_RM.Views;

public partial class ContactsPage : ContentPage
{
    public ContactsPage()
    {
        InitializeComponent();
        BindingContext = new ContactsViewModel();
    }

    private async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var selected = e.CurrentSelection?.FirstOrDefault() as Models.Contact;
        if (selected is null)
            return;

        await Navigation.PushAsync(new ContactDetailsPage(selected));

        ((CollectionView)sender).SelectedItem = null;
    }
}

