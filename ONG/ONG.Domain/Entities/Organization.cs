using Domain.Seedwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONG.Domain.Entities
{
    public class Organization : BaseEntity
    {
        public string CNPJ { get; set; }
        public string Name { get; set; }
        public string Acting { get; set; }
    }
}
