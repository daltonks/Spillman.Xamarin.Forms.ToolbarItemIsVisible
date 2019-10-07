using Xamarin.Forms;

namespace Spillman.Xamarin.Forms
{
    internal static class ElementExtensions
    {
        public static T GetAncestor<T>(this Element element) where T : Element
        {
            var type = typeof(T);

            var ancestor = element.Parent;
            while (true)
            {
                if (ancestor == null)
                {
                    return null;
                }

                if (type.IsInstanceOfType(ancestor))
                {
                    return (T) ancestor;
                }

                ancestor = ancestor.Parent;
            }
        }
    }
}
