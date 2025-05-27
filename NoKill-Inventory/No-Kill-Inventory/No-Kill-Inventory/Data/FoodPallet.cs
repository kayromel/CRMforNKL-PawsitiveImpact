using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.JavaScript;
using Microsoft.AspNetCore.Components;

namespace No_Kill_Inventory.Data;

public enum Status
{
    Alive,
    Used
}


public class FoodPallet
{
    [Key]
    public int ItemID { get; set; }
    
    public Barcode Barcode { get; set; }
    
    public Status Status { get; set; }
    
    public DateTime ArrivalDate { get; set; }
    
    public DateTime ExpirationDate { get; set; }
    
    public int InitWeight { get; set; }
    
    public int CurrentWeight { get; set; }
    
    [StringLength(100)]
    public String LocationDesc { get; set; }
}