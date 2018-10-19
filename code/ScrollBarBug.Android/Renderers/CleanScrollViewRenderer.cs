using System;
using System.ComponentModel;

using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Runtime;
using Android.Views;

using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

using ScrollBarBug.Controls;
using ScrollBarBug.Droid.Renderers;

[assembly: ExportRenderer(typeof(CleanScrollView), typeof(CleanScrollViewRenderer))]

namespace ScrollBarBug.Droid.Renderers
{
    /// <summary>
    /// Clean scroll view renderer.
    /// </summary>
    public class CleanScrollViewRenderer : ScrollViewRenderer
    {
        public CleanScrollViewRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

            this.VerticalScrollBarEnabled = false;
            this.HorizontalScrollBarEnabled = false;
        }
    }
}
