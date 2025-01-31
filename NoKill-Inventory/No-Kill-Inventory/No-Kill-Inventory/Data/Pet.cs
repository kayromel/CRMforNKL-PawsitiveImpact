using System.ComponentModel.DataAnnotations;

namespace No_Kill_Inventory.Data;

public class Pet
{
    [Key]
    public int Id { get; set; }
    
    public String Name { get; set; }
    
    // Dog, cat, other
    public PetType Type { get; set; }
    
    public String FoodType { get; set; }
    
    public int FoodAmount { get; set; }
    
    // Foreign key is Id from Recipient table
    public int RecipientId { get; set; }
    
    public Recipient Recipient { get; set; }
}