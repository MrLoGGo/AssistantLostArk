namespace AssistantLostArk
{
    partial class MessageForm
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
            this.panelAdd = new System.Windows.Forms.Panel();
            this.panelAlarm = new System.Windows.Forms.Panel();
            this.buttonAlarm = new System.Windows.Forms.Button();
            this.Alarm = new System.Windows.Forms.Panel();
            this.TimeBox = new System.Windows.Forms.MaskedTextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.panelAdd.SuspendLayout();
            this.panelAlarm.SuspendLayout();
            this.Alarm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAdd
            // 
            this.panelAdd.BackColor = System.Drawing.Color.Black;
            this.panelAdd.Controls.Add(this.Alarm);
            this.panelAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAdd.Location = new System.Drawing.Point(0, 0);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(385, 199);
            this.panelAdd.TabIndex = 1;
            // 
            // panelAlarm
            // 
            this.panelAlarm.BackColor = System.Drawing.Color.Black;
            this.panelAlarm.Controls.Add(this.buttonAlarm);
            this.panelAlarm.Location = new System.Drawing.Point(0, 0);
            this.panelAlarm.Name = "panelAlarm";
            this.panelAlarm.Size = new System.Drawing.Size(0, 0);
            this.panelAlarm.TabIndex = 2;
            // 
            // buttonAlarm
            // 
            this.buttonAlarm.BackColor = System.Drawing.Color.Black;
            this.buttonAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAlarm.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAlarm.ForeColor = System.Drawing.Color.White;
            this.buttonAlarm.Location = new System.Drawing.Point(68, 150);
            this.buttonAlarm.Name = "buttonAlarm";
            this.buttonAlarm.Size = new System.Drawing.Size(248, 36);
            this.buttonAlarm.TabIndex = 0;
            this.buttonAlarm.Text = "OK";
            this.buttonAlarm.UseVisualStyleBackColor = false;
            this.buttonAlarm.Click += new System.EventHandler(this.buttonAlarm_Click);
            // 
            // Alarm
            // 
            this.Alarm.Controls.Add(this.buttonOK);
            this.Alarm.Controls.Add(this.TimeBox);
            this.Alarm.Location = new System.Drawing.Point(35, 66);
            this.Alarm.Name = "Alarm";
            this.Alarm.Size = new System.Drawing.Size(314, 66);
            this.Alarm.TabIndex = 0;
            // 
            // TimeBox
            // 
            this.TimeBox.BackColor = System.Drawing.Color.Black;
            this.TimeBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TimeBox.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeBox.ForeColor = System.Drawing.Color.White;
            this.TimeBox.Location = new System.Drawing.Point(3, 17);
            this.TimeBox.Mask = "00:00:00";
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(189, 33);
            this.TimeBox.TabIndex = 0;
            this.TimeBox.Text = "000000";
            this.TimeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TimeBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.Black;
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOK.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonOK.ForeColor = System.Drawing.Color.White;
            this.buttonOK.Location = new System.Drawing.Point(198, 17);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(113, 32);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.button1_Click);
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 199);
            this.Controls.Add(this.panelAlarm);
            this.Controls.Add(this.panelAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MessageForm";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MessageForm_FormClosed);
            this.panelAdd.ResumeLayout(false);
            this.panelAlarm.ResumeLayout(false);
            this.Alarm.ResumeLayout(false);
            this.Alarm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Panel panelAlarm;
        private System.Windows.Forms.Button buttonAlarm;
        private System.Windows.Forms.Panel Alarm;
        private System.Windows.Forms.MaskedTextBox TimeBox;
        private System.Windows.Forms.Button buttonOK;
    }
}