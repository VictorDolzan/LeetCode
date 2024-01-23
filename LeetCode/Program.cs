// See https://aka.ms/new-console-template for more information

using LeetCode;

var exercicios = new Exercicios();

#region 1ºst Challenge Two Sum

/*1º challenge
var nums = new []{2,7,11,15};
var target = 9;

var nums = new[] {3, 2, 4};
var target = 6;

var nums = new[] {3, 2, 7, 5};
var target = 9;

exercicios.TwoSum(nums, target);*/

#endregion

#region 2ºnd Challenge Richest Customer Wealth

// int[][] accounts = new int[][]
// {
//     new[] {1, 5},
//     new[] {7, 3},
//     new[] {3, 5}
// };
//
// exercicios.MaximumWealth(accounts);

#endregion

#region 3º challenge Fizz Buzz

// exercicios.FizzBuzz(3);

#endregion

#region 4º Challenge 1342. Number of Steps to Reduce a Number to Zero

// exercicios.NumberOfSteps(14);

#endregion

#region 5º Middle of the Linked List

// var list = new Exercicios.ListNode();
// Exercicios.MiddleNode(list);

#endregion

#region 6º Max Consecutives Ones

// var nums = new[] { 1, 1, 0, 1, 1, 1 };

// exercicios.FindMaxConsecutiveOnes(nums);

#endregion

#region 7º Find Numbers with Even Number of Digits

var listaNums = new[] { 12, 345, 2, 6, 7896 };

// exercicios.FindNumbers(listaNums);

#endregion

#region 8º Squares of a Sorted Array

var arrayNums = new[] { -4, -1, 0, 3, 10 };

// exercicios.SortedSquares(arrayNums);

#endregion

#region 9º Duplicate Zeros

var numArray = new[] { 1, 0, 2, 3, 0, 4, 5, 0 };

// exercicios.DuplicateZeros(numArray);

#endregion

#region 10º Palindrome Number

var number = 121;
// exercicios.IsPalindrome(number);

#endregion

#region 11º Merge Sorted Array

var nums1 = new[] { 1, 2, 3, 0, 0, 0 };
var m = 3;
var nums2 = new[] { 2, 5, 6 };
var n = 3;
// exercicios.Merge(nums1, m, nums2, n);

#endregion

#region 12º Remove elements

// var nums = new[] { 3, 2, 2, 3 };
// var val = 3;

// exercicios.RemoveElement(nums, val);

#endregion

#region 13º Remove Duplicates from sorted array

//
// var nums = new[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
//
// exercicios.RemoveDuplicates(nums);

#endregion

#region 14º Check If N and Its Double Exist

// var arr = new[] { -2,0,10,-19,4,6,-8};
// var arr = new[] { 0, 0 };
// exercicios.CheckIfExists(arr);

#endregion

#region 15º ValidMountainArray

// var arr = new[] { 0,3,2,1 };
// exercicios.ValidMountainArray(arr);

#endregion

#region 16º Replace Elements with Greatest Element on Right Side

//
// var arr = new int[] { 17, 18, 5, 4, 6, 1 };
// exercicios.ReplaceElements(arr);

#endregion

#region Código BALTA.IO

var address = new Address()
{
    Street = "Rua",
    Number = "Number",
    ZipCode = "123"
};

// try
// {
//     var email = new Email("Victorddf5@gmail.com");
//     // var email2 = (Email)"Ola@gmail.com";
//     var jsonDoEmail = email.ToJson();
// }
// catch (InvalidEmailException e)
// {
//     Console.WriteLine(e.Message);
//     throw;
// }

public class Address
{
    public string Street { get; set; } = string.Empty;
    public string Number { get; set; } = string.Empty;
    public string ZipCode { get; set; } = string.Empty;

    public override string ToString() => $"{Street}, {Number}{Environment.NewLine}CEP: {ZipCode}";
}

public class Email
{
    
    public Email(string address)
    {
        if (string.IsNullOrEmpty(address)) throw new InvalidEmailException();
        
        Address = address.Trim().ToLower();
    }
    
    public string Address { get; set; } = string.Empty;
    public static implicit operator string(Email email) => email.Address;
    public static explicit operator Email(string email) => new (email);
    public override string ToString() => Address;
}

public class InvalidEmailException : Exception
{
    private const string DefaultErrorMessage = "Email inválido";

    public InvalidEmailException(string message = DefaultErrorMessage) : base(message)
    {
        
    }
}

public static class EmailExtension
{
    public static string ToJson(this Email email)
    {
        return email.ToString();
    }
}

#endregion
