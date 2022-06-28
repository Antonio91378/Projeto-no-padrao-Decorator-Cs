using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class program
    {
        //Este é um exemplo do padrao de projeto 'Decorator'
        //O que define esse Design Pattern é a sedimentação de comportamentos,
        //As classes filhas agora seguem uma classe abstrata, que admite o
        //acúmulo de comportamentos.
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
