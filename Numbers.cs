using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Threading;
using System.Runtime.CompilerServices;
using System.Windows.Threading;

namespace MultiThread
{
    public  class Numbers:INotifyPropertyChanged
    {
        private string _valueF;
        private int _minF;
        private int _topF;
        private string _valueP;
        private int _minP;
        private int _topP;
        public string ValueSth
        {
            get
            {
                return _valueP;
            }
            set
            {
                _valueP = value;
                NotifyPropertyChanged(nameof(ValueSth));
            }
        }

        public int MinSth
        {
            get
            {
                return _minP;
            }
            set
            {
                _minP = value;
                NotifyPropertyChanged(nameof(MinSth));
            }
        }
        public int TopSth
        {
            get
            {
                return _topP;
            }
            set
            {
                _topP = value;
                NotifyPropertyChanged(nameof(TopSth));
            }
        }
        public string ValueFTh { 
            get { 
                return _valueF;
            }
           
            set { 
                _valueF = value;
                NotifyPropertyChanged(nameof(ValueFTh));
            } }
        public int BottomFTh
        {
            get
            {
                return _minF;
            }
            set
            {
                _minF = value;
                NotifyPropertyChanged(nameof(BottomFTh));
            }
        }
        public int TopFTh
        {
            get { return _topF; }
            set
            {
                _topF = value;
                NotifyPropertyChanged(nameof(TopFTh));
            }
        }
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public event PropertyChangedEventHandler? PropertyChanged;

        public  void GenerateFibanacci(object ?data)
        {
            int a = 0, b = this.BottomFTh, c = 0;
            while ((a + b )< this.TopFTh)
            {
                c = a + b;
                a = b;
                b = c;
                Thread.Sleep(1000);
                ValueFTh = c.ToString();
            }
        }
        public void GeneratePrimary(object? data)
        {
            for(int i = this.MinSth;i<this.TopSth;i++) {
                bool IsPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if(i%j== 0)
                    {
                        IsPrime=false;
                        break;
                    }
                }
                if (IsPrime)
                {
                    this.ValueSth=i.ToString();
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
