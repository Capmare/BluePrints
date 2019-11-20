using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace BluePrints
{

    public partial class Form1 : Form
    {


        GroupBox groupBox = new GroupBox();
        CheckBox negative = new CheckBox();
        TextBox textbox = new TextBox();
        string url;


        //mouse location
        int mouseX = MousePosition.X;
        int mouseY = MousePosition.Y;
        public Form1()
        {
            InitializeComponent();
            init();
           
        }

        private void init()
        {
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void clickToolStripMenuItem_Click(object sender, EventArgs e)
        {

            groupBox.Show();
            groupBox.Enabled = true;

            //label settings
            Label name = new Label();
            name.Text = "function1";
            name.Font = new Font("", 15);
            name.Location = new Point(60, 0);

            //spawn box at mouse location
            groupBox.Location = new Point(MousePosition.X - 400, MousePosition.Y - 200);

            //create negative
            
            negative.Location = new Point(10, 10);
            negative.Text = "-";
            negative.CheckState = CheckState.Checked;
            negative.ThreeState = false;

            //create close button
            Button closeBtn = new Button();
            closeBtn.Location = new Point(65, 60);
            closeBtn.Text = "Close";
            closeBtn.PerformClick();

            //create textbox
            
            textbox.Location = new Point(50, 35);
            textbox.Text = url;

            //add to groupBox
            groupBox.Controls.Add(name);
            groupBox.Controls.Add(negative);
            groupBox.Controls.Add(closeBtn);
            groupBox.Controls.Add(textbox);

            //create group box
            this.Controls.Add(groupBox);


            closeBtn.Click += CloseBtn_Click;




        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            groupBox.Hide();
            groupBox.Enabled = false;

        }
        private static readonly HttpClient client = new HttpClient();

        private void compilerBtn_Click(object sender, EventArgs e)
        {

            
            if (negative.CheckState == CheckState.Checked && groupBox.Enabled == true)
            {
                GetRequest(textbox.Text);

            }
            else
            {
                
            }
        }
        async static void GetRequest(string urlPost)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync(urlPost))
                {
                    using (HttpContent content = response.Content)
                    {
                        string mycontent = await content.ReadAsStringAsync();
                        Console.WriteLine(mycontent);
                    }
                }
            }
        }

    }


}
