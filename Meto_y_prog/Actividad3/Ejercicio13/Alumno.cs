using System;

namespace Ejercicio13
{
	/// <summary>
	/// Subclase de Persona
	/// </summary>
	public class Alumno:Persona, IObservador
	{
		private int Legajo;
		private double Promedio;
		private IEstrategiaComparacion Estrategia;
		public Alumno(string Nombre, int Dni, int Legajo, double Promedio):base(Nombre, Dni)
		{
			this.Legajo = Legajo;
			this.Promedio = Promedio;
			this.Estrategia = new CompararDni();
		}
		public int legajo
		{
			get{return this.Legajo;}
			set{this.Legajo = value;}
		}
		public double promedio
		{
			get{return this.Promedio;}
			set{this.Promedio = value;}
		}
		
		public void SetEstrategia(IEstrategiaComparacion Estrategia)
		{
			this.Estrategia = Estrategia;
			
		}
		//metodo para imprimir en forma de string un obj. Alumno
		public override string ToString()
    	{
         	return "Nombre: " + Nombre + " DNI: " + Dni + " Legajo: " + Legajo + " Promedio: " + Promedio;
    	}
		//Reimplementación de metodos
		public override bool SosIgual(IComparable C)
		{
			return Estrategia.sosIgual((Persona)this,(Persona)C);
		}
		
		public override bool SosMenor(IComparable C)
		{
			Alumno alu = (Alumno)C;
			return Estrategia.sosMenor((Persona)this,(Persona)C);
		}
		
		public override bool SosMayor(IComparable C)
		{
			Alumno alu = (Alumno)C;
			return Estrategia.sosMayor((Persona)this,(Persona)C);
		}
		//Metodos
		public void prestarAtencion()
		{
			Console.WriteLine("Prestando atención");
		}
		public void distraerse()
		{
			Random Ran= new Random();
			int op = Ran.Next(3);
			switch(op){
				case 0:
					Console.WriteLine("Mirando el celular");
					break;
				case 1:
					Console.WriteLine("Dibujando en el margen de la carpeta");
					break;
				case 2:
					Console.WriteLine("Tirando aviones de papel");
					break;
			}
		}
		public void actualizar(IObservado o)
		{
			if(((Profesor)o).isHablando())
			{
				this.prestarAtencion();
			}else
			{
				this.distraerse();
			}
		}
	}
}
