using System.Collections.ObjectModel;

namespace ContactListApplication_RM.Models;

public class ContactGroup : ObservableCollection<Contact>
{
    public string Key { get; }

    public ContactGroup(string key, IEnumerable<Contact> contacts) : base(contacts)
    {
        Key = key;
    }
}
