/*
 * User: lauta
 * Date: 25/9/2024
 */
using System;

namespace Ejercicio4
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
			for(int i = 0;i<20;i++)
			{
				if(i < 10)
				{
					Alumno stuAdapt = (Alumno)FabricaDeComparables.crearAleatorio(1);
					if (stuAdapt !=null)
					{
						AlumnoAdapter student= new AlumnoAdapter(stuAdapt);
						Console.WriteLine("get nombre: "+ stuAdapt.Nombre);
						teach.goToClass(student);	
					}
					
				}else
				{
					AlumnoMuyEstudioso stuAdapt = (AlumnoMuyEstudioso)FabricaDeComparables.crearAleatorio(3);
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