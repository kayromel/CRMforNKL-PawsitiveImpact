using CsvHelper.Configuration.Attributes;

namespace No_Kill_Inventory.Data;

public class PetFoodRequestCSV
{
    [Name("Timestamp")]
    public string? Timestamp { get; set; }
    
    [Name("**I understand and agree to the guidelines listed above. I understand that No Kill Louisville accepts all kinds of donations and no warranties or guarantees are being made as to the pet food and supplies.**")]
    public string? AgreementToGuidelines { get; set; }

    [Name("Terms and Conditions (Part 1):\nPlease read carefully and be sure you agree to the Terms and Conditions below:")]
    public string? TermsAndConditionsPart1 { get; set; }
    
    [Name("Terms and Conditions (Part 2):\nPlease read carefully and be sure you agree to the Terms and Conditions below:")]
    public string? TermsAndConditionsPart2 { get; set; }
    
    [Name("First name:")]
    public string? FirstName { get; set; }
    
    [Name("Last name:")]
    public string? LastName { get; set; }
    
    [Name("How many adults (18 years & older) live at your address?")]
    public string? AdultsInHousehold { get; set; }
    
    [Name("Name of each adult (18 years and older) living at your address:")]
    public string? NamesOfAdults { get; set; }
    
    [Name("How many children (17 years and younger) live at your address?")]
    public string? ChildrenInHousehold { get; set; }
    
    [Name("Physical street address where your animals live (include city and zip code):")]
    public string? PhysicalAddress { get; set; }
    
    [Name("Phone number we can text you at:")]
    public string? ContactPhoneNumber { get; set; }
    
    [Name("Email address:")]
    public string? EmailAddress { get; set; }
    
    [Name("Name of person(s) you authorize to pick up food for you:")]
    public string? AuthorizedPickupPersons { get; set; }
    
    [Name("Including all adults (18 years and older), living at my address, the household receives the following:\nCheck all that apply")]
    public string? HouseholdIncomeSources { get; set; }
    
    [Name("Are you currently fostering any animals for a rescue organization or shelter? If so, please provide the name of the organization you are fostering for:")]
    public string? FosteringOrganization { get; set; }
    
    [Name("Are any of your animals being used for breeding purposes? Are they producing offspring? If so, please provide the names of those animals:")]
    public string? BreedingAnimals { get; set; }
    
    [Name("I understand that I am required to show proof of spay/neuter for each animal I request donations for:")]
    public string? SpayNeuterAcknowledgment { get; set; }
    
    [Name("How many dogs do you own?")]
    public string? DogCount { get; set; }

    [Name("Dog #1's name")]
    public string? Dog1Name { get; set; }
    
    [Name("Dog #1's age")]
    public string? Dog1Age { get; set; }
    
    [Name("Dog #1's weight")]
    public string? Dog1Weight { get; set; }
    
    [Name("Dog #1's sex")]
    public string? Dog1Sex { get; set; }
    
    [Name("Dog #1's spay/neuter details")]
    public string? Dog1SpayNeuter { get; set; }
    
    [Name("Dog #1's breed (type of dog)")]
    public string? Dog1Breed { get; set; }
    
    [Name("Dog #1's dietary details or restrictions:\nCheck all that apply")]
    public string? Dog1DietaryDetails { get; set; }
    
    [Name("Dog #1's prescription or restriction (please be specific):\n\n**We cannot guarantee we will have these requests available**")]
    public string? Dog1PrescriptionNotes { get; set; }
    
    [Name("Dog #2's name")]
    public string? Dog2Name { get; set; }
    
    [Name("Dog #2's age")]
    public string? Dog2Age { get; set; }
    
    [Name("Dog #2's weight")]
    public string? Dog2Weight { get; set; }
    
    [Name("Dog #2's sex")]
    public string? Dog2Sex { get; set; }
    
    [Name("Dog #2's spay/neuter details")]
    public string? Dog2SpayNeuter { get; set; }
    
    [Name("Dog #2's breed (type of dog)")]
    public string? Dog2Breed { get; set; }
    
    [Name("Dog #2's dietary details or restrictions:\nCheck all that apply")]
    public string? Dog2DietaryDetails { get; set; }
    
    [Name("Dog #2's prescription or restriction (please be specific):\n\n**We cannot guarantee we will have these requests available**")]
    public string? Dog2PrescriptionNotes { get; set; }

    [Name("Dog #3's name")]
    public string? Dog3Name { get; set; }
    
    [Name("Dog #3's age")]
    public string? Dog3Age { get; set; }
    
    [Name("Dog #3's weight")]
    public string? Dog3Weight { get; set; }
    
    [Name("Dog #3's sex")]
    public string? Dog3Sex { get; set; }
    
    [Name("Dog #3's spay/neuter details")]
    public string? Dog3SpayNeuter { get; set; }
    
    [Name("Dog #3's breed (type of dog)")]
    public string? Dog3Breed { get; set; }
    
