
namespace Employees; 
internal abstract partial class Employee {
    private string _empName;
    private int _empAge;
    private int _empId;
    private float _currPay;
    private string _empSSN;

    private EmployeePayTypeEnum _payType;
    private DateTime _hireDate;


    public EmployeePayTypeEnum PayType {
        get => _payType;
        set => _payType = value;
    }

    public DateTime HireDate {
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
    public Employee(string name, int id, float pay) : this(name, 0, id, pay, "", EmployeePayTypeEnum.Salaried) { }
    public Employee(string name, int age, int id, float pay, string ssn, EmployeePayTypeEnum payType) {
        Name = name;
        Age = age;
        Id = id;
        Pay = pay;
        SocialSecurityNumber = ssn;
        PayType = payType;
    }

}
