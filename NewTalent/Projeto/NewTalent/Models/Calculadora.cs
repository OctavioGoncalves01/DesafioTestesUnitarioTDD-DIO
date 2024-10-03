using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewTalent.Models
{
    public class Calculadora
    {

        private List<string> listaHistoricoContas;
        public Calculadora(){
            listaHistoricoContas = new List<string>();
        }

        public int Somar(int valor1, int valor2){
            int resultado = valor1 + valor2;
            listaHistoricoContas.Insert(0, "Res: " + resultado);
            return resultado;
        }

        public int Subtrair(int valor1, int valor2){
            int resultado = valor1 - valor2;
            listaHistoricoContas.Insert(0, "Res: " + resultado);
            return resultado;
        }

        public int Multiplicar(int valor1, int valor2){
            int resultado = valor1 * valor2;
            listaHistoricoContas.Insert(0, "Res: " + resultado);
            return resultado;
        }

        public int Dividir(int valor1, int valor2){
            int resultado = valor1 / valor2;
            listaHistoricoContas.Insert(0, "Res: " + resultado);
            return resultado;
        }

        public List<string> Historico(){
            // return new List<string>();
            listaHistoricoContas.RemoveRange(3, listaHistoricoContas.Count - 3);
            return listaHistoricoContas;
        }
    }
}