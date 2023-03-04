using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FormularioApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void cbox_terminos_CheckedChanged(Object sender, CheckedChangedEventArgs e)
        {
            if (cbox_terminos.IsChecked)
                btn_registrar.IsEnable = true;
            else
                btn_registrar.IsEnable = false;
        }

        private void btn_registar_clicked(Object sender, EventArgs e)
        {
            if (Lbl_password == Lbl_password2)
            {
                limpiarRegistros();

            }

        }
        private void sw_example_Toggled(Object sender, ToggledEventArgs e)
        {

        }
        private void lbl_nombre_Completed(Object sender, EventArgs e)
        {
            progress.ProgressTo(.25, 250, Easing.Linear);
            lbl_progress.Text = "25%";

        }
        private void lbl_nombre_Textchanged(Object sender, TextChangedEventArgs e)
        {
            string nombre = Lbl_nombre.Text.ToString();
            string cadena = $"Bienvenido{nombre}.Llene sus datos";
            lbl_principal.Text = cadena;
        }
        private void lbl_correo_compled(Object sender, EventArgs e)
        {
            progress.ProgressTo(.5, 250, Easing.Linear);
            lbl_progress.Text = "50%";
        }
        private void lbl_password_compled(Object sender, EventArgs e)
        {
            progress.ProgressTo(.75, 250, Easing.Linear);
            lbl_progress.Text = "75%";
        }
        private void lbl_password2_compled(Object sender, EventArgs e)
        {
            progress.ProgressTo(.1, 250, Easing.Linear);
            lbl_progress.Text = "100%";

        }
    }
}
