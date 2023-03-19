namespace AssistantLostArk
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonOpenGameCenter = new System.Windows.Forms.Button();
            this.stopwatchLable = new System.Windows.Forms.MaskedTextBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonGo = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonStop = new System.Windows.Forms.ToolStripButton();
            this.timerLable = new System.Windows.Forms.MaskedTextBox();
            this.labelEfonUnion = new System.Windows.Forms.Label();
            this.textBoxEfonUnion = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonArgos = new System.Windows.Forms.Button();
            this.buttonEfonUnion = new System.Windows.Forms.Button();
            this.buttonAlarm = new System.Windows.Forms.Button();
            this.buttonStopwatch = new System.Windows.Forms.Button();
            this.buttonTimer = new System.Windows.Forms.Button();
            this.buttonMain = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.panelEfonUnion = new System.Windows.Forms.Panel();
            this.panelTimerAndStopwatch = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelAlarm = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainAlarmPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panelArgos = new System.Windows.Forms.Panel();
            this.toolStrip2.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelEfonUnion.SuspendLayout();
            this.panelTimerAndStopwatch.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelAlarm.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOpenGameCenter
            // 
            this.buttonOpenGameCenter.BackgroundImage = global::AssistantLostArk.Properties.Resources.buttonUp;
            this.buttonOpenGameCenter.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonOpenGameCenter.FlatAppearance.BorderSize = 0;
            this.buttonOpenGameCenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenGameCenter.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenGameCenter.Location = new System.Drawing.Point(524, 367);
            this.buttonOpenGameCenter.Name = "buttonOpenGameCenter";
            this.buttonOpenGameCenter.Size = new System.Drawing.Size(211, 39);
            this.buttonOpenGameCenter.TabIndex = 2;
            this.buttonOpenGameCenter.TabStop = false;
            this.buttonOpenGameCenter.Text = "Запустить GameCenter";
            this.buttonOpenGameCenter.UseVisualStyleBackColor = true;
            this.buttonOpenGameCenter.Click += new System.EventHandler(this.buttonOpenGameCenter_Click);
            this.buttonOpenGameCenter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            this.buttonOpenGameCenter.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
            // 
            // stopwatchLable
            // 
            this.stopwatchLable.BackColor = System.Drawing.Color.Black;
            this.stopwatchLable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stopwatchLable.Enabled = false;
            this.stopwatchLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stopwatchLable.ForeColor = System.Drawing.Color.White;
            this.stopwatchLable.Location = new System.Drawing.Point(535, 226);
            this.stopwatchLable.Mask = "00:00:00";
            this.stopwatchLable.Name = "stopwatchLable";
            this.stopwatchLable.Size = new System.Drawing.Size(210, 55);
            this.stopwatchLable.TabIndex = 8;
            this.stopwatchLable.Text = "000000";
            this.stopwatchLable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip2.BackColor = System.Drawing.Color.Black;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonGo,
            this.toolStripButtonStop});
            this.toolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip2.Location = new System.Drawing.Point(601, 200);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip2.Size = new System.Drawing.Size(77, 22);
            this.toolStrip2.TabIndex = 9;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButtonGo
            // 
            this.toolStripButtonGo.BackColor = System.Drawing.Color.Black;
            this.toolStripButtonGo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonGo.ForeColor = System.Drawing.Color.White;
            this.toolStripButtonGo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonGo.Image")));
            this.toolStripButtonGo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGo.Name = "toolStripButtonGo";
            this.toolStripButtonGo.Size = new System.Drawing.Size(38, 19);
            this.toolStripButtonGo.Text = "Пуск";
            this.toolStripButtonGo.Click += new System.EventHandler(this.toolStripButtonGo_Click);
            // 
            // toolStripButtonStop
            // 
            this.toolStripButtonStop.BackColor = System.Drawing.Color.Black;
            this.toolStripButtonStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonStop.ForeColor = System.Drawing.Color.White;
            this.toolStripButtonStop.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonStop.Image")));
            this.toolStripButtonStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStop.Name = "toolStripButtonStop";
            this.toolStripButtonStop.Size = new System.Drawing.Size(38, 19);
            this.toolStripButtonStop.Text = "Стоп";
            this.toolStripButtonStop.Click += new System.EventHandler(this.toolStripButtonStop_Click);
            // 
            // timerLable
            // 
            this.timerLable.BackColor = System.Drawing.Color.Black;
            this.timerLable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timerLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timerLable.ForeColor = System.Drawing.Color.White;
            this.timerLable.Location = new System.Drawing.Point(535, 226);
            this.timerLable.Mask = "00:00:00";
            this.timerLable.Name = "timerLable";
            this.timerLable.Size = new System.Drawing.Size(210, 55);
            this.timerLable.TabIndex = 10;
            this.timerLable.Text = "000000";
            this.timerLable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelEfonUnion
            // 
            this.labelEfonUnion.BackColor = System.Drawing.SystemColors.MenuText;
            this.labelEfonUnion.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEfonUnion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelEfonUnion.Location = new System.Drawing.Point(237, 15);
            this.labelEfonUnion.Name = "labelEfonUnion";
            this.labelEfonUnion.Size = new System.Drawing.Size(303, 23);
            this.labelEfonUnion.TabIndex = 12;
            this.labelEfonUnion.Text = "Эфонский союз";
            this.labelEfonUnion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxEfonUnion
            // 
            this.textBoxEfonUnion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEfonUnion.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEfonUnion.Location = new System.Drawing.Point(237, 62);
            this.textBoxEfonUnion.Multiline = true;
            this.textBoxEfonUnion.Name = "textBoxEfonUnion";
            this.textBoxEfonUnion.Size = new System.Drawing.Size(303, 371);
            this.textBoxEfonUnion.TabIndex = 11;
            this.textBoxEfonUnion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxEfonUnion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxEfonUnion_KeyDown);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(12, 27);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(174, 35);
            this.buttonSave.TabIndex = 13;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(762, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "test";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.Transparent;
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.Location = new System.Drawing.Point(13, 397);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(174, 36);
            this.buttonDel.TabIndex = 0;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Transparent;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(198, 397);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(174, 36);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackgroundImage = global::AssistantLostArk.Properties.Resources.BackgroundForMenu;
            this.panelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMenu.Controls.Add(this.panelButtons);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(0, 0);
            this.panelMenu.TabIndex = 15;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.buttonArgos);
            this.panelButtons.Controls.Add(this.buttonEfonUnion);
            this.panelButtons.Controls.Add(this.buttonAlarm);
            this.panelButtons.Controls.Add(this.buttonStopwatch);
            this.panelButtons.Controls.Add(this.buttonTimer);
            this.panelButtons.Controls.Add(this.buttonMain);
            this.panelButtons.Location = new System.Drawing.Point(233, 44);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(333, 351);
            this.panelButtons.TabIndex = 0;
            // 
            // buttonArgos
            // 
            this.buttonArgos.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonArgos.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonArgos.ForeColor = System.Drawing.Color.White;
            this.buttonArgos.Location = new System.Drawing.Point(41, 242);
            this.buttonArgos.Name = "buttonArgos";
            this.buttonArgos.Size = new System.Drawing.Size(251, 38);
            this.buttonArgos.TabIndex = 5;
            this.buttonArgos.Text = "Аргос";
            this.buttonArgos.UseVisualStyleBackColor = false;
            this.buttonArgos.Click += new System.EventHandler(this.buttonArgos_Click);
            // 
            // buttonEfonUnion
            // 
            this.buttonEfonUnion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonEfonUnion.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEfonUnion.ForeColor = System.Drawing.Color.White;
            this.buttonEfonUnion.Location = new System.Drawing.Point(41, 198);
            this.buttonEfonUnion.Name = "buttonEfonUnion";
            this.buttonEfonUnion.Size = new System.Drawing.Size(251, 38);
            this.buttonEfonUnion.TabIndex = 4;
            this.buttonEfonUnion.Text = "Эфонский союз";
            this.buttonEfonUnion.UseVisualStyleBackColor = false;
            this.buttonEfonUnion.Click += new System.EventHandler(this.buttonEfonUnion_Click);
            // 
            // buttonAlarm
            // 
            this.buttonAlarm.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAlarm.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAlarm.ForeColor = System.Drawing.Color.White;
            this.buttonAlarm.Location = new System.Drawing.Point(41, 154);
            this.buttonAlarm.Name = "buttonAlarm";
            this.buttonAlarm.Size = new System.Drawing.Size(251, 38);
            this.buttonAlarm.TabIndex = 3;
            this.buttonAlarm.Text = "Будильник";
            this.buttonAlarm.UseVisualStyleBackColor = false;
            this.buttonAlarm.Click += new System.EventHandler(this.buttonAlarm_Click);
            // 
            // buttonStopwatch
            // 
            this.buttonStopwatch.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonStopwatch.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStopwatch.ForeColor = System.Drawing.Color.White;
            this.buttonStopwatch.Location = new System.Drawing.Point(41, 110);
            this.buttonStopwatch.Name = "buttonStopwatch";
            this.buttonStopwatch.Size = new System.Drawing.Size(251, 38);
            this.buttonStopwatch.TabIndex = 2;
            this.buttonStopwatch.Text = "Секундомер";
            this.buttonStopwatch.UseVisualStyleBackColor = false;
            this.buttonStopwatch.Click += new System.EventHandler(this.buttonStopwatch_Click);
            // 
            // buttonTimer
            // 
            this.buttonTimer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonTimer.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTimer.ForeColor = System.Drawing.Color.White;
            this.buttonTimer.Location = new System.Drawing.Point(41, 66);
            this.buttonTimer.Name = "buttonTimer";
            this.buttonTimer.Size = new System.Drawing.Size(251, 38);
            this.buttonTimer.TabIndex = 1;
            this.buttonTimer.Text = "Таймер";
            this.buttonTimer.UseVisualStyleBackColor = false;
            this.buttonTimer.Click += new System.EventHandler(this.buttonTimer_Click);
            // 
            // buttonMain
            // 
            this.buttonMain.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonMain.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMain.ForeColor = System.Drawing.Color.White;
            this.buttonMain.Location = new System.Drawing.Point(41, 22);
            this.buttonMain.Name = "buttonMain";
            this.buttonMain.Size = new System.Drawing.Size(251, 38);
            this.buttonMain.TabIndex = 0;
            this.buttonMain.Text = "Главная";
            this.buttonMain.UseVisualStyleBackColor = false;
            this.buttonMain.Click += new System.EventHandler(this.buttonMain_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonMenu.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMenu.ForeColor = System.Drawing.Color.White;
            this.buttonMenu.Location = new System.Drawing.Point(703, 410);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(73, 28);
            this.buttonMenu.TabIndex = 6;
            this.buttonMenu.Text = "Меню";
            this.buttonMenu.UseVisualStyleBackColor = false;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // panelEfonUnion
            // 
            this.panelEfonUnion.BackgroundImage = global::AssistantLostArk.Properties.Resources.EfonUnionBackgrount;
            this.panelEfonUnion.Controls.Add(this.buttonSave);
            this.panelEfonUnion.Controls.Add(this.textBoxEfonUnion);
            this.panelEfonUnion.Controls.Add(this.labelEfonUnion);
            this.panelEfonUnion.Location = new System.Drawing.Point(0, 0);
            this.panelEfonUnion.Name = "panelEfonUnion";
            this.panelEfonUnion.Size = new System.Drawing.Size(0, 0);
            this.panelEfonUnion.TabIndex = 16;
            // 
            // panelTimerAndStopwatch
            // 
            this.panelTimerAndStopwatch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTimerAndStopwatch.BackgroundImage = global::AssistantLostArk.Properties.Resources.background;
            this.panelTimerAndStopwatch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelTimerAndStopwatch.Controls.Add(this.toolStrip2);
            this.panelTimerAndStopwatch.Controls.Add(this.stopwatchLable);
            this.panelTimerAndStopwatch.Controls.Add(this.timerLable);
            this.panelTimerAndStopwatch.Location = new System.Drawing.Point(0, 0);
            this.panelTimerAndStopwatch.Name = "panelTimerAndStopwatch";
            this.panelTimerAndStopwatch.Size = new System.Drawing.Size(0, 0);
            this.panelTimerAndStopwatch.TabIndex = 17;
            // 
            // panelMain
            // 
            this.panelMain.BackgroundImage = global::AssistantLostArk.Properties.Resources.background;
            this.panelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelMain.Controls.Add(this.buttonOpenGameCenter);
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(0, 0);
            this.panelMain.TabIndex = 18;
            // 
            // panelAlarm
            // 
            this.panelAlarm.BackgroundImage = global::AssistantLostArk.Properties.Resources.BackgroundForAlarm;
            this.panelAlarm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelAlarm.Controls.Add(this.panel1);
            this.panelAlarm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAlarm.Location = new System.Drawing.Point(0, 0);
            this.panelAlarm.Name = "panelAlarm";
            this.panelAlarm.Size = new System.Drawing.Size(798, 449);
            this.panelAlarm.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.buttonDel);
            this.panel1.Controls.Add(this.mainAlarmPanel);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 449);
            this.panel1.TabIndex = 8;
            // 
            // mainAlarmPanel
            // 
            this.mainAlarmPanel.AutoScroll = true;
            this.mainAlarmPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainAlarmPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.mainAlarmPanel.Location = new System.Drawing.Point(32, 27);
            this.mainAlarmPanel.Name = "mainAlarmPanel";
            this.mainAlarmPanel.Size = new System.Drawing.Size(320, 332);
            this.mainAlarmPanel.TabIndex = 7;
            // 
            // panelArgos
            // 
            this.panelArgos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelArgos.Location = new System.Drawing.Point(0, 0);
            this.panelArgos.Name = "panelArgos";
            this.panelArgos.Size = new System.Drawing.Size(0, 0);
            this.panelArgos.TabIndex = 20;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(798, 449);
            this.Controls.Add(this.panelArgos);
            this.Controls.Add(this.panelAlarm);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTimerAndStopwatch);
            this.Controls.Add(this.panelEfonUnion);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Помошник";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelEfonUnion.ResumeLayout(false);
            this.panelEfonUnion.PerformLayout();
            this.panelTimerAndStopwatch.ResumeLayout(false);
            this.panelTimerAndStopwatch.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelAlarm.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonOpenGameCenter;
        private System.Windows.Forms.MaskedTextBox stopwatchLable;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButtonGo;
        private System.Windows.Forms.ToolStripButton toolStripButtonStop;
        private System.Windows.Forms.MaskedTextBox timerLable;
        private System.Windows.Forms.Label labelEfonUnion;
        private System.Windows.Forms.TextBox textBoxEfonUnion;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button buttonMain;
        private System.Windows.Forms.Button buttonTimer;
        private System.Windows.Forms.Button buttonArgos;
        private System.Windows.Forms.Button buttonEfonUnion;
        private System.Windows.Forms.Button buttonAlarm;
        private System.Windows.Forms.Button buttonStopwatch;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Panel panelEfonUnion;
        private System.Windows.Forms.Panel panelTimerAndStopwatch;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelAlarm;
        private System.Windows.Forms.Panel panelArgos;
        private System.Windows.Forms.FlowLayoutPanel mainAlarmPanel;
        private System.Windows.Forms.Panel panel1;
    }
}

