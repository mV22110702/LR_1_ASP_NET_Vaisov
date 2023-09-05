using System;

public class Company
{
	public string Name { get; set; }
	public string TaxNumber {  get; set; }
	public int EmployeeCount { get; set; }
	public Company(string name = "", string taxNumber = "", int employeeCount = 0)
	{
		this.Name = name;
		this.TaxNumber = taxNumber;
		this.EmployeeCount = employeeCount;
	}
}
