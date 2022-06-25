using System;
using System.Collections.Generic;
using System.Text;

using Xamarin.Forms;

namespace AnimacionesCurso.Controles.Vbehaviors
  {
  public class ScrollerView : ScrollView
    {
    #region CONSTRUCTOR
    public ScrollerView()
      {
      Scrolled+=ScrollerView_Scrolled;
      }
    #endregion
    #region EVENTOS
    private void ScrollerView_Scrolled(object sender,ScrolledEventArgs e)
      {
      ScrollPosicion=e.ScrollY;
      ScrollPorcentaje=e.ScrollY/ContentSize.Height;
      }
    #endregion
    #region PROPIEDADES ENLAZABLES
    public static readonly BindableProperty ScrollPositionProperty = BindableProperty.Create(nameof(ScrollPosicion),typeof(double),typeof(ScrollerView),default(double));
    public static readonly BindableProperty ScrollPorcentajeProperty = BindableProperty.Create(nameof(ScrollPorcentaje),typeof(double),typeof(ScrollerView),default(double));
    #endregion
    #region PROPIEDADES EXPORTABLES
    public double ScrollPosicion
      {
      get { return (double)GetValue(ScrollPositionProperty); }
      set { SetValue(ScrollPositionProperty,value); }
      }
    public double ScrollPorcentaje
      {
      get { return (double)GetValue(ScrollPorcentajeProperty); }
      set { SetValue(ScrollPorcentajeProperty,value); }
      }

    #endregion
    }
  }
