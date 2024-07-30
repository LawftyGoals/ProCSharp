

namespace EmployeeApp;
internal class Employee {
    private string _empName;
    private int _empAge;
    private int _empId;
    private float _currPay;
    private string _empSSN;

    private EmployeePayTypeEnum _payType;
    private DateTime _hireDate;


    public EmployeePayTypeEnum PayType
    {
        get => _payType;
        set => _payType = value;
    }

    public DateTime HireDate
    {
        get => _hireDate;
        set => _hireDate = value;
    }


    // works like a normal get: public string SocialSecurityNumber  => _empSSN;
    public string SocialSecurityNumber {
        get => _empSSN;
        private set => _empSSN = value;
    }

    public string Name {
        get { return _empName; }
        set {
            if (value.Length > 15) {
                Console.WriteLine("ERROR! Name length exceeds 15 characters!");
            }
            else {
                _empName = value;
            }
        }
    }

    public int Age {
        get => _empAge;
        set => _empAge = value;
    }

    public int Id {
        get { return _empId; }
        set { _empId = value; }
    }

    public float Pay {
        get { return _currPay; }
        set { _currPay = value; }
    }

    public Employee() {

    }
    public Employee(string name, int id, float pay) :this (name, 0, id, pay, "", EmployeePayTypeEnum.Salaried) { }
    public Employee(string name, int age, int id, float pay, string ssn, EmployeePayTypeEnum payType) {
        Name = name;
        Age = age;
        Id = id;
        Pay = pay;
        SocialSecurityNumber = ssn;
        PayType = payType;
    }

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

