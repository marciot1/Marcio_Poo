using System;
using System.Collections.Generic;
using System.Text;

namespace atividade
{
    class Abastecimento
    {
        private double valorLitro;
        private double ValorPago;
        private double valorKmRodados;

        public void SetValorLitro(double valorLitro)
        {
            if (valorLitro > 0) this.valorLitro = valorLitro;
        }
        public void SetvalorPago(double valorPago)
        {
            if (valorPago > 0) this.valorPago = valorPago;
        }
        public void SetKmRodados(double KmRodado)
        {
            if (KmRodado > 0) this.KmRodados = KmRodados;
        }
        public double MediaKmLitro()
        {
            double numLitros = valorLitro;
            return KmRodados / numLitros;
        }
        public double MediaReaisKm()
        {
            return ValorPago / KmRodados();
        }
    }
}
