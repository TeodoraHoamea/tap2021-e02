using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using RepositoryPattern;

namespace Sample
{
    public class Sample 
    {
        public Guid Id { get; private set; }
        public string DnaSequence { get; private set; }
        public DateTime AnalysisTime { get; private set; }
    }
}
