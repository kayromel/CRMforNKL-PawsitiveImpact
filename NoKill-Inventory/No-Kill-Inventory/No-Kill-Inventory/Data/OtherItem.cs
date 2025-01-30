using System.ComponentModel.DataAnnotations;

namespace No_Kill_Inventory.Data;

public class OtherItem
{
    [Key]
    public int ItemID { get; set; }
    
    [StringLength(100)]
    public String Animal { get; set; }
    
    [StringLength(500)]
    public String Desc { get; set; }
    
    public int Weight { get; set; }
}