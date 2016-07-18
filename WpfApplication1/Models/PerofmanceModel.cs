using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1.Models
{
    public class PerofmanceModel : VmBase
    {
        private int _nymber;

        public int Number
        {
            get { return _nymber; }
            set
            {
                _nymber = value;
                NotifyPropertyChanged();

            }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                NotifyPropertyChanged();
            }
        }

    }
}
