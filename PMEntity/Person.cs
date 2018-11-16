using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMEntity
{
    //[Table("tblPeople")]
    public class Person
    {
        //[Key][DatabaseGenerated(DatabaseGeneratedOption.None)]
        //public int Id { get; set; }
        
        //[Required][Column("PersonName", Order=3)][MaxLength(50)]
        //public string Name { get; set; }
        
        //[Required]
        //public string Email { get; set; }
       
        //public int Age { get; set; }

        //[NotMapped]
        //public bool Status { get; set; }

        public int Id { get; set; }
        
        [Required(ErrorMessage="Name cannot be empty")][MaxLength(10, ErrorMessage="Maximum 10 characters allowed")]
        public string Name { get; set; }
        
        [Required][DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        
        public int Age { get; set; }
    }
}
