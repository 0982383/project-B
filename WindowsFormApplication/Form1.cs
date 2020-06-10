using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;


namespace WindowsFormApplication
{


    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputpassWord = textBox1Password.Text;
            string inputUsername = textBox1Username.Text;
            var accounts = JObject.Parse(File.ReadAllText(@"ListOfAccounts.json"));
            var userName = accounts.SelectToken("$.Username").Values<string>().ToList();
            var PassWord = accounts.SelectToken("$.Password").Values<string>().ToList();
            bool login = false;
            for (int i = 0; i < userName.Count; i++)
            {
                if (inputUsername == userName[i] && inputpassWord == PassWord[i])
                {
                   
                        Main feuzi = new Main();
                        feuzi.Show();
                        login = true;
                }

            }
            if (login == false)
            {
                MessageBox.Show("Wrong username or password");
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {

            dynamic jsonAccount = JsonConvert.DeserializeObject(File.ReadAllText(@"ListOfAccounts.json"));
            jsonAccount["Username"].Add(textBox1Username.Text);
            jsonAccount["Password"].Add(textBox1Password.Text);
            string output = JsonConvert.SerializeObject(jsonAccount, Formatting.Indented);
            File.WriteAllText(@"ListOfAccounts.json", output);
            Main feuzi = new Main();
            
            feuzi.Show();


        }
        private void Text1_Click(object sender, EventArgs e)
        {

        }
    }
}
