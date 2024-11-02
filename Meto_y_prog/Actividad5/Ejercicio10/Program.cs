/*
 * User: lauta
 * Date: 31/10/2024
 */
using System;

namespace Ejercicio10
{
	class Program
	{
		public static void Main(string[] args)
		{
			Cola cola = (Cola)FabricaDeColecciones.crearColeccion(1);
			Pila pila = (Pila)FabricaDeColecciones.crearColeccion(2);
			
			Aula aula= new Aula();
			
			pila.setOrdenInicio(new OrdenInicio(aula));
			pila.setOrdenLlegaAlumno(new OrdenLlegaAlumno(aula));
			pila.setOrdenAulaLlena(new OrdenAulaLlena(aula));
			
			fill(pila);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static void fill(IColeccionable coleccion)
		{
			GeneradorDeDatosAleateorio gen= new GeneradorDeDatosAleateorio();
			for(int i = 0;i<40;i++)
			{
				if(i < 20)
				{
					IAlumno stuAdapt = new AlumnoProxy(gen.stringAleatorio(6),1);
					if (stuAdapt !=null)
					{
						AlumnoAdapter student= new AlumnoAdapter(stuAdapt);
						coleccion.Agregar(student);
					}
					
				}else
				{
					IAlumno stuAdapt = new AlumnoProxy(gen.stringAleatorio(6),3);
					if (stuAdapt != null)
					{
						AlumnoAdapter student= new AlumnoAdapter(stuAdapt);
						coleccion.Agregar(student);
					}
				}
			}
		}
	}
}