using static System.Net.Mime.MediaTypeNames;

namespace TipTime
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void quinzePorcento_Clicked(object sender, EventArgs e)
        {
            porcentagemSlider.Value = 15;
        }
        private void vinteporcento_Clicked(object sender, EventArgs e)
        {
            string Texto = ValorGorjetaEntry.Text;
            porcentagemSlider.Value = 20;
            double num = Double.Parse(Texto);
            double porcento = num * ( porcentagemSlider.Value / 100);

            GorjetaFinal.Text = $"Gorjeta: R$ {porcento:F2}";

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
