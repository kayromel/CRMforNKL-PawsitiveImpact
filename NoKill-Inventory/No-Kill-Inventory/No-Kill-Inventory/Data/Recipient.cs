using System.ComponentModel.DataAnnotations;

namespace No_Kill_Inventory.Data;
public class Recipient
{
    [Key]
    public int Id { get; set; }
    
    public String FirstName { get; set; }
    
    public String LastName { get; set; }
    
    public String PhoneNumber { get; set; }

    public String Email { get; set; }
    
    public Pet[] Pets { get; set; }
}