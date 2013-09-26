using System;
using System.Collections;
using System.Threading;

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
				Console.Write ("Telefono:");
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
			for (int i=0; i<2; i++) 
			{

			 	Persona Edit = new Persona ();
					
				 
				Console.Write("Ingrese el codigo de la persona a editar:");
				int codigoE = int.Parse (Console.ReadLine ());
							
				Edit = (Persona)(Tabla [codigoE]);

				if (Tabla.ContainsKey (codigoE))
				 {

				Console.Write("Codigo:");
				Console.WriteLine(Edit.Codigo);

				Console.Write("Nombre:");
				Console.WriteLine(Edit.Nombre);

				Console.Write("Telefono:");
				Console.WriteLine(Edit.Telefono);

				Console.Write("Correo:");
				Console.WriteLine(Edit.Correo);


				Console.WriteLine ();
				Console.WriteLine("Editar");

				Console.Write ("Nombre:");
				Edit.Nombre = Console.ReadLine();

				//Telefono
				Console.Write ("Telefono:");
				Edit.Telefono = Console.ReadLine();

				//Correo
				Console.Write ("Correo:");
					Edit.Correo = Console.ReadLine();
				}
				else
				{
					Console.WriteLine("Este codigo no existe");
					Console.Write ("Continuar");

				}
				Thread.Sleep(1000);
				Console.Clear ();

						


			}

		}

		public void Eliminar()
		{
			for (int i=0; i<2; i++) 
			{
				Persona Elm= new Persona ();

				Console.Write("Ingrese el codigo de la persona a Elimar:");
				int codigoE = int.Parse (Console.ReadLine ());

				Elm = (Persona)(Tabla [codigoE]);

				if (Tabla.ContainsKey (codigoE) == true) {

					Console.Write ("Codigo:");
					Console.WriteLine (Elm.Codigo);

					Console.Write ("Nombre:");
					Console.WriteLine (Elm.Nombre);

					Console.Write ("Telefono:");
					Console.WriteLine (Elm.Telefono);

					Console.Write ("Correo:");
					Console.WriteLine (Elm.Correo);

				}

				if (Tabla.ContainsKey (codigoE) == true) {
					Console.Write ("¿Esta seguro de elimnar a esta persona? si)1 no)0: ");
					int opc = int.Parse (Console.ReadLine ());

					if (opc == 1) 
					{
						Tabla.Remove (codigoE);
						Console.Write ("Se elimino la persona");
					}
					if (opc == 0) 
					{
						Console.Write ("No se elimino la persona");

					}



				} else 
				{
					Console.WriteLine("Este codigo no existe");
					Console.Write ("Continuar");

				}

				Thread.Sleep(1000);
				Console.Clear ();

			}

		}
	
	}
}

