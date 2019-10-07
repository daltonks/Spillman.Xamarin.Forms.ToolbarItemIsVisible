using Xamarin.Forms;

namespace Spillman.Xamarin.Forms
{
    public class ToolbarItemIsVisible
    {
        public static readonly BindableProperty IsVisibleProperty = BindableProperty.CreateAttached(
            "IsVisible", 
            typeof(bool), 
            typeof(ToolbarItemIsVisible), 
            true,
            propertyChanged: OnIsVisibleChanged
        );

        public static bool GetIsVisible(BindableObject view)
        {
            return (bool)view.GetValue(IsVisibleProperty);
        }

        public static void SetIsVisible(BindableObject view, bool value)
        {
            view.SetValue(IsVisibleProperty, value);
        }

        private static void OnIsVisibleChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var toolbarItem = bindable as ToolbarItem;

            if (toolbarItem == null)
            {
                return;
            }

            var isVisible = (bool) newValue;

            Device.BeginInvokeOnMainThread(() => {
                var page = toolbarItem.GetAncestor<Page>();
                if (page == null)
                {
                    return;
                }

                var toolbarItems = page.ToolbarItems;

                if (isVisible && !toolbarItems.Contains(toolbarItem))
                {
                    toolbarItems.Add(toolbarItem);
                }
                else if (!isVisible && toolbarItems.Contains(toolbarItem))
                {
                    toolbarItems.Remove(toolbarItem);
                }
            });
        }
    }
}
