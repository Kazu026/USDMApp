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
        private List<USDM> usdmlist = new List<USDM>();
        private USDM usdm;
        private string path;
        private int numofreq;//要求の数

        public MainWindow()
        {
            
            usdm = new USDM();
            usdmlist.Add(usdm);
            InitializeComponent();
            
        }

        private void Openfile_Click(object sender, RoutedEventArgs e)
        {
            numofreq = 0;

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = "";
            ofd.DefaultExt = "*.*";
            if (ofd.ShowDialog() == true)
            {
                path = ofd.FileName;
            }
            else
            {
                MessageBox.Show("ファイルが指定されていません");
                return;
            }
            xls = new Xls();
            xls.Openbook(path);
           usdmlist[0].AddRequireText(xls.read_require(),numofreq);
            
            column1.Text = usdm.getRequireText(numofreq);
           


        }
    }
}
