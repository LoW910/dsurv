using System.ComponentModel.DataAnnotations;

namespace DojoSurvey.Models
{
    public class Survey
    {
        [Required]
        [MinLength(3)]
        public string Name {get;set;}
        [Required]
        public string Location {get;set;}
        [Required]
        public string Language {get;set;}

        public string Comment {get;set;}
    }
}