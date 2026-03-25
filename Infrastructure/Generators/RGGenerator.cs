using System.Text;
using GeneratorFakeData.Domain.Interfaces.Generators;

namespace GeneratorFakeData.Infrastructure.Generators
{
    public class RGGenerator : IRGGenerator
    {
        private readonly Random random = new Random();

        public string Generate()
        {
            int[] digits = new int[8];

            for (int i = 0; i < 8; i++)
            {
                digits[i] = random.Next(0, 10);
            }

            if (digits.All(d => d == digits[0]))
            {
                return Generate();
            }

            int[] weights = { 2, 3, 4, 5, 6, 7, 8, 9 };

            int sum = 0;
            for (int i = 0; i < 8; i++)
            {
                sum += digits[i] * weights[i];
            }

            int remainder = sum % 11;
            string checkDigit = remainder == 10 ? "X" : remainder.ToString();
            string baseRg = string.Concat(digits);

            return $"{baseRg}-{checkDigit}";
        }
    }
}
