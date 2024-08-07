

namespace Employees;
internal partial class Employee {

    protected BenefitPackage EmpBenefits = new BenefitPackage();
    public double GetBenefitCost() => EmpBenefits.ComputePayDeduction();

    public BenefitPackage Benefits
    {
        get => EmpBenefits;
        set => EmpBenefits = value;
    }

    public virtual void GiveBonus(float amount) {
        /*Pay = this switch
        {
            { Age: >= 18, PayType: EmployeePayTypeEnum.Commision  }
                => Pay += .10F * amount,
            { Age: >= 18, PayType: EmployeePayTypeEnum.Hourly }
                => Pay += 40F * amount / 2080F,
            { Age: >= 18, PayType: EmployeePayTypeEnum.Salaried }
                => Pay += amount,
            _ => Pay += 0
        };*/
        Pay += amount;
    }
    public virtual void DisplayStats() {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Pay: {Pay}");
        Console.WriteLine($"SSN: {SocialSecurityNumber}");
    }

    public string GetName() => _empName;
    public void SetName(string name) {
        if (name.Length > 15) {
            Console.WriteLine("ERROR! Name length exceeds 15 characters!");
        }
        else {
            _empName = name;
        }
    }

}

