using Xamarin.Forms;

namespace VijetasNews.CustomRender
{
  public class ExtendedViewCell : ViewCell
  {
    public static readonly BindableProperty SelectedBackgroundColorProperty =
        BindableProperty.Create("SelectedBackgroundColor", 
                                typeof(Color), 
                                typeof(ExtendedViewCell), 
                                Color.FromHex("#303030"));

    public Color SelectedBackgroundColor
    {
      get { return Color.FromHex("#303030"); }
      set { SetValue(SelectedBackgroundColorProperty, value); }
    }
  }
}