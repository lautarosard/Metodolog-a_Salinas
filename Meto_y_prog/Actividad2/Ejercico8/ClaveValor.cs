/*
 * User: lauta
 * Date: 7/9/2024
 */
using System;

namespace Ejercicio8
{
	/// <summary>
	/// Description of ClaveValor.
	/// </summary>
	public class ClaveValor:IComparable
	{
		int clave;
		IComparable valor;
		public ClaveValor(int clave, IComparable valor)
		{
			this.clave = clave;
			this.valor = valor;
		}
		//Metodos
		public bool SosIgual(IComparable c)
		{
			ClaveValor Claval = (ClaveValor)c;
			return this.Clave == Claval.Clave;
		}
		public bool SosMenor(IComparable c)
		{
			ClaveValor Claval = (ClaveValor)c;
			return this.Clave > Claval.Clave;
		}
		public bool SosMayor(IComparable c)
		{
			ClaveValor Claval = (ClaveValor)c;
			return this.Clave < Claval.Clave;	
		}
		//Propiedades
		public int Clave
		{
			get{return this.clave;}
			set{this.clave = value;}
		}
		public IComparable Valor
		{
			get{return this.valor;}
			set{this.valor = value;}
		}
	}
}
