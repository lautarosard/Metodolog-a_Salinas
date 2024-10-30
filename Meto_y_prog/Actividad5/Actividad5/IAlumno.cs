/*
 * User: lauta
 * Date: 14/9/2024
 */
using System;

namespace Ejercicio1
{
	public interface IAlumno:IComparable
	{
		//propiedades
		string Nombre{get; set;};
		//metodos
		bool SosIgual(IComparable c);
		bool SosMenor(IComparable c);
		bool SosMayor(IComparable c);
		void prestarAtencion();
		void distraerse();
		void actualizar(IObservado o);
		int responderPregunta(int pregunta);
		string motrarCalificacion();
	}
}
