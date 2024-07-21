namespace Pedido_De_Coleta
{
    partial class listHitorico
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.listBoxHistorico = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxHistorico
            // 
            this.listBoxHistorico.FormattingEnabled = true;
            this.listBoxHistorico.Location = new System.Drawing.Point(9, 10);
            this.listBoxHistorico.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxHistorico.Name = "listBoxHistorico";
            this.listBoxHistorico.Size = new System.Drawing.Size(583, 303);
            this.listBoxHistorico.TabIndex = 0;
            this.listBoxHistorico.SelectedIndexChanged += new System.EventHandler(this.list_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(493, 325);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listHitorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxHistorico);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "listHitorico";
            this.Text = "Histórico de Impressões";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.ListBox listBoxHistorico;
        private System.Windows.Forms.Button button1;
    }
}
