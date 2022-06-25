using System;
using System.Collections.Generic;
using System.Text;

using Xamarin.Forms;
namespace AnimacionesCurso.Triggers.Animaciones
  {
  public class Rotacioninfinita : TriggerAction<View>
    {
    public bool estado { get; set; }
    protected override void Invoke(View sender)
      {
      var page = (App.Current.MainPage);
      if (estado==true)
        {

        var rotacion = new Animation(v => sender.Rotation=v,0,360);
        rotacion.Commit(page,"rotacionInfinita",16,1000,Easing.Linear,(v,c) => sender.Rotation=0,() => true);
        }
      else
        {
        page.AbortAnimation("rotacionInfinita");
        }

      }
    }
  }
