using PanelaTI.AbstractFactory.Entitites;
using PanelaTI.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanelaTI.AbstractFactory.Factories
{
    public class BrazilGasFactory : IOilGasFactory
    {
        public IBlock BuildBlock()
        {
            BrazilBlock brazilBlock = new BrazilBlock();

            return brazilBlock;
        }

        public IWell BuildWell()
        {
            BrazilWell brazilWell = new BrazilWell();

            return brazilWell;
        }
    }
}
