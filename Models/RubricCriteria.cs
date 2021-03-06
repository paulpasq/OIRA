
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace parser.Models
{

    // TODO: finish XML comments
    /// <summary>
    /// 
    /// </summary>    
    public class RubricCriteria
    {
        public int Id { get; set; }

        public virtual Rubric Rubric { get; set; }
        public string RubricId { get; set; }


        // TODO: this can be further normalized
        public string Name { get; set; }

        [Display(Name = "Score of 4")]
        public string Desciption4 { get; set; }

        [Display(Name = "Score of 3")]
        public string Desciption3 { get; set; }

        [Display(Name = "Score of 2")]
        public string Desciption2 { get; set; }

        [Display(Name = "Score of 1")]
        public string Desciption1 { get; set; }

        [Display(Name = "Score of 0")]
        public string Desciption0 { get; set; }


        public virtual ICollection<Score> Scores { get; set; }
    }

}