using System;

namespace Ejercicio6
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
			return (this.valor < ((Numero)c).getValor());
		}
			
		public bool SosMayor(IComparable c)
		{
			return (this.valor > ((Numero)c).getValor());
		}

		public bool SosIgual(IComparable c)
		{
			return (this.valor == ((Numero)c).getValor());
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
