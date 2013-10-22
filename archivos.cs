
using System;
using System.IO;
using System.Collections;

namespace practica4
{
	
	public class archivos
	{
	    private string path;
        private ArrayList list= new ArrayList();
		public archivos (string path)
		{
		     	this.path = path;
			
		        }
		        public void leer(){
			    
			    try 
				{
				StreamReader objReader = new StreamReader("C:/Users/RicardoAlfonso/Documents/programacion3/registro.csv");
				// objReader.GetType();
				string linea = objReader.ReadLine();
				ArrayList lista = new ArrayList();
				while (linea != null) 
				{
					archivos per=new archivos();
				string[] campos=linea.Split(',');
				per.id =int.Parse(campos[0]);
				per.nombre=campos[1];
				per.domicilio=campos[2];
				per.telefono=campos[3];
				list.Add(per);
				}
				}
		        }
		 public void imprimirRegistros()
                {
                        Console.WriteLine("Numero de registros: "+list.Count);
                        foreach (object Registro in list)
                {
                        this.per= (archivos) archivos;
                        imprimirtodo();
                }
                }
		  public void imprimirtodo()
                {
		  	            Console.WriteLine("----------------------------------------");
                        Console.Write("ID:");
                        Console.WriteLine(this.per.id);
                        Console.WriteLine("----------------------------------------");
                        Console.Write("Nombre:");
                        Console.WriteLine(this.per.nombre);
                        Console.Write("Telefono:");
                        Console.WriteLine(this.per.domicilio);
                        Console.Write("Domicilio:");
                        Console.WriteLine(this.per.telefono);
                        Console.WriteLine("----------------------------------------");
                        
                }
	          }
            }
