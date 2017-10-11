using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SuggestionBox.Models
{
    public class SuggestionModel
    {

        [Key]
        public int RecordNum { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }

    
}