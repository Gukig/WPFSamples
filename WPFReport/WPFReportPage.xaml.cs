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

namespace WPFReport
{
    /// <summary>
    /// Interaction logic for WPFReportPage.xaml
    /// </summary>
    public partial class WPFReportPage : Page
    {
        public WPFReportPage()
        {
            InitializeComponent();
        }

        public WPFReportPage(object obj):this()
        {
            this.DataContext = obj;
        }
    }
}
