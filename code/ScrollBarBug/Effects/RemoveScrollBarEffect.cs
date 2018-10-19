using System;

using Xamarin.Forms;

namespace ScrollBarBug.Effects
{
    public class RemoveScrollBarEffect : RoutingEffect
    { 
        public RemoveScrollBarEffect() : base($"{nameof(ScrollBarBug)}.{nameof(Effects)}.{nameof(RemoveScrollBarEffect)}")
        {
            /*
             * Side Note:
             * 
             * Effects are horrible to declare and use, there needs to be a better way of declaring them as opposed to inputting a string (See my attempt above, can't be done in the platform implementation though).
             * 
             * This can lead to SO MANY avoidable errors such as mistakes and also really harms the refactoring process.
             * 
             * This is C#, not Javascript :)
             */
        }
    }
}