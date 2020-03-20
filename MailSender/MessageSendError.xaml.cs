using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MailSender
{
    /// <summary>
    /// Логика взаимодействия для MessageSendError.xaml
    /// </summary>
    public partial class MessageSendError : Window
    {
        public MessageSendError(string mess)
        {
            InitializeComponent();
            MainLabel.Content = mess;
        }

        private void Button_OnClick(object sender, RoutedEventArgs e)
        {
            if (((Button)sender).Content.ToString() == "Ok")
                DialogResult = true;

            Close();
        }
    }
}
