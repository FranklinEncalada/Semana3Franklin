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
    public partial class ingreso : ContentPage
    {
        public ingreso()
        {
            InitializeComponent();
        }

        

        private void btningresar_Clicked(object sender, EventArgs e)
        {
            String Susuario = txtUsuario.Text;
            string Spassword = txtPasword.Text;

            if ((Susuario == "estudiante2021") && (Spassword == "uisrael2021"))
            {
                Navigation.PushAsync(new pagina());
            }
            else
            {
                lblResultado.Text = "El Usuario y Password son incorrectos";
            }

        }
    }
}