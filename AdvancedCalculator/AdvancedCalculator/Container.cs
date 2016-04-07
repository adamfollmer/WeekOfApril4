using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace AdvancedCalculator
{
    public class Container
    {
        UnityContainer container;
        public Container()
        {
            container = new UnityContainer();
            container.RegisterType<IAdder, Adder>();
            container.RegisterType<ISubtractor, Subtractor>();
            container.RegisterType<IMultiplier, Multiplier>();
            container.RegisterType<IDivider, Divider>();
            container.RegisterType<IExponenter, Exponenter>();
        }
        public void RegisterTypes()
        {
        }
    }
}
