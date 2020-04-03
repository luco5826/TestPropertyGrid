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

namespace TestPropertyGrid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MyObject Container { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            DataContext = this;

            // Container creation
            Container = new MyObject();

            // Add Circular dependending elements
            Container.Elements = new List<SubObj> { new SubObj() { Parent = Container }, new SubObj() { Parent = Container } };
        }
    }
}
