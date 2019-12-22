using System;
 
namespace Sample
{
	class Employee
	{
		String FirstName,LastName,MiddleName;
		DateTime? DateOfBirth=null;

		public Employee(String FirstName,String LastName,String MiddleName,DateTime? DateOfBirth)
		{
			this.FirstName=FirstName;
			this.LastName=LastName;
			this.MiddleName=MiddleName;
			this.DateOfBirth=DateOfBirth;
		}

		public String getFirstName(){return this.FirstName;}
		public String getLastName(){return this.LastName;}
		public String getMiddleName()
		{
			if(string.IsNullOrEmpty(this.MiddleName))
				return "---";
			return this.MiddleName;
		}
		public String getDateOfBirth()
		{
			if(this.DateOfBirth.HasValue)
				return this.DateOfBirth.ToString();
			return "Not Provided by User...";
		}

		public String toString()
		{
			return ("Employee First Name: "+this.getFirstName()+"\nEmployee Last Name: "+this.getLastName()+"\nEmployee Middle Name: "+this.getMiddleName()+"\nEmployee Date Of Birth: "+this.getDateOfBirth());
		}


		public static void Main(string[] args)
		{

			Console.Write("Enter First Name ");
			String FirstName = Console.ReadLine();

			Console.Write("Enter Last Name ");
			String LastName=Console.ReadLine();

			Console.Write("Enter Middle Name ");
			String MiddleName=Console.ReadLine();

			Console.Write("Need DateOfBirth: ");
			String token=Console.ReadLine();

			DateTime? DateOfBirth=null;

			if(token=="yes"||token=="YES")
			{

			Console.Write("Enter Date of birth ");
			int Date=Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter Month of birth ");
			int Month=Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter Year of birth ");
			int Year=Convert.ToInt32(Console.ReadLine());

			DateOfBirth=new DateTime(Year,Month,Date);
			}

			Employee emp=new Employee(FirstName,LastName,MiddleName,DateOfBirth);

			Console.Write(emp.toString());
		}
	}
}
