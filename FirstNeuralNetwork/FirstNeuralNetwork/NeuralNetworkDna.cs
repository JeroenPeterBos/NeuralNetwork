using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstNeuralNetwork
{
    class NeuralNetworkDna
    {
        private static Random random = new Random();

        private int layerCount;
        private int[] neuronCount;
        private int inputCount;

        public NeuralNetworkDna(int inputNeurons, int outputNeurons, int minLayerCount, int maxLayerCount)
        {
            layerCount = random.Next(0, 3);
            neuronCount = new int[layerCount + 1];
            inputCount = inputNeurons;

            for(int i = 0; i < layerCount - 1; i++)
            {
                neuronCount[i] = random.Next(1, Math.Max(inputNeurons, outputNeurons) * 4);
            }

            neuronCount[layerCount - 1] = outputNeurons;
        }

        public NeuralNetworkDna(NeuralNetworkDna parent1, NeuralNetworkDna parent2)
        {
            if(random.NextDouble() > 0.5)
            {
                layerCount = parent1.layerCount;
            } else
            {
                layerCount = parent2.layerCount;
            }
            if(random.NextDouble() > 0.99)
            {
                layerCount++;
            } else if(random.NextDouble() > 0.01 && layerCount > 0)
            {
                layerCount--;
            }


        }
    }
}
