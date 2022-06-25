using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using AnimacionesCurso.VistaModelo;

using Xamarin.Forms;

namespace AnimacionesCurso.VistaModelo
  {
  public class VManimaciones:BaseViewModel
    {
    #region VARIABLES
    bool _estadoRotar;
    bool _estadoSacudir;
    bool _estadoPalpitar;
    #endregion
    #region CONSTRUCTOR
    public VManimaciones(INavigation navigation)
      {
      Navigation=navigation;
      }
    #endregion
    #region OBJETOS
    public bool EstadoPalpitar
      {
      get { return _estadoPalpitar; }
      set { SetValue(ref _estadoPalpitar,value); }
      }
    public bool EstadoRotar
      {
      get { return _estadoRotar; }
      set { SetValue(ref _estadoRotar,value); }
      }
    public bool EstadoSacudir
      {
      get { return _estadoSacudir; }
      set { SetValue(ref _estadoSacudir,value); }
      }
    #endregion
    #region PROCESOS
    private void Sacudir()
      {
      EstadoSacudir=true;
      EstadoSacudir=false;
      }
    private void Rotarinfinito()
      {
      EstadoRotar=true;
      }

    public void Detenerrotar()
      {
      EstadoRotar=false;
      }
    private void Palpitarinfinito()
      {
      EstadoPalpitar=true;
      }

    public void Detenerpalpitar()
      {
      EstadoPalpitar=false;
      }
    #endregion
    #region COMANDOS
    public ICommand Palpitarcommand => new Command(Palpitarinfinito);
    public ICommand Detenerpalpitarcommand => new Command(Detenerpalpitar);

    public ICommand RotarInfinitocommand => new Command(Rotarinfinito);
    public ICommand Detenercommand => new Command(Detenerrotar);
    public ICommand Sacudircommand => new Command(Sacudir);

    #endregion
    }
  }
