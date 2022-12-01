using Exercicio.Quatro.Apresentacao.Classes;

namespace Exercicio.Quatro.Apresentacao.Models
{
    public class CartaoModel : AbstractModel
    {
        private string _numero = string.Empty;
        private string _validade = string.Empty;
        private string _cvv = string.Empty;

        public string Numero 
        { 
            get => _numero;
            set => SetField(ref _numero, value);
        }

        public string Validade
        {
            get => _validade;
            set => SetField(ref _validade, value);
        }

        public string CVV
        {
            get => _cvv;
            set => SetField(ref _cvv, value);
        }
    }
}