using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstNeuralNetwork
{
    class Neuron
    {
        public decimal value { get; set; }

        public List<Axon> hillockAxons { get; set; }
        public List<Axon> terminalAxons { get; set; }

        public Neuron()
        {
            hillockAxons = new List<Axon>();
            terminalAxons = new List<Axon>();
        }

        public void calculateSum()
        {
            decimal val = 0; 
            foreach(Axon a in hillockAxons)
            {
                val += a.Value();
                Console.WriteLine("Added axon value of " + a.Value());
            }
            value = val;

            Console.WriteLine("Set the value of this neuron to " + val);
        }

        public void fireToAxon()
        {
            foreach(Axon a in terminalAxons)
            {
                a.calculateValue(value);
            }
        }
    }
}
