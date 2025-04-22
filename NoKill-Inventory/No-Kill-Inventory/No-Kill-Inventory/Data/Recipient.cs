using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace No_Kill_Inventory.Data;
public class Recipient
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    public String FirstName { get; set; }
    
    public String LastName { get; set; }
    
    public String PhoneNumber { get; set; }

    public String Email { get; set; }
    
    public RecipientStatus Status { get; set; }
    
    public List<Pet> Pets { get; set; }

    public string? ItemsReceiving { get; set; }

    public string? LastAppointmentDate { get; set; }
}
