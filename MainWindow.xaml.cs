using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace MultiThread
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Thread thread1;
        private Thread thread2;
        private Numbers numbers;
        public MainWindow()
        {
            InitializeComponent();
            numbers= new Numbers();
            this.DataContext= numbers;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            thread1 = new Thread(numbers.GenerateFibanacci);
            thread2=new Thread(numbers.GeneratePrimary);
        }

        private void bStartFT_Click(object sender, RoutedEventArgs e)
        {
            this.thread1.Start();
        }

        //private void bStopFT_Click(object sender, RoutedEventArgs e)
        //{
        //    this.thread1.Abort();
        //}

        //private void bRefreshFT_Click(object sender, RoutedEventArgs e)
        //{
        //    this.thread1.Interrupt();
        //}

        //private void bPauseFT_Click(object sender, RoutedEventArgs e)
        //{
        //    thread1.Suspend();
        //}

        //private void bResumeFT_Click(object sender, RoutedEventArgs e)
        //{
        //    thread1.Resume();
        //}

        private void bStartST_Click(object sender, RoutedEventArgs e)
        {
            thread2.Start();
        }

        //private void bStopST_Click(object sender, RoutedEventArgs e)
        //{
        //    thread2?.Abort();
        //}

        //private void bPauseST_Click(object sender, RoutedEventArgs e)
        //{
        //    thread2.Suspend();
        //}

        //private void bResumeST_Click(object sender, RoutedEventArgs e)
        //{
        //    thread2.Resume();
        //}

        //private void bRefreshST_Click(object sender, RoutedEventArgs e)
        //{
        //    thread2.Interrupt();
        //}
    }
}
