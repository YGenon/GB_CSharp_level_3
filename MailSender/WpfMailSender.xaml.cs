﻿using System;
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
		    }
		    catch (Exception exception)
		    {
			    //MessageBox.Show(error.Message, "При отправке сообщения возникла ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
			    var dlg = new MessageSendCompletedDlg(exception.Message);
			    dlg.ShowDialog();
		    }
	    }
	}
}


