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
using UWP.Pages.Labs2.Model;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWP.Pages.Labs2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Mail : Page
    {
        public Mail()
        {
            this.InitializeComponent();
        }
        private static List<Mails> cus = new List<Mails>();
        private void Home(object sender, RoutedEventArgs e)
        {
            LapMain._frame.Navigate(typeof(Home));
        }
        private void Submit(object sender, RoutedEventArgs e)
        {
            if (inputEmail.Text == "" || inpuTitle.Text == "")
            {
                errors.Text = "Vui lòng nhập đủ thông tin!";
            }
            else if (inputContent.Text == "")
            {
                errors.Text = "Vui lòng nhập đủ thông tin!";

            }
            else
            {
                errors.Text = "";
                //  string txt = inputMail.Text + "--" + inputSubject.Text + "\n --------------------------------------";
                var m = new Mails() { Email = inputEmail.Text, Title = inpuTitle.Text, Content = inputContent.Text };
                cus.Add(m);
                PrintMails();
                inpuTitle.Text = "";
                inputEmail.Text = "";
                inputContent.Text = "";
            }

        }

        private void PrintMails()
        {
            txtData.Text = "";
            foreach (Mails m in cus)
            {
                txtData.Text += m.Email + "--" + m.Title + "--" + m.Content + "\n";
            }
        }
    }
}
