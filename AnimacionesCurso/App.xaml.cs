using System;

using AnimacionesCurso.Vistas;
using AnimacionesCurso.Vistas.Vbehaviors;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AnimacionesCurso
  {
  public partial class App : Application
    {
    public App()
      {
      InitializeComponent();

      MainPage=new Ejercicio2();
      }

    protected override void OnStart()
      {
      }

    protected override void OnSleep()
      {
      }

    protected override void OnResume()
      {
      }
    }
  }
