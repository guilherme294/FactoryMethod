using FactoryMethod.ConcretePruduct;
using FactoryMethod.Creator;
using FactoryMethod.Product;

namespace FactoryMethod.ConcreteCreator
{
    public class BlackFactory : CartaoFactory
    {
        private int _limiteCredito;
        private int _cobrancaAnual;

        public BlackFactory(int _limiteCredito, int _cobrancaAnual)
        {
            this._limiteCredito = _limiteCredito;
            this._cobrancaAnual = _cobrancaAnual;
        }
        public override CartaoCredito BuscarCartaoCredito()
        {
            return new CartaoBlack(_limiteCredito, _cobrancaAnual);
        }
    }
}
