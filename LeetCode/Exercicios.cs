namespace LeetCode;

public class Exercicios
{
    //1ºSt challenge Two Sum
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
    
    //2º challenge Richest Customer Wealth
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
        for (int i = 0; i < accounts.Length; i++)
        {
            var objeto = accounts[i];
            int soma = 0;
            for (int j = 0; j < objeto.Length; j++)
            {
                soma += objeto[j];
            }
            somaTotal.Add(soma);
        }

        return somaTotal.Max();
    }
    
}