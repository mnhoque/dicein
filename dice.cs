//Rextester.Program.Main is the entry point for your code. Don't change it.
//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
             int gunnarA1,gunnarB1,gunnarA2,gunnarB2;
			int emmaA1,emmaB1,emmaA2,emmaB2;
            
			
			string[] inputLine = Console.ReadLine().Split();

            //first Line
            gunnarA1 = int.Parse(inputLine[0]);
            gunnarB1 = int.Parse(inputLine[1]);
			gunnarA2 = int.Parse(inputLine[2]);
			gunnarB2 = int.Parse(inputLine[3]);
			
			
			inputLine = Console.ReadLine().Split();

            //second Line
            emmaA1 = int.Parse(inputLine[0]);
            emmaB1 = int.Parse(inputLine[1]);
			emmaA2 = int.Parse(inputLine[2]);
			emmaB2 = int.Parse(inputLine[3]);
			
			
			
			double gunnarDie1Probability, gunnarDie2Probability,gunnarWinningProbability;
			gunnarDie1Probability = GetProbability(gunnarB1, gunnarA1);
			gunnarDie2Probability = GetProbability(gunnarB2, gunnarA2);
			gunnarWinningProbability = gunnarDie1Probability + gunnarDie2Probability;
			
			
			double emmaDie1Probability, emmaDie2Probability,emmaWinningProbability;
			emmaDie1Probability = GetProbability(emmaB1,  emmaA1);
			emmaDie2Probability = GetProbability(emmaB2, emmaA2);
			emmaWinningProbability = emmaDie1Probability + emmaDie2Probability;
			
			if(gunnarWinningProbability>emmaWinningProbability){
			    Console.WriteLine("Gunnar");
			}
			
			else if(emmaWinningProbability> gunnarWinningProbability){
			    Console.WriteLine("Emma");
			}
			
			else{
			    Console.WriteLine("Tie");
			}
			
        }
        
       public static double GetProbability(int high, int low){
       
	   double expectedValue;
	   double sum=0;
	   for(int index= low; index<=high; index++){
	       sum= sum + index; 
       }
	   
	   expectedValue = sum/(high-low+1);
       return expectedValue;
}
    }
    
    
}
