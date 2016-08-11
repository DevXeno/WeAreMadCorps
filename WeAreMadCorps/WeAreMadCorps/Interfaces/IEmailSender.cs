using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreMadCorps.Interfaces
{
    public interface IEmailSender
    {
        void SendMail(string ToWho, string Title, string Message);


    }
}
