using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class CarroEletrico : Carro 
    {
        public int Bateria;
        public int TempoDeCarga;

        public override void MostrarInformacoes()
        {
            Console.WriteLine("Modelo: " + Modelo);
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Quilometragem: " + Quilometragem);
            Console.WriteLine("Bateria: " + Bateria);
            Console.WriteLine("Tempo de carga: " + TempoDeCarga);

        }
        //Um metodo com mesmo nome pode fazer coisas diferentes 
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