    [Name("Dog #3's dietary details or restrictions:\nCheck all that apply")]
    public string? Dog3DietaryDetails { get; set; }
    
    [Name("Dog #3's prescription or restriction (please be specific):\n\n**We cannot guarantee we will have these requests available**")]
    public string? Dog3PrescriptionNotes { get; set; }

    [Name("My dogs are mainly kept... (pick one)")]
    public string? DogsKeptLocation { get; set; }

    [Name("How many cats do you own?")]
    public string? CatCount { get; set; }

    [Name("Cat #1's name")]
    public string? Cat1Name { get; set; }
    
    [Name("Cat #1's age")]
    public string? Cat1Age { get; set; }
    
    [Name("Cat #1's sex")]
    public string? Cat1Sex { get; set; }
    
    [Name("Cat #1's spay/neuter details")]
    public string? Cat1SpayNeuter { get; set; }
    
    [Name("Cat #1's dietary details or restrictions:\nCheck all that apply")]
    public string? Cat1DietaryDetails { get; set; }
    
    [Name("Cat #1's prescription or restriction (please be specific):\n\n**We cannot guarantee we will have these requests available**")]
    public string? Cat1PrescriptionNotes { get; set; }
    
    [Name("Cat #1: Resides inside or outside? Pick one")]
    public string? Cat1Residence { get; set; }

    [Name("Cat #2's name")]
    public string? Cat2Name { get; set; }
    
    [Name("Cat #2's age")]
    public string? Cat2Age { get; set; }
    
    [Name("Cat #2's sex")]
    public string? Cat2Sex { get; set; }
    
    [Name("Cat #2's spay/neuter details")]
    public string? Cat2SpayNeuter { get; set; }
    
    [Name("Cat #2's dietary details or restrictions:\nCheck all that apply")]
    public string? Cat2DietaryDetails { get; set; }
    
    [Name("Cat #2's prescription or restriction (please be specific):\n\n**We cannot guarantee we will have these requests available**")]
    public string? Cat2PrescriptionNotes { get; set; }
    
    [Name("Cat #2: Resides inside or outside? Pick one")]
    public string? Cat2Residence { get; set; }

    [Name("Cat #3's name")]
    public string? Cat3Name { get; set; }
    
    [Name("Cat #3's age")]
    public string? Cat3Age { get; set; }
    
    [Name("Cat #3's sex")]
    public string? Cat3Sex { get; set; }
    
    [Name("Cat #3's spay/neuter details")]
    public string? Cat3SpayNeuter { get; set; }
    
    [Name("Cat #3's dietary details or restrictions:\nCheck all that apply")]
    public string? Cat3DietaryDetails { get; set; }
    
    [Name("Cat #3's prescription or restriction (please be specific):\n\n**We cannot guarantee we will have these requests available**")]
    public string? Cat3PrescriptionNotes { get; set; }
    
    [Name("Cat #3: Resides inside or outside? Pick one")]
    public string? Cat3Residence { get; set; }

    [Name("Cat #4's name")]
    public string? Cat4Name { get; set; }
    
    [Name("Cat #4's age")]
    public string? Cat4Age { get; set; }
    
    [Name("Cat #4's sex")]
    public string? Cat4Sex { get; set; }
    
    [Name("Cat #4's spay/neuter details")]
    public string? Cat4SpayNeuter { get; set; }
    
    [Name("Cat #4's dietary details or restrictions:\nCheck all that apply")]
    public string? Cat4DietaryDetails { get; set; }
    
    [Name("Cat #4's prescription or restriction (please be specific):\n\n**We cannot guarantee we will have these requests available**")]
    public string? Cat4PrescriptionNotes { get; set; }
    
    [Name("Cat #4: Resides inside or outside? Pick one")]
    public string? Cat4Residence { get; set; }

    [Name("Cat #5's name")]
    public string? Cat5Name { get; set; }
    
    [Name("Cat #5's age")]
    public string? Cat5Age { get; set; }
    
    [Name("Cat #5's sex")]
    public string? Cat5Sex { get; set; }
    
    [Name("Cat #5's spay/neuter details")]
    public string? Cat5SpayNeuter { get; set; }
    
    [Name("Cat #5's dietary details or restrictions:\nCheck all that apply")]
    public string? Cat5DietaryDetails { get; set; }
    
    [Name("Cat #5's prescription or restriction (please be specific):\n\n**We cannot guarantee we will have these requests available**")]
    public string? Cat5PrescriptionNotes { get; set; }
    
    [Name("Cat #5: Resides inside or outside? Pick one")]
    public string? Cat5Residence { get; set; }

    [Name("Do you have any other animals you'd like to request food/supplies for? Sometimes we can provide food for Guinea Pigs, Rabbits, Gerbils, etc.\nPlease let us know how many of what animal or we cannot provide donations for them.")]
    public string? OtherAnimals { get; set; }
    
    [Name("Do you prefer to receive notification by phone call, text, or email?\nCheck all that apply.")]
    public string? PreferredNotificationMethod { get; set; }
}