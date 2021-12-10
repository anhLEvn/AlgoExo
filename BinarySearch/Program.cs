using System;

namespace BinarySearch
{
    public class Program

    /*Given an array of integers nums which is sorted in ascending order, 
     * and an integer target, write a function to search target in nums.
     * If target exists, then return its index. Otherwise, return -1.
     * You must write an algorithm with O(log n) runtime complexity.
     Constraints:
        a, 1 <= nums.length <= 10000
        b,-10000 < nums[i], target < 10000
        c, All the integers in nums are unique.
        d, nums is sorted in ascending order.
     */

    {
        public static void Main(string[] args)
        {
            //Require array length
            int[] nums = { };
            int target = 0;
            Solution solution = new Solution();
            solution.Search(nums, target);

        }

    }

    public class Solution
    {
        public int Search(int[] nums, int target)
        {

            Console.WriteLine("Enter length of array pls: ");
            int numsLength = 0;
            try
            {
                numsLength = Convert.ToInt32(Console.ReadLine());
                if (numsLength < 1 || numsLength > 10000) // Constraint:1 <= nums.length <= 10000
                {
                    Console.WriteLine("numsLength must be inferior than 10.000 ");
                    numsLength = Convert.ToInt32(Console.ReadLine());
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Enter number only pls!");
                numsLength = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Length = " + numsLength);

            Console.WriteLine("Enter array's element pls: ");
            nums = new int[numsLength];
            //int count = 1; => to check doublicated element , not yet done
            int i = 0;

            for (i = 0; i < numsLength; i++)
            {
                try
                {
                    nums[i] = Convert.ToInt32(Console.ReadLine());
                    // constraint: -10000 < nums[i]
                    if (nums[i] < -10000)
                    {
                        Console.WriteLine("Number must be supperior than (-10000) pls!");
                        nums[i] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Enter number only pls!");
                    nums[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (i = 0; i < numsLength - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    Console.WriteLine("element is unique pls change another number : ");
                }
            }
            Array.Sort(nums); // constraint: nums is sorted in ascending order.

            Console.Write("Your binary array : ");
            foreach (int element in nums)
            {
                Console.Write(element + ", ");
            }

            Console.WriteLine();
            Console.WriteLine("Enter your target pls: ");
            target = Convert.ToInt32(Console.ReadLine());
            // constraint: target < 10000 
            if (target > 10000)
            {
                Console.WriteLine("Target must be smaller than 10000! ");
                target = Convert.ToInt32(Console.ReadLine());
            }

            if (numsLength == 1)
            {
                if (nums[0] == target)
                {
                    Console.WriteLine("Index of target = 0");
                }
                else
                {
                    Console.WriteLine("-1");
                }
            }
            else
            {    // find middle of array
                int indexRoot = 0;
                if (numsLength % 2 == 0)
                {
                    indexRoot = numsLength / 2;

                    if (nums[indexRoot] == target)
                    {
                        Console.WriteLine("Index of target: " + indexRoot);
                    }

                    if (nums[indexRoot] < target)
                    {
                        for (int j = 0; j < (nums.Length - indexRoot); j++)
                        {
                            if (nums[j] == target)
                            {
                                Console.WriteLine("Index of target: " + j);
                            }
                        }
                        Console.WriteLine("-1");
                    }

                    else
                    {
                        for (int j = 0; j < indexRoot; j++)
                        {
                            if (nums[j] == target)
                            {
                                Console.WriteLine("Index of target: " + j);
                            }
                            Console.WriteLine("-1");
                        }
                    }
                }
                else
                {
                    indexRoot = (numsLength + 1) / 2;
                    if (nums[indexRoot] == target)
                    {
                        Console.WriteLine("Index of target: " + indexRoot);
                    }


                    if (nums[indexRoot] < target)
                    {
                        for (int j = 0; j < (numsLength - indexRoot); j++)
                        {
                            if (nums[j] == target)
                            {
                                Console.WriteLine("Index of target: " + j);
                            }

                        }

                        Console.WriteLine("-1");
                    }
                    else
                    {
                        for (int j = 0; j < indexRoot; j++)
                        {
                            if (nums[j] == target)
                            {
                                Console.WriteLine("Index of target: " + j);
                            }
                        }
                        Console.WriteLine("-1");
                    }
                }
            }

            return 0;

        }
    }


}

