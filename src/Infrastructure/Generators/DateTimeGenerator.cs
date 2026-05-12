using GeneratorFakeData.Domain.Interfaces;
using GeneratorFakeData.Domain.Interfaces.Generators;

namespace GeneratorFakeData.Infrastructure.Generators
{
    public class DateTimeGenerator : IDateTimeGenerator
    {
        private readonly Random random = new Random();

        public DateTime Generate()
        {
            DateTime startDate = new DateTime(1960, 1, 1);
            DateTime endDate = new DateTime(2015, 1, 1);

            int daysRange = (endDate - startDate).Days;

            DateTime randomDate = startDate.AddDays(this.random.Next(daysRange));

            return randomDate;
        }
    }
}
