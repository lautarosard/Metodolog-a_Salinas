/*
 * User: lauta
 * Date: 14/9/2024
 */
using System;

namespace Ejercicio8
{
	public interface IAlumno:IComparable
	{
		//propiedades
		string Nombre{ get; }
		int Legajo{ get; }
		double Promedio{ get; }
		int Dni{ get; }
		int Calificacion{ get; set; }
		//metodos
		void prestarAtencion();
		void distraerse();
		void actualizar(IObservado o);
		int responderPregunta(int pregunta);
		string motrarCalificacion();
	}
}
