using Ejercicio_1_1.modulo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio_1_1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void limpiar()
        {
            txtnumero1.Text = "";
            txtnumero2.Text = "";
        }


    private async void btnSumar_Clicked(object sender, EventArgs e)
    {


      if (await ValidarValoresNumeros() ==true)
      {


        var v_numero1 = Convert.ToDecimal(txtnumero1.Text);
        var v_numero2 = Convert.ToDecimal(txtnumero2.Text);

        Operaciones ope = new Operaciones();
        ope.Numero1 = v_numero1;
        ope.Numero2 = v_numero2;

        var suma = ope.sumar();
        await Navigation.PushAsync(new Resultado( suma ));
        limpiar();

      }
   }
    async private Task<bool> ValidarValoresNumeros()
    {
      bool camposValidados = false;
      if (String.IsNullOrWhiteSpace(txtnumero1.Text) || String.IsNullOrWhiteSpace(txtnumero2.Text))
      { 
        await DisplayAlert("Verifique", "Debe ingresar los digitos en los campos correspondientes.", "OK");
      }
      else
      {
        camposValidados = true;
      }
      return camposValidados; 
    }

    private async void btnRestar_Clicked(object sender, EventArgs e){

      if (await ValidarValoresNumeros())
      {

        var v_numero1 = Convert.ToDecimal(txtnumero1.Text);
        var v_numero2 = Convert.ToDecimal(txtnumero2.Text);

        Operaciones ope = new Operaciones();
        ope.Numero1 = v_numero1;
        ope.Numero2 = v_numero2;

        var resta = ope.restar();  
        await Navigation.PushAsync(new Resultado(resta));

        limpiar();

       }

                 
    } 

        private async void btndividir_Clicked(object sender, EventArgs e)
        {
        if (await ValidarValoresNumeros())
        {
            var v_numero1 = Convert.ToDecimal(txtnumero1.Text);
            var v_numero2 = Convert.ToDecimal(txtnumero2.Text);

            Operaciones ope = new Operaciones();
            ope.Numero1 = v_numero1;
            ope.Numero2 = v_numero2;

            var dividir = ope.dividir();  
            await Navigation.PushAsync(new Resultado(dividir));

            limpiar();
        }

                 

    } 

        private async void btnMultiplicar_Clicked(object sender, EventArgs e)
        {
                if (await ValidarValoresNumeros())
                {
                  var v_numero1 = Convert.ToDecimal(txtnumero1.Text);
                    var v_numero2 = Convert.ToDecimal(txtnumero2.Text);

                    Operaciones ope = new Operaciones();
                    ope.Numero1 = v_numero1;
                    ope.Numero2 = v_numero2;

                    var multi = ope.multiplicar();  
                    await Navigation.PushAsync(new Resultado(multi));

                    limpiar();
                }
 

            } 
    }
}
