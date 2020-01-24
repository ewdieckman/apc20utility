namespace MIDI_SysEx
{
    partial class Form1
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
            this.lbDevices = new System.Windows.Forms.ListBox();
            this.btnGeneric = new System.Windows.Forms.Button();
            this.btnAbleton = new System.Windows.Forms.Button();
            this.btnAltAbleton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbDevices
            // 
            this.lbDevices.DisplayMember = "Name";
            this.lbDevices.FormattingEnabled = true;
            this.lbDevices.Location = new System.Drawing.Point(76, 44);
            this.lbDevices.Name = "lbDevices";
            this.lbDevices.Size = new System.Drawing.Size(224, 82);
            this.lbDevices.TabIndex = 0;
            this.lbDevices.SelectedIndexChanged += new System.EventHandler(this.lbDevices_SelectedIndexChanged);
            // 
            // btnGeneric
            // 
            this.btnGeneric.Location = new System.Drawing.Point(260, 225);
            this.btnGeneric.Name = "btnGeneric";
            this.btnGeneric.Size = new System.Drawing.Size(95, 33);
            this.btnGeneric.TabIndex = 1;
            this.btnGeneric.Text = "Generic";
            this.btnGeneric.UseVisualStyleBackColor = true;
            this.btnGeneric.Click += new System.EventHandler(this.btnGeneric_Click);
            // 
            // btnAbleton
            // 
            this.btnAbleton.Location = new System.Drawing.Point(76, 179);
            this.btnAbleton.Name = "btnAbleton";
            this.btnAbleton.Size = new System.Drawing.Size(178, 33);
            this.btnAbleton.TabIndex = 2;
            this.btnAbleton.Text = "Ableton Live (Recommended)";
            this.btnAbleton.UseVisualStyleBackColor = true;
            this.btnAbleton.Click += new System.EventHandler(this.btnAbleton_Click);
            // 
            // btnAltAbleton
            // 
            this.btnAltAbleton.Location = new System.Drawing.Point(106, 225);
            this.btnAltAbleton.Name = "btnAltAbleton";
            this.btnAltAbleton.Size = new System.Drawing.Size(148, 33);
            this.btnAltAbleton.TabIndex = 3;
            this.btnAltAbleton.Text = "Alternate Ableton Live";
            this.btnAltAbleton.UseVisualStyleBackColor = true;
            this.btnAltAbleton.Click += new System.EventHandler(this.btnAltAbleton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "1.  Select APC20";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "2.  Click Mode (Ableton Live recommended)";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(51, 310);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(313, 52);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 378);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAltAbleton);
            this.Controls.Add(this.btnAbleton);
            this.Controls.Add(this.btnGeneric);
            this.Controls.Add(this.lbDevices);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APC20 Midi Mode Switcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbDevices;
        private System.Windows.Forms.Button btnGeneric;
        private System.Windows.Forms.Button btnAbleton;
        private System.Windows.Forms.Button btnAltAbleton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
    }
}

