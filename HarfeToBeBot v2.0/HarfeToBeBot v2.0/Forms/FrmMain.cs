using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarfeToBeBot_v2._0
{
    public partial class FrmMain : Form
    {
        Controller.BotConnectionHandler BotConnection;
        public FrmMain()
        {
            InitializeComponent();
            txtToken.Text = Controller.BotConfigs.BOT_TOKEN;
            Controller.ErrorHandler.TextBoxErrors = txtErrors;
        }

        private async void btnStartStop_ClickAsync(object sender, EventArgs e)
        {
            BotConnection = new Controller.BotConnectionHandler(token: txtToken.Text);
            if (BotConnection.IsBotConnected())
            {
                lblStatus.Text = "Connected.";
                lblStatus.ForeColor = Color.Green;

                await Task.Run(async () =>
                {
                    await BotConnection.StartReceivingAsync();
                });
            }
            else
            {
                lblStatus.Text = "Connection faild.";
                lblStatus.ForeColor = Color.Red;
            }
        }
    }
}
