using System;
using System.Collections.Generic;
using System.Text;

namespace EarlyEduCare.Models
{
    public class WordAndDefinition
    {
        public string word { get; set; }
        public int score { get; set; }
        public List<string> defs { get; set; }
    }
}