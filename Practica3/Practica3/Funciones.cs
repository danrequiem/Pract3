using System;
using System.Collections;

namespace Practica3
{
	public class Funciones
	{

		public Hashtable Tabla = new Hashtable();


		public Funciones ()
		{
		}
		 
		public void Ingresar()
		{

			for (int i=0; i<4; i++) 
			{
				Persona P = new Persona ();

				Console.WriteLine ("Ingrese los Datos de la Persona");

				//Codigo
				Console.Write("Codigo:");
				P.Codigo = int.Parse(Console.ReadLine());

				//Nombre
				Console.Write ("Nombre:");
				P.Nombre = Console.ReadLine();

				//Telefono
				Console.Write ("Telefono");
				P.Telefono = Console.ReadLine();
				 
				//Correo
				Console.Write ("Correo:");
				P.Correo = Console.ReadLine();

				Tabla.Add(P.Codigo,P);

				Console.Clear ();
			}

		}

		public void Editar()
		{
			for (int i=0; i<=2; i++) 
			{

			 	Persona Edit = new Persona ();
					
				 
				Console.Write("Ingrese el codigo de la persona a editar:");
				int codigoE = int.Parse (Console.ReadLine ());
							
				Edit = (Persona)(Tabla [codigoE]);

				Console.Write("Codigo:");
				Console.WriteLine(Edit.Codigo);

				Console.Write("Nombre:");
				Console.WriteLine(Edit.Nombre);

				Console.Write("Telefono:");
				Console.WriteLine(Edit.Telefono);

				Console.Write("Correo:");
				Console.WriteLine(Edit.Correo);

				Console.WriteLines("Editar");


						


			}

		}
	
	}
}

