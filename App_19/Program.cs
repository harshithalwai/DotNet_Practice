using System.Net;
using System.Net.Mail;

class Program
{
    static void Main(string[] args)
    {
        string senderEmail = "yourgmail@gmail.com";
        string appPassword = "YOUR_APP_PASSWORD";

        string receiverEmail = "xyz@gmail.com";

        MailMessage mail = new MailMessage();

        mail.From = new MailAddress(senderEmail);
        mail.To.Add(receiverEmail);

        mail.Subject = "Test Mail from C#";

        mail.Body = @"Hello,

                    This mail is sent using Gmail SMTP.

                    Regards,
                    Harshit";

        SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);

        smtp.Credentials = new NetworkCredential(senderEmail, appPassword);

        smtp.EnableSsl = true;

        try
        {
            smtp.Send(mail);
            Console.WriteLine("Mail Sent Successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.ReadLine();
    }
}