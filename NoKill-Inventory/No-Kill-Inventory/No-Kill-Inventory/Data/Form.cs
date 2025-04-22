using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace No_Kill_Inventory.Data;

public enum FormType
{
    Application,
    ProofOfIncome,
    SpayNeuter,
    FoodExpiration
}

public class Form
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    
    public int RecipientId { get; set; }
    public FormType FormType { get; set; }
    
    // Add date of submission
    
    
}