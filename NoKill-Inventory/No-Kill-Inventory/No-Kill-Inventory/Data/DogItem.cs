using System.ComponentModel.DataAnnotations;

namespace No_Kill_Inventory.Data;
public class DogItem
{
    [Key]
    public int ItemID { get; set; }
    
    public bool Wet { get; set; }
    
    public bool Puppy { get; set; }
    
    public bool WgtCtrl { get; set; }
    
    public bool GrainFree { get; set; }
    
    public bool SmBites { get; set; }
    
    public String? Special { get; set; }
    
    public int Weight { get; set; }
}