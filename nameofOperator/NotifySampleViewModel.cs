using System.ComponentModel;

namespace nameof
{
    class NotifySampleViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _title;
        public string Title
        {
            get { return _title; }
            set
            {
                if (value != _title)
                {
                    _title = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Title"));
                    }
                }
            }
        }

        private double _orderAmount;
        public double OrderAmount
        {
            get { return _orderAmount; }
            set
            {
                if (value != _orderAmount)
                {
                    _orderAmount = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("OrderAmount"));
                    }
                }
            }
        }

    }

    #region CSharp6 Working Code
    //class NotifySampleViewModelCSharp6 : INotifyPropertyChanged
    //{
    //    public event PropertyChangedEventHandler PropertyChanged;

    //    private string _title;
    //    public string Title
    //    {
    //        get { return _title; }
    //        set
    //        {
    //            if (value != _title)
    //            {
    //                _title = value;
    //                if (PropertyChanged != null)
    //                {
    //                    PropertyChanged(this, new PropertyChangedEventArgs("Title"));
    //                }
    //            }
    //        }
    //    }

    //    private double _orderAmount;
    //    public double OrderAmount
    //    {
    //        get { return _orderAmount; }
    //        set
    //        {
    //            if (value != _orderAmount)
    //            {
    //                _orderAmount = value;
    //                if (PropertyChanged != null)
    //                {
    //                    PropertyChanged(this, new PropertyChangedEventArgs("OrderAmount"));
    //                }
    //            }
    //        }
    //    }

    //}
    #endregion

}
