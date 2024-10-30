/*
 * User: lauta
 * Date: 28/9/2024
 */
using System;

namespace Ejercicio5
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
		public void nuevoAlumno()
		{
			//agrega alu a con goToClass
		}
		public void claseLista()
		{
			//usar teachingAClass a teacher
		}
	}
}
