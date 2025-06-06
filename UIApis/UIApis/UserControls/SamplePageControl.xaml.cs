using Microsoft.UI.Xaml.Markup;

namespace UIApis.UserControls;

[ContentProperty(Name = nameof(Sample))]
public sealed partial class SamplePageControl : UserControl
{
    public SamplePageControl()
    {
        this.InitializeComponent();
    }

    public string Title
    {
        get => (string)GetValue(TitleProperty);
        set => SetValue(TitleProperty, value);
    }

    public static DependencyProperty TitleProperty { get; } =
        DependencyProperty.Register(nameof(Title), typeof(string), typeof(SamplePageControl), new PropertyMetadata(""));

    public Uri IconUri
    {
        get => (Uri)GetValue(IconUriProperty);
        set => SetValue(IconUriProperty, value);
    }

    public static readonly DependencyProperty IconUriProperty =
        DependencyProperty.Register(nameof(IconUri), typeof(Uri), typeof(SamplePageControl), new PropertyMetadata(null));

    public Uri DocsUri
    {
        get => (Uri)GetValue(DocsUriProperty);
        set => SetValue(DocsUriProperty, value);
    }

    public static readonly DependencyProperty DocsUriProperty =
        DependencyProperty.Register(nameof(DocsUri), typeof(Uri), typeof(SamplePageControl), new PropertyMetadata(null));

    public object Sample
    {
        get => (object)GetValue(SampleProperty);
        set => SetValue(SampleProperty, value);
    }

    public static DependencyProperty SampleProperty { get; } =
        DependencyProperty.Register(nameof(Sample), typeof(object), typeof(SamplePageControl), new PropertyMetadata(null));

    public string CodeSnippet
    {
        get => (string)GetValue(CodeSnippetProperty);
        set => SetValue(CodeSnippetProperty, value);
    }

    public static DependencyProperty CodeSnippetProperty { get; } =
        DependencyProperty.Register(nameof(CodeSnippet), typeof(string), typeof(SamplePageControl), new PropertyMetadata(""));
}
