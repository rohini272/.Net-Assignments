public abstract class Employee
{
	protected decimal basic;
	public abstract decimal Basic
	{
		get;
		set;
	}
	public Employee(string Name="noname", short DeptNo=10, decimal Basic=1000)
	{
		this.Name = Name;
		this.DeptNo = DeptNo;
		this.Basic = Basic;
	}
}

public class Manager : Employee
{
	public override decimal Basic
	{
		get{}
		set{}
	}
	public Manager(string Name="noname", short DeptNo=10,
 decimal Basic=1000, string Designation="GM") : base(Name, DeptNo, Basic)
	{
		this.Designation = Designation;
		
	}
}

public class GeneralManager : Manager
{
	public override decimal Basic
	{
		get{}
		set{}
	}
	public GeneralManager(string Name="noname", short DeptNo=10,
 decimal Basic=1000, string Designation="GM", string Perks="none") 
: base(Name, DeptNo, Basic, Designation)
	{
		this.Perks = Perks;
		
	}
}
