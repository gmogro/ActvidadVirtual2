/*
 * Created by SharpDevelop.
 *
 */
using System;

namespace ActividadVirtual2
{
	
	public class Cls_MiCuenta
	{
		//Atributos
		private int NroCuenta=0;
		private double saldo=0;
		private string Propietario,FechaAlta;
	
		public Cls_MiCuenta()//Constructor 1
		{
		}
		public Cls_MiCuenta(int nroC,int s,string prop,string fechA)
		{
	
		}
		public Boolean transaccion(double cantidad,string tipo){
			if(String.equals(tipo,"deposito"))
			{
				saldo=saldo+cantidad;
			}
			else if(saldo>cantidad)
				{
					saldo=saldo-cantidad;
				}
			     else saldo=0;
		}
	}
}
