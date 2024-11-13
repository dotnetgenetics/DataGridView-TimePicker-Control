namespace DataGridViewTimePicker.TimePicker
{
    public class TimeColumn : DataGridViewColumn
    {
        public TimeColumn()
            : base(new TimeCell())
        {

        }

        public override DataGridViewCell CellTemplate
        {
            get
            {
                return base.CellTemplate;
            }
            set
            {
                //Ensure that the cell used for the template is a TimeCell. 
                if (value != null &&
                    !value.GetType().IsAssignableFrom(typeof(TimeCell)))
                {
                    throw new InvalidCastException("Must be a TimeCell");
                }

                base.CellTemplate = value;
            }
        }
    }
}
