using System.ComponentModel;

namespace DataGridViewTimePicker.Model
{
    public class Car : INotifyPropertyChanged
    {
        private string _make;
        private string _model;
        private int _year;
        private DateTime _date;
        private DateTime _time;

        public event PropertyChangedEventHandler PropertyChanged;

        public Car(string make, string model, int year)
        {
            _make = make;
            _model = model;
            _year = year;
        }

        public Car(DateTime date, string make, string model, int year)
        {
            _date = date;
            _make = make;
            _model = model;
            _year = year;
        }

        public Car(DateTime date, string make, string model, int year, DateTime time)
        {
            _date = date;
            _make = make;
            _model = model;
            _year = year;
            _time = DateTime.Parse(time.ToString("hh:mm", System.Globalization.CultureInfo.InvariantCulture));
        }

        public string Make
        {
            get { return _make; }
            set
            {
                _make = value;
                this.NotifyPropertyChanged("Make");
            }
        }

        public string Model
        {
            get { return _model; }
            set
            {
                _model = value;
                this.NotifyPropertyChanged("Model");
            }
        }

        public int Year
        {
            get { return _year; }
            set
            {
                _year = value;
                this.NotifyPropertyChanged("Year");
            }
        }

        public DateTime Date
        {
            get { return _date; }
            set
            {
                _date = value;
                this.NotifyPropertyChanged("Date");
            }
        }

        public DateTime Time
        {
            get { return _time; }
            set
            {
                _time = value;
                this.NotifyPropertyChanged("Time");
            }
        }

        private void NotifyPropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}
