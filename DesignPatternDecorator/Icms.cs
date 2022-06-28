using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class Icms : Imposto
    {
        public Icms(Imposto outroImposto) : base(outroImposto)
        {
        }
        public Icms() : base()
        {
        }

        public override double Calcula(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.05) + 50 + CalculoDoOutroImposto(orcamento);
        }
    }
}
