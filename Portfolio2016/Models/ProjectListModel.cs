using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Portfolio2016.Models
{
    public class ProjectListModel
    {   [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectID { get; set; }
        [Display(Name ="Project Name")]
        public string ProjectName { get; set; }
        [Display(Name ="I used:")]
        public string ProjectMaterials { get; set; }
        [Display(Name ="Description")]
        public string ProjectDescription { get; set; }
        [Display(Name ="Screenshot")]
        public string ProjectImage { get; set; }
        [Display(Name ="Mobile Screenshot")]
        public string ProjectSmlImage { get; set; }
        [Display(Name ="Github Repo")]
        public string ProjectRepo { get; set; }
        [Display(Name ="Click here")]
        public string ProjectURL { get; set; }

    }
}