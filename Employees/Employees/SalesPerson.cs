
namespace Employees;
internal class SalesPerson : Employee {
    public int SalesNumber { get; set; }

    public SalesPerson() {
    }

    public SalesPerson(string name, int age, int id, float pay, string ssn, int numbOfSales) : base(name, age, id, pay, ssn, EmployeePayTypeEnum.Commision) {
        SalesNumber = numbOfSales;
    }
}
