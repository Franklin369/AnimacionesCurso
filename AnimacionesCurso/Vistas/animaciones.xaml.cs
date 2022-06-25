using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

using AnimacionesCurso.VistaModelo;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AnimacionesCurso.Vistas
  {
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class animaciones : ContentPage
    {
    public animaciones()
      {
      InitializeComponent();
      BindingContext=new VManimaciones(Navigation);
      }

    private async void btnRotar_Clicked(object sender,EventArgs e)
      {
      await Frame.RotateTo(90,1000,Easing.BounceOut);
      await Frame.RotateTo(0,1000,Easing.BounceOut);
      }

    private async void btntranslate_Clicked(object sender,EventArgs e)
      {
      await Frame.TranslateTo(100,0,500,Easing.SpringOut);
      await Frame.TranslateTo(100,-100,500,Easing.SpringOut);
      await Frame.TranslateTo(0,0,500,Easing.SpringOut);
      }

    private async void btnscale_Clicked(object sender,EventArgs e)
      {
      await Frame.ScaleTo(2,1000);
      await Frame.ScaleTo(0.5,1000);
      await Frame.ScaleTo(1,1000);
      }

    private async void btnfade_Clicked(object sender,EventArgs e)
      {
      await Frame.FadeTo(0,1000);
      await Frame.FadeTo(1,1000);

      }

    private async void btnrotatex_Clicked(object sender,EventArgs e)
      {
      await Frame.RotateXTo(180,1000);
      await Frame.RotateXTo(0,1000);

      }

    private async void rotatey_Clicked(object sender,EventArgs e)
      {
      await Frame.RotateYTo(180,1000);
      await Frame.RotateYTo(0,1000);
      }
    }
  }