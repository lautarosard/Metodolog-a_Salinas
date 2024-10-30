/*
 * User: lauta
 * Date: 24/10/2024
 */
using System;

namespace Ejercicio2
{
	class Program
	{
		public static void Main(string[] args)
		{
			Teacher teacher = new Teacher();
			fill(teacher);
			teacher.teachingAClass();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static void fill(Teacher teach)
		{
			GeneradorDeDatosAleateorio gen= new GeneradorDeDatosAleateorio();
			for(int i = 0;i<20;i++)
			{
				if(i < 10)
				{
					IAlumno stuAdapt = new AlumnoProxy(gen.stringAleatorio(6),1);
					if (stuAdapt !=null)
					{
						AlumnoAdapter student= new AlumnoAdapter(stuAdapt);
						Console.WriteLine("get nombre: "+ stuAdapt.Nombre);
						teach.goToClass((Student)student);	
					}
					
				}else
				{
					IAlumno stuAdapt = new AlumnoProxy(gen.stringAleatorio(6),3);
					if (stuAdapt != null)
					{
						AlumnoAdapter student= new AlumnoAdapter(stuAdapt);
						teach.goToClass((Student)student);
					}
				}
			}
		}
	}
}