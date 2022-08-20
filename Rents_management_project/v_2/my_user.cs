using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v_2
{
    public partial class my_user : UserControl
    {
        public my_user()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("  Please read these conditions carefully." +
              " \n We offer a wide range of Homeasy Services, and sometimes additional terms may apply." +
              "\n When you use an Homeeasy Service you also will be subject to the guidelines, terms and agreements applicable to that Homeeasy Service (Service Terms). " +
              "\n If these Conditions of Use are inconsistent with the Service Terms, those Service Terms will control." +
              "\n\n PRIVACY " +
              "\n Please review our Privacy Notice, which also governs your use of Homeeasy Services, to understand our practices." +
              "\n\nELECTRONIC COMMUNICATIONS" +
              "\n\n When you use Homeasy Services, or send e-mails, text messages, and other communications from your desktop or mobile device to us, you may be communicating with us electronically. " +
              "\n You consent to receive communications from us electronically, such as e-mails, texts, mobile push notices, or notices and messages on this site or through the other Homeasy Services, such as our Message Center, and you can retain copies of these communications for your records. " +
              "\n You agree that all agreements, notices, disclosures, and other communications that we provide to you electronically satisfy any legal requirement that such communications be in writing." +
              "\n\n COPYRIGHT" +
              "\n All content included in or made available through any Homeeasy Service, such as text, graphics, logos, button icons, images, audio clips, digital downloads, data compilations, and software is the property of Homeeasy or its content suppliers and protected by Romania and international copyright laws. " +
              "\n The compilation of all content included in or made available through any Homeeasy Service is the exclusive property of Homeeasy and protected by U.S. and international copyright laws."
              );
        }
    }
}
