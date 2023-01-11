using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace kIzaExamen1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciar_Clicked(object sender, EventArgs e)
        {
            string usuario = "estudiante2023";
            string contrasena = "uisrael2023";
            if (usuario == txtUsuario.Text && contrasena == txtContrasena.Text)
            {
                Navigation.PushAsync(new Registro());
            }
            else
            {
                DisplayAlert("Alerta", "Usuario/Contraseña Incorrectos", "Cerrar");
            
        }
    }
}
}