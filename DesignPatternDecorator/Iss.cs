using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class Iss : Imposto
    {
        public Iss(Imposto outroImposto) : base(outroImposto)
        {
        }
        public Iss() : base()
        {
        }

        public override double Calcula(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.06) + 50 + CalculoDoOutroImposto(orcamento);
        }



    }
}
