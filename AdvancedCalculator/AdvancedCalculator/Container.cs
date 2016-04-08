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
        public UnityContainer unityContainer;
        public int firstExpression;
        public int secondExpression;
        public string mathOperator;
        public Container(Queue<string> userInput)
        {
            unityContainer = new UnityContainer();
            firstExpression = int.Parse(userInput.Dequeue());
            mathOperator = userInput.Dequeue();
            secondExpression = int.Parse(userInput.Dequeue());
            RegisterTypes();
        }
        public void RegisterTypes()
        {
            unityContainer.RegisterType<IAdder, Adder>();
            unityContainer.RegisterType<ISubtractor, Subtractor>();
            unityContainer.RegisterType<IMultiplier, Multiplier>();
            unityContainer.RegisterType<IDivider, Divider>();
            unityContainer.RegisterType<IExponenter, Exponenter>();
        }
        public delegate void MathOperatorEventHandler(object source, EventArgs args);
        public event MathOperatorEventHandler OperatorAssigned;
        public virtual void OnOperatorAssigned()
        {
            if (OperatorAssigned != null)
            {
                OperatorAssigned(this.mathOperator, EventArgs.Empty);
            }
        }
        public void SelectOperation()
        {
            switch (mathOperator)
            {
                case "+":
                    Adder adder = new Adder();
                    adder.First = firstExpression;
                    adder.Second = secondExpression;
                    unityContainer.RegisterInstance(adder);
                    break;
                case "-":
                    Subtractor subtractor = new Subtractor();
                    subtractor.First = firstExpression;
                    subtractor.Second = secondExpression;
                    unityContainer.RegisterInstance(subtractor);
                    break;
                case "/":
                    Divider divider = new Divider();
                    divider.First = firstExpression;
                    divider.Second = secondExpression;
                    unityContainer.RegisterInstance(divider);
                    break;
                case "*":
                    Multiplier multiplier = new Multiplier();
                    multiplier.First = firstExpression;
                    multiplier.Second = secondExpression;
                    unityContainer.RegisterInstance(multiplier);
                    break;
                case "^":
                    Exponenter exponenter = new Exponenter();
                    exponenter.First = firstExpression;
                    exponenter.Second = secondExpression;
                    unityContainer.RegisterInstance(exponenter);
                    break;
                default:
                    break;
            }
        }
    }
}
