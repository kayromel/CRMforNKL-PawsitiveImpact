using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace No_Kill_Inventory.Data;

public class PetFoodRequest
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public string? Timestamp { get; set; }
    public string? AgreementToGuidelines { get; set; }
    public string? TermsAndConditionsPart1 { get; set; }
    public string? TermsAndConditionsPart2 { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? AdultsInHousehold { get; set; }
    public string? NamesOfAdults { get; set; }
    public string? ChildrenInHousehold { get; set; }
    public string? PhysicalAddress { get; set; }
    public string? ContactPhoneNumber { get; set; }
    public string? EmailAddress { get; set; }
    public string? AuthorizedPickupPersons { get; set; }
    public string? HouseholdIncomeSources { get; set; }
    public string? FosteringOrganization { get; set; }
    public string? BreedingAnimals { get; set; }
    public string? SpayNeuterAcknowledgment { get; set; }

    public string? DogCount { get; set; }

    public string? Dog1Name { get; set; }
    public string? Dog1Age { get; set; }
    public string? Dog1Weight { get; set; }
    public string? Dog1Sex { get; set; }
    public string? Dog1SpayNeuter { get; set; }
    public string? Dog1Breed { get; set; }
    public string? Dog1DietaryDetails { get; set; }
    public string? Dog1PrescriptionNotes { get; set; }

    public string? Dog2Name { get; set; }
    public string? Dog2Age { get; set; }
    public string? Dog2Weight { get; set; }
    public string? Dog2Sex { get; set; }
    public string? Dog2SpayNeuter { get; set; }
    public string? Dog2Breed { get; set; }
    public string? Dog2DietaryDetails { get; set; }
    public string? Dog2PrescriptionNotes { get; set; }

    public string? Dog3Name { get; set; }
    public string? Dog3Age { get; set; }
    public string? Dog3Weight { get; set; }
    public string? Dog3Sex { get; set; }
    public string? Dog3SpayNeuter { get; set; }
    public string? Dog3Breed { get; set; }
    public string? Dog3DietaryDetails { get; set; }
    public string? Dog3PrescriptionNotes { get; set; }

    public string? DogsKeptLocation { get; set; }

    public string? CatCount { get; set; }

    public string? Cat1Name { get; set; }
    public string? Cat1Age { get; set; }
    public string? Cat1Sex { get; set; }
    public string? Cat1SpayNeuter { get; set; }
    public string? Cat1DietaryDetails { get; set; }
    public string? Cat1PrescriptionNotes { get; set; }
    public string? Cat1Residence { get; set; }

    public string? Cat2Name { get; set; }
    public string? Cat2Age { get; set; }
    public string? Cat2Sex { get; set; }
    public string? Cat2SpayNeuter { get; set; }
    public string? Cat2DietaryDetails { get; set; }
    public string? Cat2PrescriptionNotes { get; set; }
    public string? Cat2Residence { get; set; }

    public string? Cat3Name { get; set; }
    public string? Cat3Age { get; set; }
    public string? Cat3Sex { get; set; }
    public string? Cat3SpayNeuter { get; set; }
    public string? Cat3DietaryDetails { get; set; }
    public string? Cat3PrescriptionNotes { get; set; }
    public string? Cat3Residence { get; set; }

    public string? Cat4Name { get; set; }
    public string? Cat4Age { get; set; }
    public string? Cat4Sex { get; set; }
    public string? Cat4SpayNeuter { get; set; }
    public string? Cat4DietaryDetails { get; set; }
    public string? Cat4PrescriptionNotes { get; set; }
    public string? Cat4Residence { get; set; }

    public string? Cat5Name { get; set; }
    public string? Cat5Age { get; set; }
    public string? Cat5Sex { get; set; }
    public string? Cat5SpayNeuter { get; set; }
    public string? Cat5DietaryDetails { get; set; }
    public string? Cat5PrescriptionNotes { get; set; }
    public string? Cat5Residence { get; set; }

    public string? OtherAnimals { get; set; }
    public string? PreferredNotificationMethod { get; set; }
}