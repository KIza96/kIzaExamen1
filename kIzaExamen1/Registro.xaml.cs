using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace kIzaExamen1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro(String usuario)
        {
            InitializeComponent();
            lblUsuario.Text = usuario;
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            try
            {
                double montoInicial = Convert.ToDouble(txtMonto.Text);
                double Pago = (400 - montoInicial) / 5 + 5 % 4000;

                txtPago.Text = Pago.ToString();

            }
            catch (Exception ex)
            {

                DisplayAlert("Alerta", ex.ToString(), "Cerrar");

            }
          

        }

        private void btnGuardar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Resumen(lblUsuario.Text, txtNombre.Text, txtPago.Text));
        }
    }
}