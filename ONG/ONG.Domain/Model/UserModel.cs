using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class UserModel
    {
        public string Name { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string Uf { get; set; }
        public string City { get; set; }
        public string Gender { get; set; }
    }
}
