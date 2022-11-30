using Exercicio.Quatro.Apresentacao.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Exercicio.Quatro.Apresentacao.Models
{
    public class ProdutoModel : AbstractModel
    {
        private ImageSource _imagem;
        private string _descricao;
        private string _referecia;
        private string _cor;
        private string _quantidade;
        private decimal _preco;

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

        public string Quantidade
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