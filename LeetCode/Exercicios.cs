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
            var result= num % 2 == 0;
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
}