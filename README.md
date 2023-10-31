# Introduction 🏥 
This is open source software to help people understand how $9,000 or more monthly medications fall into the different Medicare coverage gap tiers.  

# The software supports the following user goals
•	Help identify when manufacturer drug assistance will be needed

•	Post resource types regarding grants used for copay assistance 

# Overview 
This is an open source software using a full stack framework to quickly create an environment to get Rx assistance/resources for medicaiton costs. We will begin by using Ionic framework using React. The project begins by building backend API endpoints using MVP concepts and OOP principles. 

# Project Vision  
To create a backend API to get resources for people on high dollar Medicare medications.

# User story
Like a trapeze artist on a balance beam at the circus, estimating medication costs on Medicare move in multiple directions quickly. Thus forcing a patient (user) to make quick financial decisions on thier financial path regarding medication costs.  

# Rest API/CSV.files Resources

• Restful API Drug Cost Resource: https://www.goodrx.com/developer/documentation

• CSV File AWP Drug Cost Resource: https://data.chhs.ca.gov/dataset/prescription-drug-wholesale-acquisition-cost-wac-increases/resource/351098ca-5a59-4461-9069-36c7dce4d0b0?view_id=864f5312-d7e8-484d-a39a-d689cceb030d

# Ionic/React

• https://ionicframework.com/docs/developing/starting

# Parameters

• DrugManufacturerName

• NPD (Drug Product Description)

• AWP (Average Wholesale Cost Offer for Prescription)

• IncomeLevel

• HouseHoldValue

• InsuranceType

Roadmap:

Setting Up the Environment:

Use .NET 5 or .NET 6 (recommended for new projects).
Create a new Web API project using the .NET CLI or Visual Studio.
Data Models:

Drug
Patient
Grant
Notification
Database:

Use Entity Framework Core for database operations.
Define relationships between models.
Endpoints:

CRUD operations for drugs, patients, and grants.
An endpoint to retrieve a patient’s out-of-pocket costs.
An endpoint to send notifications.
Business Logic:

Cost calculation engine.
Notification engine.

Business Logic: 
public class CostCalculator
{
    public double CalculateOutOfPocketExpense(Drug drug)
    {
        if (drug.Cost > 9000)
        {
            return drug.Cost * 0.10;
        }
        return drug.Cost;
    }

    public bool ShouldNotify(Patient patient)
    {
        // Notify if close to or exceeds $6k
        return patient.OutOfPocketExpenses >= 5000 && patient.OutOfPocketExpenses <= 6000;
    }

    public double DeductGrant(Patient patient, double expense)
    {
        // Deduct from grant if available
        if (patient.Grants.Count > 0)
        {
            var grant = patient.Grants[0]; // assuming one grant for simplicity
            if (grant.Amount > expense)
            {
                grant.Amount -= expense;
                return 0;
            }
            else
            {
                expense -= grant.Amount;
                grant.Amount = 0;
            }
        }
        return expense;
    }
}

Endpoint to retrieve patient's true out-of-pocket cost: 
[HttpGet("GetOutofPocketExpense/{patientId}")]
public IActionResult GetOutofPocketExpense(int patientId)
{
    var patient = _dbContext.Patients.Include(p => p.Grants).FirstOrDefault(p => p.Id == patientId);
    if (patient == null)
        return NotFound();

    var costCalculator = new CostCalculator();
    var expense = costCalculator.CalculateOutOfPocketExpense(/* Get drug details */);
    expense = costCalculator.DeductGrant(patient, expense);
    patient.OutOfPocketExpenses += expense;

    _dbContext.SaveChanges();

    if (costCalculator.ShouldNotify(patient))
    {
        // Send notification to patient's email
    }

    return Ok(patient.OutOfPocketExpenses);
}

