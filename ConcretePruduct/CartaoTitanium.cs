using FactoryMethod.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod.ConcretePruduct
{
    public class CartaoTitanium : CartaoCredito
    {
        private readonly string _tipoCartao;
        private int _limiteCredito;
        private int _cobrancaAnual;
        public CartaoTitanium(int limiteCredito, int cobancaAnual)
        {
            this._tipoCartao = "Titanium";
            this._limiteCredito = limiteCredito;
            this._cobrancaAnual = cobancaAnual;
        }

        public override string TipoCartao
        {
            get { return _tipoCartao; }
        }
        public override int LimiteCredito
        {
            get { return _limiteCredito; }
            set { _limiteCredito = value; }
        }
        public override int CobrancaAnual
        {
            get { return _cobrancaAnual; }
            set { _cobrancaAnual = value; }
        }
    }
}
