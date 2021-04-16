using System;
using System.Collections.Generic;
using System.Text;

namespace IsValidSequence
{
    public static class IsValidDnaSequenceExtensionMethod
    {
        public static int ValidateDnaSequence(this String dna)
        {
            for(int i = 0; i<dna.Length; i++)
            {
                if (!dna[i].Equals('A') || !dna[i].Equals('C') || !dna[i].Equals('G') || !dna[i].Equals('T'))
                    throw new InvalidOperationException("The DNA MUST conatain JUST characters A, C, D, T!!!!");
            }
            
            return dna.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
