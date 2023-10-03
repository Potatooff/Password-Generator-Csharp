namespace Program
{
    class Program
    {
        static void Main()
        {
            int length = 10; // Change this to change the password length
            Console.WriteLine("Hello World!");
            Console.WriteLine(Password_Generator(length));

        }

        public static string Password_Generator(int length) 
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
    }
}