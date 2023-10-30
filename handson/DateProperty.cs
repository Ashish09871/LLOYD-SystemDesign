namespace oops
{
    public class DateProperty
    {
        private int _month = 8;

        public int Month
        {
            get => _month;
            set
            {
                if ((value > 0) && (value < 13))
                {
                    _month = value;
                }
            }
        }

        ~DateProperty()
        {
            Console.WriteLine("Hello destructor");
        }
    }
}
