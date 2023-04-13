 using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
// useing dataannotation to validate the data
using System.ComponentModel.DataAnnotations;


namespace TodoAPI.Models
{
    public class TodoItem
    {
        [Required]
        [Range(1,100)]

        public long Id { get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; }
       
    }
}
