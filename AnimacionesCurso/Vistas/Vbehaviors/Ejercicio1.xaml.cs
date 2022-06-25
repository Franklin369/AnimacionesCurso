using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AnimacionesCurso.VistaModelo.Vbehaviors;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AnimacionesCurso.Vistas.Vbehaviors
  {
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class Ejercicio1 : ContentPage
    {
    public Ejercicio1()
      {
      InitializeComponent();
      BindingContext=new VMejercicio1(Navigation);
      }
    }
  }