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

namespace WpfApp2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void txtEditor_SelectionChanged(object sender,RoutedEventArgs e)
        {
            int row = txtEditor.GetLineIndexFromCharacterIndex.(txtEditor.CaretIndex);
            int col = txtEditor.CareIndex - txtEditor.GetCharacterIndexFromLineIndex(row);
            IbCursorPosition.Text = "Linea" + (row + 1) + ",Letra" + (col + 1);
            PbLleno.Value = col + 10;
        }
    }
}
