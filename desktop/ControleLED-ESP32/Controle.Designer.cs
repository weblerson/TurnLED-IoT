namespace ControleLED_ESP32
{
    partial class Controle
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firebaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FirebaseState = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conectarAoFirebaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desconectarDoFirebaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.TurnON = new System.Windows.Forms.Button();
            this.TurnOFF = new System.Windows.Forms.Button();
            this.LEDState = new System.Windows.Forms.Label();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.firebaseToolStripMenuItem,
            this.FirebaseState});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(318, 24);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // firebaseToolStripMenuItem
            // 
            this.firebaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conectarAoFirebaseToolStripMenuItem,
            this.desconectarDoFirebaseToolStripMenuItem});
            this.firebaseToolStripMenuItem.Name = "firebaseToolStripMenuItem";
            this.firebaseToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.firebaseToolStripMenuItem.Text = "Firebase";
            // 
            // FirebaseState
            // 
            this.FirebaseState.Name = "FirebaseState";
            this.FirebaseState.Size = new System.Drawing.Size(100, 20);
            this.FirebaseState.Text = "Estado Firebase";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // conectarAoFirebaseToolStripMenuItem
            // 
            this.conectarAoFirebaseToolStripMenuItem.Name = "conectarAoFirebaseToolStripMenuItem";
            this.conectarAoFirebaseToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.conectarAoFirebaseToolStripMenuItem.Text = "Conectar ao Firebase";
            this.conectarAoFirebaseToolStripMenuItem.Click += new System.EventHandler(this.conectarAoFirebaseToolStripMenuItem_Click);
            // 
            // desconectarDoFirebaseToolStripMenuItem
            // 
            this.desconectarDoFirebaseToolStripMenuItem.Name = "desconectarDoFirebaseToolStripMenuItem";
            this.desconectarDoFirebaseToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.desconectarDoFirebaseToolStripMenuItem.Text = "Desconectar do Firebase";
            this.desconectarDoFirebaseToolStripMenuItem.Click += new System.EventHandler(this.desconectarDoFirebaseToolStripMenuItem_Click);
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Controle do LED";
            // 
            // TurnON
            // 
            this.TurnON.BackColor = System.Drawing.SystemColors.Control;
            this.TurnON.Location = new System.Drawing.Point(12, 100);
            this.TurnON.Name = "TurnON";
            this.TurnON.Size = new System.Drawing.Size(144, 23);
            this.TurnON.TabIndex = 2;
            this.TurnON.Text = "Ligar";
            this.TurnON.UseVisualStyleBackColor = false;
            this.TurnON.Click += new System.EventHandler(this.TurnON_Click);
            // 
            // TurnOFF
            // 
            this.TurnOFF.Location = new System.Drawing.Point(162, 100);
            this.TurnOFF.Name = "TurnOFF";
            this.TurnOFF.Size = new System.Drawing.Size(144, 23);
            this.TurnOFF.TabIndex = 3;
            this.TurnOFF.Text = "Desligar";
            this.TurnOFF.UseVisualStyleBackColor = true;
            this.TurnOFF.Click += new System.EventHandler(this.TurnOFF_Click);
            // 
            // LEDState
            // 
            this.LEDState.AutoSize = true;
            this.LEDState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEDState.Location = new System.Drawing.Point(105, 61);
            this.LEDState.Name = "LEDState";
            this.LEDState.Size = new System.Drawing.Size(96, 20);
            this.LEDState.TabIndex = 4;
            this.LEDState.Text = "Estado LED";
            // 
            // Controle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 141);
            this.Controls.Add(this.LEDState);
            this.Controls.Add(this.TurnOFF);
            this.Controls.Add(this.TurnON);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.MaximizeBox = false;
            this.Name = "Controle";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle";
            this.Load += new System.EventHandler(this.Controle_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firebaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conectarAoFirebaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desconectarDoFirebaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FirebaseState;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TurnON;
        private System.Windows.Forms.Button TurnOFF;
        private System.Windows.Forms.Label LEDState;
    }
}

