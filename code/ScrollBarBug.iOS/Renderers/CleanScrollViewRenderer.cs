using System;
using System.ComponentModel;

using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

using ScrollBarBug.Controls;
using ScrollBarBug.iOS.Renderers;

[assembly: ExportRenderer(typeof(CleanScrollView), typeof(CleanScrollViewRenderer))]

namespace ScrollBarBug.iOS.Renderers
{
    public class CleanScrollViewRenderer : ScrollViewRenderer
    {
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

            this.ShowsHorizontalScrollIndicator = false;
            this.ShowsVerticalScrollIndicator = false;
        }
    }
}
