using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace BidOneCodingTest.Models
{
  
    public class PersonViewModel
    {
        
        [Required(ErrorMessage = "First Name is required.")]
        [DataType(DataType.Text)]
        [StringLength(50,MinimumLength =1)]
        [RegularExpression("[A-Za-z ]*", ErrorMessage = "Only Characters allowed")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required.")]
        [DataType(DataType.Text)]
        [StringLength(50, MinimumLength = 1)]
        [RegularExpression("[A-Za-z ]*", ErrorMessage = "Only Characters allowed")]
        public string LastName { get; set; }

        public string SubmitMessage { get; set; }

        public PersonViewModel()
        {
        }
            public PersonViewModel(string fname,string lname)
        {
            this.FirstName = fname;
            this.LastName = lname;
        }
       
    }
   
}
