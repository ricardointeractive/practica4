using System;
using System.IO;
using System.Collections;
namespace practica4
{
	class Program
	{
		public static void Main(string[] args)
		{
			 
                        try
                        {
                                personas fun =  new personas();
                                
                                Console.ReadLine();
                        }
                        catch(Exception e)
                        {
                                Console.WriteLine("Exception: " + e.Message);
                        }
                        finally 
                        {
                                Console.WriteLine("Cerrando la lectura.");
                        }
                        
                
                }
		}
	}
