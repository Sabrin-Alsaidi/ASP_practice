using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FullToDoWebsite.Models
{
	public class ToDoTasks
	{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Task_id { get; set; }
        [Required (ErrorMessage ="Task is required, please enter your task")]
        public string? Task_todo { get; set; }
        public string? Task_description { get; set; }
        public DateTime Task_DueDate { get; set; }
        public bool Task_Status { get; set; }

    }
}

