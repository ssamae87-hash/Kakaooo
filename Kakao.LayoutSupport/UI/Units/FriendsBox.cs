using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Unity;

namespace Kakao.LayoutSupport.UI.Units
{

    public class FriendsBox : ListBox
    {
        public static readonly DependencyProperty DoubleClickCommandProperty =
           DependencyProperty.Register(
               nameof(DoubleClickCommand),
               typeof(ICommand),
               typeof(FriendsBox),
               new PropertyMetadata(null));


        public ICommand DoubleClickCommand
        {
            get => (ICommand)GetValue(DoubleClickCommandProperty);
            set => SetValue(DoubleClickCommandProperty, value);
        }


        static FriendsBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FriendsBox), new FrameworkPropertyMetadata(typeof(FriendsBox)));
        }

        protected override void OnMouseDoubleClick(MouseButtonEventArgs e)
        {
            base.OnMouseDoubleClick(e);

            if (e.OriginalSource is FrameworkElement fe && fe.DataContext != null)
            {
                DoubleClickCommand?.Execute(fe.DataContext);
            }



        }
    }
}
