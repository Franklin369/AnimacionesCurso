using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

using Xamarin.Forms;

namespace AnimacionesCurso.Convertidores.Vbehaviors
  {
  public class ConvertidordeComparacion : IValueConverter
    {
    public object Convert(object value,Type targetType,object parameter,CultureInfo culture)
      {
      var formato = new NumberFormatInfo();
      formato.NegativeSign="-";
      var parametros = ((string)parameter).Split(';');
      var factorAcomparar = Double.Parse(parametros[0],formato);
      var Signocomparacion = parametros[1];
      switch(Signocomparacion)
        {
        case "<":
          return ((double)value)<factorAcomparar;
        case ">":
          return ((double)value)>factorAcomparar;
        case "!=":
          return ((double)value)!=factorAcomparar;
        case "==":
        default:
          return ((double)value)==factorAcomparar;

        }
      }

    public object ConvertBack(object value,Type targetType,object parameter,CultureInfo culture)
      {
      return null;
      }
    }
  }
