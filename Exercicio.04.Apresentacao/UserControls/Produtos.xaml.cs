using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Exercicio._04.Apresentacao.UserControls
{
    public partial class Produtos : UserControl
    {
        public Produtos()
        {
            InitializeComponent();
        }

        public ImageSource Imagem
        {
            get { return (ImageSource)GetValue(ImagemProperty); }
            set { SetValue(ImagemProperty, value); }
        }

        public static readonly DependencyProperty ImagemProperty = DependencyProperty.Register("Imagem", typeof(ImageSource), typeof(Produtos));


        public string Descricao
        {
            get { return (string)GetValue(DescricaoProperty); }
            set { SetValue(DescricaoProperty, value); }
        }

        public static readonly DependencyProperty DescricaoProperty = DependencyProperty.Register("Descricao", typeof(string), typeof(Produtos));


        public string Referencia
        {
            get { return (string)GetValue(ReferenciaProperty); }
            set { SetValue(ReferenciaProperty, value); }
        }

        public static readonly DependencyProperty ReferenciaProperty = DependencyProperty.Register("Referencia", typeof(string), typeof(Produtos));


        public string Cor
        {
            get { return (string)GetValue(CorProperty); }
            set { SetValue(CorProperty, value); }
        }

        public static readonly DependencyProperty CorProperty = DependencyProperty.Register("Cor", typeof(string), typeof(Produtos));


        public string Quantidade
        {
            get { return (string)GetValue(QuantidadeProperty); }
            set { SetValue(QuantidadeProperty, value); }
        }

        public static readonly DependencyProperty QuantidadeProperty = DependencyProperty.Register("Quantidade", typeof(string), typeof(Produtos));


        public string Preco
        {
            get { return (string)GetValue(PrecoProperty); }
            set { SetValue(PrecoProperty, value); }
        }

        public static readonly DependencyProperty PrecoProperty = DependencyProperty.Register("Preco", typeof(string), typeof(Produtos));
    }
}
