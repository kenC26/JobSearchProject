using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearchProject.Shared.Domain
{
    public class ApplicantDetail : BaseDomainModel
    {
        
        public string Name { get; set; }
        public DateTime TimeUpload { get; set; }
        public int? job_infoId { get; set; }
        public virtual job_info Job_info { get; set; }


    }
}