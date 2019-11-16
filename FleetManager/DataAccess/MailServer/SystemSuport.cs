using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.MailServer
{
    class SystemSuport:MasterServerMail
    {
        public SystemSuport()
        {
            senderMail = "andesnascimento@gmail.com";
            password = "vidatudo";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            inicializeSmtpClient();
        }

        internal void sendMail(string subject, string body)
        {
            throw new NotImplementedException();
        }
    }
}
