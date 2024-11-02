/*
 * Created by SharpDevelop.
 * User: lauta
 * Date: 30/08/2024
 * Time: 04:18 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Ejercicio10
{
	public class Cola:IColeccionable, IIterable, IOrdenable
	{
		private List<AlumnoAdapter> Datos;
		private OrdenEnAula1 ordenInicio=null;
		private OrdenEnAula1 ordenFin=null;
		private OrdenEnAula2 ordenAlumno=null;
		
		//constructor	
		public Cola()
		{
			 Datos = new List<AlumnoAdapter>();
		}
		//metodos Icollec
		
		public int Cuantos()
		{
			return this.CantidadElementos();
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
			this.Encolar(m);
			
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
		//metodos Iterable
		public IIterador crearIterador()
		{
			return new IteradorLista(Datos);
		}
		//metodos Command
		public void setOrdenInicio(OrdenEnAula1 aula)
		{
			this.ordenInicio = aula;
		}
		public void setOrdenLlegaAlumno(OrdenEnAula2 Al)
		{
			this.ordenAlumno = Al;
		}
		public void setOrdenAulaLlena(OrdenEnAula1 aula)
		{
			this.ordenFin = aula;
		}
		//Metodos
		private void Encolar (AlumnoAdapter elem)
		{
			this.Datos.Add(elem);
			if(this.Cuantos()==1)
			{
				if(ordenInicio!=null)
				{
					ordenInicio.ejecutar();
				}
			}
			if(ordenAlumno!=null)
			{
				ordenAlumno.ejecutar(elem);
			}
			if(this.Cuantos() == 40)
			{
				ordenFin.ejecutar();
			}
		}
		
		public AlumnoAdapter Desencolar()
		{
			if(EsVacia())
			{
			
				throw new InvalidOperationException("La cola está vacía.");	
			}
			else{
				AlumnoAdapter temp = this.Datos[0];
				this.Datos.RemoveAt(0);
				return temp;
			}
		}
		
		public AlumnoAdapter Tope()
		{
			if(EsVacia()){
			
				throw new InvalidOperationException("La cola está vacía.");	
			}
			
			return this.Datos[0];
		}
		
		public bool EsVacia()
		{
			return this.Datos.Count == 0;
		}
		
		private int CantidadElementos()
		{
			return this.Datos.Count;
		}
		
		
	 }
}