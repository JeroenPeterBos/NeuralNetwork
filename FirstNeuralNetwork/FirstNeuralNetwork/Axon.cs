using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstNeuralNetwork
{
    class Axon
    {
        private static Random random = new Random();

        private Neuron hillockNeuron;
        private Neuron terminalNeuron;

        private decimal weight;
        private decimal value;

        public Axon(Neuron hillock, Neuron terminal)
        {
            hillock.terminalAxons.Add(this);
            terminal.hillockAxons.Add(this);

            weight = (decimal)random.NextDouble() * 4 - 2;
        }

        public void calculateValue(decimal inputValue)
        {
            Console.WriteLine("Calulating for axon with inputValue " + inputValue + " and weight " + weight);

            value = inputValue * weight;

            Console.WriteLine("Set value to " + value);
        }

        public decimal Value()
        {
            return value;
        }
    }
}
