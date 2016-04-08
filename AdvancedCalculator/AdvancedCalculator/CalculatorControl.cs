using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using UserInput;

namespace AdvancedCalculator
{
    //Facade
    public class CalculatorControl
    {
        Run userInput;
        Container container;
        Calculator calculator;
        public CalculatorControl()
        {
            userInput = new Run();
            container = new Container(userInput.InitiateCalculator());
            container.SelectOperation();
            calculator = container.unityContainer.Resolve<Calculator>();
            container.OperatorAssigned += calculator.OnOperatorAssigned;
            container.OnOperatorAssigned();
            calculator.DoMath();
            Console.ReadLine();
        }

    }
}
