using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistemabancario.Entidades
{
	public enum tipoExtraccion
	{
		CajeroHumano = 1,
		CajeroAutomatico = 2
	}

	public class CCenPesos
	{
		private int saldo;

		public int Saldo { get => saldo; set => saldo = value; }

		public CCenPesos(int saldo)
		{
			Saldo = saldo;
		}

		public void insercion(int monto)
		{
			saldo = saldo + monto;
		}

		public void Extraccion(int monto, tipoExtraccion tipo)
		{
			if(saldo - monto < -5000)
			{
				Console.WriteLine("No podes endeudarte asi :(");
				return;
			}
			if(tipo == tipoExtraccion.CajeroAutomatico)
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
}
