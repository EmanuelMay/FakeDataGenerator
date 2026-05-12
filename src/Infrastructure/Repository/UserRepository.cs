namespace GeneratorFakeData.Infrastructure.Repository
{
    using System.Text.Json;
    using GeneratorFakeData.Domain.Interfaces.Repository;
    using GeneratorFakeData.Domain.Models;

    public class UserRepository : IUserRepository
    {
        private readonly string path;

        public UserRepository(string path)
        {
            this.path = path;
        }

        public void Save(UserData user)
        {
            List<UserData> users = new List<UserData>();

            if (File.Exists(path))
            {
                var json = File.ReadAllText(path);

                if (!string.IsNullOrWhiteSpace(json))
                {
                    users = JsonSerializer.Deserialize<List<UserData>>(json) 
                            ?? new List<UserData>();
                }
            }

            users.Add(user);

            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };

            var newJson = JsonSerializer.Serialize(users, options);

            File.WriteAllText(path, newJson);
        }
    }
}
