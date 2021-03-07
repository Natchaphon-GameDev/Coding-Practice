using System;
using System.Collections.Generic;
using System.Globalization;

namespace TEST_pactice
{
    public static class TestArray
    {
        public static void Array_Find_Highest_Lowest()
        {
            //Write a program to find the hightest and lowest number [without method] from this set of number 1,6,0,8,9,-2
            
            var numbers = new[] {1,6,0,8,9,-2};
            var highestNumber = numbers[0]; // to call the first position in numbers[]
            var lowestNumber = numbers[0];
            
            
            foreach (var number in numbers)
            {
                //to set the new hightest number
                if (number > highestNumber)
                { 
                    highestNumber = number;
                    Console.WriteLine($"now hight is {highestNumber}");
                }
                //to set the new lowest number
                //use "else if" to set he real one lowest number
                //cause if you use if it'll call the lowestNumber
                else if (number < lowestNumber)
                {
                    Console.WriteLine($"now low is {lowestNumber}");
                    lowestNumber = number;
                }
            }
            Console.WriteLine($"HighestNumber is {highestNumber} and Lowest is {lowestNumber}");
        }

        public static void Array_Find_EvenOdd_Number()
        {
            //Problem write a program to find even numbers from 1-10 and print it,by using for-loop
            
            var numbers = new[] {1,2,3,4,5,6,7,8,9,10};
            Console.Write("Even number is ");
            for (var i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0) //to find even of numbers
                {
                    Console.Write($"{numbers[i]} ");
                }
            }
            
            //Write a program to find odd numbers form 1-10 and print it,by using foreach loop
            
            Console.Write("\nOdd number is ");
            foreach (var number in numbers) 
            {
                if (number % 2 == 0)//to find odd of numbers
                {
                    continue;
                }
                Console.Write($"{number} ");
            }
        }

        public static void Array_Backward()
        {
            //Write a program to print numbers from 0-10 backward
            
            var numbers = new[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            Console.Write("The Numbers from 0-10 backward are ");
            for (var i = numbers.Length - 1; i >= 0; i--)
                //number.Length -1 because .Length count start at 1 but index start at 0 so .Length count are 11 but array are 10
            {
                Console.Write($" {numbers[i]}");
            }
        }

        public static void Array_Find_Average()
        {
            //Write a program to find the average amount of those number 0,-1,5,-11,4,5,-6 then print the result,by using for loop

            var numbers = new[] {0, -1, 5, -11, 4, 5, -6};
            var totalOfNumbers = 0;
            for (var i = 0 ; i < numbers.Length; i++ )
            {
                totalOfNumbers += numbers[i];
            }
            Console.WriteLine($"The Average of Numbers is {(float)totalOfNumbers/numbers.Length}");//used float because the output is decimal but totalOfNumbers is int
        }

        public static void Array_Find_Frequency_Of_1()
        {
            //Write a program to find the frequency of 1 in this set of numbers 1,2,3,1,0,6,10,1,7,1,1,8

            var numbers = new[] {1, 2, 3, 1, 0, 6, 10, 1, 7, 1, 1, 8};
            const int targetNumber = 1;
            var frequency = 0;
            for (var i = 0;i < numbers.Length;i++)
            {
                if (numbers[i] == targetNumber)
                {
                    frequency++;
                }
            }
            Console.Write($"Frequency of 1 are {frequency} time");
        }

        public static void Array_Find_SumOfOddPosition()
        {
            //Write a program to find the sum of odd position from these numbers 1,6,0,8,9,26

            var numbers = new[] {1, 6, 0, 8, 9, 26};
            var sumOfOddPosition = 0;
            for (var i = 0; i < numbers.Length; i+=2)
            {
                sumOfOddPosition += numbers[i];
            }
            Console.WriteLine($"The sum of odd position is {sumOfOddPosition}");
        }
        
        public static void Array2d_PrintIndex()
        {
            //Write a program to print each element and their index in this set of numbers {1,2,3},{4,5,6},{7,8,9} 
            
            var numbers = new[,]
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };

            for (var i = 0; i < numbers.GetLength(0); i++) //Check Rows
            {
                for (var j = 0; j < numbers.GetLength(numbers.Rank - 1); j++)//Check Columns
                //use numbers.Rank because number.Rank is check dimension but it's start at 1 but index start at 0 so numbers.Rank is 1-2 but in index we need 0-1
                {
                    Console.WriteLine($"number at {i} {j} is [{numbers[i,j]}]");
                }
            }
            
            // The way to call the first position in each row before
            // for (int i = 0; i < 3; i++)
            // {
            //     for (int j = 0; j < 3; j++)
            //     {
            //         Console.WriteLine($"number at {i} {j} is [{numbers[j,i]}]"); //just swipe i to j , j to i
            //     }
            // }
            //Out put is
            // number at 0 0 is [1]
            // number at 0 1 is [4]
            // number at 0 2 is [7]
            // number at 1 0 is [2]
            // number at 1 1 is [5]
            // number at 1 2 is [8]
            // number at 2 0 is [3]
            // number at 2 1 is [6]
            // number at 2 2 is [9]

        }

        public static void Array2d_Find_FirstElementEachRow()
        {
            //Write a program to print the first element of each row of this set of numbers (1,2,3),(4,5,6),(7,8,9)

            var numbers = new[,]
            {
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };

            for (var i = 0; i < numbers.GetLength(0); i++)
            {
                //Console.WriteLine($"The first element of Row {i} is {numbers[i,0]}"); used if you don't need to code only row(i) for loop
                for (var j = 0; j < 1; j++)
                {
                    Console.WriteLine($"The first element of Row {i} is {numbers[i,j]}");
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"number at {i} {j} is [{numbers[j,i]}]"); //just swipe i to j , j to i
                }
            }
            
        }

        public static void Arry2d_Find_SumEachRow()
        {
            //Write a program to calculate a sum of first,second,third of each row of this set of numbers (1,2,3),(4,5,6),(7,8,9)

            var numbers = new[,]
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };
            int sumOfEachRow = 0;

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(numbers.Rank - 1); j++)
                {
                    sumOfEachRow += numbers[i, j];
                }
                Console.WriteLine($"Sum of Row {i} is {sumOfEachRow}");
                sumOfEachRow = 0;
            } 
        }

        public static void Arry2d_Find_SumOfEachColumn()
        {
            //Write a program to calculate a sum of first,second,third of each row of this set of numbers (1,2,3),(4,5,6),(7,8,9)
            
            var numbers = new[,]
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };
            
            var sumOfEachColumn = new[] {0, 0, 0};

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(numbers.Rank - 1); j++)
                {
                    if (j == 0)
                    {
                        sumOfEachColumn[0] += numbers[i, j];
                    }
                    else if (j == 1)
                    {
                        sumOfEachColumn[1] += numbers[i, j];
                    }
                    else
                    {
                        sumOfEachColumn[2] += numbers[i, j];
                    }
                }
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Sum of row {i} is {sumOfEachColumn[i]}");

            }
            Console.WriteLine($"The Total sum is {sumOfEachColumn[0]+sumOfEachColumn[1]+sumOfEachColumn[2]}");
        }
        

    }//Class TestArray
    
    
}//namespace