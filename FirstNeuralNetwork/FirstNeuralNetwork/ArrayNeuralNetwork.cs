using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstNeuralNetwork
{
    class ArrayNeuralNetwork
    {
        private static Random random = new Random();
        private List<double[,]> layers;
        private double learningRate;

        public int InputSize { get; }
        public int OutputSize { get; }


        public ArrayNeuralNetwork(int inputs, params int[] network_neurons)
        {
            if(network_neurons.Length <= 0)
            {
                throw new ArgumentException("At least an output layer must be provided.");
            }

            layers = new List<double[,]>();
            InputSize = inputs;
            
            for(int i = 0; i < network_neurons.Length; i++)
            {
                layers.Add(generateRandomWeightTable(network_neurons[i], inputs + 1)); // add 1 to inputs for bias
                inputs = network_neurons[i];
            }

            OutputSize = network_neurons[network_neurons.Length - 1];

            learningRate = 0.02;
        }

        public double[] process(double[] inputs)
        {
            if(inputs.Length != InputSize)
            {
                throw new ArgumentException("The given input did not match the amount of input neurons.");
            }

            for(int i = 0; i < layers.Count; i++)
            {
                inputs = advanceLayer(layers[i], inputs);
            }

            return inputs;
        }

        public List<double[]> processWithReport(double[] inputs)
        {
            if(inputs.Length != InputSize)
            {
                throw new ArgumentException("The given input did not match the amount of input neurons.");
            }

            List<double[]> reports = new List<double[]>();
            reports.Add(inputs);

            for(int i = 0; i < layers.Count; i++)
            {
                inputs = advanceLayer(layers[i], inputs);
                reports.Add(inputs);
            }

            return reports;
        }

        private double[] advanceLayer(double[,] weightTable, double[] inputs)
        {
            double[] outputs = new double[weightTable.GetLength(0)];

            for (int x = 0; x < weightTable.GetLength(0); x++)
            {
                double sum = 0;
                for (int y = 0; y < inputs.Length; y++)
                {
                    sum += inputs[y] * weightTable[x, y];
                }
                sum += weightTable[x, inputs.Length]; // add the bias weight to the sum

                outputs[x] = sigmoid(sum);
            }

            return outputs;
        }

        public void train(double[] inputs, double[] targets)
        {
            if(inputs.Length != InputSize)
            {
                throw new ArgumentException("Invalid amount of inputs provided.");
            }
            if(targets.Length != OutputSize)
            {
                throw new ArgumentException("Invalid amount of outputs provided.");
            }

            // Make initial prediction
            List<double[]> processedOutputs = processWithReport(inputs);
            List<double[]> reversedDeltas = new List<double[]>();

            // Calculate output deltas
            double[] outputs = processedOutputs[processedOutputs.Count - 1];
            double[] outputDeltas = new double[outputs.Length];

            for(int i = 0; i < outputs.Length; i++)
            {
                outputDeltas[i] = outputs[i] * (1 - outputs[i]) * (outputs[i] - targets[i]);
            }

            reversedDeltas.Add(outputDeltas);

            // Calculate hidden deltas
            for(int i = layers.Count -1; i > 0; i--)
            {
                double[,] outgoingWeightTable = layers[i];
                double[] layerOutputs = processedOutputs[i];
                double[] previousLayerDeltas = reversedDeltas[reversedDeltas.Count - 1];
                double[] hiddenDeltas = new double[outgoingWeightTable.GetLength(1) - 1]; // Array length: number of axons incoming to next layer (-1 for bias)
                for(int j = 0; j < hiddenDeltas.Length; j++)
                {
                    double sum = 0;
                    for(int k = 0; k < outgoingWeightTable.GetLength(0); k++)
                    {
                        sum += outgoingWeightTable[k, j] * previousLayerDeltas[k];
                    }
                    hiddenDeltas[j] = layerOutputs[j] * (1 - layerOutputs[j]) * sum;
                }
                reversedDeltas.Add(hiddenDeltas);
            }

            // Update weights
            for(int i = 0; i < layers.Count; i++)
            {
                for(int j = 0; j < layers[i].GetLength(0); j++)
                {
                    // Iterate over all axons except over those with the connection to bias.
                    for(int k = 0; k < layers[i].GetLength(1) - 1; k++)
                    {
                        layers[i][j, k] += -1 * learningRate * reversedDeltas[reversedDeltas.Count - 1 - i][j] * processedOutputs[i][k];
                    }
                    layers[i][j, layers[i].GetLength(1) - 1] += -1 * learningRate * reversedDeltas[reversedDeltas.Count - 1 - i][j];
                }
            }
        }

        public void setWeight(int layer, int axon, int neuron, double weight)
        {
            layers[layer-1][neuron,axon] = weight;
        }


        // -- helper methods -- //

        private static double[,] generateRandomWeightTable(int neurons, int axons)
        {
            double[,] weightTable = new double[neurons, axons];

            for(int i = 0; i < neurons; i++)
            {
                for(int j = 0; j < axons; j++)
                {
                    weightTable[i, j] = random.NextDouble() * 4 / 2;
                }
            }

            return weightTable;
        }

        private static double sigmoid(double x)
        {
            return 1.0 / (1.0 + Math.Pow(Math.E, -x));
        }
    }
}
