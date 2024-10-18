/*
 * User: lauta
 * Date: 14/9/2024
 */
using System;
using Ejercicio8;


namespace Ejercicio8
{
	/// <summary>
	/// Description of AlumnoAdapter.
	/// </summary>
	public class AlumnoAdapter:Student
	{
		IAlumno alu;
		public AlumnoAdapter(IAlumno alu)
		{
			this.alu=alu;
		}
		
		public IAlumno getAlumno()
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
			IComparable stu = ((AlumnoAdapter)student).getAlumno();
			bool flag=alu.SosIgual(stu);
			return flag;
		}
		public bool lessThan(Student student)
		{
			IComparable stu = ((AlumnoAdapter)student).getAlumno();
			bool flag=alu.SosMenor(stu);
			return flag;
		}
		public bool greaterThan(Student student)
		{
			IComparable stu = ((AlumnoAdapter)student).getAlumno();
			bool flag=alu.SosMayor(stu);
			return flag;
		}
	}
}
