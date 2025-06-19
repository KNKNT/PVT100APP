using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.Net.Http;
using System.Net.Sockets;
using System.Threading.Tasks;
using Modbus;
using Modbus.Device;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;
using System.Web.UI.WebControls.WebParts;
using System.Threading;
using System.Security.Cryptography;
using System.Net;

namespace PVT100APP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        TcpClient client = new TcpClient();
        bool isRunning = false;
        bool demoRunning = false;
        string C = "°С";
        string RH = "%RH";

        private string ipAddress = "192.168.9.22";
        private int port = 502;
        private byte slaveId = 3;

        private async void ConnectButton_Click(object sender, EventArgs e)
        {
            if (isRunning)
                return;

            if (client == null)
                client = new TcpClient();

            InitializeChart();
            ChartPanel.Visible = true;

            try
            {
                ushort startAddress = 258;
                ushort numRegisters = 3;

                client.SendTimeout = 2000;
                client.ReceiveTimeout = 2000;
                await client.ConnectAsync(ipAddress, port);

                isRunning = true;
                DemoButton.Enabled = false;

                while (isRunning)
                {
                    IModbusMaster master = ModbusIpMaster.CreateIp(client);
                    ushort[] registers = master.ReadHoldingRegisters(slaveId, startAddress, numRegisters);

                    double temperature = registers[0] / 100.0;
                    double dewPoint = registers[1] / 100.0;
                    double wetness = registers[2] / 100.0;

                    this.Invoke((MethodInvoker)delegate
                    {
                        TemperatureLb.Text = $"{temperature}{C}";
                        DewPointLb.Text = $"{dewPoint}{RH}";
                        WetLb.Text = $"{wetness}{C}";

                        AddDataToChart(temperature, dewPoint, wetness);
                        chart1.ChartAreas[0].RecalculateAxesScale();
                    });

                    await Task.Delay(1000);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (client != null && client.Connected)
                    client.Close();
            }
        }

        private void DataStyle_Click(object sender, EventArgs e)
        {
            if (DataStyle.Checked)
            {
                DataStyle.Checked = false;
                C = "";
                RH = "";
            }
            else
            {
                DataStyle.Checked = true;
                C = "°С";
                RH = "%RH";
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            InitializeChart();
            ChartPanel.Visible = true;
            
            if (demoRunning)
                return;
            demoRunning = true;
            ConnectButton.Enabled = false;

            while (demoRunning)
            {
                Random random = new Random();
                int random1 = random.Next(10, 100);
                int random2 = random.Next(10, 100); 
                int random3 = random.Next(10, 100); 


                TemperatureLb.Text = $"{random1} {C}";
                DewPointLb.Text = $"{random2} {RH}";
                WetLb.Text = $"{random3} {C}";

                AddDataToChart(random1, random2, random3);
                chart1.ChartAreas[0].RecalculateAxesScale();

                await Task.Delay(1000);
            }
        }

        private void InitializeChart()
        {
            chart1.Series.Clear();

            chart1.Series.Add("Температура");
            chart1.Series["Температура"].ChartType = SeriesChartType.Spline;
            chart1.Series["Температура"].Color = Color.Blue;
            chart1.Series["Температура"].Color = Color.Blue;

            chart1.Series.Add("Точка росы");
            chart1.Series["Точка росы"].ChartType = SeriesChartType.Spline;
            chart1.Series["Точка росы"].Color = Color.Orange;
            chart1.Series["Точка росы"].BorderWidth = 2;

            chart1.Series.Add("Влажность");
            chart1.Series["Влажность"].ChartType = SeriesChartType.Spline;
            chart1.Series["Влажность"].Color = Color.Red;
            chart1.Series["Влажность"].BorderWidth = 2;

            chart1.ChartAreas[0].AxisX.Interval = 1;
        }

        private void AddDataToChart(double temp, double dewPoint, double wet)
        {
            chart1.Series["Температура"].Points.AddY(temp);
            chart1.Series["Точка росы"].Points.AddY(dewPoint);
            chart1.Series["Влажность"].Points.AddY(wet);
    
            foreach (var series in chart1.Series)
            {
                if (series.Points.Count > 10)
                {
                    series.Points.RemoveAt(0);
                }
            }

            chart1.Update();
        }

        private void TemperatureCheck_CheckedChanged(object sender, EventArgs e)
        {         
            chart1.Series["Температура"].Enabled = TemperatureCheck.Checked;
        }

        private void DotCheck_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series["Точка росы"].Enabled = DotCheck.Checked;
        }

        private void WetCheck_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series["Влажность"].Enabled = WetCheck.Checked;
        }

        private void Disconnect_Click(object sender, EventArgs e)
        {
            isRunning = false;
            demoRunning = false;
            DemoButton.Enabled = true;
            ConnectButton.Enabled = true;

            if (client != null)
            {
                if (client.Connected)
                    client.Close(); 

                client.Dispose();   
                client = null;      
            }

            MessageBox.Show("Соединение закрыто.");
        }

        private void CheckConnection_Click(object sender, EventArgs e)
        {
            if (client != null && client.Connected)
            {
                MessageBox.Show("Соединение с устройством установлено.");
            }
            else
            {
                MessageBox.Show("Соединение с устройством НЕ установлено.");
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            using (var settingsForm = new Settings())
            {
                if (settingsForm.ShowDialog() == DialogResult.OK)
                {
                    ipAddress = settingsForm._ip;
                    port = settingsForm._port;
                    slaveId = settingsForm._id;
                }
            }

        }
    }
}
