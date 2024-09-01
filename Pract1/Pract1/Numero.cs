using System;

namespace Pract1
{

	//Ejercicio 2
	public class Numero:Icomparable
	{
		private int valor;
		public Numero(int v)
		{
			this.valor=v;
		}
		public int getValor()
		{
			return valor;
		}
		public bool sosMenor(Icomparable m)
		{
			if (this.valor<((Numero)m).getValor())
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		public bool sosMayor(Icomparable m)
		{
			
			if (this.valor>((Numero)m).getValor())
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		public bool sosIgual(Icomparable m)
		{
			if (this.valor==((Numero)m).getValor())
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		public override string ToString()
		{
			//return string.Format("[Numero Valor={0}]", valor);
			return this.valor.ToString();
		}

			
	}
}
