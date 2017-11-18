using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstNeuralNetwork
{
    class Tester
    {
        private static double[][][] xorSet = new double[][][]
            {
                new double[][]
                {
                    new double[] { 0,0 },
                    new double[] { 0 }
                },
                new double[][]
                {
                    new double[] { 0, 1 },
                    new double[] { 1 }
                },
                new double[][]
                {
                    new double[] { 1, 0 },
                    new double[] { 1 }
                },
                new double[][]
                {
                    new double[] { 1, 1 },
                    new double[] { 0 }
                }
            };

        private static double[][][] countSet = new double[][][]
        {
            new double[][]
            {
                intToBinDouble(0, 3),
                intToBinDouble(1, 3)
            },
            new double[][]
            {
                intToBinDouble(1, 3),
                intToBinDouble(2, 3)
            },
            new double[][]
            {
                intToBinDouble(2, 3),
                intToBinDouble(3, 3)
            },
            new double[][]
            {
                intToBinDouble(3, 3),
                intToBinDouble(4, 3)
            },
            new double[][]
            {
                intToBinDouble(4, 3),
                intToBinDouble(5, 3)
            },
            new double[][]
            {
                intToBinDouble(5, 3),
                intToBinDouble(6, 3)
            },
            new double[][]
            {
                intToBinDouble(6, 3),
                intToBinDouble(7, 3)
            },
            new double[][]
            {
                intToBinDouble(7, 3),
                intToBinDouble(0, 3)
            }
        };

        private static double[][][] evenSet = new double[][][]
        {
            new double[][]
            {
                intToBinDouble(0, 3),
                intToBinDouble(2, 2)
            },
            new double[][]
            {
                intToBinDouble(1, 3),
                intToBinDouble(1, 2)
            },
            new double[][]
            {
                intToBinDouble(2, 3),
                intToBinDouble(2, 2)
            },
            new double[][]
            {
                intToBinDouble(3, 3),
                intToBinDouble(1, 2)
            },
            new double[][]
            {
                intToBinDouble(4, 3),
                intToBinDouble(2, 2)
            },
            new double[][]
            {
                intToBinDouble(5, 3),
                intToBinDouble(1, 2)
            },
            new double[][]
            {
                intToBinDouble(6, 3),
                intToBinDouble(2, 2)
            },
            new double[][]
            {
                intToBinDouble(7, 3),
                intToBinDouble(1, 2)
            }
        };

        private static double[][][] trainSet;

        public static void Main(String[] args)
        {
            ArrayNeuralNetwork network = new ArrayNeuralNetwork(3, 6, 3);
            trainSet = countSet;

            Console.WriteLine("Press enter to start training...");
            Console.ReadLine();
            Console.WriteLine("Starting the training.");
            for(int x = 0; x < 100; x++)
            {
                logSquaredError(network, trainSet, x);

                for(int y = 0; y < 10000; y++)
                {
                    for(int z = 0; z < trainSet.Length; z++)
                    {
                        network.train(trainSet[z][0], trainSet[z][1]);
                    }
                }
            }

            Console.WriteLine("Stopped the Training.");

            for(int i = 0; i < trainSet.Length; i++)
            {
                Console.WriteLine(String.Format("Test number {0}: {1}", i, doubleArrayToString(network.process(trainSet[i][0]))));
            }

            Console.WriteLine("Press enter to start time testing of pass forward.");
            Console.ReadLine();

            for(int i = 0; i < 1000; i++)
            {
                for(int j = 0; j < 1000; j++)
                {
                    network.process(trainSet[0][0]);
                }
            }

            Console.WriteLine("Finished Testing the pass forward");
            Console.ReadLine();
        }

        private static String doubleArrayToString(double[] values)
        {
            String s = "";
            for(int i = 0; i < values.Length; i++)
            {
                s += String.Format("{0:N3}", values[i]) + " ";
            }
            return s;
        }

        public static void logSquaredError(ArrayNeuralNetwork network, double[][][] testSet, int reportId)
        {
            Console.WriteLine("Performance Report ---------- " + reportId);

            double error = 0;
            for(int i = 0; i < testSet.Length; i++)
            {
                double[] results = network.process(testSet[i][0]);
                bool success = true;
                for(int j = 0; j < results.Length; j++)
                {
                    if(Math.Abs(results[j] - testSet[i][1][j]) > 0.5)
                    {
                        success = false;
                    }
                    error += Math.Pow(results[j] - testSet[i][1][j], 2);
                }
                Console.WriteLine(String.Format("--- Test number {0} resulted in {1}", i, success));
            }

            Console.WriteLine(String.Format("The combined squared error is {0}.", error));
        }

        private static double[] intToBinDouble(int number, int bits)
        {
            double[] result = new double[bits];

            for(int i = 0; i < result.Length; i++)
            {
                result[i] = (number >> (result.Length - i - 1)) & 1;
            }
            return result;
        }
    }
}
