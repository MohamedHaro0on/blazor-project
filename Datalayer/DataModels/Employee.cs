using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalayer.DataModels
{
    public class Employee
    {
        [Key]
        [Required(ErrorMessage = "enter employee Id")]
        public int emp_id { get; set; }
     

        [Required(ErrorMessage = "enter Employee Name")]
        [MinLength(4, ErrorMessage = "less than 4 charachters")]
        public string emp_name { get; set; }


        [Required(ErrorMessage = "enter Employee Name")]
        [MinLength(4, ErrorMessage = "less than 4 charachters")]
        public string emp_address { get; set; }
       


        [Required(ErrorMessage = "enter Employee Name")]
        [MinLength(4, ErrorMessage = "less than 4 charachters")]
        public string emp_photo_path { get; set; }
        
    }
}
