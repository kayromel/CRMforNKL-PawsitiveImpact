using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Recipient
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Ensures auto-increment behavior
    public int Id { get; set; } // Primary key, auto-incremented
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Status { get; set; }
}