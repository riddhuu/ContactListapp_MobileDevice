using ContactListApplication_RM.Models;

namespace ContactListApplication_RM.Views;

public partial class ContactDetailsPage : ContentPage
{
    private readonly Models.Contact _selected;

    public ContactDetailsPage(Models.Contact selected)
    {
        InitializeComponent();
        _selected = selected;
        BindingContext = _selected;
    }

    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
