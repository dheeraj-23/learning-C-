namespace Practice
{
    internal class Encapsulation
    {
        private int empExpYear;
        public int EmpExp {
            get { return empExpYear; }
            set
            {
                if (value >= 0)
                {
                    empExpYear = value;
                }
                else
                {
                    throw new ArgumentException("Experience years cannot be negative.");
                }
            }
        }

        public void GetExperience()
        {
            Console.WriteLine($"Experience is: {empExpYear} years");
        }
    }
}
