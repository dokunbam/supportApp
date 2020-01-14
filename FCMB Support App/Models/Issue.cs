using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FCMB_Support_App.Models
{
    [Table("Issue")]
    public class Issue
    {
        [Key]
        public int IssueId { get; set; }
        [Required]
        public string IssueName { get; set; }
        [Required]
        public string Resolution { get; set; }
    }
}
