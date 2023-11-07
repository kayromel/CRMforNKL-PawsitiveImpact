namespace NoKill_Inventory.Data;
using System;

public class Item
{
    // Cat/dog/other
    public String Animal { get; set; }
    
    // Is it prescription?
    public bool Prescription { get; set; }
    
    // If true, specific info here
    public String? PrescriptionDesc { get; set; }
    
    // Dry/wet
    public String DryWet { get; set; }
    
    // Youth/Adult/Senior
    public String Age { get; set; }
    
    // Grain Free
    public bool GrainFree { get; set; }
    
    // Weight Control
    public bool WeightCtrl { get; set; }
    
    // Small Bites
    public bool SmallBites { get; set; }
    
    // Junk
    public bool Junk { get; set; }
    
    // If Junk, why
    public String? JunkDesc { get; set; }
    
    // Quantity of item
    public int Qty { get; set; }
    
    // Weight of food bag/can/box
    public int FoodWeight { get; set; }
    
    // Do we want to have ID's for each item/entry?
    public int ItemID { get; set; }
}