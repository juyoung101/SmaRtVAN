namespace GCProject
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OutputDevices_add = new System.Windows.Forms.Button();
            this.InputDevices_add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OutputDevices = new System.Windows.Forms.ListBox();
            this.InputDevices = new System.Windows.Forms.ListBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TimeRemaining = new System.Windows.Forms.Label();
            this.CurrentPowerPlan = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.CurrentStoredPower = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CurrentPowerExpendeture = new System.Windows.Forms.Label();
            this.CurrentPowerGeneration = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.InteriorSensors = new System.Windows.Forms.ListBox();
            this.ExteriorSensors = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.InteriorSensors_add = new System.Windows.Forms.Button();
            this.ExteriorSensors_add = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel1.Controls.Add(this.OutputDevices_add);
            this.panel1.Controls.Add(this.InputDevices_add);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.OutputDevices);
            this.panel1.Controls.Add(this.InputDevices);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 656);
            this.panel1.TabIndex = 0;
            // 
            // OutputDevices_add
            // 
            this.OutputDevices_add.BackColor = System.Drawing.Color.PaleTurquoise;
            this.OutputDevices_add.ForeColor = System.Drawing.Color.DarkMagenta;
            this.OutputDevices_add.Location = new System.Drawing.Point(213, 364);
            this.OutputDevices_add.Name = "OutputDevices_add";
            this.OutputDevices_add.Size = new System.Drawing.Size(47, 25);
            this.OutputDevices_add.TabIndex = 13;
            this.OutputDevices_add.Text = "+";
            this.OutputDevices_add.UseVisualStyleBackColor = false;
            this.OutputDevices_add.Click += new System.EventHandler(this.OutputDevices_add_Click);
            // 
            // InputDevices_add
            // 
            this.InputDevices_add.BackColor = System.Drawing.Color.PaleTurquoise;
            this.InputDevices_add.ForeColor = System.Drawing.Color.DarkMagenta;
            this.InputDevices_add.Location = new System.Drawing.Point(213, 32);
            this.InputDevices_add.Name = "InputDevices_add";
            this.InputDevices_add.Size = new System.Drawing.Size(47, 25);
            this.InputDevices_add.TabIndex = 12;
            this.InputDevices_add.Text = "+";
            this.InputDevices_add.UseVisualStyleBackColor = false;
            this.InputDevices_add.Click += new System.EventHandler(this.InputDevices_add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label2.Location = new System.Drawing.Point(3, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Output Devices";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label1.Location = new System.Drawing.Point(3, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Input Devices";
            // 
            // OutputDevices
            // 
            this.OutputDevices.BackColor = System.Drawing.Color.Thistle;
            this.OutputDevices.FormattingEnabled = true;
            this.OutputDevices.ItemHeight = 20;
            this.OutputDevices.Location = new System.Drawing.Point(0, 392);
            this.OutputDevices.Name = "OutputDevices";
            this.OutputDevices.Size = new System.Drawing.Size(263, 264);
            this.OutputDevices.TabIndex = 2;
            // 
            // InputDevices
            // 
            this.InputDevices.BackColor = System.Drawing.Color.Thistle;
            this.InputDevices.FormattingEnabled = true;
            this.InputDevices.ItemHeight = 20;
            this.InputDevices.Location = new System.Drawing.Point(0, 63);
            this.InputDevices.Name = "InputDevices";
            this.InputDevices.Size = new System.Drawing.Size(263, 264);
            this.InputDevices.TabIndex = 1;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.DarkMagenta;
            this.TitleLabel.Location = new System.Drawing.Point(301, 12);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(768, 47);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "SmaRtVAN - Power Management System";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Thistle;
            this.panel2.Controls.Add(this.TimeRemaining);
            this.panel2.Controls.Add(this.CurrentPowerPlan);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.CurrentStoredPower);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(309, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 264);
            this.panel2.TabIndex = 2;
            // 
            // TimeRemaining
            // 
            this.TimeRemaining.AutoSize = true;
            this.TimeRemaining.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeRemaining.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.TimeRemaining.Location = new System.Drawing.Point(10, 149);
            this.TimeRemaining.Name = "TimeRemaining";
            this.TimeRemaining.Size = new System.Drawing.Size(350, 28);
            this.TimeRemaining.TabIndex = 11;
            this.TimeRemaining.Text = "Est. Remaining Time: 0 min";
            // 
            // CurrentPowerPlan
            // 
            this.CurrentPowerPlan.AutoSize = true;
            this.CurrentPowerPlan.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentPowerPlan.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.CurrentPowerPlan.Location = new System.Drawing.Point(10, 185);
            this.CurrentPowerPlan.Name = "CurrentPowerPlan";
            this.CurrentPowerPlan.Size = new System.Drawing.Size(324, 28);
            this.CurrentPowerPlan.TabIndex = 10;
            this.CurrentPowerPlan.Text = "Current Power Plan: None";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button2.ForeColor = System.Drawing.Color.DarkMagenta;
            this.button2.Location = new System.Drawing.Point(12, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 40);
            this.button2.TabIndex = 9;
            this.button2.Text = "Analytics";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.ForeColor = System.Drawing.Color.DarkMagenta;
            this.button1.Location = new System.Drawing.Point(153, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "Create Power Plan";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // CurrentStoredPower
            // 
            this.CurrentStoredPower.AutoSize = true;
            this.CurrentStoredPower.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentStoredPower.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.CurrentStoredPower.Location = new System.Drawing.Point(12, 59);
            this.CurrentStoredPower.Name = "CurrentStoredPower";
            this.CurrentStoredPower.Size = new System.Drawing.Size(355, 84);
            this.CurrentStoredPower.TabIndex = 7;
            this.CurrentStoredPower.Text = "0.00 MaH";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel3.Controls.Add(this.CurrentPowerExpendeture);
            this.panel3.Controls.Add(this.CurrentPowerGeneration);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(378, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(381, 263);
            this.panel3.TabIndex = 6;
            // 
            // CurrentPowerExpendeture
            // 
            this.CurrentPowerExpendeture.AutoSize = true;
            this.CurrentPowerExpendeture.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentPowerExpendeture.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.CurrentPowerExpendeture.Location = new System.Drawing.Point(16, 189);
            this.CurrentPowerExpendeture.Name = "CurrentPowerExpendeture";
            this.CurrentPowerExpendeture.Size = new System.Drawing.Size(232, 56);
            this.CurrentPowerExpendeture.TabIndex = 9;
            this.CurrentPowerExpendeture.Text = "0.00 MaH";
            // 
            // CurrentPowerGeneration
            // 
            this.CurrentPowerGeneration.AutoSize = true;
            this.CurrentPowerGeneration.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentPowerGeneration.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.CurrentPowerGeneration.Location = new System.Drawing.Point(16, 59);
            this.CurrentPowerGeneration.Name = "CurrentPowerGeneration";
            this.CurrentPowerGeneration.Size = new System.Drawing.Size(232, 56);
            this.CurrentPowerGeneration.TabIndex = 8;
            this.CurrentPowerGeneration.Text = "0.00 MaH";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Thistle;
            this.label5.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label5.Location = new System.Drawing.Point(-1, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(383, 50);
            this.label5.TabIndex = 8;
            this.label5.Text = "Current Expendeture";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Thistle;
            this.label4.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label4.Location = new System.Drawing.Point(-1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(383, 50);
            this.label4.TabIndex = 7;
            this.label4.Text = "Current Generation";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LemonChiffon;
            this.label3.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label3.Location = new System.Drawing.Point(2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(379, 50);
            this.label3.TabIndex = 5;
            this.label3.Text = "Current Stored Power";
            // 
            // InteriorSensors
            // 
            this.InteriorSensors.BackColor = System.Drawing.Color.Thistle;
            this.InteriorSensors.FormattingEnabled = true;
            this.InteriorSensors.ItemHeight = 20;
            this.InteriorSensors.Location = new System.Drawing.Point(309, 404);
            this.InteriorSensors.Name = "InteriorSensors";
            this.InteriorSensors.Size = new System.Drawing.Size(381, 264);
            this.InteriorSensors.TabIndex = 3;
            // 
            // ExteriorSensors
            // 
            this.ExteriorSensors.BackColor = System.Drawing.Color.Thistle;
            this.ExteriorSensors.FormattingEnabled = true;
            this.ExteriorSensors.ItemHeight = 20;
            this.ExteriorSensors.Location = new System.Drawing.Point(688, 404);
            this.ExteriorSensors.Name = "ExteriorSensors";
            this.ExteriorSensors.Size = new System.Drawing.Size(381, 264);
            this.ExteriorSensors.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.LemonChiffon;
            this.label11.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label11.Location = new System.Drawing.Point(311, 353);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(379, 50);
            this.label11.TabIndex = 12;
            this.label11.Text = "Interior Sensors";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.LemonChiffon;
            this.label12.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label12.Location = new System.Drawing.Point(688, 353);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(379, 50);
            this.label12.TabIndex = 13;
            this.label12.Text = "Exterior Sensors";
            // 
            // InteriorSensors_add
            // 
            this.InteriorSensors_add.BackColor = System.Drawing.Color.PaleTurquoise;
            this.InteriorSensors_add.ForeColor = System.Drawing.Color.DarkMagenta;
            this.InteriorSensors_add.Location = new System.Drawing.Point(622, 365);
            this.InteriorSensors_add.Name = "InteriorSensors_add";
            this.InteriorSensors_add.Size = new System.Drawing.Size(47, 25);
            this.InteriorSensors_add.TabIndex = 14;
            this.InteriorSensors_add.Text = "+";
            this.InteriorSensors_add.UseVisualStyleBackColor = false;
            this.InteriorSensors_add.Click += new System.EventHandler(this.InteriorSensors_add_Click);
            // 
            // ExteriorSensors_add
            // 
            this.ExteriorSensors_add.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ExteriorSensors_add.ForeColor = System.Drawing.Color.DarkMagenta;
            this.ExteriorSensors_add.Location = new System.Drawing.Point(1008, 365);
            this.ExteriorSensors_add.Name = "ExteriorSensors_add";
            this.ExteriorSensors_add.Size = new System.Drawing.Size(47, 25);
            this.ExteriorSensors_add.TabIndex = 15;
            this.ExteriorSensors_add.Text = "+";
            this.ExteriorSensors_add.UseVisualStyleBackColor = false;
            this.ExteriorSensors_add.Click += new System.EventHandler(this.ExteriorSensors_add_Click);
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1107, 680);
            this.Controls.Add(this.ExteriorSensors_add);
            this.Controls.Add(this.InteriorSensors_add);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ExteriorSensors);
            this.Controls.Add(this.InteriorSensors);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox OutputDevices;
        private System.Windows.Forms.ListBox InputDevices;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OutputDevices_add;
        private System.Windows.Forms.Button InputDevices_add;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label TimeRemaining;
        private System.Windows.Forms.Label CurrentPowerPlan;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label CurrentStoredPower;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label CurrentPowerExpendeture;
        private System.Windows.Forms.Label CurrentPowerGeneration;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox InteriorSensors;
        private System.Windows.Forms.ListBox ExteriorSensors;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button InteriorSensors_add;
        private System.Windows.Forms.Button ExteriorSensors_add;
        private System.Windows.Forms.Timer Timer;
    }
}

