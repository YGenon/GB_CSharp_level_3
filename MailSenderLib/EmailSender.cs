using System.Net;
using System.Net.Mail;

namespace MailSenderLib
{
    public sealed class EmailSender
    {
        string strUser { set; get; }
        string strPass { set; get; }

        public EmailSender(string StrUser, string StrPass)
        {
            this.strUser = StrUser;
            this.strPass = StrPass;
        }
        /// <summary>
        /// Метод для отправки email
        /// </summary>
        /// <param name="strUser">dhgfhg</param>
        /// <param name="strPass">ghgfh</param>
        /// <exception cref="SmtpException">hgfhgf</exception>
        public void Send()
	    {
		    try
		    {
			    using (var message = new MailMessage(Settings.from, Settings.to, Settings.subject, Settings.body ))
                {
                    using (var client = new SmtpClient(Settings.server, Settings.port) { EnableSsl = true,
                        Credentials = new NetworkCredential(strUser, strPass) })
                    {
                        client.Send(message);
                    }
                }
            }
		    catch (SmtpException error)
		    {
			   throw new SmtpException(error.Message);
		    }
        }
	}
}