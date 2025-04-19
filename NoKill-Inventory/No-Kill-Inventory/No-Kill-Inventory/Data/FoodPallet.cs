using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.JavaScript;
using Microsoft.AspNetCore.Components;

namespace No_Kill_Inventory.Data;

public enum Species
{
    Dog,
    Cat,
    Other
}

public enum Status
{
    Active,
    Used
}

public class FoodPallet
{
    [Key]
    public int ItemID { get; set; }
    
    public Status Status { get; set; }
    
    public Species Animal { get; set; }
    
    public DateTime ArrivalDate { get; set; }
    
    public DateTime ExpirationDate { get; set; }
    
    [StringLength(100)]
    public String LocationDesc { get; set; }
}