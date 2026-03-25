using GeneratorFakeData.Domain.Interfaces.Generators;

namespace GeneratorFakeData.Infrastructure.Generators
{
    public class CPFGenerator : ICPFGenerator
    {
        private readonly Random random = new Random();

        public string Generate()
        {
            int[] digits = new int[11];

            for (int i = 0; i < 9; i++)
            {
                digits[i] = random.Next(0, 10);
            }

            if (digits.Take(9).All(d => d == digits[0]))
            {
                return Generate();
            }

            int sum = 0;
            for (int i = 0; i < 9; i++)
            {
                sum += digits[i] * (10 - i);
            }

            int remainder = sum % 11;
            digits[9] = remainder < 2 ? 0 : 11 - remainder;

            sum = 0;
            for (int i = 0; i < 10; i++)
            {
                sum += digits[i] * (11 - i);
            }

            remainder = sum % 11;
            digits[10] = remainder < 2 ? 0 : 11 - remainder;

            string cpf = string.Concat(digits);

            return $"{cpf.Substring(0, 3)}.{cpf.Substring(3, 3)}.{cpf.Substring(6, 3)}-{cpf.Substring(9, 2)}";
        }
    }
}
