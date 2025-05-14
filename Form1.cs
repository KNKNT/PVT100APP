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

namespace PVT100APP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        TcpClient client = new TcpClient();

        private async void ConnectButton_Click(object sender, EventArgs e)
        {
            var ipAdress = "192.168.9.22";
            int port = 502;
            byte slaveId = 3;
            ushort startAddress = 258;
            ushort numRegisters = 3;
      
            try
            {
                using (client)
                {
                    client.SendTimeout = 2000;
                    client.ReceiveTimeout = 2000;
                    await client.ConnectAsync(ipAdress, port);

                    while (true)
                    {
                        IModbusMaster master = ModbusIpMaster.CreateIp(client);
                        ushort[] registers =  master.ReadHoldingRegisters(slaveId, startAddress, numRegisters);

                        double temperature = registers[0] / 100.0;
                        double dewPoint = registers[1] / 100.0;
                        double wetness = registers[2] / 100.0;

                        TemperatureLb.Text = $"{temperature:F2} °С";
                        DewPointLb.Text = $"{dewPoint:F2} %RH";
                        WetLb.Text = $"{wetness:F2} °С";
                        
                        await Task.Delay(1000);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
