using System;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Net.NetworkInformation;

public class Program
{
    public static void Main()
    {
        
        Console.WriteLine("Welcome to the restocking tool.");
        Console.WriteLine("How many sodas have been sold today? 100 are in stock");
        int SodaSold = int.Parse(Console.ReadLine());
        int SodaStock = 100;
        int RemainingSoda = SodaStock - SodaSold;
        { if (SodaSold <= 100) {
            Console.WriteLine("There are " + RemainingSoda + " sodas left");
        } if (SodaSold > 100) {
            Console.WriteLine("That value is too high. Stock not adjusted.");
        }
        Console.WriteLine("How many chips have been sold today? 40 in stock.");
        int ChipSold = int.Parse(Console.ReadLine());
        int ChipStock = 40;
        int RemainingChip = ChipStock - ChipSold;
        { if (ChipSold <= 40) {
            Console.WriteLine("There are " + RemainingChip + " chips left");
        } if (ChipSold > 40) {
            Console.WriteLine("That value is too high. Stock not adjusted");
        }
        Console.WriteLine("How much candy was sold today? 60 in stock.");
        int CandySold = int.Parse(Console.ReadLine());
        int CandyStock = 60;
        int RemainingCandy = CandyStock - CandySold;
        { if (CandySold <= 60) {
            Console.WriteLine("There is " + RemainingCandy + " candy left.");
        } if (CandySold > 60) {
            Console.WriteLine("That value is too high. Stock not adjusted.");
        }
        Console.WriteLine("Thank you for filling out the values. Here's what needs to be restocked.");
        int SodaRestock = 40;
        int ChipRestock = 20;
        int CandyRestock = 40;
        if (RemainingSoda <= SodaRestock) {
            Console.WriteLine("Soda needs to be restocked.");
        }
        if (RemainingChip <= ChipRestock) {
            Console.WriteLine("Chips need to be restocked.");
        }
        if (RemainingCandy <= CandyRestock)
            Console.WriteLine("Candy needs to be restocked.");
        }
        Console.WriteLine("Goodbye!");

        }             

                   
            
            
            
        
    }
}}