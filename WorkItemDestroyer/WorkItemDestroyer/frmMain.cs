using Microsoft.TeamFoundation.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkItemDestroyer
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            DestroyWI();
        }

        private void DestroyWI()
        {
            txtCommands.Clear();

            //string path = ConfigurationManager.AppSettings["scripts.dir"].ToString();
            int numberofIds = int.Parse(txtBatchSize.Text);
            StringBuilder sb = new StringBuilder();
            string noprompt = "";

            if (chkNoPrompt.Checked)
            {
                noprompt = "/noprompt";
            }
            string destroyLineFormat = "witadmin.exe destroywi /collection:\"{0}\" /id:{1} {2} ";
            List<int> destroyIDList = new List<int>();
            int teller = 0;

            foreach (string l in txtSourceID.Lines)
            {
                teller++;
                if (string.IsNullOrEmpty(l))
                {
                    continue;
                }
                destroyIDList.Add(int.Parse(l.Replace("\t","")));
                if (teller == numberofIds)
                {
                    sb.AppendLine(string.Format(destroyLineFormat, txtCollectionURL.Text, string.Join(",", destroyIDList),noprompt));
                    teller = 0;
                    destroyIDList = new List<int>();
                }
            }

            if (teller > 0)
            {
                sb.AppendLine(string.Format(destroyLineFormat, txtCollectionURL.Text, string.Join(",", destroyIDList),noprompt));
            }
            txtCommands.Text = sb.ToString();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            TeamProjectPicker tpp = new TeamProjectPicker();
            if (tpp.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtCollectionURL.Text = tpp.SelectedTeamProjectCollection.Uri.ToString();
            }
        }
    }
}
