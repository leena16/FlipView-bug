using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace Temp.UserControls
{
    public sealed partial class MyUserControl1 : UserControl
    {
        public MyUserControl1()
        {
            this.InitializeComponent();
        }
        public string textblock
        {
            get { return (string)GetValue(textblockProperty); }
            set { SetValue(textblockProperty, value); }
        }

        // Using a DependencyProperty as the backing store for textblock.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty textblockProperty =
            DependencyProperty.Register("textblock", typeof(string), typeof(MyUserControl1), null);

    }
}
