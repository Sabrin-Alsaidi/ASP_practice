using System;
using System.ComponentModel.DataAnnotations;

namespace day3_FullToDoList.Models
{
	public class ToDoList
	{
		public int id { get; set; }
		[Required(ErrorMessage ="There is no tasks to do ") ]
		public string task { get; set; }
		public string? Description { get; set; }
		public bool isFinished { get; set; }
		public DateTime DueDate { get; set; }

	}
}

