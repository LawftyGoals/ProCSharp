namespace Employees; 
sealed class PtSalesPerson: SalesPerson {
    public PtSalesPerson(string name, int age, int empId, float currPay, string ssn, int numbOfSales) : base(name, age, empId, currPay, ssn, numbOfSales)
    {
        
    }
}
