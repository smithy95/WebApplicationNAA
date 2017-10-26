using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAA.Data
{
    [MetadataType(typeof(Profile.MetaData))]
    public partial class Profile
    {

        internal class MetaData
        {

            [DisplayName("Applicant Name")]
            public string ApplicantName { get; set; }

            [DisplayName("Applicant Address")]
            public string ApplicantAddress { get; set; }
        }
    }
}
