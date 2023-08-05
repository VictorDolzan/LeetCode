// See https://aka.ms/new-console-template for more information

using LeetCode;

var exercicios = new Exercicios();

#region First Challenge Two Sum

/*1º challenge
var nums = new []{2,7,11,15};
var target = 9;

var nums = new[] {3, 2, 4};
var target = 6;

var nums = new[] {3, 2, 7, 5};
var target = 9;

exercicios.TwoSum(nums, target);*/

#endregion

#region Second Challenge Richest Customer Wealth

int[][] accounts = new int[][]
{
    new[] {1, 5},
    new[] {7, 3},
    new[] {3, 5}
};

exercicios.MaximumWealth(accounts);
#endregion