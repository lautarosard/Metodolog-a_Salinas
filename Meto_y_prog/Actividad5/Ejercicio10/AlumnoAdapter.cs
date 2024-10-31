/*
 * User: lauta
 * Date: 14/9/2024
 */
using System;
using Ejercicio10;


namespace Ejercicio10
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
			return alu.mostrarCalificacion();
		}
		public bool equals(Student student)
		{
			if(student is AlumnoAdapter)
			{	
				IAlumno stu = ((AlumnoAdapter)student).getAlumno();
				return alu.SosIgual(stu);
			}
			Console.WriteLine("Student no es adapter");
			return false;
		}
		public bool lessThan(Student student)
		{
			if(student is AlumnoAdapter)
			{
				IAlumno stu = ((AlumnoAdapter)student).getAlumno();
				return alu.SosMenor(stu);
			}
			Console.WriteLine("Student no es adapter");
			return false;
		}
		public bool greaterThan(Student student)
		{
			if(student is AlumnoAdapter)
			{
				IAlumno stu = ((AlumnoAdapter)student).getAlumno();
				return alu.SosMayor(stu);
			}
			Console.WriteLine("Student no es adapter");
			return false;
		}
	}
}
