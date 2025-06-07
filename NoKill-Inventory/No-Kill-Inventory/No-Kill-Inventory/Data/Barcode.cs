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

public enum Age
{
    Adult,
    Senior,
    Large,
    Young
}

public enum FoodType
{
    Dry,
    Wet
}

public class Barcode
{
    [Key]
    public int ItemID { get; set; }
    
    public String Name { get; set; }
    
    public Species Animal { get; set; }
    
    public String? AnimalName { get; set; }
    
    public Age Age { get; set; }
    
    public FoodType FoodType { get; set; }
    
    public bool Prescription { get; set; }
    
}