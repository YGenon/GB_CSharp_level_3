using System;
using System.Net;
using System.Windows;
using System.Net.Mail;
using MailSenderLib;

namespace MailSender
{
	partial class MainWindow : Window
    {
		public MainWindow() => InitializeComponent();

	    void Button_Click(object sender, RoutedEventArgs e)
	    {
		    try
		    {
			    var send = new EmailSender(UserNameTextBox.Text, PasswordEdit.Password);
			    send.Send();

                var dlg = new MessageSendCompletedDlg("Сообщение отправлено");
                dlg.ShowDialog();
            }
		    catch (Exception exception)
		    {
			    //MessageBox.Show(exception.Message, "При отправке сообщения возникла ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                var dlg = new MessageSendError(exception.Message);
                dlg.ShowDialog();
            }
        }
	}
}


