var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

static string Password_Generator(int length) 
        {
            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%?&*()";
            var random = new Random(); //Initialize random generator 
            var password = new char[length];

            for (int i =0; i < length; i++) // Loop for the password length
            {
                password[i] = characters[random.Next(characters.Length)];
            }

            return new string(password);

}

app.MapGet("/{length}", (int length) => Password_Generator(length));

app.Run();

