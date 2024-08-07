namespace Employees;
internal class Manager : Employee {
    public int StockOptions { get; set; }

    public Manager() {
    }
    public Manager(string name, int age, int id, float pay, string ssn, int numberOfOptions) : base(name, age, id, pay, ssn, EmployeePayTypeEnum.Salaried) {
        StockOptions = numberOfOptions;
    }

    public override void GiveBonus(float amount) {
        base.GiveBonus(amount);
        Random r = new();
        StockOptions -= r.Next(10);
    }

    public override void DisplayStats() {
        base.DisplayStats();
        Console.WriteLine($"Stock Options: {StockOptions}");
    }

}
