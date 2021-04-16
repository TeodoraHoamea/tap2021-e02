using System;

namespace RepositoryPattern
{
    public class SampleModel
    {
        public Guid Id { get; private set; }
        public string DnaSequence { get; private set; }
        public DateTime AnalysisTime { get; private set; }
    }
}