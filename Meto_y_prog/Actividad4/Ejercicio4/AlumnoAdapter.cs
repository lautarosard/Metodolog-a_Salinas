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
		
		public Alumno getAlumno()
		{
			return alu;
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
			alu.Calificacion = score;
		}
		public string showResult()
		{
			return alu.motrarCalificacion();
		}
		public bool equals(Student student)
		{
			Alumno stu = ((AlumnoAdapter)student).getAlumno();
			return alu.SosIgual(stu);
		}
		public bool lessThan(Student student)
		{
			Alumno stu = ((AlumnoAdapter)student).getAlumno();
			return alu.SosMenor(stu);
		}
		public bool greaterThan(Student student)
		{
			Alumno stu = ((AlumnoAdapter)student).getAlumno();
			return alu.SosMayor(stu);
		}
	}
}
