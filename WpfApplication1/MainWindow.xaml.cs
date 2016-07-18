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
using MahApps.Metro.Controls;
using System.Diagnostics;
using System.Threading;

using System.Windows.Threading;

using FontAwesome;

using System.Collections.ObjectModel;
using WpfApplication1.ViewModels;

namespace WpfApplication
{

    public partial class MainWindow
    {
        float cou = 2;
        PerformanceCounter theCPUCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        public MainWindow()
        {
            InitializeComponent();





            //DispatcherTimer timer = new DispatcherTimer();
            //timer.Interval = TimeSpan.FromSeconds(1);
            //timer.Tick += timer_Tick;
            //timer.Start();

            this.DataContext = new MainVm();//new MainViewModel(cou);

        }
        void timer_Tick(object sender, EventArgs e)
        {

            // label1.Content = theCPUCounter.NextValue();

            Thread.Sleep(1000);
            cou = theCPUCounter.NextValue();

            //label1.Content = theCPUCounter.NextValue();


        }



        private object selectedItem = null;
        public object SelectedItem
        {
            get
            {
                return selectedItem;
            }
            set
            {
                // selected item has changed
                selectedItem = value;
            }
        }
    }

    internal class MainViewModel
    {
        public MainViewModel(float cou)
        {
            Errors = new ObservableCollection<TestClass>();
            Errors.Add(new TestClass() { Name = "China", Number = (int)cou });

        }

        public ObservableCollection<TestClass> Errors { get; private set; }
    }

    // class which represent a data point in the chart
    public class TestClass
    {

        public int Number { get; set; }
        public string Name { get; set; }
    }

}

