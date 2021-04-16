﻿using System;
using IsValidSequence;

namespace SolutionExam2
{
    class Program
    {
        static void Main(string[] args)
        {
            String dna = "AGCCCATCGTGGTCCTTAGACTTCGTACACTTACACCTGCACCGCGCGCATGTGGAATTAGAGGCGAAGTACGATCCCTAGACCGACGTACGATGCAACTGTGTGGATGTGACGAGCTTCTTTTATATGCTTCGCCCGCCGGACCGGCCTCGGCATGGCGTAGCAGTGCACAAGCAAATGACAATTAACCACCGTGTATTCGTTATAACATCAGGCAGTTTAAGTCGGGACAATAGGAGCCGCAATACACAGTTTACCGCATCTTGACCTAACTGACATACTGCCATGGACGACTAGCCATGCCACTGGCTCTTAGATAGCCCGATACAGTGATTATGAAAGGTTTGCGGGGCATAGCTACGACTTGCTTAGCTACGTGCGAGGGAAGAAACTTTTGCGTATTTGTATGTTCACCCGTCTACTACCCATGCCCGGAGATTATGTAGGTTGTGAGATGCGGGAGAAGTTCTCGACCTTCCCGTGGGACGTCAACCTATCCCTTAATAGAGCATTCCGTTCGGGCATGGCAGTAAGTACGCCTTCTCAATTGTGCTAACCTTCATCCTTATCAAAGCTTGGAGCCAATGATCAGGATTATTGCCTTGCGACAGACTTCCTACTCACAGTCGCTCACATTGAGCTACTCGATGGGTCATCAGCTTGACCCGGTCTGTTGGGCCGCGATTACGTGAGTTAGGGCTCCGGACTGCGCTGTATAGTCGAATCTGATCCGGCCCCCACAACTGCAAACCCCAACTTATTTAGATAACATGATTAGCCGAAGTTGCACGGGGTGCCCACCGTGGAGTCCTCCCCGGGTGTCCCTCCTTCATTTGACGATAAGCAGCCGCTACCACCATCGATTAATACAAGGAACGGTGATGTTATCATAGATTCGGCACATTACCCTTGTAGGTGTGGAATCACTTAGCTACGCGCCGAAGTCTTATGGCAAAACCGATGGACAATGATTCGGGTAGCACTAAAAGTCCATAGCACG";
            var result = dna.ValidateDnaSequence();
            Console.WriteLine(result);
        }
    }
}
