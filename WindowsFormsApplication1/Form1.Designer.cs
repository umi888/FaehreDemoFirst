namespace WindowsFormsApplication1
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
            this.buttonFahrzeugAufnehmen = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonFaehreErzeugen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBaujahr = new System.Windows.Forms.TextBox();
            this.textBoxLänge = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelMeldung = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonFahrzeugAufnehmen
            // 
            this.buttonFahrzeugAufnehmen.Location = new System.Drawing.Point(334, 70);
            this.buttonFahrzeugAufnehmen.Name = "buttonFahrzeugAufnehmen";
            this.buttonFahrzeugAufnehmen.Size = new System.Drawing.Size(75, 23);
            this.buttonFahrzeugAufnehmen.TabIndex = 0;
            this.buttonFahrzeugAufnehmen.Text = "button1";
            this.buttonFahrzeugAufnehmen.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonFaehreErzeugen);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxBaujahr);
            this.groupBox1.Controls.Add(this.textBoxLänge);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Location = new System.Drawing.Point(56, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 192);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FähreDaten";
            // 
            // buttonFaehreErzeugen
            // 
            this.buttonFaehreErzeugen.Location = new System.Drawing.Point(19, 154);
            this.buttonFaehreErzeugen.Name = "buttonFaehreErzeugen";
            this.buttonFaehreErzeugen.Size = new System.Drawing.Size(110, 23);
            this.buttonFaehreErzeugen.TabIndex = 2;
            this.buttonFaehreErzeugen.Text = "Fähre erzeugen";
            this.buttonFaehreErzeugen.UseVisualStyleBackColor = true;
            this.buttonFaehreErzeugen.Click += new System.EventHandler(this.buttonFaehreErzeugen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Baujahr";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Länge";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // textBoxBaujahr
            // 
            this.textBoxBaujahr.Location = new System.Drawing.Point(19, 127);
            this.textBoxBaujahr.Name = "textBoxBaujahr";
            this.textBoxBaujahr.Size = new System.Drawing.Size(110, 20);
            this.textBoxBaujahr.TabIndex = 2;
            // 
            // textBoxLänge
            // 
            this.textBoxLänge.Location = new System.Drawing.Point(19, 91);
            this.textBoxLänge.Name = "textBoxLänge";
            this.textBoxLänge.Size = new System.Drawing.Size(110, 20);
            this.textBoxLänge.TabIndex = 1;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(19, 51);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(110, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelMeldung});
            this.statusStrip1.Location = new System.Drawing.Point(0, 393);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(477, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelMeldung
            // 
            this.toolStripStatusLabelMeldung.Name = "toolStripStatusLabelMeldung";
            this.toolStripStatusLabelMeldung.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabelMeldung.Text = "toolStripStatusLabel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 415);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonFahrzeugAufnehmen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFahrzeugAufnehmen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonFaehreErzeugen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBaujahr;
        private System.Windows.Forms.TextBox textBoxLänge;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMeldung;
    }
}

