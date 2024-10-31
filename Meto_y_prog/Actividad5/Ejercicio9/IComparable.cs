using System;
using System.Collections.Generic;

namespace Ejercicio9
{
	public interface IComparable
	{
		bool SosIgual(IComparable c);
		bool SosMenor(IComparable c);
		bool SosMayor(IComparable c);
	}
}
