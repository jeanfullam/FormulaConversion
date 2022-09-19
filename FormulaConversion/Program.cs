/*
purpose:The program
should display a menu of available options to the user, prompt for the desired option, and then
prompt for the value. The conversion should be performed, and the new value should be
displayed. Use the following table for conversions:
CONVERSION FORMULA
POUNDS TO KILOGRAMS kg = lb / 2.20462
FLUID OUNCES (U.S.) TO LITRES 1 litre = 33.8140226 ounces
INCHES TO CENTIMETERS cm = in / 0.393701
FAHRENHEIT TO CELSIUS C = (F - 32) / 1.8
input: option number, amount.
output: conversion 
written by: Jean Fullam
Date: 09/19/2022
*/
namespace FormulaConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare variables  
            char option;
            double unit = 0,
                finalUnit = 0;

            // prompt for options
            Console.WriteLine("Select conversion option: ");
            Console.WriteLine("\t1 - pounds to KG");
            Console.WriteLine("\t2 - Fluid Ounces to Litres");
            Console.WriteLine("\t3 - Inches to Centimetres");
            Console.WriteLine("\t4 - Fahrenheit to Celcius");
            Console.Write("Option");
            option = char.Parse(Console.ReadLine());

            // prompt for amount
            if (option == '1')
            {
                Console.WriteLine("Enter pounds: ");
                unit = double.Parse(Console.ReadLine());
                finalUnit = unit / 2.20462;
            }
            else if (option == '2')
            {
                Console.WriteLine("Enter Ounces: ");
                unit = double.Parse(Console.ReadLine());
                finalUnit = unit * 33.8140226;
            }
            else if (option == '3')
            {
                Console.WriteLine("Enter Inches: ");
                unit = double.Parse(Console.ReadLine());
                finalUnit = unit / 0.393701;
            }
            if (option == '4')
            {
                Console.WriteLine("Enter Fahrenheit: ");
                unit = double.Parse(Console.ReadLine());
                finalUnit = (unit - 32) / 1.8;
            }

            
          // display results  
            Console.WriteLine($"{unit} = {finalUnit:f2}");            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            Console.ReadLine();
        }
    }
}