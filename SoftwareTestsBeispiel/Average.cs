namespace SoftwareTestsBeispiel
{
    public class Average
    {
        public double Median(List<int> numbers)
        {
            if (numbers.Count == 0)
            {
                throw new ArgumentException("Die Zahlenliste darf nicht leer sein.");
            }

            numbers.Sort();

            int size = numbers.Count;
            int middle = size / 2;

            if (size % 2 != 0)
            {
                return numbers[middle];
            }
            double middle1 = numbers[middle - 1];
            double middle2 = numbers[middle];
            return (middle1 + middle2) / 2;
        }
    }
}
