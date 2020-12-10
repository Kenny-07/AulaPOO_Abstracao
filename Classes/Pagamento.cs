using System;
namespace AulaPOO_Abstracao.Classes
{
    public class Pagamento
    {
        private DateTime data;
        protected float valor;

        public string Cancelar(){
            return $"Cancelamento feito em {data}";
        }

        public abstract string Desconto(float valor);
    }
}