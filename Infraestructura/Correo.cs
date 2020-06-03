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

        private void ConfigurarEmail(Persona persona)
        {
            Email = new MailMessage();
            Email.To.Add(persona.Email);
            Email.From = new MailAddress("isaacpimienta358@gmail.com");
            Email.Subject = $"registro de usuario {persona.Nombre}";
            Email.Body = $"<b> Registro satisfactoriamente</b>";
            Email.IsBodyHtml = true;
            Email.Priority = MailPriority.Normal;

            
        }

        public string EnviarEmail(Persona persona)
        {
            try
            {
                ConfigurarSmtp();
                ConfigurarEmail(persona);
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
