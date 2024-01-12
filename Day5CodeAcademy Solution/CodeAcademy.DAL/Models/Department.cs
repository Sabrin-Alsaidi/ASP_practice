using System;
using System.ComponentModel.DataAnnotations;

namespace CodeAcademy.DAL.Models
{
	public class Department
	{
		[Key]
		public int Code { get; set; }
		[Required(ErrorMessage ="Name is Required")]
		[MaxLength(50)]
		public string Name { get; set; }
		public DateTime CreatedDate { get; set; }
	}
}

