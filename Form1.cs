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



/* TO DO LIST:
 *            move close button under the scrolupdown box (dynamically)
 */



namespace BluePrints
{

    public partial class Form1 : Form
    {


        GroupBox Function1 = new GroupBox();
        CheckBox Fuction1_ActivateButton = new CheckBox();
        DomainUpDown selectFunction2 = new DomainUpDown();
        
        int x = 60;
        int y = 65;
        string Function1_code = "import RPi.GPIO as gpio\nimport time\ngpio.setwarnings(False)\ngpio.setmode(gpio.BCM)\ngpio.setup(21, gpio.OUT)\nwhile True:\n    gpio.output(21, gpio.HIGH)\n";
        string function1FileName = "function1_code";


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

        private void function1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Function1.Show();
            Function1.Enabled = true;
            Function1.Height = 100;
            selectFunction2.Hide();
            selectFunction2.Enabled = false;
            
            //label settings
            Label name = new Label();
            name.Text = "function1";
            name.Font = new Font("", 15);
            name.Location = new Point(60, 0);
            
            //spawn box at mouse location
            Function1.Location = new Point(MousePosition.X - 400, MousePosition.Y - 200);

            //add new boxFunction
            Button newBox = new Button();
            newBox.Text = "add function";
            newBox.Location = new Point(120,30);
            
            //create negative
            Fuction1_ActivateButton.Location = new Point(10, 20);
            Fuction1_ActivateButton.Text = "Is Active";
            Fuction1_ActivateButton.CheckState = CheckState.Checked;
            Fuction1_ActivateButton.ThreeState = false;

            //create close button
            Button Function1_closeBtn = new Button();
            Function1_closeBtn.Location = new Point(x, y);
            Function1_closeBtn.Text = "Close";
            Function1_closeBtn.PerformClick();

            //add to groupBox
            Function1.Controls.Add(name);
            Function1.Controls.Add(Fuction1_ActivateButton);
            Function1.Controls.Add(Function1_closeBtn);
            Function1.Controls.Add(newBox);
            Function1.Controls.Add(selectFunction2);
            //create group box
            this.Controls.Add(Function1);

            newBox.Click += NewBox_Click;
            Function1_closeBtn.Click += CloseBtn_Click;
            
        }

        private void NewBox_Click(object sender, EventArgs e)
        {
            selectFunction2.Show();
            selectFunction2.Enabled = true;
            selectFunction2.Location = new Point(20,60);
            selectFunction2.Items.Add("Function2");
            selectFunction2.Items.Add("Function3"); 
            Function1.Height = 120;
            selectFunction2.Click += SelectFunction2_Click;

        }

        private void SelectFunction2_Click(object sender, EventArgs e)
        {
            // move close button under the box
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Function1.Hide();
            Function1.Enabled = false;

        }
        private static readonly HttpClient client = new HttpClient();

        private void compilerBtn_Click(object sender, EventArgs e)
        {


            if (Fuction1_ActivateButton.CheckState == CheckState.Checked && Function1.Enabled == true)
            {
                byte[] Function1_data = System.Text.ASCIIEncoding.ASCII.GetBytes(Function1_code);
                string Function1_codeBase64 = System.Convert.ToBase64String(Function1_data);

                byte[] Function1_name_data = System.Text.ASCIIEncoding.ASCII.GetBytes(function1FileName);
                string function1_name_base64 = System.Convert.ToBase64String(Function1_name_data);
               GetRequest($"http://192.168.0.249:8080/api?code={Function1_codeBase64}&name={function1_name_base64}");
               GetRequest($"http://192.168.0.249:8080/exec?file={function1FileName}");

            }

        }
        async static void GetRequest(string urlPost)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync(urlPost))
                {                    using (HttpContent content = response.Content)
                   {
                        string mycontent = await content.ReadAsStringAsync();
                        Console.WriteLine(mycontent);
                    }
                }
            }
        }
    }


}
