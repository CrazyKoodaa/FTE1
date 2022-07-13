namespace Gondel
{
    partial class Gondelzähler
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.dazu = new System.Windows.Forms.Button();
            this.zaehler = new System.Windows.Forms.TextBox();
            this.weg = new System.Windows.Forms.Button();
            this.counter = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dazu
            // 
            this.dazu.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dazu.Location = new System.Drawing.Point(66, 261);
            this.dazu.Name = "dazu";
            this.dazu.Size = new System.Drawing.Size(233, 80);
            this.dazu.TabIndex = 0;
            this.dazu.Text = "dazu";
            this.dazu.UseVisualStyleBackColor = true;
            this.dazu.Click += new System.EventHandler(this.hinzuzaehlen);
            // 
            // zaehler
            // 
            this.zaehler.Font = new System.Drawing.Font("MS PGothic", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zaehler.Location = new System.Drawing.Point(300, 107);
            this.zaehler.Name = "zaehler";
            this.zaehler.Size = new System.Drawing.Size(293, 63);
            this.zaehler.TabIndex = 1;
            this.zaehler.Text = "0";
            // 
            // weg
            // 
            this.weg.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weg.Location = new System.Drawing.Point(360, 261);
            this.weg.Name = "weg";
            this.weg.Size = new System.Drawing.Size(233, 80);
            this.weg.TabIndex = 2;
            this.weg.Text = "weg";
            this.weg.UseVisualStyleBackColor = true;
            this.weg.Click += new System.EventHandler(this.wegnehmen);
            // 
            // counter
            // 
            this.counter.AutoSize = true;
            this.counter.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counter.Location = new System.Drawing.Point(51, 95);
            this.counter.Name = "counter";
            this.counter.Size = new System.Drawing.Size(175, 86);
            this.counter.TabIndex = 3;
            this.counter.Text = "Gäste:";
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(300, 202);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 4;
            this.exit.Text = "exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Visible = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Gondelzähler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 407);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.counter);
            this.Controls.Add(this.weg);
            this.Controls.Add(this.zaehler);
            this.Controls.Add(this.dazu);
            this.Name = "Gondelzähler";
            this.Text = "Gondelzähler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dazu;
        private System.Windows.Forms.TextBox zaehler;
        private System.Windows.Forms.Button weg;
        private System.Windows.Forms.Label counter;
        private System.Windows.Forms.Button exit;
    }
}

