using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Carro
    {
        public string Modelo;
        public string Marca;
        public string Quilometragem;
        public virtual void MostrarInformacoes()
        {
            Console.WriteLine("Modelo" + Modelo);
        }
    public void MostrarInformacoes(string nome)
        {
            Console.WriteLine("Modelo: " + Modelo);
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Quilometragem: " + Quilometragem);
            Console.WriteLine("Bateria: " + Bateria);
            Console.WriteLine("Tempo de carga: " + TempoDeCarga);
        }

    }
}
