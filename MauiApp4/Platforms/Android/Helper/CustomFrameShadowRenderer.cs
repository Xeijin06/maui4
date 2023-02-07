using Android.Content;
using MauiApp4.Droid.Renderers;
using MauiApp4.Helper;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: ExportRenderer(typeof(CustomFrame), typeof(CustomFrameShadowRenderer))]
namespace MauiApp4.Droid.Renderers
{
    public class CustomFrameShadowRenderer : Microsoft.Maui.Controls.Handlers.Compatibility.FrameRenderer
    {
        public CustomFrameShadowRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Frame> e)
        {
            base.OnElementChanged(e);
            var element = e.NewElement as CustomFrame;


            if (element == null) return;

            if (element.HasShadow)
            {
                Android.Graphics.Color color = new Android.Graphics.Color(0, 0, 0, 255);
                
                SetOutlineSpotShadowColor(color);
                SetOutlineAmbientShadowColor(color);
                Elevation = 30.0f;
                TranslationZ = 0.0f;
                SetZ(30f);
            }

        }

    }
}
