using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using UWP.Models;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWP.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Mail : Page
    {
        private List<Email> mails = new List<Email>();
        public Mail()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(inputMail.Text == "" || inputSubject.Text == "")
            {
                errors.Text = "Vui lòng nhập đủ thông tin!";
            }
            else
            {
                errors.Text = "";
                //  string txt = inputMail.Text + "--" + inputSubject.Text + "\n --------------------------------------";
                var m = new Email() { Mail = inputMail.Text, Subject = inputSubject.Text, Content = inputContent.Text };
                mails.Add(m) ;
                PrintMails();
                inputMail.Text = "";
                inputSubject.Text = "";
                inputContent.Text = "";
            }
            
        }

        private void PrintMails()
        {
            txtMail.Text = "";
            foreach(Email m in mails)
            {
                txtMail.Text += m.Mail+"--"+m.Subject+"\n-------------";
            }
        }
    }
}
