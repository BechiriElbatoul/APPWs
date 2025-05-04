using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPWs.Model
{
    public class ModeleTexte
    {
        private string texte;

        public void SetTexte(string input)
        {
            texte = input;
        }

        public string ConvertirEnMajuscules()
        {
            char[] resultat = new char[texte.Length];
            for (int i = 0; i < texte.Length; i++)
            {
                char c = texte[i];
                resultat[i] = char.IsLower(c) ? char.ToUpper(c) : c;
            }
            return new string(resultat);
        }
    }
}
