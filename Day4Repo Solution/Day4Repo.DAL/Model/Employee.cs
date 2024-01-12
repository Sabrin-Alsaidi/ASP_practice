using System;
using System.ComponentModel.DataAnnotations;

namespace Day4Repo.DAL.Model
{
	public class Employee
	{
		public int Id { get; set; }
		[Required(ErrorMessage = "Name is REquired")]
		[MaxLength(50)]
		[MinLength(5)]
		public string Name { get; set; }
		[MaxLength(50)]
		[MinLength(4)]
		public string City { get; set; }
		[EmailAddress]
		public string Email { get; set; }
		[Range(18,33)]
		public int Age { get; set; }
		[DataType(DataType.Currency)]
		public decimal Salary { get; set; }
	}
}

