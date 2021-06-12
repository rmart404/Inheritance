namespace Employees
{
  sealed class PtSalesPerson : SalesPerson
  {
    public int WorkHours { get; set; }
    public PtSalesPerson(string fullName, int age, int empId,
        float currPay, string ssn, int numbOfSales, int workHours)
        : base(fullName, age, empId, currPay, ssn, numbOfSales)
    {
      WorkHours = workHours;
    }

  }
}