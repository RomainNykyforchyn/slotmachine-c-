namespace Slotmachine
{
    partial class Form1
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
            this.Nr3 = new System.Windows.Forms.TextBox();
            this.Nr2 = new System.Windows.Forms.TextBox();
            this.Nr1 = new System.Windows.Forms.TextBox();
            this.Titel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Gewinn = new System.Windows.Forms.TextBox();
            this.gewinntext = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Einsatz = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nr3
            // 
            this.Nr3.Font = new System.Drawing.Font("Microsoft Sans Serif", 65F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nr3.Location = new System.Drawing.Point(561, 152);
            this.Nr3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Nr3.Name = "Nr3";
            this.Nr3.ReadOnly = true;
            this.Nr3.Size = new System.Drawing.Size(114, 130);
            this.Nr3.TabIndex = 1;
            // 
            // Nr2
            // 
            this.Nr2.Font = new System.Drawing.Font("Microsoft Sans Serif", 65F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nr2.Location = new System.Drawing.Point(308, 152);
            this.Nr2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Nr2.Name = "Nr2";
            this.Nr2.ReadOnly = true;
            this.Nr2.Size = new System.Drawing.Size(114, 130);
            this.Nr2.TabIndex = 2;
            this.Nr2.TextChanged += new System.EventHandler(this.Nr2_TextChanged);
            // 
            // Nr1
            // 
            this.Nr1.Font = new System.Drawing.Font("Microsoft Sans Serif", 65F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nr1.Location = new System.Drawing.Point(58, 152);
            this.Nr1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Nr1.Name = "Nr1";
            this.Nr1.ReadOnly = true;
            this.Nr1.Size = new System.Drawing.Size(114, 130);
            this.Nr1.TabIndex = 3;
            // 
            // Titel
            // 
            this.Titel.AutoSize = true;
            this.Titel.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Titel.Location = new System.Drawing.Point(166, 45);
            this.Titel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Titel.Name = "Titel";
            this.Titel.Size = new System.Drawing.Size(398, 51);
            this.Titel.TabIndex = 4;
            this.Titel.Text = "Slot Machine 3000";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button1.Location = new System.Drawing.Point(281, 364);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 87);
            this.button1.TabIndex = 5;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Gewinn
            // 
            this.Gewinn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gewinn.Location = new System.Drawing.Point(281, 490);
            this.Gewinn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Gewinn.Name = "Gewinn";
            this.Gewinn.ReadOnly = true;
            this.Gewinn.Size = new System.Drawing.Size(164, 45);
            this.Gewinn.TabIndex = 6;
            // 
            // gewinntext
            // 
            this.gewinntext.AutoSize = true;
            this.gewinntext.ForeColor = System.Drawing.SystemColors.Desktop;
            this.gewinntext.Location = new System.Drawing.Point(325, 471);
            this.gewinntext.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gewinntext.Name = "gewinntext";
            this.gewinntext.Size = new System.Drawing.Size(59, 17);
            this.gewinntext.TabIndex = 7;
            this.gewinntext.Text = "Gewinn:";
            this.gewinntext.Click += new System.EventHandler(this.gewinntext_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(326, 319);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Einsatz:";
            // 
            // Einsatz
            // 
            this.Einsatz.Location = new System.Drawing.Point(281, 338);
            this.Einsatz.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Einsatz.Name = "Einsatz";
            this.Einsatz.Size = new System.Drawing.Size(164, 22);
            this.Einsatz.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 319);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 216);
            this.panel1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Spielregeln";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(7, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Einsatz eingeben und Start drücken";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(7, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Sind 3 Nummern gleich, wird der";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(7, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Einsatz mit 20 multipliziert";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(7, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Sind 2 Nummern gleich, wir der";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(7, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Einsatz mit 2 multipliziert";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(10, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Sonst passiert nichts :)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 553);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Einsatz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gewinntext);
            this.Controls.Add(this.Gewinn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Titel);
            this.Controls.Add(this.Nr1);
            this.Controls.Add(this.Nr2);
            this.Controls.Add(this.Nr3);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Slot Machine 3000";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Nr3;
        private System.Windows.Forms.TextBox Nr2;
        private System.Windows.Forms.TextBox Nr1;
        private System.Windows.Forms.Label Titel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Gewinn;
        private System.Windows.Forms.Label gewinntext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Einsatz;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

