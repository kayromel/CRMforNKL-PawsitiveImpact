namespace No_Kill_Inventory.Data;
using System;

public class Item
{
    public int itemID { get; set; }
    
    public String Brand { get; set; }

    public String Animal { get; set; }
    
    public bool Prescription { get; set; }
    
    public String? PrescriptionDesc { get; set; }
    
    public String DryWet { get; set; }
    
    public String Age { get; set; }
    
    public bool GrainFree { get; set; }
    
    public bool WeightCtrl { get; set; }
    
    public bool SmallBites { get; set; }
    
    public bool Junk { get; set; }
    
    public int Qty { get; set; }
    
    public int FoodWeight { get; set; }
}