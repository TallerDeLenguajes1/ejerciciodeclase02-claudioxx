using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaBancario.Entidades
{
	public enum tipoExtraccion
	{
		CajeroHumano = 1,
		CajeroAutomatico = 2
	}

	public class Cuenta
	{
		protected int saldo;

		public int Saldo { get => saldo; set => saldo = value; }

		public Cuenta(int saldo) 
		{
			this.saldo = saldo;
		}

		public virtual void insercion(int monto) { }

		public virtual void Extraccion(int monto, tipoExtraccion tipo) { }
	}

	public class CCenPesos : Cuenta
	{

		public CCenPesos(int saldo) : base(saldo)
		{
			 Saldo = saldo;
		}

		public override void insercion(int monto)
		{
			saldo = saldo + monto;
		}

		public override void Extraccion(int monto, tipoExtraccion tipo)
		{
			if (saldo - monto < -5000)
			{
				Console.WriteLine("No podes endeudarte asi :(");
				return;
			}
			if (tipo == tipoExtraccion.CajeroAutomatico)
			{
				if (monto > 20000)
				{
					Console.WriteLine("No te hagas el picaro, hasta 20000 nomas pibe.");
					return;
				}
			}
			saldo = saldo - monto;
		}
	}

	public class CCenDolares : Cuenta
	{

		public CCenDolares(int saldo) : base(saldo)
		{
			Saldo = saldo;
		}

		public override void insercion(int monto)
		{
			saldo = saldo + monto;
		}

		public override void Extraccion(int monto, tipoExtraccion tipo)
		{
			if (tipo == tipoExtraccion.CajeroAutomatico)
			{
				if (monto > 200)
				{
					Console.WriteLine("No te hagas el picaro, hasta 200 nomas pibe.");
					return;
				}
			}
			saldo = saldo - monto;
		}
	}

		public class cajaDeAhorro : Cuenta
		{

			public cajaDeAhorro(int saldo) : base(saldo)
			{
				Saldo = saldo;
			}

			public override void insercion(int monto)
			{
				saldo = saldo + monto;
			}

			public override void Extraccion(int monto, tipoExtraccion tipo)
			{
				if (tipo == tipoExtraccion.CajeroAutomatico)
				{
					if (monto > 10000)
					{
						Console.WriteLine("No te hagas el picaro, hasta 10000 nomas pibe.");
						return;
					}
				}
				saldo = saldo - monto;
			}
		}

	}


}
