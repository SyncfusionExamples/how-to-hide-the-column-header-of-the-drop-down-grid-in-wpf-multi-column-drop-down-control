using Syncfusion.Data.Extensions;
using Syncfusion.UI.Xaml.TreeGrid;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
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

namespace SfDataGrid_MVVM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.multiColumnDropDown.Loaded += OnMultiColumnDropDown_Loaded;

        }

        private void OnMultiColumnDropDown_Loaded(object sender, RoutedEventArgs e)
        {
            this.multiColumnDropDown.GetDropDownGrid().HeaderRowHeight = 0;
        }
    }
}
