using System;

namespace Pract1
{
	public class ColeccionMultiple:Icoleccionable
	{
		private Pila pila1;
		private Cola cola1;
		public ColeccionMultiple(Pila p,Cola c)
		{
			this.pila1=p;
			this.cola1=c;
		}
		public int cuantos()
		{
			int suma=(cola1.cuantos())+(pila1.cuantos());
			return suma;
		}
		public Icomparable minimo()
		{
			Icomparable numero1=pila1.minimo();
			Icomparable numero2=cola1.minimo();
			if (numero1.sosMenor(numero2))
			{
				return numero1;
			}
			return numero2;
		}
		public Icomparable maximo()
		{
			Icomparable numero1=pila1.maximo();
			Icomparable numero2=cola1.maximo();
			if (numero1.sosMayor(numero2))
			{
				return numero2;
			}
			return numero1;
		}
		public void agregar(Icomparable m)
		{
			
		}
		public bool contiene(Icomparable m)
		{
			if (cola1.contiene(m) || pila1.contiene(m))
			{
				return true;
			}
			return false;
		}
	}
}
