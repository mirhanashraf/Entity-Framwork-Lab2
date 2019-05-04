using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Lab2.Models
{
    public class UserActivities
    {
        [Key]
        [ForeignKey("User")]
        public int Act_Id { get; set; }
        public string Name { get; set; }
        public User User { get; set; }
    }
}
