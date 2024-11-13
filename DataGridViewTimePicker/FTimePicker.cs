using DataGridViewTimePicker.Model;
using System.ComponentModel;

namespace DataGridViewTimePicker
{
    public partial class FTimePicker : Form
    {
        public FTimePicker()
        {
            InitializeComponent();
        }

        private void FTimePicker_Load(object sender, EventArgs e)
        {
            BindingList<Car> cars = new BindingList<Car>();

            cars.Add(new Car(DateTime.Now.AddDays(-15), "Ford", "Mustang", 1967, Convert.ToDateTime("10:25")));
            cars.Add(new Car(DateTime.Now.AddDays(-3), "Shelby AC", "Cobra", 1965, Convert.ToDateTime("10:20")));
            cars.Add(new Car(DateTime.Now.AddDays(-5), "Chevrolet", "Corvette Sting Ray", 1965, Convert.ToDateTime("10:15")));
            dgData.DataSource = cars;
        }
    }
}
