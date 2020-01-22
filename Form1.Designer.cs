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
            this.SuspendLayout();
            // 
            // lbDevices
            // 
            this.lbDevices.FormattingEnabled = true;
            this.lbDevices.Location = new System.Drawing.Point(76, 48);
            this.lbDevices.Name = "lbDevices";
            this.lbDevices.Size = new System.Drawing.Size(143, 108);
            this.lbDevices.TabIndex = 0;
            this.lbDevices.SelectedIndexChanged += new System.EventHandler(this.lbDevices_SelectedIndexChanged);
            // 
            // btnGeneric
            // 
            this.btnGeneric.Location = new System.Drawing.Point(75, 240);
            this.btnGeneric.Name = "btnGeneric";
            this.btnGeneric.Size = new System.Drawing.Size(95, 33);
            this.btnGeneric.TabIndex = 1;
            this.btnGeneric.Text = "Generic";
            this.btnGeneric.UseVisualStyleBackColor = true;
            this.btnGeneric.Click += new System.EventHandler(this.btnGeneric_Click);
            // 
            // btnAbleton
            // 
            this.btnAbleton.Location = new System.Drawing.Point(186, 240);
            this.btnAbleton.Name = "btnAbleton";
            this.btnAbleton.Size = new System.Drawing.Size(95, 33);
            this.btnAbleton.TabIndex = 2;
            this.btnAbleton.Text = "Ableton Live";
            this.btnAbleton.UseVisualStyleBackColor = true;
            this.btnAbleton.Click += new System.EventHandler(this.btnAbleton_Click);
            // 
            // btnAltAbleton
            // 
            this.btnAltAbleton.Location = new System.Drawing.Point(296, 240);
            this.btnAltAbleton.Name = "btnAltAbleton";
            this.btnAltAbleton.Size = new System.Drawing.Size(148, 33);
            this.btnAltAbleton.TabIndex = 3;
            this.btnAltAbleton.Text = "Alternate Ableton Live";
            this.btnAltAbleton.UseVisualStyleBackColor = true;
            this.btnAltAbleton.Click += new System.EventHandler(this.btnAltAbleton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 302);
            this.Controls.Add(this.btnAltAbleton);
            this.Controls.Add(this.btnAbleton);
            this.Controls.Add(this.btnGeneric);
            this.Controls.Add(this.lbDevices);
            this.Name = "Form1";
            this.Text = "APC20 Midi Mode Switcher";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbDevices;
        private System.Windows.Forms.Button btnGeneric;
        private System.Windows.Forms.Button btnAbleton;
        private System.Windows.Forms.Button btnAltAbleton;
    }
}

