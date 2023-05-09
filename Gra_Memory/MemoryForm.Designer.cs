namespace Gra_Memory
{
    partial class MemoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblCzas = new System.Windows.Forms.Label();
            this.lblCzasWartosc = new System.Windows.Forms.Label();
            this.lblPunkty = new System.Windows.Forms.Label();
            this.lblPunktyWartosc = new System.Windows.Forms.Label();
            this.lblStartInfo = new System.Windows.Forms.Label();
            this.panelKart = new System.Windows.Forms.Panel();
            this.timerZakrywacz = new System.Windows.Forms.Timer(this.components);
            this.timerCzasGry = new System.Windows.Forms.Timer(this.components);
            this.timerCzasPodgladu = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblCzas
            // 
            this.lblCzas.AutoSize = true;
            this.lblCzas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCzas.Location = new System.Drawing.Point(24, 22);
            this.lblCzas.Name = "lblCzas";
            this.lblCzas.Size = new System.Drawing.Size(47, 18);
            this.lblCzas.TabIndex = 0;
            this.lblCzas.Text = "Czas:";
            // 
            // lblCzasWartosc
            // 
            this.lblCzasWartosc.AutoSize = true;
            this.lblCzasWartosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCzasWartosc.Location = new System.Drawing.Point(68, 22);
            this.lblCzasWartosc.Name = "lblCzasWartosc";
            this.lblCzasWartosc.Size = new System.Drawing.Size(24, 18);
            this.lblCzasWartosc.TabIndex = 1;
            this.lblCzasWartosc.Text = "60";
            // 
            // lblPunkty
            // 
            this.lblPunkty.AutoSize = true;
            this.lblPunkty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPunkty.Location = new System.Drawing.Point(143, 22);
            this.lblPunkty.Name = "lblPunkty";
            this.lblPunkty.Size = new System.Drawing.Size(57, 18);
            this.lblPunkty.TabIndex = 2;
            this.lblPunkty.Text = "Punkty:";
            // 
            // lblPunktyWartosc
            // 
            this.lblPunktyWartosc.AutoSize = true;
            this.lblPunktyWartosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPunktyWartosc.Location = new System.Drawing.Point(197, 22);
            this.lblPunktyWartosc.Name = "lblPunktyWartosc";
            this.lblPunktyWartosc.Size = new System.Drawing.Size(16, 18);
            this.lblPunktyWartosc.TabIndex = 3;
            this.lblPunktyWartosc.Text = "0";
            // 
            // lblStartInfo
            // 
            this.lblStartInfo.AutoSize = true;
            this.lblStartInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStartInfo.Location = new System.Drawing.Point(346, 22);
            this.lblStartInfo.Name = "lblStartInfo";
            this.lblStartInfo.Size = new System.Drawing.Size(131, 18);
            this.lblStartInfo.TabIndex = 4;
            this.lblStartInfo.Text = "Początek gry za 5.";
            // 
            // panelKart
            // 
            this.panelKart.Location = new System.Drawing.Point(27, 52);
            this.panelKart.Name = "panelKart";
            this.panelKart.Size = new System.Drawing.Size(548, 25);
            this.panelKart.TabIndex = 5;
            // 
            // timerZakrywacz
            // 
            this.timerZakrywacz.Interval = 1000;
            this.timerZakrywacz.Tick += new System.EventHandler(this.timerZakrywacz_Tick);
            // 
            // timerCzasGry
            // 
            this.timerCzasGry.Interval = 1000;
            this.timerCzasGry.Tick += new System.EventHandler(this.timerCzasGry_Tick);
            // 
            // timerCzasPodgladu
            // 
            this.timerCzasPodgladu.Interval = 1000;
            this.timerCzasPodgladu.Tick += new System.EventHandler(this.timerCzasPodgladu_Tick);
            // 
            // MemoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(605, 88);
            this.Controls.Add(this.panelKart);
            this.Controls.Add(this.lblStartInfo);
            this.Controls.Add(this.lblPunktyWartosc);
            this.Controls.Add(this.lblPunkty);
            this.Controls.Add(this.lblCzasWartosc);
            this.Controls.Add(this.lblCzas);
            this.Name = "MemoryForm";
            this.Text = "Gra w memory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCzas;
        private System.Windows.Forms.Label lblCzasWartosc;
        private System.Windows.Forms.Label lblPunkty;
        private System.Windows.Forms.Label lblPunktyWartosc;
        private System.Windows.Forms.Label lblStartInfo;
        private System.Windows.Forms.Panel panelKart;
        private System.Windows.Forms.Timer timerZakrywacz;
        private System.Windows.Forms.Timer timerCzasGry;
        private System.Windows.Forms.Timer timerCzasPodgladu;
    }
}

