using System;
using System.Net;
using System.Windows.Forms;

namespace PVT100APP
{
    public partial class Settings : Form
    {
        public string _ip { get; private set; }
        public int _port { get; private set; }
        public byte _id { get; private set; }
        public Settings()
        {
            InitializeComponent();
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            _ip = $"{ip1.Text}.{ip2.Text}.{ip3.Text}.{ip4.Text}";
            _port = int.Parse(port.Text);
            _id = byte.Parse(id.Text);

            DialogResult = DialogResult.OK;
            
            Close();
        }
    }
}
