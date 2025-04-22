using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.EntityFrameworkCore;
using No_Kill_Inventory.Data;
using System.Globalization;
using System.Text.RegularExpressions;

public class CSVImporter
{
    private readonly ApplicationDbContext _context;

    public CSVImporter(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public static string FormatPhoneNumber(string rawNumber)
    {
        if (string.IsNullOrWhiteSpace(rawNumber))
            return "Invalid Number";
        
        // Step 1: Strip non-numeric characters
        string digits = Regex.Replace(rawNumber ?? "", @"\D", "");

        // Step 2: Validate length (should be 11 digits, e.g., 1 for US + 10 digits)
        if (digits.Length != 10)
        {
            return "Invalid Number";
        }

        // Step 3: Format to xxx-xxx-xxxx
        return $"{digits.Substring(0, 3)}-{digits.Substring(3, 3)}-{digits.Substring(6, 4)}";
    }

    public async Task ImportPetFoodRequestsAsync(string csvFilePath)
    {
        var config = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            HasHeaderRecord = true,
            MissingFieldFound = null,
            HeaderValidated = null,
            BadDataFound = null
        };

        using var reader = new StreamReader(csvFilePath);
        using var csv = new CsvReader(reader, config);

        var records = csv.GetRecords<PetFoodRequestCSV>().ToList();

        var existingRecipient = new Recipient();

        foreach (var r in records)
        {
            // Match recipient based on name, phone, and email
                existingRecipient = await _context.Recipients.FirstOrDefaultAsync(rec =>
                rec.FirstName == r.FirstName &&
                rec.LastName == r.LastName &&
                rec.PhoneNumber == r.ContactPhoneNumber &&
                rec.Email == r.EmailAddress);

            // Create recipient if not found
            if (existingRecipient == null)
            {
                existingRecipient = new Recipient
                {
                    FirstName = r.FirstName ?? "Unknown",
                    LastName = r.LastName ?? "Unknown",
                    PhoneNumber = r.ContactPhoneNumber ?? "N/A",
                    Email = r.EmailAddress ?? "N/A",
                    Status = RecipientStatus.NotStarted,
                    Pets = new List<Pet>(),
                    ItemsReceiving = null,
                    LastAppointmentDate = null
                };

                _context.Recipients.Add(existingRecipient);
                await _context.SaveChangesAsync(); // Save to get Recipient.Id
            }
        }

        var entities = records.Select(r => new PetFoodRequest
        {
            Timestamp = r.Timestamp,
            AgreementToGuidelines = r.AgreementToGuidelines,
            TermsAndConditionsPart1 = r.TermsAndConditionsPart1,
            TermsAndConditionsPart2 = r.TermsAndConditionsPart2,
            FirstName = r.FirstName,
            LastName = r.LastName,
            AdultsInHousehold = r.AdultsInHousehold,
            NamesOfAdults = r.NamesOfAdults,
            ChildrenInHousehold = r.ChildrenInHousehold,
            PhysicalAddress = r.PhysicalAddress,
            ContactPhoneNumber = r.ContactPhoneNumber != null ? FormatPhoneNumber(r.ContactPhoneNumber) : "Invalid Number",
            EmailAddress = r.EmailAddress,
            AuthorizedPickupPersons = r.AuthorizedPickupPersons,
            HouseholdIncomeSources = r.HouseholdIncomeSources,
            FosteringOrganization = r.FosteringOrganization,
            BreedingAnimals = r.BreedingAnimals,
            SpayNeuterAcknowledgment = r.SpayNeuterAcknowledgment,
            DogCount = r.DogCount,
            Dog1Name = r.Dog1Name,
            Dog1Age = r.Dog1Age,
            Dog1Weight = r.Dog1Weight,
            Dog1Sex = r.Dog1Sex,
            Dog1SpayNeuter = r.Dog1SpayNeuter,
            Dog1Breed = r.Dog1Breed,
            Dog1DietaryDetails = r.Dog1DietaryDetails,
            Dog1PrescriptionNotes = r.Dog1PrescriptionNotes,
            Dog2Name = r.Dog2Name,
            Dog2Age = r.Dog2Age,
            Dog2Weight = r.Dog2Weight,
            Dog2Sex = r.Dog2Sex,
            Dog2SpayNeuter = r.Dog2SpayNeuter,
            Dog2Breed = r.Dog2Breed,
            Dog2DietaryDetails = r.Dog2DietaryDetails,
            Dog2PrescriptionNotes = r.Dog2PrescriptionNotes,
            Dog3Name = r.Dog3Name,
            Dog3Age = r.Dog3Age,
            Dog3Weight = r.Dog3Weight,
            Dog3Sex = r.Dog3Sex,
            Dog3SpayNeuter = r.Dog3SpayNeuter,
            Dog3Breed = r.Dog3Breed,
            Dog3DietaryDetails = r.Dog3DietaryDetails,
            Dog3PrescriptionNotes = r.Dog3PrescriptionNotes,
            DogsKeptLocation = r.DogsKeptLocation,
            CatCount = r.CatCount,
            Cat1Name = r.Cat1Name,
            Cat1Age = r.Cat1Age,
            Cat1Sex = r.Cat1Sex,
            Cat1SpayNeuter = r.Cat1SpayNeuter,
            Cat1DietaryDetails = r.Cat1DietaryDetails,
            Cat1PrescriptionNotes = r.Cat1PrescriptionNotes,
            Cat1Residence = r.Cat1Residence,
            Cat2Name = r.Cat2Name,
            Cat2Age = r.Cat2Age,
            Cat2Sex = r.Cat2Sex,
            Cat2SpayNeuter = r.Cat2SpayNeuter,
            Cat2DietaryDetails = r.Cat2DietaryDetails,
            Cat2PrescriptionNotes = r.Cat2PrescriptionNotes,
            Cat2Residence = r.Cat2Residence,
            Cat3Name = r.Cat3Name,
            Cat3Age = r.Cat3Age,
            Cat3Sex = r.Cat3Sex,
            Cat3SpayNeuter = r.Cat3SpayNeuter,
            Cat3DietaryDetails = r.Cat3DietaryDetails,
            Cat3PrescriptionNotes = r.Cat3PrescriptionNotes,
            Cat3Residence = r.Cat3Residence,
            Cat4Name = r.Cat4Name,
            Cat4Age = r.Cat4Age,
            Cat4Sex = r.Cat4Sex,
            Cat4SpayNeuter = r.Cat4SpayNeuter,
            Cat4DietaryDetails = r.Cat4DietaryDetails,
            Cat4PrescriptionNotes = r.Cat4PrescriptionNotes,
            Cat4Residence = r.Cat4Residence,
            Cat5Name = r.Cat5Name,
            Cat5Age = r.Cat5Age,
            Cat5Sex = r.Cat5Sex,
            Cat5SpayNeuter = r.Cat5SpayNeuter,
            Cat5DietaryDetails = r.Cat5DietaryDetails,
            Cat5PrescriptionNotes = r.Cat5PrescriptionNotes,
            Cat5Residence = r.Cat5Residence,
            OtherAnimals = r.OtherAnimals,
            PreferredNotificationMethod = r.PreferredNotificationMethod
        }).ToList();

        _context.PetFoodRequests.AddRange(entities);
        await _context.SaveChangesAsync();
    }
}