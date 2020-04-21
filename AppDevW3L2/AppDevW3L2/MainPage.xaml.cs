using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppDevW3L2
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Btn_Check_Clicked(object sender, EventArgs e)
        {
            //string txt = Lbl_Purchase.Text.Replace('/', ' ');
            string[] split = Inp_Birthday.Text.Split('/');

            int usrYear = Int32.Parse(split[2]);
            int usrMonth = Int32.Parse(split[0]);
            int usrDay = Int32.Parse(split[1]);
            DateTime usrDate = new DateTime(usrYear, usrMonth, usrDay, 0, 0, 0);
            DateTime todayDate = DateTime.Today;

            Lbl_Purchase.Text = Int32.Parse((usrDate - todayDate).TotalDays.ToString()) <= -7665 ? "You can purchase alcohol." : "You cannot purchase alcohol";
        }
    }
}
