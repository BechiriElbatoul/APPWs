using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using APPWs.Model;

namespace APPWs.ViewModel
{
    public class ViewModel
    {
        private readonly ModeleTexte modele;

        public ViewModel()
        {
            modele = new ModeleTexte();
        }

        public string Convertir(string texte)
        {
            modele.SetTexte(texte);
            return modele.ConvertirEnMajuscules();
        }
    }
}
