using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace ControleLED_ESP32
{
    public partial class Controle : Form
    {
        IFirebaseConfig config = new FirebaseConfig()
        {
            BasePath = "", //Database URL
            AuthSecret = ""//Database password
        };

        IFirebaseClient client;

        string path = "ESP32/Valor";

        public Controle()
        {
            InitializeComponent();
        }

        private void Controle_Load(object sender, EventArgs e)
        {
            FirebaseState.Text = "Desconectado do Firebase";
            LEDState.Text = "LED Apagado";

            TurnON.BackColor = Color.Green;
            TurnOFF.BackColor = Color.Red;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void conectarAoFirebaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (client == null)
            {
                try
                {
                    client = new FireSharp.FirebaseClient(config);
                    FirebaseState.Text = "Conectado ao Firebase";
                    Timer.Enabled = true;

                    MessageBox.Show("Conectado com sucesso ao Firebase!", "Conexão bem sucedida", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch
                {
                    FirebaseState.Text = "Desconectado do Firebase";
                    Timer.Enabled = false;

                    MessageBox.Show("Ocorreu um erro ao conectar com o Firebase", "Conexão mal sucedida", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void desconectarDoFirebaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(client != null)
            {
                client = null;
                Timer.Enabled = false;

                FirebaseState.Text = "Desconectado do Firebase";
            }
        }

        private async void Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                FirebaseResponse response = await client.GetTaskAsync(path);
                Data update = response.ResultAs<Data>();

                if(update.Valor)
                {
                    LEDState.Text = "LED Ligado";
                }
                else
                {
                    LEDState.Text = "LED Desligado";
                }
            }
            catch { }
        }

        private async void TurnON_Click(object sender, EventArgs e)
        {
            if(client != null)
            {
                var data = new Data()
                {
                    Valor = true
                };

                FirebaseResponse response = await client.UpdateTaskAsync(path, data);
            }
            else
            {
                MessageBox.Show("Não é possível alterar o estado do LED. Aplicativo desconectado do Firebase.",
                    "Aplicativo desconectado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void TurnOFF_Click(object sender, EventArgs e)
        {
            if(client != null)
            {
                var data = new Data()
                {
                    Valor = false
                };

                FirebaseResponse response = await client.UpdateTaskAsync(path, data);
            }
            else
            {
                MessageBox.Show("Não é possível alterar o estado do LED. Aplicativo desconectado do Firebase.",
                    "Aplicativo desconectado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
