using System;

using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

using Android.Graphics.Drawables;

using ScrollBarBug.Droid.Effects;

[assembly: ResolutionGroupName("ScrollBarBug.Effects")]
[assembly: ExportEffect(typeof(RemoveScrollBarEffect), nameof(RemoveScrollBarEffect))]

namespace ScrollBarBug.Droid.Effects
{
    public class RemoveScrollBarEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            HideScrollBar(true);
        }

        protected override void OnDetached()
        {
            HideScrollBar(false);
        }

        /// <summary>
        /// Hides the scroll bar.
        /// </summary>
        /// <param name="hide">If set to <c>true</c> hide.</param>
        private void HideScrollBar(bool hide)
        {
            try
            {
                var scrollView = (Android.Widget.ScrollView)Control;

                if (scrollView != null)
                {
                    //scrollView.VerticalScrollBarEnabled = !hide;
                    //scrollView.HorizontalScrollBarEnabled = !hide;
                    scrollView.VerticalScrollBarEnabled = false;
                    scrollView.HorizontalScrollBarEnabled = false;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"RemoveScrollBarEffect - Android - HideScrollBar - Error:'{ex.Message}'");
            }
        }
    }
}
