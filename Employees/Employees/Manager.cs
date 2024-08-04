namespace Employees;
internal class Manager : Employee {
    public int StockOptions { get; set; }

    public Manager() {
    }
    public Manager(string name, int age, int id, float pay, string ssn, int numberOfOptions) : base(name, age, id, pay, ssn, EmployeePayTypeEnum.Salaried) {
        StockOptions = numberOfOptions;
    }
}
