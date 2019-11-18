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
            senderMail = "suportefleet.pimds3p42@gmail.com";
            password = "ds3p42fleetmanager";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            inicializeSmtpClient();
        }
    }
}
