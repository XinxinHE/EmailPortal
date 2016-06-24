using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Limilabs.Client.IMAP;
using Limilabs.Client.POP3;
using Limilabs.Client.SMTP;
using Limilabs.Mail;
using Limilabs.Mail.MIME;
using Limilabs.Mail.Fluent;
using Limilabs.Mail.Headers;

namespace EmailPortal
{
    public partial class Form1 : Form
    {
        private Imap imap;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                imap = new Imap();
                imap.Connect("mail.telamon.com");
                imap.UseBestLogin("xinxin.he", "ICBC#*11180103hx");
                foreach (FolderInfo folder in imap.GetFolders())

                {

                    Console.WriteLine(folder.Name);

                }

                imap.Select("INBOX/2. Done/Greenfax");

                List<long> uids = imap.Search(Flag.All);
                
                foreach (long uid in uids)
                {

                    EmailList.Items.Add(uid);

                }
            
        }

        private void Body_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailList_SelectedIndexChanged(object sender, EventArgs e)
        {

            long emailUID = Convert.ToInt64(EmailList.SelectedItem);

            var eml = imap.GetMessageByUID(emailUID);
            IMail email = new MailBuilder().CreateFromEml(eml);

            Subject.Text = email.Subject.ToString();
            Sender.Text = email.Sender.ToString();
            Body.Text = email.GetTextFromHtml().ToString();
        }

        private void Form1_Closed(object sender, System.EventArgs e)
        {
            imap.Close();
        }

    }
}
