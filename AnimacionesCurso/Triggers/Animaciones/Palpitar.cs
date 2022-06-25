using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace AnimacionesCurso.Triggers.Animaciones
  {
  public class Palpitar : TriggerAction<View>
    {
    public bool estado { get; set; }
    protected override async void Invoke(View sender)
      {
    

      ////var animacion = new Animation(v => sender.Scale=v,2,1);
      ////animacion.Commit(sender,"pulso",rate:1,length: 1000,Easing.Linear,(v,c) => sender.Scale=1,repeat: () => true);
      var animationDownSize = new Animation
(
    callback: e =>
    {
      sender.Scale=e;

      if (e==0.5)
        {
        var animationUpSize = new Animation
        (
            callback: d => sender.Scale=d,
            start:0,
            end: sender.Scale=1,
            easing: Easing.Linear
        );
        animationUpSize.Commit(sender,"UpSize",length: 3000);
        }
    },
    start: sender.Scale,
    end: sender.Scale=0.5,
    easing: Easing.Linear
);
      animationDownSize.Commit(sender,"DownSize",length: 1000,repeat: () => true);
      //var page = (App.Current.MainPage);
      //if (estado==true)
      //  {

      //  var palpitar = new Animation(v => sender.Scale=v,1,1.5);
      //  palpitar.Commit(page,"palpitar",5,2000,Easing.Linear,(v,c) => sender.Scale=1,() => true);
      //  }
      //else
      //  {
      //  page.AbortAnimation("palpitar");
      //  }
      }
    }
  }
