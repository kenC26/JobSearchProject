using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearchProject.Shared.Domain
{
    public class applicant_info : BaseDomainModel
    {
        //public int applicant_ID { get; set; }
        
        public string applicant_Name { get; set; }
        public string applicant_Gender { get; set; }
        public int applicant_Contact { get; set; }
        public string applicant_email{ get; set; }
        public string applicant_qualification { get; set; }
        public float applicant_salary { get; set; }
        public string applicant_username { get; set; }
        public string applicant_password { get; set; }

    }
}
