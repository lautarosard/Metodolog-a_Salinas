/*
 * User: lauta
 * Date: 10/10/2024
 */
using System;
using Ejercicio6.Decorators;

namespace Ejercicio6
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Alumno con los decoradores separados
			IAlumno alumno = (Alumno)FabricaDeComparables.crearAleatorio(1);
			IAlumno decoleg = new LegajoDecorator(alumno);
			Console.WriteLine(decoleg.motrarCalificacion());
			
			IAlumno decoCali = new CalificacionDecorator(alumno);
			Console.WriteLine(decoCali.motrarCalificacion());
			
			IAlumno decoNota = new NotaDecorator(alumno);
			Console.WriteLine(decoNota.motrarCalificacion());
			
			IAlumno decoAsteriscos = new AsteriscosDecorator(alumno);
			Console.WriteLine(decoAsteriscos.motrarCalificacion());
			
			//Alumno con todos los decoradores
			Teacher teacher = new Teacher();
			
			decoleg = new LegajoDecorator(alumno);
			decoCali = new CalificacionDecorator(decoleg);
			decoNota = new NotaDecorator(decoCali);
			decoAsteriscos = new AsteriscosDecorator(decoNota);
			
			AlumnoAdapter aluAdapt = new AlumnoAdapter(decoAsteriscos);
			teacher.goToClass(aluAdapt);
			teacher.teachingAClass();
			
			Console.WriteLine(decoAsteriscos.motrarCalificacion());
			
			Console.Write("\n Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}