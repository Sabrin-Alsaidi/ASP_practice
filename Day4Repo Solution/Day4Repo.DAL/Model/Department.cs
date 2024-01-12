using System;
using System.ComponentModel.DataAnnotations;

namespace Day4Repo.DAL.Model
{
	public class Department
	{
		public int Id { get; set; }
		[Required (ErrorMessage ="Code is Required for the Department")]
		public string Code { get; set; }
        [Required(ErrorMessage = "Name is Required for the Department")]
		[MaxLength(50)]
        public string Name { get; set; }
		public DateTime CreatedAt { get; set; }
	}
}

