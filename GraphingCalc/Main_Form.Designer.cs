namespace mandelbrot_set_plotter
{
    partial class Main_Form
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
            this.graphBox = new PictureBox();
            this.debugBox = new RichTextBox();
            this.offsetBoxX = new TextBox();
            this.stretchBoxX = new TextBox();
            this.textBox3 = new TextBox();
            this.textBox4 = new TextBox();
            this.stepSizeBox = new TextBox();
            this.stepNumberBox = new TextBox();
            this.stepStartBox = new TextBox();
            this.label1 = new Label();
            this.offsetBoxY = new Label();
            this.label3 = new Label();
            this.stretchBoxY = new Label();
            this.label5 = new Label();
            this.label6 = new Label();
            this.label7 = new Label();
            this.startButton = new Button();
            this.label2 = new Label();
            this.saveButton = new Button();
            this.fStepBox = new TextBox();
            this.label4 = new Label();
            this.clearButton = new Button();
            this.checkBox1 = new CheckBox();
            this.operationBox = new TextBox();
            this.numberButton1 = new Button();
            this.numberButton2 = new Button();
            this.numberButton3 = new Button();
            this.numberButton4 = new Button();
            this.numberButton5 = new Button();
            this.numberButton6 = new Button();
            this.numberButton7 = new Button();
            this.numberButton8 = new Button();
            this.numberButton9 = new Button();
            this.numberButton0 = new Button();
            this.numberButtonX = new Button();
            this.numberButtonAdd = new Button();
            this.numberButtonSubtract = new Button();
            this.numberButtonMultiply = new Button();
            this.numberButtonDivide = new Button();
            this.numberButtonPow = new Button();
            this.numberButtonSin = new Button();
            this.numberButtonCos = new Button();
            this.numberButtonDot = new Button();
            this.numberButtonDelete = new Button();
            this.checkBox2 = new CheckBox();
            this.thicknessBox = new TextBox();
            this.label8 = new Label();
            this.button1 = new Button();
            this.numberButtonParantesesClosed = new Button();
            this.numberButtonParantesesOpen = new Button();
            ((ISupportInitialize)this.graphBox).BeginInit();
            base.SuspendLayout();
            this.graphBox.BackColor = Color.Black;
            this.graphBox.Location = new Point(-1, -3);
            this.graphBox.Name = "graphBox";
            this.graphBox.Size = new Size(803, 574);
            this.graphBox.TabIndex = 0;
            this.graphBox.TabStop = false;
            this.debugBox.BorderStyle = BorderStyle.None;
            this.debugBox.Location = new Point(702, 475);
            this.debugBox.Name = "debugBox";
            this.debugBox.ReadOnly = true;
            this.debugBox.ScrollBars = RichTextBoxScrollBars.Vertical;
            this.debugBox.Size = new Size(100, 96);
            this.debugBox.TabIndex = 1;
            this.debugBox.Text = "";
            this.offsetBoxX.Location = new Point(702, 22);
            this.offsetBoxX.Name = "offsetBoxX";
            this.offsetBoxX.Size = new Size(100, 20);
            this.offsetBoxX.TabIndex = 2;
            this.offsetBoxX.TextChanged += new EventHandler(this.offsetBoxX_TextChanged);
            this.stretchBoxX.Location = new Point(702, 114);
            this.stretchBoxX.Name = "stretchBoxX";
            this.stretchBoxX.Size = new Size(100, 20);
            this.stretchBoxX.TabIndex = 3;
            this.stretchBoxX.TextChanged += new EventHandler(this.stretchBoxX_TextChanged);
            this.textBox3.Location = new Point(702, 67);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Size(100, 20);
            this.textBox3.TabIndex = 3;
            this.textBox3.TextChanged += new EventHandler(this.textBox3_TextChanged);
            this.textBox4.Location = new Point(702, 167);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Size(100, 20);
            this.textBox4.TabIndex = 3;
            this.textBox4.TextChanged += new EventHandler(this.textBox4_TextChanged);
            this.stepSizeBox.Location = new Point(702, 212);
            this.stepSizeBox.Name = "stepSizeBox";
            this.stepSizeBox.Size = new Size(100, 20);
            this.stepSizeBox.TabIndex = 3;
            this.stepSizeBox.TextChanged += new EventHandler(this.stepSizeBox_TextChanged);
            this.stepNumberBox.Location = new Point(702, 262);
            this.stepNumberBox.Name = "stepNumberBox";
            this.stepNumberBox.Size = new Size(100, 20);
            this.stepNumberBox.TabIndex = 3;
            this.stepNumberBox.TextChanged += new EventHandler(this.stepNumberBox_TextChanged);
            this.stepStartBox.Location = new Point(702, 318);
            this.stepStartBox.Name = "stepStartBox";
            this.stepStartBox.Size = new Size(100, 20);
            this.stepStartBox.TabIndex = 3;
            this.stepStartBox.TextChanged += new EventHandler(this.stepStartBox_TextChanged);
            this.label1.AutoSize = true;
            this.label1.BackColor = Color.Black;
            this.label1.FlatStyle = FlatStyle.System;
            this.label1.ForeColor = Color.White;
            this.label1.Location = new Point(724, 6);
            this.label1.Name = "label1";
            this.label1.Size = new Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Offset X";
            this.label1.TextAlign = ContentAlignment.MiddleCenter;
            this.offsetBoxY.AutoSize = true;
            this.offsetBoxY.BackColor = Color.Black;
            this.offsetBoxY.FlatStyle = FlatStyle.System;
            this.offsetBoxY.ForeColor = Color.White;
            this.offsetBoxY.Location = new Point(724, 51);
            this.offsetBoxY.Name = "offsetBoxY";
            this.offsetBoxY.Size = new Size(45, 13);
            this.offsetBoxY.TabIndex = 4;
            this.offsetBoxY.Text = "Offset Y";
            this.offsetBoxY.TextAlign = ContentAlignment.MiddleCenter;
            this.label3.AutoSize = true;
            this.label3.BackColor = Color.Black;
            this.label3.FlatStyle = FlatStyle.System;
            this.label3.ForeColor = Color.White;
            this.label3.Location = new Point(724, 98);
            this.label3.Name = "label3";
            this.label3.Size = new Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Stretch X";
            this.label3.TextAlign = ContentAlignment.MiddleCenter;
            this.stretchBoxY.AutoSize = true;
            this.stretchBoxY.BackColor = Color.Black;
            this.stretchBoxY.FlatStyle = FlatStyle.System;
            this.stretchBoxY.ForeColor = Color.White;
            this.stretchBoxY.Location = new Point(724, 151);
            this.stretchBoxY.Name = "stretchBoxY";
            this.stretchBoxY.Size = new Size(51, 13);
            this.stretchBoxY.TabIndex = 4;
            this.stretchBoxY.Text = "Stretch Y";
            this.stretchBoxY.TextAlign = ContentAlignment.MiddleCenter;
            this.label5.AutoSize = true;
            this.label5.BackColor = Color.Black;
            this.label5.FlatStyle = FlatStyle.System;
            this.label5.ForeColor = Color.White;
            this.label5.Location = new Point(724, 196);
            this.label5.Name = "label5";
            this.label5.Size = new Size(50, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Step size";
            this.label5.TextAlign = ContentAlignment.MiddleCenter;
            this.label6.AutoSize = true;
            this.label6.BackColor = Color.Black;
            this.label6.FlatStyle = FlatStyle.System;
            this.label6.ForeColor = Color.White;
            this.label6.Location = new Point(724, 246);
            this.label6.Name = "label6";
            this.label6.Size = new Size(59, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Total steps";
            this.label6.TextAlign = ContentAlignment.MiddleCenter;
            this.label7.AutoSize = true;
            this.label7.BackColor = Color.Black;
            this.label7.FlatStyle = FlatStyle.System;
            this.label7.ForeColor = Color.White;
            this.label7.Location = new Point(724, 302);
            this.label7.Name = "label7";
            this.label7.Size = new Size(52, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Step start";
            this.label7.TextAlign = ContentAlignment.MiddleCenter;
            this.startButton.BackColor = Color.Black;
            this.startButton.FlatStyle = FlatStyle.Flat;
            this.startButton.ForeColor = Color.White;
            this.startButton.Location = new Point(713, 364);
            this.startButton.Name = "startButton";
            this.startButton.Size = new Size(75, 23);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Render";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new EventHandler(this.startButton_Click);
            this.label2.AutoSize = true;
            this.label2.BackColor = Color.Black;
            this.label2.FlatStyle = FlatStyle.System;
            this.label2.ForeColor = Color.White;
            this.label2.Location = new Point(710, 459);
            this.label2.Name = "label2";
            this.label2.Size = new Size(78, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Debug window";
            this.label2.TextAlign = ContentAlignment.MiddleCenter;
            this.saveButton.Location = new Point(792, 344);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new Size(10, 10);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save image";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new EventHandler(this.saveButton_Click);
            this.fStepBox.Location = new Point(596, 22);
            this.fStepBox.Name = "fStepBox";
            this.fStepBox.Size = new Size(100, 20);
            this.fStepBox.TabIndex = 2;
            this.fStepBox.TextChanged += new EventHandler(this.fStepBox_TextChanged);
            this.label4.AutoSize = true;
            this.label4.BackColor = Color.Black;
            this.label4.FlatStyle = FlatStyle.System;
            this.label4.ForeColor = Color.White;
            this.label4.Location = new Point(602, 6);
            this.label4.Name = "label4";
            this.label4.Size = new Size(85, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Step on function";
            this.label4.TextAlign = ContentAlignment.MiddleCenter;
            this.clearButton.BackColor = Color.Black;
            this.clearButton.FlatStyle = FlatStyle.Flat;
            this.clearButton.ForeColor = Color.White;
            this.clearButton.Location = new Point(713, 393);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new Size(75, 23);
            this.clearButton.TabIndex = 5;
            this.clearButton.Tag = "";
            this.clearButton.Text = "Clear screen";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new EventHandler(this.clearButton_Click);
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = Color.Black;
            this.checkBox1.FlatStyle = FlatStyle.Flat;
            this.checkBox1.ForeColor = Color.White;
            this.checkBox1.Location = new Point(623, 96);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new Size(42, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Grid";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new EventHandler(this.checkBox1_CheckedChanged);
            this.operationBox.Enabled = false;
            this.operationBox.Location = new Point(45, 396);
            this.operationBox.Name = "operationBox";
            this.operationBox.ReadOnly = true;
            this.operationBox.Size = new Size(100, 20);
            this.operationBox.TabIndex = 8;
            this.operationBox.Visible = false;
            this.numberButton1.BackColor = Color.Black;
            this.numberButton1.Enabled = false;
            this.numberButton1.FlatStyle = FlatStyle.Flat;
            this.numberButton1.ForeColor = Color.White;
            this.numberButton1.Location = new Point(45, 426);
            this.numberButton1.Name = "numberButton1";
            this.numberButton1.Size = new Size(23, 23);
            this.numberButton1.TabIndex = 9;
            this.numberButton1.Text = "1";
            this.numberButton1.UseVisualStyleBackColor = false;
            this.numberButton1.Visible = false;
            this.numberButton1.Click += new EventHandler(this.numberButton1_Click);
            this.numberButton2.BackColor = Color.Black;
            this.numberButton2.Enabled = false;
            this.numberButton2.FlatStyle = FlatStyle.Flat;
            this.numberButton2.ForeColor = Color.White;
            this.numberButton2.Location = new Point(74, 426);
            this.numberButton2.Name = "numberButton2";
            this.numberButton2.Size = new Size(23, 23);
            this.numberButton2.TabIndex = 9;
            this.numberButton2.Text = "2";
            this.numberButton2.UseVisualStyleBackColor = false;
            this.numberButton2.Visible = false;
            this.numberButton2.Click += new EventHandler(this.numberButton2_Click);
            this.numberButton3.BackColor = Color.Black;
            this.numberButton3.Enabled = false;
            this.numberButton3.FlatStyle = FlatStyle.Flat;
            this.numberButton3.ForeColor = Color.White;
            this.numberButton3.Location = new Point(103, 426);
            this.numberButton3.Name = "numberButton3";
            this.numberButton3.Size = new Size(23, 23);
            this.numberButton3.TabIndex = 9;
            this.numberButton3.Text = "3";
            this.numberButton3.UseVisualStyleBackColor = false;
            this.numberButton3.Visible = false;
            this.numberButton3.Click += new EventHandler(this.numberButton3_Click);
            this.numberButton4.BackColor = Color.Black;
            this.numberButton4.Enabled = false;
            this.numberButton4.FlatStyle = FlatStyle.Flat;
            this.numberButton4.ForeColor = Color.White;
            this.numberButton4.Location = new Point(45, 449);
            this.numberButton4.Name = "numberButton4";
            this.numberButton4.Size = new Size(23, 23);
            this.numberButton4.TabIndex = 9;
            this.numberButton4.Text = "4";
            this.numberButton4.UseVisualStyleBackColor = false;
            this.numberButton4.Visible = false;
            this.numberButton4.Click += new EventHandler(this.numberButton4_Click);
            this.numberButton5.BackColor = Color.Black;
            this.numberButton5.Enabled = false;
            this.numberButton5.FlatStyle = FlatStyle.Flat;
            this.numberButton5.ForeColor = Color.White;
            this.numberButton5.Location = new Point(74, 449);
            this.numberButton5.Name = "numberButton5";
            this.numberButton5.Size = new Size(23, 23);
            this.numberButton5.TabIndex = 9;
            this.numberButton5.Text = "5";
            this.numberButton5.UseVisualStyleBackColor = false;
            this.numberButton5.Visible = false;
            this.numberButton5.Click += new EventHandler(this.numberButton5_Click);
            this.numberButton6.BackColor = Color.Black;
            this.numberButton6.Enabled = false;
            this.numberButton6.FlatStyle = FlatStyle.Flat;
            this.numberButton6.ForeColor = Color.White;
            this.numberButton6.Location = new Point(103, 449);
            this.numberButton6.Name = "numberButton6";
            this.numberButton6.Size = new Size(23, 23);
            this.numberButton6.TabIndex = 9;
            this.numberButton6.Text = "6";
            this.numberButton6.UseVisualStyleBackColor = false;
            this.numberButton6.Visible = false;
            this.numberButton6.Click += new EventHandler(this.numberButton6_Click);
            this.numberButton7.BackColor = Color.Black;
            this.numberButton7.Enabled = false;
            this.numberButton7.FlatStyle = FlatStyle.Flat;
            this.numberButton7.ForeColor = Color.White;
            this.numberButton7.Location = new Point(45, 472);
            this.numberButton7.Name = "numberButton7";
            this.numberButton7.Size = new Size(23, 23);
            this.numberButton7.TabIndex = 9;
            this.numberButton7.Text = "7";
            this.numberButton7.UseVisualStyleBackColor = false;
            this.numberButton7.Visible = false;
            this.numberButton7.Click += new EventHandler(this.numberButton7_Click);
            this.numberButton8.BackColor = Color.Black;
            this.numberButton8.Enabled = false;
            this.numberButton8.FlatStyle = FlatStyle.Flat;
            this.numberButton8.ForeColor = Color.White;
            this.numberButton8.Location = new Point(74, 472);
            this.numberButton8.Name = "numberButton8";
            this.numberButton8.Size = new Size(23, 23);
            this.numberButton8.TabIndex = 9;
            this.numberButton8.Text = "8";
            this.numberButton8.UseVisualStyleBackColor = false;
            this.numberButton8.Visible = false;
            this.numberButton8.Click += new EventHandler(this.numberButton8_Click);
            this.numberButton9.BackColor = Color.Black;
            this.numberButton9.Enabled = false;
            this.numberButton9.FlatStyle = FlatStyle.Flat;
            this.numberButton9.ForeColor = Color.White;
            this.numberButton9.Location = new Point(103, 472);
            this.numberButton9.Name = "numberButton9";
            this.numberButton9.Size = new Size(23, 23);
            this.numberButton9.TabIndex = 9;
            this.numberButton9.Text = "9";
            this.numberButton9.UseVisualStyleBackColor = false;
            this.numberButton9.Visible = false;
            this.numberButton9.Click += new EventHandler(this.numberButton9_Click);
            this.numberButton0.BackColor = Color.Black;
            this.numberButton0.Enabled = false;
            this.numberButton0.FlatStyle = FlatStyle.Flat;
            this.numberButton0.ForeColor = Color.White;
            this.numberButton0.Location = new Point(74, 498);
            this.numberButton0.Name = "numberButton0";
            this.numberButton0.Size = new Size(23, 23);
            this.numberButton0.TabIndex = 9;
            this.numberButton0.Text = "0";
            this.numberButton0.UseVisualStyleBackColor = false;
            this.numberButton0.Visible = false;
            this.numberButton0.Click += new EventHandler(this.numberButton0_Click);
            this.numberButtonX.BackColor = Color.Black;
            this.numberButtonX.Enabled = false;
            this.numberButtonX.FlatStyle = FlatStyle.Flat;
            this.numberButtonX.ForeColor = Color.White;
            this.numberButtonX.Location = new Point(161, 426);
            this.numberButtonX.Name = "numberButtonX";
            this.numberButtonX.Size = new Size(23, 23);
            this.numberButtonX.TabIndex = 9;
            this.numberButtonX.Text = "X";
            this.numberButtonX.UseVisualStyleBackColor = false;
            this.numberButtonX.Visible = false;
            this.numberButtonX.Click += new EventHandler(this.numberButtonX_Click);
            this.numberButtonAdd.BackColor = Color.Black;
            this.numberButtonAdd.Enabled = false;
            this.numberButtonAdd.FlatStyle = FlatStyle.Flat;
            this.numberButtonAdd.ForeColor = Color.White;
            this.numberButtonAdd.Location = new Point(132, 449);
            this.numberButtonAdd.Name = "numberButtonAdd";
            this.numberButtonAdd.Size = new Size(23, 23);
            this.numberButtonAdd.TabIndex = 9;
            this.numberButtonAdd.Text = "+";
            this.numberButtonAdd.UseVisualStyleBackColor = false;
            this.numberButtonAdd.Visible = false;
            this.numberButtonAdd.Click += new EventHandler(this.numberButtonAdd_Click);
            this.numberButtonSubtract.BackColor = Color.Black;
            this.numberButtonSubtract.Enabled = false;
            this.numberButtonSubtract.FlatStyle = FlatStyle.Flat;
            this.numberButtonSubtract.ForeColor = Color.White;
            this.numberButtonSubtract.Location = new Point(103, 498);
            this.numberButtonSubtract.Name = "numberButtonSubtract";
            this.numberButtonSubtract.Size = new Size(23, 23);
            this.numberButtonSubtract.TabIndex = 9;
            this.numberButtonSubtract.Text = "-";
            this.numberButtonSubtract.UseVisualStyleBackColor = false;
            this.numberButtonSubtract.Visible = false;
            this.numberButtonSubtract.Click += new EventHandler(this.numberButtonSubstract_Click);
            this.numberButtonMultiply.BackColor = Color.Black;
            this.numberButtonMultiply.Enabled = false;
            this.numberButtonMultiply.FlatStyle = FlatStyle.Flat;
            this.numberButtonMultiply.ForeColor = Color.White;
            this.numberButtonMultiply.Location = new Point(132, 426);
            this.numberButtonMultiply.Name = "numberButtonMultiply";
            this.numberButtonMultiply.Size = new Size(23, 23);
            this.numberButtonMultiply.TabIndex = 9;
            this.numberButtonMultiply.Text = "*";
            this.numberButtonMultiply.UseVisualStyleBackColor = false;
            this.numberButtonMultiply.Visible = false;
            this.numberButtonMultiply.Click += new EventHandler(this.numberButtonMultiply_Click);
            this.numberButtonDivide.BackColor = Color.Black;
            this.numberButtonDivide.Enabled = false;
            this.numberButtonDivide.FlatStyle = FlatStyle.Flat;
            this.numberButtonDivide.ForeColor = Color.White;
            this.numberButtonDivide.Location = new Point(132, 498);
            this.numberButtonDivide.Name = "numberButtonDivide";
            this.numberButtonDivide.Size = new Size(23, 23);
            this.numberButtonDivide.TabIndex = 9;
            this.numberButtonDivide.Text = "/";
            this.numberButtonDivide.UseVisualStyleBackColor = false;
            this.numberButtonDivide.Visible = false;
            this.numberButtonDivide.Click += new EventHandler(this.numberButtonDivide_Click);
            this.numberButtonPow.BackColor = Color.Black;
            this.numberButtonPow.Enabled = false;
            this.numberButtonPow.FlatStyle = FlatStyle.Flat;
            this.numberButtonPow.ForeColor = Color.White;
            this.numberButtonPow.Location = new Point(132, 472);
            this.numberButtonPow.Name = "numberButtonPow";
            this.numberButtonPow.Size = new Size(23, 23);
            this.numberButtonPow.TabIndex = 9;
            this.numberButtonPow.Text = "^";
            this.numberButtonPow.UseVisualStyleBackColor = false;
            this.numberButtonPow.Visible = false;
            this.numberButtonPow.Click += new EventHandler(this.numberButtonPow_Click);
            this.numberButtonSin.BackColor = Color.Black;
            this.numberButtonSin.Enabled = false;
            this.numberButtonSin.FlatStyle = FlatStyle.Flat;
            this.numberButtonSin.ForeColor = Color.White;
            this.numberButtonSin.Location = new Point(5, 426);
            this.numberButtonSin.Name = "numberButtonSin";
            this.numberButtonSin.Size = new Size(34, 23);
            this.numberButtonSin.TabIndex = 9;
            this.numberButtonSin.Text = "sin";
            this.numberButtonSin.UseVisualStyleBackColor = false;
            this.numberButtonSin.Visible = false;
            this.numberButtonSin.Click += new EventHandler(this.numberButtonSin_Click);
            this.numberButtonCos.BackColor = Color.Black;
            this.numberButtonCos.Enabled = false;
            this.numberButtonCos.FlatStyle = FlatStyle.Flat;
            this.numberButtonCos.ForeColor = Color.White;
            this.numberButtonCos.Location = new Point(5, 449);
            this.numberButtonCos.Name = "numberButtonCos";
            this.numberButtonCos.Size = new Size(34, 23);
            this.numberButtonCos.TabIndex = 9;
            this.numberButtonCos.Text = "cos";
            this.numberButtonCos.UseVisualStyleBackColor = false;
            this.numberButtonCos.Visible = false;
            this.numberButtonCos.Click += new EventHandler(this.numberButtonCos_Click);
            this.numberButtonDot.BackColor = Color.Black;
            this.numberButtonDot.Enabled = false;
            this.numberButtonDot.FlatStyle = FlatStyle.Flat;
            this.numberButtonDot.ForeColor = Color.White;
            this.numberButtonDot.Location = new Point(45, 498);
            this.numberButtonDot.Name = "numberButtonDot";
            this.numberButtonDot.Size = new Size(23, 23);
            this.numberButtonDot.TabIndex = 9;
            this.numberButtonDot.Text = ".";
            this.numberButtonDot.UseVisualStyleBackColor = false;
            this.numberButtonDot.Visible = false;
            this.numberButtonDot.Click += new EventHandler(this.numberButtonDot_Click);
            this.numberButtonDelete.BackColor = Color.Black;
            this.numberButtonDelete.Enabled = false;
            this.numberButtonDelete.FlatStyle = FlatStyle.Flat;
            this.numberButtonDelete.ForeColor = Color.White;
            this.numberButtonDelete.Location = new Point(188, 426);
            this.numberButtonDelete.Name = "numberButtonDelete";
            this.numberButtonDelete.Size = new Size(23, 23);
            this.numberButtonDelete.TabIndex = 9;
            this.numberButtonDelete.Text = "←";
            this.numberButtonDelete.UseVisualStyleBackColor = false;
            this.numberButtonDelete.Visible = false;
            this.numberButtonDelete.Click += new EventHandler(this.numberButtonDelete_Click);
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = Color.Black;
            this.checkBox2.FlatStyle = FlatStyle.Flat;
            this.checkBox2.ForeColor = Color.White;
            this.checkBox2.Location = new Point(623, 117);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new Size(62, 17);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "New alg";
            this.checkBox2.UseVisualStyleBackColor = false;
            this.checkBox2.CheckedChanged += new EventHandler(this.checkBox2_CheckedChanged);
            this.thicknessBox.Location = new Point(596, 68);
            this.thicknessBox.Name = "thicknessBox";
            this.thicknessBox.Size = new Size(100, 20);
            this.thicknessBox.TabIndex = 2;
            this.label8.AutoSize = true;
            this.label8.BackColor = Color.Black;
            this.label8.FlatStyle = FlatStyle.System;
            this.label8.ForeColor = Color.White;
            this.label8.Location = new Point(602, 52);
            this.label8.Name = "label8";
            this.label8.Size = new Size(56, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Thickness";
            this.label8.TextAlign = ContentAlignment.MiddleCenter;
            this.button1.BackColor = Color.Black;
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.ForeColor = Color.White;
            this.button1.Location = new Point(5, 534);
            this.button1.Name = "button1";
            this.button1.Size = new Size(89, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Equasion calc";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new EventHandler(this.button1_Click);
            this.numberButtonParantesesClosed.BackColor = Color.Black;
            this.numberButtonParantesesClosed.Enabled = false;
            this.numberButtonParantesesClosed.FlatStyle = FlatStyle.Flat;
            this.numberButtonParantesesClosed.ForeColor = Color.White;
            this.numberButtonParantesesClosed.Location = new Point(188, 455);
            this.numberButtonParantesesClosed.Name = "numberButtonParantesesClosed";
            this.numberButtonParantesesClosed.Size = new Size(23, 23);
            this.numberButtonParantesesClosed.TabIndex = 9;
            this.numberButtonParantesesClosed.Text = ")";
            this.numberButtonParantesesClosed.UseVisualStyleBackColor = false;
            this.numberButtonParantesesClosed.Visible = false;
            this.numberButtonParantesesClosed.Click += new EventHandler(this.numberButtonDot_Click);
            this.numberButtonParantesesOpen.BackColor = Color.Black;
            this.numberButtonParantesesOpen.Enabled = false;
            this.numberButtonParantesesOpen.FlatStyle = FlatStyle.Flat;
            this.numberButtonParantesesOpen.ForeColor = Color.White;
            this.numberButtonParantesesOpen.Location = new Point(161, 455);
            this.numberButtonParantesesOpen.Name = "numberButtonParantesesOpen";
            this.numberButtonParantesesOpen.Size = new Size(23, 23);
            this.numberButtonParantesesOpen.TabIndex = 9;
            this.numberButtonParantesesOpen.Text = "(";
            this.numberButtonParantesesOpen.UseVisualStyleBackColor = false;
            this.numberButtonParantesesOpen.Visible = false;
            this.numberButtonParantesesOpen.Click += new EventHandler(this.numberButtonDot_Click);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(800, 569);
            base.Controls.Add(this.numberButtonCos);
            base.Controls.Add(this.numberButtonSin);
            base.Controls.Add(this.numberButtonPow);
            base.Controls.Add(this.numberButtonDelete);
            base.Controls.Add(this.numberButtonDivide);
            base.Controls.Add(this.numberButtonMultiply);
            base.Controls.Add(this.numberButtonSubtract);
            base.Controls.Add(this.numberButtonAdd);
            base.Controls.Add(this.numberButtonX);
            base.Controls.Add(this.numberButtonParantesesOpen);
            base.Controls.Add(this.numberButtonParantesesClosed);
            base.Controls.Add(this.numberButtonDot);
            base.Controls.Add(this.numberButton0);
            base.Controls.Add(this.numberButton9);
            base.Controls.Add(this.numberButton8);
            base.Controls.Add(this.numberButton7);
            base.Controls.Add(this.numberButton6);
            base.Controls.Add(this.numberButton5);
            base.Controls.Add(this.numberButton4);
            base.Controls.Add(this.numberButton3);
            base.Controls.Add(this.button1);
            base.Controls.Add(this.numberButton2);
            base.Controls.Add(this.numberButton1);
            base.Controls.Add(this.operationBox);
            base.Controls.Add(this.checkBox2);
            base.Controls.Add(this.checkBox1);
            base.Controls.Add(this.label2);
            base.Controls.Add(this.saveButton);
            base.Controls.Add(this.clearButton);
            base.Controls.Add(this.startButton);
            base.Controls.Add(this.label7);
            base.Controls.Add(this.label6);
            base.Controls.Add(this.label5);
            base.Controls.Add(this.stretchBoxY);
            base.Controls.Add(this.label3);
            base.Controls.Add(this.offsetBoxY);
            base.Controls.Add(this.label8);
            base.Controls.Add(this.label4);
            base.Controls.Add(this.label1);
            base.Controls.Add(this.textBox3);
            base.Controls.Add(this.stepStartBox);
            base.Controls.Add(this.stepNumberBox);
            base.Controls.Add(this.stepSizeBox);
            base.Controls.Add(this.textBox4);
            base.Controls.Add(this.stretchBoxX);
            base.Controls.Add(this.thicknessBox);
            base.Controls.Add(this.fStepBox);
            base.Controls.Add(this.offsetBoxX);
            base.Controls.Add(this.debugBox);
            base.Controls.Add(this.graphBox);
            base.Icon = (Icon)resources.GetObject("$this.Icon");
            base.Name = "Form1";
            this.Text = "Graphing calculator";
            base.Load += new EventHandler(this.Form1_Load);
            ((ISupportInitialize)this.graphBox).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        #endregion

        public PictureBox graphBox;

        private RichTextBox debugBox;

        private TextBox offsetBoxX;

        private TextBox stretchBoxX;

        private TextBox textBox3;

        private TextBox textBox4;

        private TextBox stepSizeBox;

        private TextBox stepNumberBox;

        private TextBox stepStartBox;

        private Label label1;

        private Label offsetBoxY;

        private Label label3;

        private Label stretchBoxY;

        private Label label5;

        private Label label6;

        private Label label7;

        private Button startButton;

        private Label label2;

        private Button saveButton;

        private TextBox fStepBox;

        private Label label4;

        private Button clearButton;

        private CheckBox checkBox1;

        private TextBox operationBox;

        private Button numberButton1;

        private Button numberButton2;

        private Button numberButton3;

        private Button numberButton4;

        private Button numberButton5;

        private Button numberButton6;

        private Button numberButton7;

        private Button numberButton8;

        private Button numberButton9;

        private Button numberButton0;

        private Button numberButtonX;

        private Button numberButtonAdd;

        private Button numberButtonSubtract;

        private Button numberButtonMultiply;

        private Button numberButtonDivide;

        private Button numberButtonPow;

        private Button numberButtonSin;

        private Button numberButtonCos;

        private Button numberButtonDot;

        private Button numberButtonDelete;

        private CheckBox checkBox2;

        private TextBox thicknessBox;

        private Label label8;

        private Button button1;

        private Button numberButtonParantesesClosed;

        private Button numberButtonParantesesOpen;
    }
}