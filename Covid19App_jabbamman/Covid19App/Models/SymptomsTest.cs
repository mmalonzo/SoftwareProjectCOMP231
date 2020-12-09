using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Covid19App.Models
{
    public class SymptomsTest
    {

    [Key]
        public int Id { get; set; }
        [Display (Name = "Client Name")]
        public string Name { get; set; }
        
        public string DOB { get; set; }
        
        public string Address { get; set; }
        
        public bool Feverorchills { get; set; }
        public bool Difficultybreathings { get; set; }
        public bool Cough { get; set; }
        public bool Sorethroat { get; set; }
        public bool Runnynose { get; set; }
        public bool Lossofsmell { get; set; }
        public bool Nausea { get; set; }
        public bool Tiredness { get; set; }

        public bool Travelled { get; set; }
        public bool ContactCovidCases { get; set; }

        public string TestDate { get; set; } 
        public string Result { get; set; }

        public enum Answers
        {
            Yes,
            No
        }

        

    }
}
