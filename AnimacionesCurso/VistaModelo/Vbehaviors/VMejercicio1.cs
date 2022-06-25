using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Xamarin.Forms;

namespace AnimacionesCurso.VistaModelo.Vbehaviors
  {
  public class VMejercicio1 : BaseViewModel
    {
    #region VARIABLES
    double _posicionenPantalla;

    #endregion
    #region CONSTRUCTOR
    public VMejercicio1(INavigation navigation)
      {
      Navigation=navigation;
      }
    #endregion
    #region OBJETOS
    public double PosicionenPantalla
      {
      get { return _posicionenPantalla; }
      set { SetValue(ref _posicionenPantalla,value); }


      }
    #endregion
    #region PROCESOS
    private void IniciarScroll(double posicion)
      {
      PosicionenPantalla=posicion;
      }
    #endregion
    #region COMANDOS
    public ICommand Scrollcommand => new Command<double>(IniciarScroll);
    #endregion
    }
  }
