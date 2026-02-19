using ContactListApplication_RM.Views;

namespace ContactListApplication_RM;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        MainPage = new NavigationPage(new ContactsPage());
    }
}
