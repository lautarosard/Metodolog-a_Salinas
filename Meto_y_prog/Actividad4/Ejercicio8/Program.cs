/*
 * User: lauta
 * Date: 13/10/2024
 */
using System;

namespace Ejercicio8
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
					IAlumno stuAdapt = (Alumno)FabricaDeComparables.crearAleatorio(1);
									
					IAlumno decoleg = new LegajoDecorator(stuAdapt);
					
					IAlumno decoCali = new CalificacionDecorator(decoleg);
					
					IAlumno decoNota = new NotaDecorator(decoCali);
					
					IAlumno decoAsteriscos = new AsteriscosDecorator(decoNota);
					
					AlumnoAdapter student= new AlumnoAdapter(decoAsteriscos);
					
					teach.goToClass(student);
					
					
				}else
				{
					IAlumno stuAdapt = (AlumnoMuyEstudioso)FabricaDeComparables.crearAleatorio(3);
					if (stuAdapt != null)
					{
						
						IAlumno decoleg = new LegajoDecorator(stuAdapt);
						IAlumno decoCali = new CalificacionDecorator(decoleg);
						IAlumno decoNota = new NotaDecorator(decoCali);
						IAlumno decoAsteriscos = new AsteriscosDecorator(decoNota);
						AlumnoAdapter student= new AlumnoAdapter(decoAsteriscos);
						teach.goToClass((Student)student);	
					}
				}
			}
		}
	}
}