

namespace EmployeeApp;
internal partial class Employee {
    

    public void GiveBonus(float amount) {
        Pay = this switch
        {
            { Age: >= 18, PayType: EmployeePayTypeEnum.Commision, HireDate.Year: > 2020  }
                => Pay += .10F * amount,
            { Age: >= 18, PayType: EmployeePayTypeEnum.Hourly, HireDate.Year: > 2020 }
                => Pay += 40F * amount / 2080F,
            { Age: >= 18, PayType: EmployeePayTypeEnum.Salaried, HireDate.Year: > 2020 }
                => Pay += amount,
            _ => Pay += 0
        };
    }
    public void DisplayStats() {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Pay: {Pay}");
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

