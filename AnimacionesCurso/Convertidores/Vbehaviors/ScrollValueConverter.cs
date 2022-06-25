using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

using Xamarin.Forms;

namespace AnimacionesCurso.Convertidores.Vbehaviors
  {
  public class ScrollValueConverter : IValueConverter
    {
    public object Convert(object value,Type targetType,object parameter,CultureInfo culture)
      {
      //-10;0;200;false;0
      var formato = new NumberFormatInfo();
      formato.NegativeSign="-";
      var porcentaje = (double)value;
      var parametros = ((string)parameter).Split(';');
      var factor = Double.Parse(parametros[0],formato);//-10
      var min = Double.Parse(parametros[1]);//0
      var max = Double.Parse(parametros[2]);//200
      var reversa =bool.Parse(parametros[3]);//false
      var retrasoHastaPorcentaje = Double.Parse(parametros[4]);//0
      if(porcentaje==0) return min;
      if(retrasoHastaPorcentaje>0&&porcentaje<retrasoHastaPorcentaje) return min;
      porcentaje=porcentaje-retrasoHastaPorcentaje;
      if(reversa)
        {
        porcentaje=1-(porcentaje*factor);//1-(0.3*-10) = 4
        return (porcentaje*max);//800
        }
      else
        {
        return (porcentaje*max)*factor;//-600
        }
      



      }

    public object ConvertBack(object value,Type targetType,object parameter,CultureInfo culture)
      {
      return null;
      }
    }
  }
