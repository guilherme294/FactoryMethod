using FactoryMethod.ConcretePruduct;
using FactoryMethod.Creator;
using FactoryMethod.Product;

namespace FactoryMethod.ConcreteCreator
{
    public class PlatinumFactory : CartaoFactory
    {
        private int _limiteCredito;
        private int _cobrancaAnual;

        public PlatinumFactory(int _limiteCredito, int _cobrancaAnual)
        {
            this._limiteCredito = _limiteCredito;
            this._cobrancaAnual = _cobrancaAnual;
        }
        public override CartaoCredito BuscarCartaoCredito()
        {
            return new CartaoPlatinum(_limiteCredito, _cobrancaAnual);
        }
    }
}
