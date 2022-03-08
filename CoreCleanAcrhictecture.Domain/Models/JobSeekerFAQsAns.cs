using CoreCleanAcrhictecture.Domain.Models.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCleanAcrhictecture.Domain.Models
{
    public partial class JobSeekerFAQsAns:Table
    {
        public int Id { get; set; }
        public string JobSeekerAns { get; set; }
        [ForeignKey("FAQsQuestions")]
        public int FAQsQuestionID { get; set; }
        public virtual FAQsQuestions FAQsQuestions { get; set; }
        [ForeignKey("JobSeeker")]
        public int JobSeekerID { get; set; }
        public virtual JobSeeker JobSeeker { get; set; }
    
    }
}
