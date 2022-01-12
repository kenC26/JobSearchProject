using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearchProject.Shared.Domain
{
    public class Company_info : BaseDomainModel
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public string Mission { get; set; }
        public string Contact { get; set; }

    }
}
