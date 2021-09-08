using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistemabancario.Entidades
{

	public class cajaDeAhorro
	{
		private int saldo;

		public int Saldo { get => saldo; set => saldo = value; }

		public cajaDeAhorro(int saldo)
		{
			Saldo = saldo;
		}

		public void insercion(int monto)
		{
			saldo = saldo + monto;
		}

		public void Extraccion(int monto, tipoExtraccion tipo)
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
