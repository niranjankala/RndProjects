using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADUsersExtractor
{
    public partial class MainForm : Form
    {
        //Reference: http://ianatkinson.net/computing/adcsharp.htm#intro
        //https://stackoverflow.com/questions/5162897/how-can-i-get-a-list-of-users-from-active-directory
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //txtADDomain.Text = "smp.motherson.com";
            //txtADDomain.Text = "mind.motherson.com";
            //txtUserEmail.Text = "Joachim.Maier@smp-automotive.com,Adelbert.Siegel@smp-automotive.com,R.Ortega@smp-automotive.com,Tim.Schuette@smp-automotive.com";
            //this.dataGridView1.DataSource = GetADUsers(txtADDomain.Text, "");

        }

        private List<UserInfo> GetADUsers(string domain, string filter)
        {
            List<UserInfo> users = new List<UserInfo>();
            using (var context = new PrincipalContext(ContextType.Domain, domain))
            {
                using (var searcher = new PrincipalSearcher(new UserPrincipal(context)))
                {
                    string[] accountNames = txtUserEmail.Text.Split(',').Select(m => m.Split('@')[0].Split('.')[0]).ToArray();
                    //var results = searcher.FindAll().Where(u => u.SamAccountName.Contains("niranjan"));
                    var results = searcher.FindAll().Where(u => txtUserEmail.Text.Split(',').Contains((u as UserPrincipal).EmailAddress, StringComparer.InvariantCultureIgnoreCase));
                    //.Where(e => accountNames.Contains(e.DisplayName, StringComparer.InvariantCultureIgnoreCase));
                    //var results = searcher.FindAll();
                    foreach (UserPrincipal result in results)
                    {
                        DirectoryEntry de = result.GetUnderlyingObject() as DirectoryEntry;                       

                        //if (txtUserEmail.Text.Split(',').Contains(Convert.ToString(de.Properties["mail"].Value), StringComparer.InvariantCultureIgnoreCase))
                        //{
                        //    Console.WriteLine("========    ==================");
                        //    foreach (var item in de.Properties.PropertyNames)
                        //    {
                        //        Console.WriteLine($"{item}:{de.Properties[item.ToString()].Value}");
                        //    }
                        //}


                        users.Add(
                            new UserInfo()
                            {
                                AccountName = result.SamAccountName,
                                DisplayName = result.GivenName,
                                 Email = result.EmailAddress,
                                  Name = result.Name
                            });
                    }
                }
            }
            if(!string.IsNullOrWhiteSpace(txtUserEmail.Text))
                users = users.Where(u=> txtUserEmail.Text.Split(',').Contains(u.Email, StringComparer.InvariantCultureIgnoreCase)).ToList();
            return users;
        }

       

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = GetADUsers(txtADDomain.Text, txtUserEmail.Text);
        }
    }
}

