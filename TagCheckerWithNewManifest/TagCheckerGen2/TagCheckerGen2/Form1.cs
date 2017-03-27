using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class  Form1 : Form
    {
        public static  int maxEPCLength;
        public static int maxTIDLength;
        String masterFile = "";
        String toRead= "";
        bool pred;
        DualList dl;
        FileSelection files;
        String orderNumber;

       

        public Form1()
        {
            maxEPCLength = 24;
            maxTIDLength = 24;
            InitializeComponent();
            EPCLength_TextBox.Text = "24";
            TIDLength_TextBox.Text = "24";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EpcCount_TextBox.Text = "1";

        }
   

        private void LoadMaster_Button_Click(object sender, EventArgs e)
        {
                maxEPCLength = Int32.Parse(EPCLength_TextBox.Text);
                maxTIDLength = Int32.Parse(TIDLength_TextBox.Text);
                if(OrderNumber_TextBox.Text == "")
                {
                    MessageBox.Show("Please enter the order numbr before continuing");
                    Application.Restart();
                }
                else
                {
                    orderNumber = OrderNumber_TextBox.Text;
                }

                OpenFileDialog dialog = new OpenFileDialog();
                if (this.Offline_CheckBox.Checked)
                {
                    dialog.InitialDirectory = @"C:\Users\";

                }
                else
                {
                    dialog.InitialDirectory = @"W:\Public\RFID\";
                }

                dialog.ShowDialog();

                masterFile = dialog.FileName;
                FileName_ListBox.Items.Add(dialog.SafeFileName);
                FileName_ListBox.Update();
                dl = new DualList(masterFile, Convert.ToInt32(EpcCount_TextBox.Text), maxEPCLength, 
                                  maxTIDLength);
        }

        private void LoadPredator_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            if (this.Offline_CheckBox.Checked)
            {
                dialog.InitialDirectory = @"C:\Users\";

            }
            else
            {
                dialog.InitialDirectory = @"W:\Public\RFID\";
            }

            dialog.ShowDialog();

            toRead = dialog.FileName;
            FileName_ListBox.Items.Add(dialog.SafeFileName);
            FileName_ListBox.Update();
            pred = true;
            Main main = new Main(masterFile, @"C:/Users/public/AssociationFiles/", toRead, dl, orderNumber);
            main.main(pred);


        }

        private void LoadTid_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            
            if (this.Offline_CheckBox.Checked)
            {
                dialog.InitialDirectory = @"C:\Users\";

            }
            else
            {
                dialog.InitialDirectory = @"W:\Public\RFID\";
            }
            dialog.ShowDialog();

            toRead = dialog.FileName;
            FileName_ListBox.Items.Add(dialog.SafeFileName);
            FileName_ListBox.Update();
            pred = false;

            Main mainBody = new Main(masterFile, @"C:/Users/public/AssociationFiles/", 
                                    toRead, dl, orderNumber);
            mainBody.main(pred);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    };
}
