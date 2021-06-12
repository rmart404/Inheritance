using System;

namespace Employees
{
  partial class Employee
  {
    // Properties!
    private string _empName;
    public string Name
    {
      get => _empName;
      set
      {
        if (value.Length > 15)
        {
          Console.WriteLine("Error! Name length exceeds 15 characters!");
        }
        else
        {
          _empName = value;
        }
      }
    }

    // We could add additional business rules to the sets of these properties;
    // however, there is no need to do so for this example.
    public int Id { get; set; }
    public float Pay { get; set; }
    public int Age { get; set; }
    public EmployeePayTypeEnum PayType { get; set; }

    //public string SocialSecurityNumber => _empSSN;
    private string _empSSN;
    public string SocialSecurityNumber
    {
      get => _empSSN;
      private set => _empSSN = value;
    }

    public BenefitPackage EmpBenefits = new BenefitPackage();
    public BenefitPackage Benefits
    {
      get => EmpBenefits;
      set => EmpBenefits = value;
    }


  }
}