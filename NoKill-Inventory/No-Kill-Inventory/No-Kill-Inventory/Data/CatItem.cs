using System.ComponentModel.DataAnnotations;

namespace No_Kill_Inventory.Data;

public class CatItem
{
    [Key]
    public int ItemID { get; set; }
    
    public bool Wet { get; set; }
    
    public bool Adult { get; set; }
    
    public bool Kitty { get; set; }
    
    public String? Special { get; set; }
    
    public int Weight { get; set; }
}