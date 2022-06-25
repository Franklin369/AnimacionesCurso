using System;
using System.Collections.Generic;
using System.Text;

using Xamarin.Forms;

namespace AnimacionesCurso.Triggers.Animaciones
  {
  public class Sacudir : TriggerAction<View>
    {
    protected override async void Invoke(View sender)
      {
      uint tiempo = 50;
      await sender.TranslateTo(-15,0,tiempo);
      await sender.TranslateTo(15,0,tiempo);
      await sender.TranslateTo(-10,0,tiempo);
      await sender.TranslateTo(10,0,tiempo);
      await sender.TranslateTo(-5,0,tiempo);
      await sender.TranslateTo(5,0,tiempo);
      sender.TranslationX=0;
      }
    }
  }
