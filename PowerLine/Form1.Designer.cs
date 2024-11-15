namespace PowerLine
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            listView1 = new ListView();
            timer1 = new System.Windows.Forms.Timer(components);
            groupBox1 = new GroupBox();
            txtpf1 = new TextBox();
            lblpf1 = new Label();
            txtfrequency1 = new TextBox();
            lblfrequency1 = new Label();
            txtenergy1 = new TextBox();
            lblenergy1 = new Label();
            txtpower1 = new TextBox();
            lblpower1 = new Label();
            txtcurrent1 = new TextBox();
            lblcurrent1 = new Label();
            txtvoltage1 = new TextBox();
            lblvoltage1 = new Label();
            groupBox2 = new GroupBox();
            txtpf2 = new TextBox();
            lblpf2 = new Label();
            txtfrequency2 = new TextBox();
            lblfrequency2 = new Label();
            txtenergy2 = new TextBox();
            lblenergy2 = new Label();
            txtpower2 = new TextBox();
            lblpower2 = new Label();
            txtcurrent2 = new TextBox();
            lblcurrent2 = new Label();
            txtvoltage2 = new TextBox();
            lblvoltage2 = new Label();
            groupBox3 = new GroupBox();
            txtpf3 = new TextBox();
            lblpf3 = new Label();
            txtfrequency3 = new TextBox();
            lblfrequency3 = new Label();
            txtenergy3 = new TextBox();
            lblenergy3 = new Label();
            txtpower3 = new TextBox();
            lblpower3 = new Label();
            txtcurrent3 = new TextBox();
            lblcurrent3 = new Label();
            txtvoltage3 = new TextBox();
            lblvoltage3 = new Label();
            groupBox4 = new GroupBox();
            button2 = new Button();
            label1 = new Label();
            button1 = new Button();
            comboBox1 = new ComboBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listView1.Location = new Point(14, 490);
            listView1.Name = "listView1";
            listView1.Size = new Size(1098, 282);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtpf1);
            groupBox1.Controls.Add(lblpf1);
            groupBox1.Controls.Add(txtfrequency1);
            groupBox1.Controls.Add(lblfrequency1);
            groupBox1.Controls.Add(txtenergy1);
            groupBox1.Controls.Add(lblenergy1);
            groupBox1.Controls.Add(txtpower1);
            groupBox1.Controls.Add(lblpower1);
            groupBox1.Controls.Add(txtcurrent1);
            groupBox1.Controls.Add(lblcurrent1);
            groupBox1.Controls.Add(txtvoltage1);
            groupBox1.Controls.Add(lblvoltage1);
            groupBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(14, 156);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(362, 328);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Line1";
            // 
            // txtpf1
            // 
            txtpf1.Location = new Point(168, 265);
            txtpf1.Name = "txtpf1";
            txtpf1.Size = new Size(180, 39);
            txtpf1.TabIndex = 11;
            // 
            // lblpf1
            // 
            lblpf1.AutoSize = true;
            lblpf1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblpf1.Location = new Point(37, 265);
            lblpf1.Name = "lblpf1";
            lblpf1.Size = new Size(32, 30);
            lblpf1.TabIndex = 10;
            lblpf1.Text = "Pf";
            // 
            // txtfrequency1
            // 
            txtfrequency1.Location = new Point(168, 220);
            txtfrequency1.Name = "txtfrequency1";
            txtfrequency1.Size = new Size(180, 39);
            txtfrequency1.TabIndex = 9;
            // 
            // lblfrequency1
            // 
            lblfrequency1.AutoSize = true;
            lblfrequency1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblfrequency1.Location = new Point(37, 220);
            lblfrequency1.Name = "lblfrequency1";
            lblfrequency1.Size = new Size(108, 30);
            lblfrequency1.TabIndex = 8;
            lblfrequency1.Text = "Frequency";
            // 
            // txtenergy1
            // 
            txtenergy1.Location = new Point(168, 172);
            txtenergy1.Name = "txtenergy1";
            txtenergy1.Size = new Size(180, 39);
            txtenergy1.TabIndex = 7;
            // 
            // lblenergy1
            // 
            lblenergy1.AutoSize = true;
            lblenergy1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblenergy1.Location = new Point(37, 175);
            lblenergy1.Name = "lblenergy1";
            lblenergy1.Size = new Size(76, 30);
            lblenergy1.TabIndex = 6;
            lblenergy1.Text = "Energy";
            // 
            // txtpower1
            // 
            txtpower1.Location = new Point(168, 127);
            txtpower1.Name = "txtpower1";
            txtpower1.Size = new Size(180, 39);
            txtpower1.TabIndex = 5;
            // 
            // lblpower1
            // 
            lblpower1.AutoSize = true;
            lblpower1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblpower1.Location = new Point(37, 130);
            lblpower1.Name = "lblpower1";
            lblpower1.Size = new Size(69, 30);
            lblpower1.TabIndex = 4;
            lblpower1.Text = "Power";
            // 
            // txtcurrent1
            // 
            txtcurrent1.Location = new Point(168, 85);
            txtcurrent1.Name = "txtcurrent1";
            txtcurrent1.Size = new Size(180, 39);
            txtcurrent1.TabIndex = 3;
            // 
            // lblcurrent1
            // 
            lblcurrent1.AutoSize = true;
            lblcurrent1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblcurrent1.Location = new Point(37, 85);
            lblcurrent1.Name = "lblcurrent1";
            lblcurrent1.Size = new Size(82, 30);
            lblcurrent1.TabIndex = 2;
            lblcurrent1.Text = "Current";
            // 
            // txtvoltage1
            // 
            txtvoltage1.Location = new Point(168, 40);
            txtvoltage1.Name = "txtvoltage1";
            txtvoltage1.Size = new Size(180, 39);
            txtvoltage1.TabIndex = 1;
            // 
            // lblvoltage1
            // 
            lblvoltage1.AutoSize = true;
            lblvoltage1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblvoltage1.Location = new Point(37, 40);
            lblvoltage1.Name = "lblvoltage1";
            lblvoltage1.Size = new Size(83, 30);
            lblvoltage1.TabIndex = 0;
            lblvoltage1.Text = "Voltage";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtpf2);
            groupBox2.Controls.Add(lblpf2);
            groupBox2.Controls.Add(txtfrequency2);
            groupBox2.Controls.Add(lblfrequency2);
            groupBox2.Controls.Add(txtenergy2);
            groupBox2.Controls.Add(lblenergy2);
            groupBox2.Controls.Add(txtpower2);
            groupBox2.Controls.Add(lblpower2);
            groupBox2.Controls.Add(txtcurrent2);
            groupBox2.Controls.Add(lblcurrent2);
            groupBox2.Controls.Add(txtvoltage2);
            groupBox2.Controls.Add(lblvoltage2);
            groupBox2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(382, 156);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(362, 328);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Line2";
            // 
            // txtpf2
            // 
            txtpf2.Location = new Point(168, 265);
            txtpf2.Name = "txtpf2";
            txtpf2.Size = new Size(180, 39);
            txtpf2.TabIndex = 11;
            // 
            // lblpf2
            // 
            lblpf2.AutoSize = true;
            lblpf2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblpf2.Location = new Point(37, 265);
            lblpf2.Name = "lblpf2";
            lblpf2.Size = new Size(32, 30);
            lblpf2.TabIndex = 10;
            lblpf2.Text = "Pf";
            // 
            // txtfrequency2
            // 
            txtfrequency2.Location = new Point(168, 220);
            txtfrequency2.Name = "txtfrequency2";
            txtfrequency2.Size = new Size(180, 39);
            txtfrequency2.TabIndex = 9;
            // 
            // lblfrequency2
            // 
            lblfrequency2.AutoSize = true;
            lblfrequency2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblfrequency2.Location = new Point(37, 220);
            lblfrequency2.Name = "lblfrequency2";
            lblfrequency2.Size = new Size(108, 30);
            lblfrequency2.TabIndex = 8;
            lblfrequency2.Text = "Frequency";
            // 
            // txtenergy2
            // 
            txtenergy2.Location = new Point(168, 172);
            txtenergy2.Name = "txtenergy2";
            txtenergy2.Size = new Size(180, 39);
            txtenergy2.TabIndex = 7;
            // 
            // lblenergy2
            // 
            lblenergy2.AutoSize = true;
            lblenergy2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblenergy2.Location = new Point(37, 175);
            lblenergy2.Name = "lblenergy2";
            lblenergy2.Size = new Size(76, 30);
            lblenergy2.TabIndex = 6;
            lblenergy2.Text = "Energy";
            // 
            // txtpower2
            // 
            txtpower2.Location = new Point(168, 127);
            txtpower2.Name = "txtpower2";
            txtpower2.Size = new Size(180, 39);
            txtpower2.TabIndex = 5;
            // 
            // lblpower2
            // 
            lblpower2.AutoSize = true;
            lblpower2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblpower2.Location = new Point(37, 130);
            lblpower2.Name = "lblpower2";
            lblpower2.Size = new Size(69, 30);
            lblpower2.TabIndex = 4;
            lblpower2.Text = "Power";
            // 
            // txtcurrent2
            // 
            txtcurrent2.Location = new Point(168, 85);
            txtcurrent2.Name = "txtcurrent2";
            txtcurrent2.Size = new Size(180, 39);
            txtcurrent2.TabIndex = 3;
            // 
            // lblcurrent2
            // 
            lblcurrent2.AutoSize = true;
            lblcurrent2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblcurrent2.Location = new Point(37, 85);
            lblcurrent2.Name = "lblcurrent2";
            lblcurrent2.Size = new Size(82, 30);
            lblcurrent2.TabIndex = 2;
            lblcurrent2.Text = "Current";
            // 
            // txtvoltage2
            // 
            txtvoltage2.Location = new Point(168, 40);
            txtvoltage2.Name = "txtvoltage2";
            txtvoltage2.Size = new Size(180, 39);
            txtvoltage2.TabIndex = 1;
            // 
            // lblvoltage2
            // 
            lblvoltage2.AutoSize = true;
            lblvoltage2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblvoltage2.Location = new Point(37, 40);
            lblvoltage2.Name = "lblvoltage2";
            lblvoltage2.Size = new Size(83, 30);
            lblvoltage2.TabIndex = 0;
            lblvoltage2.Text = "Voltage";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtpf3);
            groupBox3.Controls.Add(lblpf3);
            groupBox3.Controls.Add(txtfrequency3);
            groupBox3.Controls.Add(lblfrequency3);
            groupBox3.Controls.Add(txtenergy3);
            groupBox3.Controls.Add(lblenergy3);
            groupBox3.Controls.Add(txtpower3);
            groupBox3.Controls.Add(lblpower3);
            groupBox3.Controls.Add(txtcurrent3);
            groupBox3.Controls.Add(lblcurrent3);
            groupBox3.Controls.Add(txtvoltage3);
            groupBox3.Controls.Add(lblvoltage3);
            groupBox3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(750, 156);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(362, 328);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "Line3";
            // 
            // txtpf3
            // 
            txtpf3.Location = new Point(168, 265);
            txtpf3.Name = "txtpf3";
            txtpf3.Size = new Size(180, 39);
            txtpf3.TabIndex = 11;
            // 
            // lblpf3
            // 
            lblpf3.AutoSize = true;
            lblpf3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblpf3.Location = new Point(37, 265);
            lblpf3.Name = "lblpf3";
            lblpf3.Size = new Size(32, 30);
            lblpf3.TabIndex = 10;
            lblpf3.Text = "Pf";
            // 
            // txtfrequency3
            // 
            txtfrequency3.Location = new Point(168, 220);
            txtfrequency3.Name = "txtfrequency3";
            txtfrequency3.Size = new Size(180, 39);
            txtfrequency3.TabIndex = 9;
            // 
            // lblfrequency3
            // 
            lblfrequency3.AutoSize = true;
            lblfrequency3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblfrequency3.Location = new Point(37, 220);
            lblfrequency3.Name = "lblfrequency3";
            lblfrequency3.Size = new Size(108, 30);
            lblfrequency3.TabIndex = 8;
            lblfrequency3.Text = "Frequency";
            // 
            // txtenergy3
            // 
            txtenergy3.Location = new Point(168, 172);
            txtenergy3.Name = "txtenergy3";
            txtenergy3.Size = new Size(180, 39);
            txtenergy3.TabIndex = 7;
            // 
            // lblenergy3
            // 
            lblenergy3.AutoSize = true;
            lblenergy3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblenergy3.Location = new Point(37, 175);
            lblenergy3.Name = "lblenergy3";
            lblenergy3.Size = new Size(76, 30);
            lblenergy3.TabIndex = 6;
            lblenergy3.Text = "Energy";
            // 
            // txtpower3
            // 
            txtpower3.Location = new Point(168, 127);
            txtpower3.Name = "txtpower3";
            txtpower3.Size = new Size(180, 39);
            txtpower3.TabIndex = 5;
            // 
            // lblpower3
            // 
            lblpower3.AutoSize = true;
            lblpower3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblpower3.Location = new Point(37, 130);
            lblpower3.Name = "lblpower3";
            lblpower3.Size = new Size(69, 30);
            lblpower3.TabIndex = 4;
            lblpower3.Text = "Power";
            // 
            // txtcurrent3
            // 
            txtcurrent3.Location = new Point(168, 85);
            txtcurrent3.Name = "txtcurrent3";
            txtcurrent3.Size = new Size(180, 39);
            txtcurrent3.TabIndex = 3;
            // 
            // lblcurrent3
            // 
            lblcurrent3.AutoSize = true;
            lblcurrent3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblcurrent3.Location = new Point(37, 85);
            lblcurrent3.Name = "lblcurrent3";
            lblcurrent3.Size = new Size(82, 30);
            lblcurrent3.TabIndex = 2;
            lblcurrent3.Text = "Current";
            // 
            // txtvoltage3
            // 
            txtvoltage3.Location = new Point(168, 40);
            txtvoltage3.Name = "txtvoltage3";
            txtvoltage3.Size = new Size(180, 39);
            txtvoltage3.TabIndex = 1;
            // 
            // lblvoltage3
            // 
            lblvoltage3.AutoSize = true;
            lblvoltage3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblvoltage3.Location = new Point(37, 40);
            lblvoltage3.Name = "lblvoltage3";
            lblvoltage3.Size = new Size(83, 30);
            lblvoltage3.TabIndex = 0;
            lblvoltage3.Text = "Voltage";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(button2);
            groupBox4.Controls.Add(label1);
            groupBox4.Controls.Add(button1);
            groupBox4.Controls.Add(comboBox1);
            groupBox4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(14, 32);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1098, 118);
            groupBox4.TabIndex = 14;
            groupBox4.TabStop = false;
            groupBox4.Text = "Select Comport";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(458, 34);
            button2.Name = "button2";
            button2.Size = new Size(75, 49);
            button2.TabIndex = 8;
            button2.Text = "Stop";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 40);
            label1.Name = "label1";
            label1.Size = new Size(94, 30);
            label1.TabIndex = 7;
            label1.Text = "Comport";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(367, 34);
            button1.Name = "button1";
            button1.Size = new Size(75, 49);
            button1.TabIndex = 6;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(126, 40);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(225, 38);
            comboBox1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1133, 784);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(listView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ListView listView1;
        private System.Windows.Forms.Timer timer1;
        private GroupBox groupBox1;
        private Label lblvoltage1;
        private TextBox txtcurrent1;
        private Label lblcurrent1;
        private TextBox txtvoltage1;
        private TextBox txtpower1;
        private Label lblpower1;
        private TextBox txtenergy1;
        private Label lblenergy1;
        private TextBox txtfrequency1;
        private Label lblfrequency1;
        private TextBox txtpf1;
        private Label lblpf1;
        private GroupBox groupBox2;
        private TextBox txtpf2;
        private Label lblpf2;
        private TextBox txtfrequency2;
        private Label lblfrequency2;
        private TextBox txtenergy2;
        private Label lblenergy2;
        private TextBox txtpower2;
        private Label lblpower2;
        private TextBox txtcurrent2;
        private Label lblcurrent2;
        private TextBox txtvoltage2;
        private Label lblvoltage2;
        private GroupBox groupBox3;
        private TextBox txtpf3;
        private Label lblpf3;
        private TextBox txtfrequency3;
        private Label lblfrequency3;
        private TextBox txtenergy3;
        private Label lblenergy3;
        private TextBox txtpower3;
        private Label lblpower3;
        private TextBox txtcurrent3;
        private Label lblcurrent3;
        private TextBox txtvoltage3;
        private Label lblvoltage3;
        private GroupBox groupBox4;
        private Button button2;
        private Label label1;
        private Button button1;
        private ComboBox comboBox1;
    }
}
