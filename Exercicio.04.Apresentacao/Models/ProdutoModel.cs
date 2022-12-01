using Exercicio.Quatro.Apresentacao.Classes;
using System.Windows.Media;

namespace Exercicio.Quatro.Apresentacao.Models
{
    public class ProdutoModel : AbstractModel
    {
        private ImageSource _imagem;
        private string _descricao = string.Empty;
        private string _referecia = string.Empty;
        private string _cor = string.Empty;
        private int _estoque = 0;
        private int _quantidade = 0;
        private decimal _preco = 0.0m;

        public ImageSource Imagem 
        { 
            get => _imagem; 
            set => SetField(ref _imagem, value);
        }

        public string Descricao
        {
            get => _descricao;
            set => SetField(ref _descricao, value);
        }

        public string Referencia
        {
            get => _referecia;
            set => SetField(ref _referecia, value);
        }

        public string Cor
        {
            get => _cor;
            set => SetField(ref _cor, value);
        }

        public int Estoque 
        { 
            get => _estoque;
            set => SetField(ref _estoque, value);
        }

        public int Quantidade
        {
            get => _quantidade;
            set => SetField(ref _quantidade, value);
        }

        public decimal Preco
        {
            get => _preco;
            set => SetField(ref _preco, value);
        }
    }
}