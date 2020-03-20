using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSenderLib
{
    public static class Settings
    {
        public static string from = "sergvoznik-test@yandex.ru";
        public static string to = "sergvoznik-test@yandex.ru";
        public static string server = "smtp.yandex.ru";
        public static int port = 25;
        public static string subject = "Test message";
        public static string body = "Test message body";
    }
}
