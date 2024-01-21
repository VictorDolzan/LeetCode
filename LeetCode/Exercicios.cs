namespace LeetCode;

public class Exercicios
{
    #region 1ºSt challenge Two Sum

    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> dictionary = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (dictionary.ContainsKey(complement))
            {
                var retorno = new int[] {dictionary[complement], i};
                return retorno;
            }

            dictionary[nums[i]] = i;
        }

        return Array.Empty<int>();
    }

    #endregion

    #region 2º challenge Richest Customer Wealth

    public int MaximumWealth(int[][] accounts)
    {
        //CÓDIGO 1
        var somaTotal = new List<int>();
        foreach (var cliente in accounts)
        {
            var soma = 0;
            foreach (var account in cliente)
            {
                soma += account;
            }

            somaTotal.Add(soma);
        }

        //CÓDIGO 2 
        // for (int i = 0; i < accounts.Length; i++)
        // {
        //     var objeto = accounts[i];
        //     int soma = 0;
        //     for (int j = 0; j < objeto.Length; j++)
        //     {
        //         soma += objeto[j];
        //     }
        //     somaTotal.Add(soma);
        // }

        return somaTotal.Max();
    }

    #endregion

    #region 3º challenge Fizz Buzz

    public IList<string> FizzBuzz(int n)
    {
        var list = new List<string>();

        for (int cont = 1; cont <= n; cont++)
        {
            var divisibleByThree = cont % 3 == 0;
            var divisibleByFive = cont % 5 == 0;

            if (divisibleByThree && divisibleByFive)
            {
                list.Add("FizzBuzz");
            }
            else if (divisibleByThree)
            {
                list.Add("Fizz");
            }
            else if (divisibleByFive)
            {
                list.Add("Buzz");
            }
            else
            {
                list.Add(cont.ToString());
            }
        }

        return list;
    }

    #endregion

    #region 4º Challenge Number of Steps to Reduce a Number to Zero

    public int NumberOfSteps(int num)
    {
        var cont = 0;
        for (int i = 0; num != 0; i++)
        {
            var result = num % 2 == 0;
            if (result)
            {
                num /= 2;
            }
            else
            {
                num -= 1;
            }

            cont++;
        }

        // while (num > 0)
        // {
        //     if (num % 2 == 0)
        //     {
        //         num /= 2;
        //     }
        //     else
        //     {
        //         num--;
        //     }
        //     cont++;
        // }
        return cont;
    }

    #endregion

    #region 5º Middle of the Linked List

    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public ListNode MiddleNode(ListNode head)
    {
        if (head is null) return null;

        ListNode outPut = head;
        ListNode fasterPtr = head.next;

        while (fasterPtr is not null)
        {
            outPut = outPut.next;
            fasterPtr = fasterPtr.next;
            if (fasterPtr is not null)
                fasterPtr = fasterPtr.next;
        }

        return outPut;
    }

    #endregion

    #region 6º Max Consecutives Ones

    public int FindMaxConsecutiveOnes(int[] nums)
    {
        var maxLentgh = new List<int>();
        var maxNumber = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 1)
            {
                maxNumber += 1;
            }
            else
            {
                maxLentgh.Add(maxNumber);
                maxNumber = 0;
            }

            if (i == nums.Length - 1)
            {
                maxLentgh.Add(maxNumber);
            }
        }

        return maxLentgh.Max();
    }

    #endregion

    #region 7º Find Numbers with Even Number of Digits

    public int FindNumbers(int[] nums)
    {
        return nums.Select(num => num.ToString().ToCharArray()).Count(numCharArray => numCharArray.Length % 2 == 0);
    }

    #endregion

    #region 8º Squares of a Sorted Array

    public int[] SortedSquares(int[] nums)
    {
        return nums.Select(num => num * num).OrderBy(num => num).ToArray();
    }

    #endregion

    #region 9º Duplicate Zeros

    public void DuplicateZeros(int[] arr)
    {
        var listArray = new List<int>();
        var doubleZero = new int[] {0, 0};

        for (int i = 0; listArray.Count < arr.Length; i++)
        {
            if (arr[i] != 0)
            {
                listArray.Add(arr[i]);
            }
            else
            {
                listArray.AddRange(doubleZero);
            }
        }

        listArray.ToArray();
    }

    #endregion

    #region 10º Palindrome Number

    public bool IsPalindrome(int x)
    {
        // var numString = x.ToString().ToCharArray();
        //
        // for (int i = 0; i < numString.Length - 1; i++)
        // {
        //     var elementoASerComparado = numString[i];
        //     if (elementoASerComparado != numString[numString.Length - 1 - i])
        //     {
        //         return false;
        //     }
        // }
        //
        // return true;

        string first = x.ToString();
        char[] charArr = first.ToCharArray();
        char[] reverseArr = first.ToCharArray();
        
        Array.Reverse(reverseArr);

        return charArr.SequenceEqual(reverseArr);
    }

    #endregion

    #region 11º Merge Sorted Array

    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        Array.Copy(nums2, 0, nums1, m, n);
        Array.Sort(nums1);
    }

    #endregion
    
    #region 12º Remove elements

    public int RemoveElement(int[] nums, int val)
    {
        int result = 0;

        foreach (var num in nums)
        {
            if (num != val)
            {
                nums[result] = num;
                result++;
            }
        }

        return result;
    }

    #endregion
    
    #region 13º Remove Duplicates from sorted array

    public int RemoveDuplicates(int[] nums)
    {
        // { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };

        int result = 1;

        foreach (var num in nums)
        {
            if (nums[result - 1] != num)
            {
                nums[result++] = num;
            }
        }

        return result;
    }
    
    #endregion
    
    #region 14º Check If N and Its Double Exist

    public bool CheckIfExists(int[] arr)
    {
        // if (arr.Length != 0)
        // {
        //     foreach (var item in arr)
        //     {
        //         if (arr.Contains(item * 2) && item != 0)
        //         {
        //             return true;
        //         }
        //     }
        //     
        //     
        // }
        var index = 0;
        
        if (arr.Length != 0)
        {
            foreach (var item in arr)
            {
                if (item != 0)
                {
                    var find = Array.Find(arr, i => i == item * 2);
                    if (find != 0)
                    {
                        return true;
                    }
                }

                if (item == 0)
                {
                    for (int cont = index + 1; cont < arr.Length; cont++)
                    {
                        if (arr[cont] == item)
                        {
                            return true;
                        }
                    }
                }

                index++;
            }
        
        }
        
        return false;
    }
    #endregion
    
    #region 15º ValidMountainArray

    public bool ValidMountainArray(int[] arr)
    {
        // new[] { 0,3,2,1};
        if (arr.Length < 3 || arr[0] > arr[1] || arr[^1] > arr[^2]) return false;

        bool incresing = true;
        int previous = -1;

        foreach (var item in arr)
        {
            if (previous == item) return false;
            else if (incresing && previous > item) incresing = false;
            else if (!incresing && previous < item) return false;

            previous = item;
        }

        return true;
    }

    #endregion
}