using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistemabancario.Entidades
{

	public class CCenDolares
	{
		private int saldo;

		public int Saldo { get => saldo; set => saldo = value; }

		public CCenDolares(int saldo)
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
				if (monto > 200)
				{
					Console.WriteLine("No te hagas el picaro, hasta 200 nomas pibe.");
					return;
				}
			}
			saldo = saldo - monto;
		}
	}
}
