using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstNeuralNetwork
{
    class Layer
    {
        private Neuron[] neurons;

        public Layer(int no_neurons)
        {
            neurons = new Neuron[no_neurons];
            for(int i = 0; i < no_neurons; i++)
            {
                neurons[i] = new Neuron();
            }
        }

        public Layer(Layer previous, int no_neurons) : this(no_neurons)
        {
            foreach(Neuron terminal in neurons)
            {
                foreach (Neuron hillock in previous.neurons)
                {
                    new Axon(hillock, terminal);
                }
            }
        }

        public void setValues(decimal[] values)
        {
            if(neurons.Length != values.Length)
            {
                throw new ArgumentException("Invalid value size");
            }

            for(int i = 0; i < values.Length; i++)
            {
                neurons[i].value = values[i];
            }
        }

        public decimal[] getValues()
        {
            decimal[] values = new decimal[neurons.Length];

            for(int i = 0; i < neurons.Length; i++)
            {
                values[i] = neurons[i].value;
            }

            return values;
        }

        public void processInput()
        {
            foreach(Neuron n in neurons)
            {
                n.calculateSum();
            }
        }

        public void flushOutput()
        {
            foreach(Neuron n in neurons)
            {
                n.fireToAxon();
            }
        }

        public int neuronCount()
        {
            return neurons.Length;
        }
    }
}
