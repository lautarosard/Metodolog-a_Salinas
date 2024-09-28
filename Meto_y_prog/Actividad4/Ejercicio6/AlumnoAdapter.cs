/*
 * User: lauta
 * Date: 14/9/2024
 */
using System;
using Ejercicio3;


namespace Ejercicio6
{
	/// <summary>
	/// Description of AlumnoAdapter.
	/// </summary>
	public class AlumnoAdapter:Student
	{
		Alumno alu;
		public AlumnoAdapter(Alumno alu)
		{
			this.alu=alu;
		}
		public string getName()
		{
			return alu.Nombre;
		}
		
		public int yourAnswerIs(int question)
		{
			
		}
		public void setScore(int score)
		{
			alu.calificacion(score);
		}
		public string showResult()
		{
			alu.calificacion;
		}
		public bool equals(Student student)
		{
			
		}
		public bool lessThan(Student student)
		{
			
		}
		public bool greaterThan(Student student)
		{
			
		}
	}
}
