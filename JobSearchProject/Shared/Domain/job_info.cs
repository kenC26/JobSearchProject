using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearchProject.Shared.Domain
{
    public class job_info : BaseDomainModel
    {
        public int? job_CategoryId { get; set; }
        public virtual job_Category job_Category { get; set; }
        public int? job_locationId { get; set; }
        public virtual job_location job_location { get; set; }
        public int? Company_infoId { get; set; }
        public virtual Company_info company_info { get; set; }
        public string job_title { get; set; }
        public string job_description { get; set; }

        public string type { get; set; }

        public string job_salary { get; set; }

        public int no_of_vacancy { get; set; }
    }
}
//public DateTime DateOut { get; set; }

//public DateTime DateIn { get; set; }

//public int VehicleId { get; set; }

//public virtual Vehicle Vehicle { get; set; }

//public int CustomerId { get; set; }

//public virtual job_info Customer { get; set; }
//public string TaxId { get; set; }
//public virtual List<applicant_info> Bookings { get; set; }