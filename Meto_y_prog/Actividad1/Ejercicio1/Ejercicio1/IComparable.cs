﻿/*
 * Created by SharpDevelop.
 * User: lauta
 * Date: 30/08/2024
 * Time: 03:12 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio1
{
	public interface IComparable
	{
		bool SosIgual(IComparable c);
		bool SosMenor(IComparable c);
		bool SosMayor(IComparable c);
	}
}
