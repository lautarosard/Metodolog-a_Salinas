﻿/*
 * User: lauta
 * Date: 14/9/2024
 */
using System;

namespace Ejercicio2
{
	/// <summary>
	/// Description of AlumnoMuyEstudioso.
	/// </summary>
	public class AlumnoMuyEstudioso:
	{
		public AlumnoMuyEstudioso(string Nombre, int Dni, int Legajo, double Promedio):base(Nombre,Dni,Legajo,Promedio)
		{
		}
		public override int responderPregunta(int pregunta)
		{
			return 3;
		}
	}
}
