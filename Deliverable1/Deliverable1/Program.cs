using System;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Net.NetworkInformation;

public class Program
{
    public static void Main()
    {
        int SodaStock = 100;
        int ChipStock = 40;
        int CandyStock = 60;

        Console.WriteLine("Welcome to the restocking tool.");
        Console.WriteLine("How many sodas have been sold today? 100 are in stock");
        int SodaSold = int.Parse(Console.ReadLine());
        int RemainingSoda = SodaStock - SodaSold;
        { if (SodaSold < 100) {
            Console.WriteLine("There are " + RemainingSoda + " sodas left");
        } else if (SodaSold > 100) {
            Console.WriteLine("That value is too high. Stock not adjusted.");
        }
            { Console.WriteLine("How many chips have been sold today? 40 in stock.");
            int ChipSold = int.Parse(Console.ReadLine());
            int RemainingChip = ChipStock - ChipSold;
            { if (ChipSold < 40) {
                    Console.WriteLine("There are " + RemainingChip + " chips left");
            } else if (ChipSold > 40) {
                    Console.WriteLine("That value is too high. Stock not adjusted");
                }
                    { Console.WriteLine("How much candy was sold today? 60 in stock.");
                        int CandySold = int.Parse(Console.ReadLine());
                        int RemainingCandy = CandyStock - CandySold;
                        { if (CandySold < 60) {
                                Console.WriteLine("There is " + RemainingCandy + " candy left.");
                            } else if (CandySold > 60) {
                                Console.WriteLine("That value is too high. Stock not adjusted.");
                            }
                            { Console.WriteLine("Thank you for filling out the values. Here's what needs to be restocked.");
                            if (RemainingSoda <= 40) {
                                    Console.WriteLine("Soda needs to be restocked.");
                                }
                                
                                if (RemainingChip <= 20) {
                                    Console.WriteLine("Chips need to be restocked.");
                                }
                                    
                                if (RemainingCandy <= 40) {
                                    Console.WriteLine("Candy needs to be restocked.");
                                }
                                   
                            } Console.WriteLine("Goodbye!");

                        }

                    }
            }
            }
            
        }
    }
}