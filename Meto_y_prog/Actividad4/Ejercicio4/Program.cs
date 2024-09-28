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
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static void fill(Teacher teach)
		{
			for(int i = 0;i<20;i++)
			{
				if(i<=10)
				{
					IComparable stuAdapt =(Alumno) FabricaDeComparables.crearAleatorio(1);
					AlumnoAdapter student= new AlumnoAdapter(stuAdapt);
					teach.goToClass((Student)student);
				}else
				{
					IComparable stuAdapt = (AlumnoMuyEstudioso)FabricaDeComparables.crearAleatorio(3);
					AlumnoAdapter student= new AlumnoAdapter(stuAdapt);
					teach.goToClass((Student)student);
				}
			}
		}
	}
}