using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ChromeWpf
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddTab(object sender, MouseButtonEventArgs e)
        {
            var web = new WebBrowser
            {
                Source = new Uri("https://google.kz")
            };

            var textBlock = new TextBlock
            {
                Text = "Новая вкладка"
            };

            var newTab = new TabItem
            {
                Header = textBlock, 
                Content = web
            };

            var indexAddNewTab = tabs.Items.Count - 1;
            var lastAddNewTab = tabs.Items[indexAddNewTab];

            tabs.Items.RemoveAt(indexAddNewTab);
            tabs.Items.Add(newTab);
            tabs.Items.Add(lastAddNewTab);


        }
    }
}
