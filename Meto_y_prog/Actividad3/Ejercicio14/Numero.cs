using System;

namespace Ejercicio14
{
	public class Numero:IComparable
	{
		private int valor;
		
		public Numero(int v)
		{
			this.valor = v;
		}
		//metodos
		public bool SosMenor(IComparable c)
		{
			if (this.valor < ((Numero)c).getValor())
			{
				return true;
			}else
			{
				return false;
			}
		}
			
		public bool SosMayor(IComparable c)
		{
			if (this.valor > ((Numero)c).getValor())
			{
				return true;
			}else
			{
				return false;
			}
		}

		public bool SosIgual(IComparable c)
		{
			if(this.valor == ((Numero)c).getValor())
			{
				return true;
			}else
			{
				return false;
			}
		}
		
		public override string ToString()
		{
			return string.Format("[Numero Valor={0}]", valor);
		}

		//propiedades		
		public int getValor()
		{
			return valor;
		}
			
	}
}
