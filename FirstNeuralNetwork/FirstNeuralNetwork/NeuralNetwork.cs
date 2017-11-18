using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstNeuralNetwork
{
    class NeuralNetwork
    {
        private Layer inputLayer;
        private Layer[] hiddenLayers;
        private Layer outputLayer;

        public NeuralNetwork(int no_inputs, int no_outputs, params int[] layers)
        {
            inputLayer = new Layer(no_inputs);

            Layer prev = inputLayer;
            hiddenLayers = new Layer[layers.Length];
            for (int i = 0; i < layers.Length; i++)
            {
                hiddenLayers[i] = new Layer(prev, layers[i]);
                prev = hiddenLayers[i];
            }

            outputLayer = new Layer(prev, no_outputs);
        }

        public decimal[] process(params decimal[] inputValues)
        {
            if(inputValues.Length != inputLayer.neuronCount())
            {
                throw new ArgumentException("Number of process values does not match neuron count in input layer. NeuronCount: " + inputLayer.neuronCount() + " | inputCount: " + inputValues.Length);
            }

            Console.WriteLine("Processing inputLayer");

            inputLayer.setValues(inputValues);
            inputLayer.flushOutput();

            for(int i = 0; i < hiddenLayers.Length; i++)
            {
                Console.WriteLine("Process hiddenLayer " + i);
                hiddenLayers[i].processInput();
                hiddenLayers[i].flushOutput();
            }

            Console.WriteLine("Process outputLayer");
            outputLayer.processInput();
            return outputLayer.getValues();
        }
    }
}
