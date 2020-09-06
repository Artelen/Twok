using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Twok
{
    public partial class mainForm : Form
    {
        String[] ports;
        List<SerialPort> connectedPorts;
        List<Test> ActiveTests;
       
        public mainForm()
        {
            InitializeComponent();
            connectedPorts = new List<SerialPort>();
            ActiveTests = new List<Test>();
            

            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelMainMenu.Dock = DockStyle.Fill;
            panelPortlar.Dock = DockStyle.Fill;
            panelTestler.Dock = DockStyle.Fill;
            panelPortlar.Visible = false;
            panelTestler.Visible = false;
        }
        
        private void panelMainMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBoxPorts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonPortlar_Click(object sender, EventArgs e)
        {
            panelMainMenu.Visible = false;
            panelPortlar.Visible = true;
        }

        private void buttonAktifTestler_Click(object sender, EventArgs e)
        {
            panelMainMenu.Visible = false;
            panelTestler.Visible = true;
        }

        private void buttonPanelTestGeri_Click(object sender, EventArgs e)
        {
            panelMainMenu.Visible =true;
            panelTestler.Visible = false;
        }

        private void buttonPanelPortlarGeri_Click(object sender, EventArgs e)
        {
            panelMainMenu.Visible = true;
            panelPortlar.Visible = false;
        }

        private void panelPortlar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonYenile_Click(object sender, EventArgs e)
        {
            comboBoxPorts.Items.Clear();
            ports = SerialPort.GetPortNames();
            foreach (var port in ports)
            {
                
                comboBoxPorts.Items.Add(port);
            }
        }

        private void buttonPortEkle_Click(object sender, EventArgs e)
        {
            connectedPorts.Add(new SerialPort(comboBoxPorts.GetItemText(comboBoxPorts.SelectedItem), Int16.Parse(comboBoxBoudRate.GetItemText(comboBoxBoudRate.SelectedItem)), Parity.None, 8, StopBits.One));
            SerialPort lastPort = connectedPorts[connectedPorts.Count - 1];
            lastPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(port_dataRecieved);
            lastPort.Open();
            dataGridViewPorts.Rows.Add(lastPort.PortName, lastPort.BaudRate, lastPort.Parity.ToString(), lastPort.DataBits, lastPort.StopBits.ToString());
        }

        private void port_dataRecieved(object sender , EventArgs e)
        {
            MessageBox.Show(((SerialPort)sender).ReadLine());
            MessageBox.Show(connectedPorts.Find(x => x.PortName == "COM3").BaudRate.ToString());
        }
    }
}
