namespace ContactListApplication_RM.Models;

public class Contact
{
    public string Name { get; set; } = "";
    public string Email { get; set; } = "";
    public string Phone { get; set; } = "";
    public string Description { get; set; } = "";

    /// <summary>
    /// The image filename or resource path; e.g., "Avatars/avatar01.png".
    /// </summary>
    public string Photo { get; set; } = "";
}
