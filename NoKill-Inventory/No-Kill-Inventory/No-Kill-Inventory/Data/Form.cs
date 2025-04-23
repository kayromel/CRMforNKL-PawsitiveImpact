using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace No_Kill_Inventory.Data;

public enum FormType
{
    Application,
    ProofOfIncome,
    SpayNeuter
}

public class Form
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    // Foreign key pointing to Recipients.Id
    [ForeignKey(nameof(Recipient))]
    public int RecipientId { get; set; }

    public FormType FormType { get; set; }

    [Required]
    public string Date { get; set; } = string.Empty;

    // Navigation property to the recipient
    public Recipient Recipient { get; set; } = null!;
}