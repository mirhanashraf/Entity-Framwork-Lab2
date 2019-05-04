using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Lab2.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int FK_CountryId { get; set; }
        public Country Country { get; set; }
        public List<User> Users { get; set; }
        public Book Book { get; set; }
    }
}
