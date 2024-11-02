using System;
using System.Collections.Generic;

namespace Ejercicio10
{
	public class Pila:IColeccionable, IIterable, IOrdenable
	{
		private List<AlumnoAdapter> Datos;
		private OrdenEnAula1 ordenInicio = null;
		private OrdenEnAula1 ordenAulaLlena = null;
		private OrdenEnAula2 ordenLlegaAlumno = null;
		public Pila()
		{
			this.Datos = new List<AlumnoAdapter>();
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
	
		public void Apilar (AlumnoAdapter d)
		{//modificado para IOrdenable
			Datos.Add(d);
			if(this.Cuantos()==1)
			{
				if(ordenInicio!=null)
				{
					ordenInicio.ejecutar();
				}
			}
			if(ordenLlegaAlumno!=null)
			{
				ordenLlegaAlumno.ejecutar(d);
			}
			if(this.Cuantos() == 40)
			{
				ordenAulaLlena.ejecutar();
			}
		}
		
		public AlumnoAdapter Desapilar()
		{
			AlumnoAdapter aux = Datos[Datos.Count - 1];
			Datos.RemoveAt(-1);
			return aux;
		}
		//metodos Icollec
	
		public int Cuantos()
		{
			return Datos.Count;
		}
		
		public AlumnoAdapter Minimo()
		{
			AlumnoAdapter min = Datos[0];
			foreach (AlumnoAdapter com in Datos)
			{
				if (min.greaterThan(com))
				{
					min=com;
				}
			}
			return min;
		}
		public AlumnoAdapter Maximo()
		{
			AlumnoAdapter max = Datos[0];
			foreach (AlumnoAdapter com in Datos)
			{
				if (max.lessThan(com))
				{
					max = com;
				}
			}
			return max;
		}
		
		public void Agregar(AlumnoAdapter m)
		{
			this.Apilar(m);
			
		}
		
		public bool Contiene(AlumnoAdapter m)
		{
			foreach (AlumnoAdapter com in Datos)
			{
				if (com.equals(m))
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
