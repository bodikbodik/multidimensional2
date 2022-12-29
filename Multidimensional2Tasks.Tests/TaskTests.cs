using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multidimensional2Tasks.Tests
{
    [TestFixture]
    public class TaskTests
    {
        [Test]
        public void Task1_ReturnsCorrectValue()
        {
            List<int[,]> arrays = new List<int[,]>();

            arrays.Add(new int[,] { { 1, 0, 5 },
                                    { 1, 3, 3 },
                                    { 1, 5 ,6 } });
            arrays.Add(new int[,] { { -1, 0, 3 },
                                     { 5, 9, 0 },
                                     { 4, 3, 3 } });
            arrays.Add(new int[,] { { 0, 1, 3 },
                                    { 4, 3, 3 },
                                    { 3, 5, 3 } });

            int[] valuesA = { 5, 6, 4 };

            int[] expected = { 6, 9, 5 };

            for (int i = 0; i < expected.Length; i++)
            {
                var actual = Tasks.Task1(arrays[i], valuesA[i]);
                Assert.AreEqual(expected[i], actual, "Task1 returns incorrect value.");
            }
        }

        [Test]
        public void Task2_ReturnsCorrectValue()
        {
            List<int[,]> arrays = new List<int[,]>();

            arrays.Add(new int[,] { { 1, 0, -5 },
                                    { 14, 3, 3 },
                                    { -1, 54 ,6 } });
            arrays.Add(new int[,] { { -1, 10, 3 },
                                     { 5, 19, 0 },
                                     { 24, 13, 13 } });
            arrays.Add(new int[,] { { 0, -1, 3 },
                                    { 4, 3, 7 },
                                    { 33, 5, 3 } });

            int[] expected = { -6, 9, 2 };

            for (int i = 0; i < expected.Length; i++)
            {
                var actual = Tasks.Task2(arrays[i]);
                Assert.AreEqual(expected[i], actual, "Task2 returns incorrect value.");
            }
        }

        [Test]
        public void Task3_ReturnsCorrectValue()
        {
            int[,] array1 = new int[,] { { 1, 10, 5 },
                                         { -1, 3, 3 },
                                         { 1, 5 ,6 } };

            int[,] array2 = new int[,] { { 0, 31, 3 },
                                         { 5, 33, 3 },
                                         { 13, 5, 90 } };

            int[,] array3 = new int[,] { { 1, 3, 5 },
                                         { 10, 35, 3 },
                                         { -1, 5 , 17 } };

            int[] expected1 = { 1, -1, 1 };
            int[] expected2 = { 0, 3, 5 };
            int[] expected3 = { 1, 3, -1 };

            var actual1 = Tasks.Task3(array1);
            var actual2 = Tasks.Task3(array2);
            var actual3 = Tasks.Task3(array3);

            Assert.AreEqual(expected1, actual1, "Task3 returns incorrect value.");
            Assert.AreEqual(expected2, actual2, "Task3 returns incorrect value.");
            Assert.AreEqual(expected3, actual3, "Task3 returns incorrect value.");
        }
    }
}
