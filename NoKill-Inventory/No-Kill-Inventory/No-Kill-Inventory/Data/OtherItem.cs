using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.JavaScript;

namespace No_Kill_Inventory.Data;

public class OtherItem
{
    [Key]
    public int ItemID { get; set; }
    
    public String Animal { get; set; }
    
    public String Desc { get; set; }
    
    public int Weight { get; set; }
}