/*
 * User: lauta
 * Date: 14/9/2024
 */
using System;
using Ejercicio4;


namespace Ejercicio4
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
			return alu.responderPregunta(question);
		}
		public void setScore(int score)
		{
			alu.calificacion(score);
		}
		public string showResult()
		{
			return alu.motrarCalificacion();
		}
		public bool equals(Student student)
		{
			return alu.SosIgual(student);
		}
		public bool lessThan(Student student)
		{
			return alu.SosMenor(student);
		}
		public bool greaterThan(Student student)
		{
			return alu.SosMayor(student);
		}
	}
}
