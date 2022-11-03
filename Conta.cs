using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancoRural.Contas
{
   public enum TipoConta { ContaCorrente, ContaPoupaca};
    public class Conta 
    {
        public string Num;
        private double _saldo; //convenção de que é private
        public TipoConta Tipo;

        public Conta(TipoConta tipo, string num)
        {
            this.Num = num;
            this.Tipo = tipo;
            _saldo = 0;
        }

        public void Sacar (double valor)
        {
            _saldo = _saldo - valor;
        }
        public void Depositar (double valor)
        {
            _saldo = _saldo + valor;
        }
        public double GetSaldo()
        {
            return _saldo;//variável somente leitura
        }
    }
}
