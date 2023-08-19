namespace Chapter3_Debugging_Profiling
{
    public class BreakpointGroupsDemo
    {
        public void Run()
        {
            Console.WriteLine("Write the day of your birth");
            var day = Console.ReadLine();
            Console.WriteLine("Write the month of your birth");
            var month = Console.ReadLine();
            Console.WriteLine("Write the year of your birth");
            var year = Console.ReadLine();

            var birthDate = new DateTime(int.Parse(year), int.Parse(month), int.Parse(day));

            CalculateAge(birthDate);
        }

        void CalculateAge(DateTime birthDate)
        {
            var today = DateTime.Today;
            var age = today.Year - birthDate.Year;
            if (birthDate > today.AddYears(-age)) age--;
            Console.WriteLine($"You are {age} years old");
        }
    }
}
