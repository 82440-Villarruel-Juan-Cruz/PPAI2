using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

class Example
{
    
}
namespace PPAI.Clases
{
    internal class WhatsApp
    {
        public void MandarMensaje(string texto)
        {
            var accountSid = "ACc5d88ac6f6936a6d43b6174cf9a2304f";
            var authToken = "8a0f69743a97cdb4602c734176adff45";
            TwilioClient.Init(accountSid, authToken);

            var messageOptions = new CreateMessageOptions(
                new PhoneNumber("whatsapp:+5493516164414"));
            messageOptions.From = new PhoneNumber("whatsapp:+14155238886");
            messageOptions.Body = texto;   

            try
            {
                var message = MessageResource.Create(messageOptions);
                Console.WriteLine(message.Body);
                MessageBox.Show("Enviado Correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el envio {0}", ex.Message);
                throw;
            }

        }

    }
}
