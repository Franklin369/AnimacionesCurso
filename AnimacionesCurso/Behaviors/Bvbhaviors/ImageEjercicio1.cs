using System;
using System.Collections.Generic;
using System.Text;

using Xamarin.Forms;
namespace AnimacionesCurso.Behaviors.Bvbhaviors
  {
  public class ImageEjercicio1 : Behavior<View>
    {
    View _vista;
    public static readonly BindableProperty ScrollDataProperty = BindableProperty.Create(nameof(ScrollData),typeof(double),typeof(ImageEjercicio1),default(double),propertyChanged: OnScrollDataChanged);

    static void OnScrollDataChanged(BindableObject bindable,object oldValue,object newValue)
      {
      var instance = (ImageEjercicio1)bindable;
      instance.ScrollTo((double)newValue);
      }
    void ScrollTo(double newValue)
      {
      //+  -
      var x = (newValue*-1);
      _vista.TranslateTo(x,0,1,Easing.SinIn);
      }
    public double ScrollData
      {
      get => (double)GetValue(ScrollDataProperty);
      set => SetValue(ScrollDataProperty,value);

      }
    protected override void OnAttachedTo(View bindable)
      {
      base.OnAttachedTo(bindable);
      _vista=bindable;
      bindable.BindingContextChanged+=Bindable_BindingContextChanged;
      }
    protected override void OnDetachingFrom(View bindable)
      {
      base.OnDetachingFrom(bindable);
      _vista.BindingContextChanged-=Bindable_BindingContextChanged;
      }
    private void Bindable_BindingContextChanged(object sender,EventArgs e)
      {
      BindingContext=_vista.BindingContext;
      }
    }
  }