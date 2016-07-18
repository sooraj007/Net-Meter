using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using WpfApplication1.Models;

namespace WpfApplication1.ViewModels
{
    public class MainVm
    {
        PerformanceCounter theCPUCounter;
        DispatcherTimer timer = new DispatcherTimer();

        public MainVm()
        {
            theCPUCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");

            Errors = new ObservableCollection<PerofmanceModel>();
            Errors.Add(new PerofmanceModel() { Name = "Cpu Usage", Number = 1 });



            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            Errors[0].Number = (int)theCPUCounter.NextValue();
            //Errors.Add(new PerofmanceModel() { Name = "China", Number = (int)theCPUCounter.NextValue() });
        }


        public ObservableCollection<PerofmanceModel> Errors { get; private set; }
    }
}
