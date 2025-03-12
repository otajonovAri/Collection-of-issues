// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


public class Solution {
    public bool CheckIfExist(int[] arr) 
    {
        for(int i = 0; i < arr.Length; i++)
        {
            int x = arr[i] * 2;
            if(arr.Contains(x))
               return true;
        }    
        return false;
    }
}