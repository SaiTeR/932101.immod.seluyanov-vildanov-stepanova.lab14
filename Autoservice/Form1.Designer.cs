namespace Autoservice
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            flowNumeric = new NumericUpDown();
            mechNumeric = new NumericUpDown();
            label4 = new Label();
            speedNumeric = new NumericUpDown();
            label5 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            queueLabel = new Label();
            servedLabel = new Label();
            label6 = new Label();
            label7 = new Label();
            groupBox3 = new GroupBox();
            endBtn = new Button();
            startBtn = new Button();
            dataGridView1 = new DataGridView();
            mech = new DataGridViewTextBoxColumn();
            statuc = new DataGridViewTextBoxColumn();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flowNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mechNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)speedNumeric).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(824, 86);
            label1.TabIndex = 0;
            label1.Text = "Автосервис";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 79);
            label2.Name = "label2";
            label2.Size = new Size(824, 115);
            label2.TabIndex = 1;
            label2.Text = "\"Наш Гараж\"";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(20, 39);
            label3.Name = "label3";
            label3.Size = new Size(253, 37);
            label3.TabIndex = 2;
            label3.Text = "Поток посетителей";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.m1;
            pictureBox1.Location = new Point(583, -8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(253, 176);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.ВАЗ_2115__22__300х300;
            pictureBox2.Location = new Point(12, 28);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(235, 112);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // flowNumeric
            // 
            flowNumeric.DecimalPlaces = 2;
            flowNumeric.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            flowNumeric.Location = new Point(346, 43);
            flowNumeric.Name = "flowNumeric";
            flowNumeric.Size = new Size(95, 35);
            flowNumeric.TabIndex = 5;
            flowNumeric.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // mechNumeric
            // 
            mechNumeric.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            mechNumeric.Location = new Point(346, 97);
            mechNumeric.Name = "mechNumeric";
            mechNumeric.Size = new Size(95, 35);
            mechNumeric.TabIndex = 7;
            mechNumeric.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(20, 93);
            label4.Name = "label4";
            label4.Size = new Size(255, 37);
            label4.TabIndex = 6;
            label4.Text = "Работники сервиса";
            // 
            // speedNumeric
            // 
            speedNumeric.DecimalPlaces = 2;
            speedNumeric.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            speedNumeric.Location = new Point(346, 151);
            speedNumeric.Name = "speedNumeric";
            speedNumeric.Size = new Size(95, 35);
            speedNumeric.TabIndex = 9;
            speedNumeric.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(20, 147);
            label5.Name = "label5";
            label5.Size = new Size(320, 37);
            label5.TabIndex = 8;
            label5.Text = "Скорость обслуживания";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(speedNumeric);
            groupBox1.Controls.Add(flowNumeric);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(mechNumeric);
            groupBox1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox1.Location = new Point(35, 179);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(475, 212);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Настройки модели";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(queueLabel);
            groupBox2.Controls.Add(servedLabel);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox2.Location = new Point(35, 397);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(267, 150);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Статистика";
            // 
            // queueLabel
            // 
            queueLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            queueLabel.Location = new Point(190, 88);
            queueLabel.Name = "queueLabel";
            queueLabel.Size = new Size(71, 37);
            queueLabel.TabIndex = 10;
            queueLabel.Text = "---";
            // 
            // servedLabel
            // 
            servedLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            servedLabel.Location = new Point(190, 39);
            servedLabel.Name = "servedLabel";
            servedLabel.Size = new Size(71, 37);
            servedLabel.TabIndex = 9;
            servedLabel.Text = "---";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(20, 39);
            label6.Name = "label6";
            label6.Size = new Size(164, 37);
            label6.TabIndex = 2;
            label6.Text = "Обслужено:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(20, 88);
            label7.Name = "label7";
            label7.Size = new Size(151, 37);
            label7.TabIndex = 8;
            label7.Text = "В очереди:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(endBtn);
            groupBox3.Controls.Add(startBtn);
            groupBox3.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox3.Location = new Point(320, 397);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(190, 150);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Управление";
            // 
            // endBtn
            // 
            endBtn.Enabled = false;
            endBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            endBtn.Location = new Point(6, 93);
            endBtn.Name = "endBtn";
            endBtn.Size = new Size(178, 48);
            endBtn.TabIndex = 14;
            endBtn.Text = "Стоп";
            endBtn.UseVisualStyleBackColor = true;
            endBtn.Click += endBtn_Click;
            // 
            // startBtn
            // 
            startBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            startBtn.Location = new Point(6, 39);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(178, 48);
            startBtn.TabIndex = 13;
            startBtn.Text = "Начать";
            startBtn.UseVisualStyleBackColor = true;
            startBtn.Click += startBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { mech, statuc });
            dataGridView1.Location = new Point(561, 197);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.Size = new Size(275, 350);
            dataGridView1.TabIndex = 13;
            // 
            // mech
            // 
            mech.HeaderText = "Механик";
            mech.Name = "mech";
            mech.Width = 130;
            // 
            // statuc
            // 
            statuc.HeaderText = "Статус";
            statuc.Name = "statuc";
            statuc.Width = 130;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 571);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Autoservice";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)flowNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)mechNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)speedNumeric).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private NumericUpDown flowNumeric;
        private NumericUpDown mechNumeric;
        private Label label4;
        private NumericUpDown speedNumeric;
        private Label label5;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label queueLabel;
        private Label servedLabel;
        private Label label6;
        private Label label7;
        private GroupBox groupBox3;
        private Button startBtn;
        private Button endBtn;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn mech;
        private DataGridViewTextBoxColumn statuc;
        private System.Windows.Forms.Timer timer1;
    }
}
