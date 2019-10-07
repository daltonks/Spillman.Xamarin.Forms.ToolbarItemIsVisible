# Spillman.Xamarin.Forms.ToolbarItemIsVisible
Until Xamarin Forms provides an `IsVisible` property for `ToolbarItem`, this attached property can be used.

Example:
```
<ContentPage ...
             xmlns:tbiv="clr-namespace:Spillman.Xamarin.Forms;assembly=Spillman.Xamarin.Forms.ToolbarItemIsVisible">
    
    <ContentPage.ToolbarItems>
        <ToolbarItem tbiv:ToolbarItemIsVisible.IsVisible="{Binding IsToolbarItemVisible}" />
    </ContentPage.ToolbarItems>

</ContentPage>
```