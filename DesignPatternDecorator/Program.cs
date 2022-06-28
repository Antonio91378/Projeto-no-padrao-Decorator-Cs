using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class program
    {
        //Este é um exemplo do padrao de projeto 'Template Method'
        //O que define esse Design Pattern é o uso de classes abstratas, poupando maiores 
        // tralhos em manutenções futuras
        static void Main(string[] args)
        {
            Imposto iss = new Iss(new Icms());
            Orcamento orcamento = new Orcamento();

            double valor = iss.Calcula(orcamento);
            System.Console.WriteLine(valor);

        }
    }
}
