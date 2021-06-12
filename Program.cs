using System;
using Employees;

SalesPerson fred = new SalesPerson { Age = 31, Name = "Fred", SalesNumber = 50 };

fred.DisplayStats();
Console.WriteLine(fred.SalesNumber);

Console.WriteLine("**********");


Manager chucky = new Manager("Chucky", 50, 92, 100000, "333-23-2322", 9000);

chucky.DisplayStats();
Console.WriteLine(chucky.StockOptions);

Console.WriteLine(chucky.Benefits.ComputePayDeduction());