﻿/*
 * Created by SharpDevelop.
 * User: Brian
 * Date: 18/08/2016
 * Time: 23:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ActividadVirtual2
{
	
	public class Cls_Persona
	{
		public Cls_Persona()
		{
		}
	public Cls_Persona(string nom,string apell,long dni,int edad,int tel)//Constructor 2
		{
			this.nombre=nom;
			this.apellido=apell;
			this.dni=dni;
			this.edad=edad;
			this.tel=tel;
		}
		//Metodos
		public void setNombre(string nom)
		{
			this.nombre=nom;
		}
		public void setApellido(string a)
		{
			this.apellido=a;
		}
		public void setDni(long dni)
		{
			this.dni=dni;
		}
		public void setEdad(int e)
		{
			this.edad=e;
		}
		public void setTel(int t)
		{
			this.tel=t;
		}
		public string getNombre()
		{
			return this.nombre;
		}
		public string getApellido()
		{
			return this.apellido;
		}
		public long getDni()
		{
			return this.dni;
		}
		public int getEdad()
		{
			return this.edad;
		}
		public  int getTel()
		{
			return this.tel;
		}
