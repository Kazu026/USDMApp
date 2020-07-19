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
using Microsoft.Win32;

namespace USDMApp
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        private Xls xls;
        private Reqire require;
        
        public MainWindow()
        {
           
            InitializeComponent();
            require = new Reqire();

        }

        private void Openfile_Click(object sender, RoutedEventArgs e)
        {
            xls = new Xls();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = "";
            ofd.DefaultExt = "*.*";
            if (ofd.ShowDialog() == true)
            {
                xls.path = ofd.FileName;
            }
            else
            {
                MessageBox.Show("ファイルが指定されていません");
                return;
            }
            xls.Openbook();


            xls.set_require(require);
            column1.Text = require.text;
           


        }
    }
}
