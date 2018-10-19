using System;

using Foundation;
using UIKit;

using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

using ScrollBarBug.iOS.Effects;

[assembly: ResolutionGroupName("ScrollBarBug.Effects")]
[assembly: ExportEffect(typeof(RemoveScrollBarEffect), nameof(RemoveScrollBarEffect))]

namespace ScrollBarBug.iOS.Effects
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
                var scrollView = (UIScrollView)Control;

                if (scrollView != null)
                {
                    scrollView.ShowsHorizontalScrollIndicator = !hide;
                    scrollView.ShowsVerticalScrollIndicator = !hide;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"RemoveScrollBarEffect - iOS - HideScrollBar - Error:'{ex.Message}'");
            }
        }
    }
}
