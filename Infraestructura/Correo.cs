using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using Entity;
using System.Net;

namespace Infraestructura
{
    public class Correo
    {
        public MailMessage Email { get; set; }

        SmtpClient Smtp;

        public Correo()
        {
            Smtp = new SmtpClient();

        }

        private  void ConfigurarSmtp()
        {
            Smtp.Host = "smtp.gmail.com";
            Smtp.Port = 587;
            Smtp.EnableSsl = true;
            Smtp.UseDefaultCredentials = false;
            Smtp.Credentials = new NetworkCredential("isaacpimienta358@gmail.com","comot3viyo3.");
        }

        private void ConfigurarEmail(string ruta,string correo)
        {
            Email = new MailMessage();
            Email.To.Add(correo);
            Email.From = new MailAddress("isaacpimienta358@gmail.com");
            Email.Subject = $"Lista de Usuario";
            Email.Body = $"<b> Registro satisfactoriamente</b>";
            Attachment Pdf = new Attachment(ruta);
            Email.Attachments.Add(Pdf);
            Email.IsBodyHtml = true;
            Email.Priority = MailPriority.Normal;

            
        }

        public string EnviarEmail(string ruta,string correo)
        {
            try
            {
                ConfigurarSmtp();
                ConfigurarEmail(ruta,correo);
                Smtp.Send(Email);
                return $"Se envio correctamente el correo";

            }
            catch (Exception ex)
            {
                return $"Error en enviar el correo{ex.Message.ToString()}";
            }
            finally
            {
                Email.Dispose();
            }


        }


    }
}
