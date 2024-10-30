using System;
using System.Collections.Generic;

namespace Ejercicio9
{
	public class Pila:IColeccionable, IIterable, IOrdenable
	{
		private List<IComparable> Datos;
		private OrdenEnAula1 ordenInicio = null,ordenAulaLlena = null;
		private OrdenEnAula2 ordenLlegaAlumno = null;
		public Pila()
		{
			this.Datos = new List<IComparable>();
		}
		//metodos
	
		public void Apilar (IComparable d)
		{
			Datos.Add(d);
		}
		
		public IComparable Desapilar()
		{
			IComparable aux = Datos[Datos.Count - 1];
			Datos.RemoveAt(-1);
			return aux;
		}
		//metodos Icollec
	
		public int Cuantos()
		{
			return Datos.Count;
		}
		
		public IComparable Minimo()
		{
			IComparable min = Datos[0];
			foreach (IComparable com in Datos)
			{
				if (min.SosMayor(com))
				{
					min=com;
				}
			}
			return min;
		}
		public IComparable Maximo()
		{
			IComparable max = Datos[0];
			foreach (IComparable com in Datos)
			{
				if (max.SosMenor(com))
				{
					max = com;
				}
			}
			return max;
		}
		
		public void Agregar(IComparable m)
		{
			this.Apilar(m);
			if(Cuantos() == 1 && ordenInicio!=null)
			{
				ordenInicio.ejecutar();
				if(ordenLlegaAlumno != null)
					{
						ordenLlegaAlumno.ejecutar();
						if(Cuantos()==40 && ordenAulaLlena != null)
						{
							ordenAulaLlena.ejecutar();
						}
					}
			}
			
		}
		
		public bool Contiene(IComparable m)
		{
			foreach (IComparable com in Datos)
			{
				if (com.SosIgual(m))
				{
					return true;
				}
			}
			return false;
		}
		public IIterador crearIterador()
		{
			return new IteradorLista(Datos);
		}
		//
		public void setOrdenInicio(OrdenEnAula1 o)
		{
			ordenInicio = 0;
		}
		void setOrdenLlegaAlumno(OrdenEnAula2);
		void setOrdenAulaLlena(OrdenEnAula1);
	}
}
