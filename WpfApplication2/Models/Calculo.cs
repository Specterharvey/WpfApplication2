using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2.Models
{
    public class Calculo
    {
        public string Calcular(string nome)
        {
            string a;
            a = nome.Length.ToString();
            return a;
        }
        #region ReverterNome
        //public string Reverter(string nome)
        //{
        //    char[] array = nome.ToCharArray();
        //    Array.Reverse(array);
        //    return new string(array);
        //}
        #endregion


    }
}
