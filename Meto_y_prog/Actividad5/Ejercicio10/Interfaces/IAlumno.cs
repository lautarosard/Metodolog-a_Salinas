/*
 * User: lauta
 * Date: 14/9/2024
 */
using System;

namespace Ejercicio10
{
	public interface IAlumno:IComparable
	{
		//propiedades
		string Nombre{ get; set; }
		int Legajo{ get; }
		double Promedio{ get; }
		int Dni{ get; }
		int Calificacion{ get; set; }
		//metodos
		void prestarAtencion();
		void distraerse();
		void actualizar(IObservado o);
		int responderPregunta(int pregunta);
		string mostrarCalificacion();
	}
}
