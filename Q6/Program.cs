using System;

namespace Q6
{
    class Program
    {
        static void Main(string[] args)
        {


        }
    }
	class User
	{
		private int age;


		public string login
        {
            get
            {
				return login;
            }
			set
            {
				if (login.Length<3)
                {
					Console.WriteLine("Логин должен быть не длинее 3-х символов");
				}
				else
                {
					login = value;
                }
            }
        }
		public string mail
		{
			get
			{
				return mail;
			}
			set
			{
				if (!value.Contains('@'))
				{
					Console.WriteLine("Неверный формат адреса электронной почты");
				}
				else
                {
					mail = value;
                }
			}
		}
		public int Age
		{
			get
			{
				return age;
			}

			set
			{
				if (value < 18)
				{
					Console.WriteLine("Возраст должен быть не меньше 18");
				}
				else
				{
					age = value;
				}
			}
		}
	}
}
