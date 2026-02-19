using System.Collections.ObjectModel;
using ContactListApplication_RM.Models;

namespace ContactListApplication_RM.ViewModels;

public class ContactsViewModel
{
    public ObservableCollection<ContactGroup> GroupedContacts { get; } = new();

    public ContactsViewModel()
    {
        var contacts = new List<ContactListApplication_RM.Models.Contact>
        {
            new() { Name="Alice Johnson",   Email="alice.johnson@example.com",   Phone="(513) 555-0101", Description="Project coordinator.",   Photo="Resources/Images/pic_one.png" },
            new() { Name="Ava Martin",      Email="ava.martin@example.com",      Phone="(513) 555-0102", Description="UI/UX enthusiast.",     Photo="Resources/Images/pic_two.png" },
            new() { Name="Aaron Smith",     Email="aaron.smith@example.com",     Phone="(513) 555-0103", Description="Backend specialist.",   Photo="Resources/Images/pic_four.png" },

            new() { Name="Carlos Rivera",   Email="carlos.rivera@example.com",   Phone="(513) 555-0201", Description="QA engineer.",          Photo= "Resources/Images/pic_one.png" },
            new() { Name="Chloe Patel",     Email="chloe.patel@example.com",     Phone="(513) 555-0202", Description="Marketing intern.",     Photo="Resources/Images/pic_two.png" },
            new() { Name="Caleb Nguyen",    Email="caleb.nguyen@example.com",    Phone="(513) 555-0203", Description="Mobile developer.",     Photo="Resources/Images/pic_four.png"},

            new() { Name="James Carter",    Email="james.carter@example.com",    Phone="(513) 555-0301", Description="Product manager.",      Photo= "Resources/Images/pic_one.png" },
            new() { Name="Julia Kim",       Email="julia.kim@example.com",       Phone="(513) 555-0302", Description="Data analyst.",         Photo= "Resources/Images/pic_two.png" },
            new() { Name="Jasper Lee",      Email="jasper.lee@example.com",      Phone="(513) 555-0303", Description="DevOps advocate.",      Photo="Resources/Images/pic_four.png" },

            new() { Name="Mia Thompson",    Email="mia.thompson@example.com",    Phone="(513) 555-0401", Description="Technical writer.",     Photo= "Resources/Images/pic_one.png" },
            new() { Name="Mason Green",     Email="mason.green@example.com",     Phone="(513) 555-0402", Description="Cloud architect.",      Photo= "Resources/Images/pic_two.png" },
            new() { Name="Madison Clark",   Email="madison.clark@example.com",   Phone="(513) 555-0403", Description="Research assistant.",   Photo="Resources/Images/pic_four.png" },

            new() { Name="Sophia Perez",    Email="sophia.perez@example.com",    Phone="(513) 555-0501", Description="Graphic designer.",     Photo="Resources/Images/pic_one.png" },
            new() { Name="Samuel Brooks",   Email="samuel.brooks@example.com",   Phone="(513) 555-0502", Description="Security engineer.",    Photo="Resources/Images/pic_two.png" },
            new() { Name="Stella Watts",    Email="stella.watts@example.com",    Phone="(513) 555-0503", Description="Support specialist.",   Photo="Resources/Images/pic_four.png" },
        };

        var groups = contacts
            .GroupBy(c => c.Name[0].ToString().ToUpperInvariant())
            .OrderBy(g => g.Key)
            .Select(g => new ContactGroup(g.Key, g.OrderBy(c => c.Name)));

        foreach (var g in groups)
            GroupedContacts.Add(g);
    }
}
