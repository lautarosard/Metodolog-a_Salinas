/*
 * User: lauta
 * Date: 28/9/2024
 */
using System;

namespace Ejercicio3
{
	/// <summary>
	/// Description of Aula.
	/// </summary>
	public class Aula
	{
		Teacher teacher=null;
		//Constructor
		public Aula()
		{
		}
		//Metodos
		public void Comenzar()
		{
			Console.WriteLine("Comienza la clase");
			teacher= new Teacher();
		}
		public void nuevoAlumno(IAlumno alumno)
		{
			teacher.goToClass(alumno);
			//agrega alu a con goToClass
		}
		public void claseLista()
		{
			teacher.teachingAClass();
		}
	}
}
