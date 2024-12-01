/*
 * User: lauta
 * Date: 12/10/2024
 */
using System;

namespace Ejercicio10
{
	/// <summary>
	/// Description of NotaDecorator.
	/// </summary>
	public class NotaDecorator: AlumnoDecorator
	{
		public NotaDecorator(IAlumno alumno):base(alumno)
		{
		}
		
		public override string mostrarCalificacion()
		{
			//Comportamiento Base
			string resultado = base.mostrarCalificacion();
			
			//Comportamiento adicional
			string[] nota={"CERO", "UNO", "DOS", "TRES", "CUATRO", "CINCO", "SEIS", "SIETE", "OCHO", "NUEVE", "DIEZ"};
			string notaPas= nota[Calificacion];
			return string.Format("{1} {0}",resultado, notaPas);
			
		}
	}
}
