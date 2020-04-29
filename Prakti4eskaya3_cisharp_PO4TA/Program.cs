using System;
using System.Net.Mail;
using System.Net;

namespace Prakti4eskaya3_cisharp_PO4TA
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SmtpClient smtp = new SmtpClient("smpt.gmail.com", 587);
                Console.WriteLine("Введите ваш логин:");
                string login = Console.ReadLine();
                Console.WriteLine("Введите пароль:");
                string parolb = Console.ReadLine();
                smtp.Credentials = new NetworkCredential(login, parolb);
                MailAddress from = new MailAddress(login, "Ilya");
                Console.WriteLine("Введите email-адресс получателя:");
                string poly4atelb = Console.ReadLine();
                MailAddress to = new MailAddress(poly4atelb);
                MailMessage soobwenie = new MailMessage(from, to);
                soobwenie.Subject = "Privetstvie";
                soobwenie.Body = "<h2>Hello World</h2>";
                soobwenie.IsBodyHtml = true;
                smtp.EnableSsl = true;
                smtp.Send(soobwenie);
                Console.WriteLine("Сообщение успешно отправлено");
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат электронной почты");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Строка с адресом не должна быть пуста");
            }
        }
    }
}
