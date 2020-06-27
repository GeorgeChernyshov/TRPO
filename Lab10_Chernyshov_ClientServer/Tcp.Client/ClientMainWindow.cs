using System;
using System.Windows.Forms;
using SomeProject.Library.Client;
using SomeProject.Library;

namespace SomeProject.TcpClient
{
    public partial class ClientMainWindow : Form
    {
        private Client client;
        public ClientMainWindow()
        {
            InitializeComponent();
            client = new Client();
            client.OnMessageReceived += ShowServerMessage;
        }

        private void OnMsgBtnClick(object sender, EventArgs e)
        {
            Result res = client.SendMessageToServer(enterBox.Text).Result;
            if(res == Result.OK)
            {
                enterBox.Text = "";
                labelRes.Text = "Message was sent succefully!";
            }
            else
            {
                labelRes.Text = "Cannot send the message to the server.";
            }
            timer.Interval = 2000;
            timer.Start();
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            labelRes.Text = "";
            timer.Stop();
        }

        private void OnSendFileClick(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                var openFileResult = dialog.ShowDialog();
                if (openFileResult == DialogResult.OK)
                {
                    Result result = client.SendFileToServer(dialog.FileName).Result;
                    if(result == Result.OK)
                    {
                        textBox.Text = "";
                        labelRes.Text = "File was sent succefully!";
                    }
                    else
                    {
                        labelRes.Text = "Cannot send file to the server.";
                    }
                }
            }
        }

        /// <summary>
        /// Отображение сообщения от сервереа
        /// </summary>
        /// <param name="msg">Сообщение</param>
        private void ShowServerMessage(string msg) => textBox.Text += (msg + "\r\n");
    }
}
