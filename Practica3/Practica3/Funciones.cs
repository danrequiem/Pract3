	using System;
	using System.Collections;
	using System.Threading;

	namespace Practica3
	{
		public class Funciones
		{
			public Hashtable Tabla;

			public Funciones()
			{
				this.Tabla = new Hashtable();
			}
			 
			public void Ingresar()
			{
				for (int i=0; i<4; i++) 
				{
					Persona P = new Persona ();

					Console.WriteLine ("Ingrese los Datos de la Persona");

					Console.Write("Codigo:");
					P.Codigo = int.Parse(Console.ReadLine());

					Console.Write ("Nombre:");
					P.Nombre = Console.ReadLine();

					Console.Write ("Teléfono:");
					P.Telefono = Console.ReadLine();
					 
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
					Console.Write("Ingrese el codigo de la persona a editar:");
					int codigoE = int.Parse (Console.ReadLine ());
					if (Tabla.ContainsKey (codigoE))
					{
						//				
						Persona Edit = (Persona)(Tabla[codigoE]);
						
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

						Console.Write ("Telefono:");
						Edit.Telefono = Console.ReadLine();

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
					Console.Write("Ingrese el codigo de la persona a Elimar:");
					int codigoE = int.Parse (Console.ReadLine ());
					if (Tabla.ContainsKey (codigoE) == true) {
						Persona Elm = new Persona();
						Elm = (Persona)(Tabla [codigoE]);

						Console.Write ("Codigo:");
						Console.WriteLine (Elm.Codigo);

						Console.Write ("Nombre:");
						Console.WriteLine (Elm.Nombre);

						Console.Write ("Telefono:");
						Console.WriteLine (Elm.Telefono);

						Console.Write ("Correo:");
						Console.WriteLine (Elm.Correo);

						Console.Write ("¿Esta seguro de elimnar a esta persona? si)1 no)0: ");
						int opc = int.Parse (Console.ReadLine ());
						if (opc == 1) 
						{
							Tabla.Remove (codigoE);
							Console.Write ("Se elimino la persona");
							Thread.Sleep(1000);
							Console.Clear ();
						}
		
					} 
					else 
					{
						Console.WriteLine("Este codigo no existe");
						Console.WriteLine("Continuar");
						Thread.Sleep(1000);
						Console.Clear();
					}
				}
					Thread.Sleep(1000);
					Console.Clear ();
			}
			
			
			public void Mostar()
			{
				
				Console.WriteLine("Las Personas Restantes son estas:");
				Console.WriteLine();
				IDictionaryEnumerator enumerador = Tabla.GetEnumerator();
			    while ( enumerador.MoveNext() )
				{
					Persona Mos = (Persona)(Tabla[enumerador.Key]);
					Console.Write ("Codigo:");
					Console.WriteLine (Mos.Codigo);

					Console.Write ("Nombre:");
					Console.WriteLine (Mos.Nombre);

					Console.Write ("Telefono:");
					Console.WriteLine (Mos.Telefono);

					Console.Write ("Correo:");
					Console.WriteLine (Mos.Correo);
					Console.WriteLine();

				}
			}
		}
	}

