﻿using System;
using System.IO;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"D:\csharp\texto1.txt";
            string targetPath = @"D:\csharp\texto2.txt";

            try
            {
               FileInfo fileInfo = new FileInfo(sourcePath);
               fileInfo.CopyTo(targetPath);
               string[] lines = File.ReadAllLines(sourcePath);

                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }

            } catch (IOException e) { 
                Console.WriteLine("Ocorreu um erro!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
