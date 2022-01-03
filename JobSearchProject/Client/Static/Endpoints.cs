using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearchProject.Client.Static
{
    public static class Endpoints
    {
        private static readonly string Prefix = "api";

        public static readonly string Job_infosEndpoint = $"{Prefix}/job_infos";
        public static readonly string Job_locationsEndpoint = $"{Prefix}/job_locations";
        public static readonly string Job_CategorysEndpoint = $"{Prefix}/job_Categorys";
        public static readonly string Applicant_infosEndpoint = $"{Prefix}/applicant_infos";
        public static readonly string ApplicantDetailsEndpoint = $"{Prefix}/ApplicantDetails";
        public static readonly string Company_infosEndpoint = $"{Prefix}/Company_infos";
    }
}
