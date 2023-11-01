using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTalent
{
    public class Calculadora
    {
        private List<string> listaHistorico;
        private string data;

        public Calculadora(string data) 
        {
            listaHistorico = new List<string>();
            this.data = data;
        }

        public int Somar(int Val1, int Val2)
        {
            listaHistorico.Insert(0, "Res: " + Val1 + Val2 + " - data: " + data);
            return Val1 + Val2;
        }

        public int Subtrair(int Val1, int Val2) 
        {
            listaHistorico.Insert(0, "Res: " + (Val1 - Val2) + " - data: " + data);
            return Val1 - Val2;
        }

        public int Multiplicar(int Val1, int Val2)
        {
            listaHistorico.Insert(0, "Res: " + Val1 * Val2 + " - data: " + data);
            return Val1 * Val2;
        }

        public int Dividir(int Val1, int Val2)
        {
            listaHistorico.Insert(0, "Res: " + Val1 / Val2 + " - data: " + data );
            return Val1 / Val2;
        }

        public List<string> Historico()
        {            
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
            return listaHistorico;
        }
    }
}
