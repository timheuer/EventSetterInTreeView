using System.Windows;
using System.Windows.Controls;

namespace StyleInTreeView;
public partial class MyToolWindowControl : UserControl
{
    public MyToolWindowControl()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, RoutedEventArgs e)
    {
        VS.MessageBox.Show("StyleInTreeView", "Button clicked");
    }

    private void TreeViewItem_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
    {

    }
}