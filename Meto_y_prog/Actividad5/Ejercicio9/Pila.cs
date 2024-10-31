using System;
using System.Collections.Generic;

namespace Ejercicio9
{
	public class Pila:IColeccionable, IIterable, IOrdenable
	{
		private List<IComparable> Datos;
		private OrdenEnAula1 ordenInicio = null
		private OrdenEnAula1 ordenAulaLlena = null;
		private OrdenEnAula2 ordenLlegaAlumno = null;
		public Pila()
		{
			this.Datos = new List<IComparable>();
		}
		//Metodos Command
		public void setOrdenInicio(OrdenEnAula1 aula)
		{
			this.ordenInicio = aula;
		}
		public void setOrdenLlegaAlumno(OrdenEnAula2 Al)
		{
			this.ordenLlegaAlumno = Al;
		}
		public void setOrdenAulaLlena(OrdenEnAula1 aula)
		{
			this.ordenAulaLlena = aula;
		}
		//metodos
	
		public void Apilar (IComparable d)
		{//modificado para IOrdenable
			Datos.Add(d);
			if(this.Cuantos()==1)
			{
				if(!ordenInicio==null)
				{
					ordenInicio.ejecutar();
				}
			}
			if(!ordenAlumno==null)
			{
				ordenAlumno.ejecutar(elem);
			}
			if(this.Cuantos() == 40)
			{
				ordenFin.ejecutar();
			}
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
		
	}
}
