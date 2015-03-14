using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Address_Book.Models
{
    public class Record
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RecordID { get; set; }

        [Required, StringLength(100), Display(Name = "Last_Name")]
        public string LastName { get; set; }
        
        [Required, StringLength(100), Display(Name = "Name")]
        public string Name { get; set; }
        
        [Required, StringLength(100), Display(Name = "Patronymic")]
        public string Patronymic { get; set; }

        [Required, StringLength(20), Display(Name = "Phone")]
        public string Phone { get; set; }

        [Required, StringLength(300), Display(Name = "Address")]
        public string Address { get; set; }

    }
}
