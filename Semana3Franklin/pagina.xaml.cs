using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana3Franklin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class pagina : ContentPage
    {
        public pagina()
        {
            InitializeComponent();
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {



            double notaSeguimiento = 0, examen = 0, parcial = 0, notaSeguimiento2 = 0, examen2 = 0, parcial2 = 0, notaFinal = 0;
            string estado = "";
            try
            {
                notaSeguimiento = Convert.ToDouble(txtSeguimiento.Text);
                examen = Convert.ToDouble(txtExamen.Text);
                parcial = (notaSeguimiento * 0.3) + (examen * 0.2);
                lblNotaParcial.Text = parcial.ToString();
                notaSeguimiento2 = Convert.ToDouble(txtSeguimiento2.Text);
                examen2 = Convert.ToDouble(txtExamen2.Text);
                parcial2 = (notaSeguimiento2 * 0.3) + (examen2 * 0.2);
                lblNotaParcial2.Text = parcial2.ToString();
                notaFinal = parcial + parcial2;
                lblNota.Text = notaFinal.ToString();
                if (notaFinal >= 7)
                {
                    estado = "APROBADO";
                }
                else if (notaFinal >= 5 && notaFinal <= 6.9)
                {
                    estado = "COMPLEMENTARIO";
                }
                else
                {
                    estado = "REPROBADO";



                }
                DisplayAlert("RESULTADO", "El estado es :" + estado, "OK"); ;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }







}
  