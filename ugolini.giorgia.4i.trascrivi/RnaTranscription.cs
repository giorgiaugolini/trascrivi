using System;
using System.Collections.Generic;
using System.Text;

public static class TrascrizioneRNA
{
    public static string ToRna(string dna)
    {
        var rna = string.Empty;
        var let = dna.ToCharArray();
            for (int i = 0; i < let.Length; i++)
                {
                    switch (let[i])
                    {
                        case 'G':
                            rna += 'C';
                            break;
                        case 'C':
                            rna += 'G';
                            break;
                        case 'T':
                            rna += 'A';
                            break;
                        case 'A':
                            rna += 'U';
                            break;
                    }
                }
                return rna;
    }
}