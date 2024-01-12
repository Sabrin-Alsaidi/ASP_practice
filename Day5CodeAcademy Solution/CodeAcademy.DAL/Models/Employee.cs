using System;
using System.ComponentModel.DataAnnotations;

namespace CodeAcademy.DAL.Models
{
	public class Employee
	{
		public int Id { get; set; }
		[Required(ErrorMessage ="Employees Name is Required")]
		[MaxLength(50)]
		public string Name { get; set; }
		[Required(ErrorMessage ="Employee City is Required")]
        public string city { get; set; }
		[DataType(DataType.EmailAddress)]
        public string Email { get; set; }
		[Range(18,55)]
		public int Age { get; set; }
		[DataType(DataType.Currency)]
		public double Salary { get; set; }
	}
}

