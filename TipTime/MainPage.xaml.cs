using static System.Net.Mime.MediaTypeNames;

namespace TipTime
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void quinzePorcento_Clicked(object sender, EventArgs e)
        {
            porcentagemSlider.Value = 15;
            string Texto = ValorGorjetaEntry.Text;
            double num = Double.Parse(Texto);
            double porcento = num * (porcentagemSlider.Value / 100);
            double total = porcento + num;
            double final = total + num;

            ValorGorjetaLabel.Text = $"R$ {porcento:F2}";
            ValorTotalLabel.Text = $"R$ {num:F2}";
            GorjetaFinal.Text = $"R$ {total:F2}";
            Porcentagem.Text = $"{porcentagemSlider.Value}%";


        }
        private void vinteporcento_Clicked(object sender, EventArgs e)
        {
            porcentagemSlider.Value = 20;
            string Texto = ValorGorjetaEntry.Text;
            double num = Double.Parse(Texto);
            double porcento = num * ( porcentagemSlider.Value / 100);
            double total = porcento + num;
            double final = total + num;
            
            ValorGorjetaLabel.Text = $"R$ {porcento:F2}";
            ValorTotalLabel.Text = $"R$ {num:F2}";
            GorjetaFinal.Text = $"R$ {total:F2}";
            Porcentagem.Text = $"{porcentagemSlider.Value}%";
            

        }


        private void roundDown_Clicked(object sender, EventArgs e)
        {

        }

        private void RoundUp_Clicked(object sender, EventArgs e)
        {

        }

        private void porcentagemSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {

        }
    }

}
