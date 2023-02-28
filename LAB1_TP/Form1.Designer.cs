namespace LAB1_TP
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.PnlTitle = new System.Windows.Forms.Panel();
            this.BtnExit = new System.Windows.Forms.Button();
            this.PnlHistory = new System.Windows.Forms.Panel();
            this.RtBoxDisplayHistory = new System.Windows.Forms.RichTextBox();
            this.BtnClearHistory = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnHistory = new System.Windows.Forms.Button();
            this.TextDisplay2 = new System.Windows.Forms.TextBox();
            this.TextDisplay1 = new System.Windows.Forms.TextBox();
            this.BtnBackSpace = new System.Windows.Forms.Button();
            this.BtnPercent = new System.Windows.Forms.Button();
            this.BtnCE = new System.Windows.Forms.Button();
            this.BtnC = new System.Windows.Forms.Button();
            this.BtnDivision = new System.Windows.Forms.Button();
            this.Btn1X = new System.Windows.Forms.Button();
            this.BtnCos = new System.Windows.Forms.Button();
            this.BtnSquare = new System.Windows.Forms.Button();
            this.BtnMultiply = new System.Windows.Forms.Button();
            this.BtnNum7 = new System.Windows.Forms.Button();
            this.BtnNum8 = new System.Windows.Forms.Button();
            this.BtnNum9 = new System.Windows.Forms.Button();
            this.BtnSubtraction = new System.Windows.Forms.Button();
            this.BtnNum4 = new System.Windows.Forms.Button();
            this.BtnNum5 = new System.Windows.Forms.Button();
            this.BtnNum6 = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnNum1 = new System.Windows.Forms.Button();
            this.BtnNum2 = new System.Windows.Forms.Button();
            this.BtnNum3 = new System.Windows.Forms.Button();
            this.BtnEquals = new System.Windows.Forms.Button();
            this.BtnPM = new System.Windows.Forms.Button();
            this.BtnNum0 = new System.Windows.Forms.Button();
            this.BtnDesimal = new System.Windows.Forms.Button();
            this.PnlTitle.SuspendLayout();
            this.PnlHistory.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlTitle
            // 
            this.PnlTitle.Controls.Add(this.BtnExit);
            this.PnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTitle.Location = new System.Drawing.Point(0, 0);
            this.PnlTitle.Margin = new System.Windows.Forms.Padding(0);
            this.PnlTitle.Name = "PnlTitle";
            this.PnlTitle.Size = new System.Drawing.Size(358, 40);
            this.PnlTitle.TabIndex = 0;
            // 
            // BtnExit
            // 
            this.BtnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(308, 0);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(0);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(50, 40);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.Text = "X";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // PnlHistory
            // 
            this.PnlHistory.Controls.Add(this.RtBoxDisplayHistory);
            this.PnlHistory.Controls.Add(this.BtnClearHistory);
            this.PnlHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlHistory.Location = new System.Drawing.Point(0, 561);
            this.PnlHistory.Margin = new System.Windows.Forms.Padding(0);
            this.PnlHistory.Name = "PnlHistory";
            this.PnlHistory.Size = new System.Drawing.Size(358, 5);
            this.PnlHistory.TabIndex = 1;
            // 
            // RtBoxDisplayHistory
            // 
            this.RtBoxDisplayHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.RtBoxDisplayHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RtBoxDisplayHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RtBoxDisplayHistory.ForeColor = System.Drawing.Color.Silver;
            this.RtBoxDisplayHistory.Location = new System.Drawing.Point(0, 0);
            this.RtBoxDisplayHistory.Margin = new System.Windows.Forms.Padding(0);
            this.RtBoxDisplayHistory.Name = "RtBoxDisplayHistory";
            this.RtBoxDisplayHistory.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.RtBoxDisplayHistory.Size = new System.Drawing.Size(358, 0);
            this.RtBoxDisplayHistory.TabIndex = 4;
            this.RtBoxDisplayHistory.Text = "";
            // 
            // BtnClearHistory
            // 
            this.BtnClearHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnClearHistory.FlatAppearance.BorderSize = 0;
            this.BtnClearHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClearHistory.Location = new System.Drawing.Point(0, -35);
            this.BtnClearHistory.Margin = new System.Windows.Forms.Padding(0);
            this.BtnClearHistory.Name = "BtnClearHistory";
            this.BtnClearHistory.Size = new System.Drawing.Size(358, 40);
            this.BtnClearHistory.TabIndex = 3;
            this.BtnClearHistory.Text = "Clear";
            this.BtnClearHistory.UseVisualStyleBackColor = true;
            this.BtnClearHistory.Click += new System.EventHandler(this.BtnClearHistory_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnHistory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 40);
            this.panel1.TabIndex = 2;
            // 
            // BtnHistory
            // 
            this.BtnHistory.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnHistory.FlatAppearance.BorderSize = 0;
            this.BtnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHistory.Image = ((System.Drawing.Image)(resources.GetObject("BtnHistory.Image")));
            this.BtnHistory.Location = new System.Drawing.Point(308, 0);
            this.BtnHistory.Margin = new System.Windows.Forms.Padding(0);
            this.BtnHistory.Name = "BtnHistory";
            this.BtnHistory.Size = new System.Drawing.Size(50, 40);
            this.BtnHistory.TabIndex = 0;
            this.BtnHistory.UseVisualStyleBackColor = true;
            this.BtnHistory.Click += new System.EventHandler(this.BtnHistory_Click);
            // 
            // TextDisplay2
            // 
            this.TextDisplay2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.TextDisplay2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextDisplay2.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextDisplay2.Font = new System.Drawing.Font("Gadugi", 14F);
            this.TextDisplay2.ForeColor = System.Drawing.Color.DarkGray;
            this.TextDisplay2.Location = new System.Drawing.Point(0, 80);
            this.TextDisplay2.Margin = new System.Windows.Forms.Padding(0);
            this.TextDisplay2.Multiline = true;
            this.TextDisplay2.Name = "TextDisplay2";
            this.TextDisplay2.Size = new System.Drawing.Size(358, 25);
            this.TextDisplay2.TabIndex = 3;
            this.TextDisplay2.Text = "0";
            this.TextDisplay2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TextDisplay1
            // 
            this.TextDisplay1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.TextDisplay1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextDisplay1.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextDisplay1.Font = new System.Drawing.Font("Gadugi", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextDisplay1.ForeColor = System.Drawing.Color.White;
            this.TextDisplay1.Location = new System.Drawing.Point(0, 105);
            this.TextDisplay1.Margin = new System.Windows.Forms.Padding(0);
            this.TextDisplay1.Multiline = true;
            this.TextDisplay1.Name = "TextDisplay1";
            this.TextDisplay1.Size = new System.Drawing.Size(358, 50);
            this.TextDisplay1.TabIndex = 4;
            this.TextDisplay1.Text = "0";
            this.TextDisplay1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnBackSpace
            // 
            this.BtnBackSpace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BtnBackSpace.FlatAppearance.BorderSize = 0;
            this.BtnBackSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBackSpace.Image = ((System.Drawing.Image)(resources.GetObject("BtnBackSpace.Image")));
            this.BtnBackSpace.Location = new System.Drawing.Point(274, 171);
            this.BtnBackSpace.Margin = new System.Windows.Forms.Padding(0);
            this.BtnBackSpace.Name = "BtnBackSpace";
            this.BtnBackSpace.Size = new System.Drawing.Size(75, 55);
            this.BtnBackSpace.TabIndex = 5;
            this.BtnBackSpace.UseVisualStyleBackColor = false;
            this.BtnBackSpace.Click += new System.EventHandler(this.BtnBackSpace_Click);
            // 
            // BtnPercent
            // 
            this.BtnPercent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BtnPercent.FlatAppearance.BorderSize = 0;
            this.BtnPercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPercent.Location = new System.Drawing.Point(9, 171);
            this.BtnPercent.Margin = new System.Windows.Forms.Padding(0);
            this.BtnPercent.Name = "BtnPercent";
            this.BtnPercent.Size = new System.Drawing.Size(76, 55);
            this.BtnPercent.TabIndex = 7;
            this.BtnPercent.Text = "%";
            this.BtnPercent.UseVisualStyleBackColor = false;
            this.BtnPercent.Click += new System.EventHandler(this.BtnOperation_Click);
            // 
            // BtnCE
            // 
            this.BtnCE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BtnCE.FlatAppearance.BorderSize = 0;
            this.BtnCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCE.Location = new System.Drawing.Point(97, 171);
            this.BtnCE.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCE.Name = "BtnCE";
            this.BtnCE.Size = new System.Drawing.Size(74, 55);
            this.BtnCE.TabIndex = 7;
            this.BtnCE.Text = "CE";
            this.BtnCE.UseVisualStyleBackColor = false;
            this.BtnCE.Click += new System.EventHandler(this.BtnCE_Click);
            // 
            // BtnC
            // 
            this.BtnC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BtnC.FlatAppearance.BorderSize = 0;
            this.BtnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnC.Location = new System.Drawing.Point(185, 171);
            this.BtnC.Margin = new System.Windows.Forms.Padding(0);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(76, 55);
            this.BtnC.TabIndex = 7;
            this.BtnC.Text = "C";
            this.BtnC.UseVisualStyleBackColor = false;
            this.BtnC.Click += new System.EventHandler(this.BtnC_Click);
            // 
            // BtnDivision
            // 
            this.BtnDivision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BtnDivision.FlatAppearance.BorderSize = 0;
            this.BtnDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDivision.Location = new System.Drawing.Point(275, 235);
            this.BtnDivision.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDivision.Name = "BtnDivision";
            this.BtnDivision.Size = new System.Drawing.Size(75, 55);
            this.BtnDivision.TabIndex = 5;
            this.BtnDivision.Text = "÷";
            this.BtnDivision.UseVisualStyleBackColor = false;
            this.BtnDivision.Click += new System.EventHandler(this.BtnMathOperations_Click);
            // 
            // Btn1X
            // 
            this.Btn1X.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn1X.FlatAppearance.BorderSize = 0;
            this.Btn1X.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn1X.Location = new System.Drawing.Point(9, 235);
            this.Btn1X.Margin = new System.Windows.Forms.Padding(0);
            this.Btn1X.Name = "Btn1X";
            this.Btn1X.Size = new System.Drawing.Size(72, 55);
            this.Btn1X.TabIndex = 7;
            this.Btn1X.Text = "1/x";
            this.Btn1X.UseVisualStyleBackColor = false;
            this.Btn1X.Click += new System.EventHandler(this.BtnOperation_Click);
            // 
            // BtnCos
            // 
            this.BtnCos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BtnCos.FlatAppearance.BorderSize = 0;
            this.BtnCos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCos.Location = new System.Drawing.Point(97, 235);
            this.BtnCos.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCos.Name = "BtnCos";
            this.BtnCos.Size = new System.Drawing.Size(74, 55);
            this.BtnCos.TabIndex = 7;
            this.BtnCos.Text = "cos(x)";
            this.BtnCos.UseVisualStyleBackColor = false;
            this.BtnCos.Click += new System.EventHandler(this.BtnOperation_Click);
            // 
            // BtnSquare
            // 
            this.BtnSquare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BtnSquare.FlatAppearance.BorderSize = 0;
            this.BtnSquare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSquare.Location = new System.Drawing.Point(185, 235);
            this.BtnSquare.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSquare.Name = "BtnSquare";
            this.BtnSquare.Size = new System.Drawing.Size(76, 55);
            this.BtnSquare.TabIndex = 7;
            this.BtnSquare.Text = "√x";
            this.BtnSquare.UseVisualStyleBackColor = false;
            this.BtnSquare.Click += new System.EventHandler(this.BtnOperation_Click);
            // 
            // BtnMultiply
            // 
            this.BtnMultiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BtnMultiply.FlatAppearance.BorderSize = 0;
            this.BtnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMultiply.Location = new System.Drawing.Point(275, 299);
            this.BtnMultiply.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMultiply.Name = "BtnMultiply";
            this.BtnMultiply.Size = new System.Drawing.Size(75, 55);
            this.BtnMultiply.TabIndex = 5;
            this.BtnMultiply.Text = "×";
            this.BtnMultiply.UseVisualStyleBackColor = false;
            this.BtnMultiply.Click += new System.EventHandler(this.BtnMathOperations_Click);
            // 
            // BtnNum7
            // 
            this.BtnNum7.BackColor = System.Drawing.Color.DimGray;
            this.BtnNum7.FlatAppearance.BorderSize = 0;
            this.BtnNum7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNum7.Location = new System.Drawing.Point(9, 299);
            this.BtnNum7.Margin = new System.Windows.Forms.Padding(0);
            this.BtnNum7.Name = "BtnNum7";
            this.BtnNum7.Size = new System.Drawing.Size(72, 55);
            this.BtnNum7.TabIndex = 7;
            this.BtnNum7.Text = "7";
            this.BtnNum7.UseVisualStyleBackColor = false;
            this.BtnNum7.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnNum8
            // 
            this.BtnNum8.BackColor = System.Drawing.Color.DimGray;
            this.BtnNum8.FlatAppearance.BorderSize = 0;
            this.BtnNum8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNum8.Location = new System.Drawing.Point(97, 299);
            this.BtnNum8.Margin = new System.Windows.Forms.Padding(0);
            this.BtnNum8.Name = "BtnNum8";
            this.BtnNum8.Size = new System.Drawing.Size(74, 55);
            this.BtnNum8.TabIndex = 7;
            this.BtnNum8.Text = "8";
            this.BtnNum8.UseVisualStyleBackColor = false;
            this.BtnNum8.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnNum9
            // 
            this.BtnNum9.BackColor = System.Drawing.Color.DimGray;
            this.BtnNum9.FlatAppearance.BorderSize = 0;
            this.BtnNum9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNum9.Location = new System.Drawing.Point(185, 299);
            this.BtnNum9.Margin = new System.Windows.Forms.Padding(0);
            this.BtnNum9.Name = "BtnNum9";
            this.BtnNum9.Size = new System.Drawing.Size(76, 55);
            this.BtnNum9.TabIndex = 7;
            this.BtnNum9.Text = "9";
            this.BtnNum9.UseVisualStyleBackColor = false;
            this.BtnNum9.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnSubtraction
            // 
            this.BtnSubtraction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BtnSubtraction.FlatAppearance.BorderSize = 0;
            this.BtnSubtraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSubtraction.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubtraction.Location = new System.Drawing.Point(275, 363);
            this.BtnSubtraction.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSubtraction.Name = "BtnSubtraction";
            this.BtnSubtraction.Size = new System.Drawing.Size(75, 55);
            this.BtnSubtraction.TabIndex = 5;
            this.BtnSubtraction.Text = "-";
            this.BtnSubtraction.UseVisualStyleBackColor = false;
            this.BtnSubtraction.Click += new System.EventHandler(this.BtnMathOperations_Click);
            // 
            // BtnNum4
            // 
            this.BtnNum4.BackColor = System.Drawing.Color.DimGray;
            this.BtnNum4.FlatAppearance.BorderSize = 0;
            this.BtnNum4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNum4.Location = new System.Drawing.Point(9, 363);
            this.BtnNum4.Margin = new System.Windows.Forms.Padding(0);
            this.BtnNum4.Name = "BtnNum4";
            this.BtnNum4.Size = new System.Drawing.Size(72, 55);
            this.BtnNum4.TabIndex = 7;
            this.BtnNum4.Text = "4";
            this.BtnNum4.UseVisualStyleBackColor = false;
            this.BtnNum4.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnNum5
            // 
            this.BtnNum5.BackColor = System.Drawing.Color.DimGray;
            this.BtnNum5.FlatAppearance.BorderSize = 0;
            this.BtnNum5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNum5.Location = new System.Drawing.Point(97, 363);
            this.BtnNum5.Margin = new System.Windows.Forms.Padding(0);
            this.BtnNum5.Name = "BtnNum5";
            this.BtnNum5.Size = new System.Drawing.Size(74, 55);
            this.BtnNum5.TabIndex = 7;
            this.BtnNum5.Text = "5";
            this.BtnNum5.UseVisualStyleBackColor = false;
            this.BtnNum5.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnNum6
            // 
            this.BtnNum6.BackColor = System.Drawing.Color.DimGray;
            this.BtnNum6.FlatAppearance.BorderSize = 0;
            this.BtnNum6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNum6.Location = new System.Drawing.Point(185, 363);
            this.BtnNum6.Margin = new System.Windows.Forms.Padding(0);
            this.BtnNum6.Name = "BtnNum6";
            this.BtnNum6.Size = new System.Drawing.Size(76, 55);
            this.BtnNum6.TabIndex = 7;
            this.BtnNum6.Text = "6";
            this.BtnNum6.UseVisualStyleBackColor = false;
            this.BtnNum6.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BtnAdd.FlatAppearance.BorderSize = 0;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Location = new System.Drawing.Point(275, 428);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 55);
            this.BtnAdd.TabIndex = 5;
            this.BtnAdd.Text = "+";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnMathOperations_Click);
            // 
            // BtnNum1
            // 
            this.BtnNum1.BackColor = System.Drawing.Color.DimGray;
            this.BtnNum1.FlatAppearance.BorderSize = 0;
            this.BtnNum1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNum1.Location = new System.Drawing.Point(9, 428);
            this.BtnNum1.Margin = new System.Windows.Forms.Padding(0);
            this.BtnNum1.Name = "BtnNum1";
            this.BtnNum1.Size = new System.Drawing.Size(72, 55);
            this.BtnNum1.TabIndex = 7;
            this.BtnNum1.Text = "1";
            this.BtnNum1.UseVisualStyleBackColor = false;
            this.BtnNum1.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnNum2
            // 
            this.BtnNum2.BackColor = System.Drawing.Color.DimGray;
            this.BtnNum2.FlatAppearance.BorderSize = 0;
            this.BtnNum2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNum2.Location = new System.Drawing.Point(97, 428);
            this.BtnNum2.Margin = new System.Windows.Forms.Padding(0);
            this.BtnNum2.Name = "BtnNum2";
            this.BtnNum2.Size = new System.Drawing.Size(74, 55);
            this.BtnNum2.TabIndex = 7;
            this.BtnNum2.Text = "2";
            this.BtnNum2.UseVisualStyleBackColor = false;
            this.BtnNum2.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnNum3
            // 
            this.BtnNum3.BackColor = System.Drawing.Color.DimGray;
            this.BtnNum3.FlatAppearance.BorderSize = 0;
            this.BtnNum3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNum3.Location = new System.Drawing.Point(185, 428);
            this.BtnNum3.Margin = new System.Windows.Forms.Padding(0);
            this.BtnNum3.Name = "BtnNum3";
            this.BtnNum3.Size = new System.Drawing.Size(76, 55);
            this.BtnNum3.TabIndex = 7;
            this.BtnNum3.Text = "3";
            this.BtnNum3.UseVisualStyleBackColor = false;
            this.BtnNum3.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnEquals
            // 
            this.BtnEquals.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnEquals.FlatAppearance.BorderSize = 0;
            this.BtnEquals.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.BtnEquals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEquals.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEquals.Location = new System.Drawing.Point(275, 493);
            this.BtnEquals.Margin = new System.Windows.Forms.Padding(0);
            this.BtnEquals.Name = "BtnEquals";
            this.BtnEquals.Size = new System.Drawing.Size(75, 55);
            this.BtnEquals.TabIndex = 5;
            this.BtnEquals.Text = "=";
            this.BtnEquals.UseVisualStyleBackColor = false;
            this.BtnEquals.Click += new System.EventHandler(this.BtnEquals_Click);
            // 
            // BtnPM
            // 
            this.BtnPM.BackColor = System.Drawing.Color.DimGray;
            this.BtnPM.FlatAppearance.BorderSize = 0;
            this.BtnPM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPM.Location = new System.Drawing.Point(9, 493);
            this.BtnPM.Margin = new System.Windows.Forms.Padding(0);
            this.BtnPM.Name = "BtnPM";
            this.BtnPM.Size = new System.Drawing.Size(72, 55);
            this.BtnPM.TabIndex = 7;
            this.BtnPM.Text = "+/-";
            this.BtnPM.UseVisualStyleBackColor = false;
            this.BtnPM.Click += new System.EventHandler(this.BtnOperation_Click);
            // 
            // BtnNum0
            // 
            this.BtnNum0.BackColor = System.Drawing.Color.DimGray;
            this.BtnNum0.FlatAppearance.BorderSize = 0;
            this.BtnNum0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNum0.Location = new System.Drawing.Point(97, 493);
            this.BtnNum0.Margin = new System.Windows.Forms.Padding(0);
            this.BtnNum0.Name = "BtnNum0";
            this.BtnNum0.Size = new System.Drawing.Size(74, 55);
            this.BtnNum0.TabIndex = 7;
            this.BtnNum0.Text = "0";
            this.BtnNum0.UseVisualStyleBackColor = false;
            this.BtnNum0.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnDesimal
            // 
            this.BtnDesimal.BackColor = System.Drawing.Color.DimGray;
            this.BtnDesimal.FlatAppearance.BorderSize = 0;
            this.BtnDesimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDesimal.Location = new System.Drawing.Point(185, 493);
            this.BtnDesimal.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDesimal.Name = "BtnDesimal";
            this.BtnDesimal.Size = new System.Drawing.Size(76, 55);
            this.BtnDesimal.TabIndex = 7;
            this.BtnDesimal.Text = ",";
            this.BtnDesimal.UseVisualStyleBackColor = false;
            this.BtnDesimal.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(358, 566);
            this.Controls.Add(this.PnlHistory);
            this.Controls.Add(this.BtnDesimal);
            this.Controls.Add(this.BtnNum3);
            this.Controls.Add(this.BtnNum6);
            this.Controls.Add(this.BtnNum9);
            this.Controls.Add(this.BtnSquare);
            this.Controls.Add(this.BtnC);
            this.Controls.Add(this.BtnNum0);
            this.Controls.Add(this.BtnNum2);
            this.Controls.Add(this.BtnNum5);
            this.Controls.Add(this.BtnNum8);
            this.Controls.Add(this.BtnCos);
            this.Controls.Add(this.BtnPM);
            this.Controls.Add(this.BtnCE);
            this.Controls.Add(this.BtnNum1);
            this.Controls.Add(this.BtnNum4);
            this.Controls.Add(this.BtnNum7);
            this.Controls.Add(this.Btn1X);
            this.Controls.Add(this.BtnPercent);
            this.Controls.Add(this.BtnEquals);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnSubtraction);
            this.Controls.Add(this.BtnMultiply);
            this.Controls.Add(this.BtnDivision);
            this.Controls.Add(this.BtnBackSpace);
            this.Controls.Add(this.TextDisplay1);
            this.Controls.Add(this.TextDisplay2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PnlTitle);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.PnlTitle.ResumeLayout(false);
            this.PnlHistory.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel PnlTitle;
        public System.Windows.Forms.Button BtnExit;
        public System.Windows.Forms.Panel PnlHistory;
        public System.Windows.Forms.RichTextBox RtBoxDisplayHistory;
        public System.Windows.Forms.Button BtnClearHistory;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button BtnHistory;
        public System.Windows.Forms.TextBox TextDisplay2;
        public System.Windows.Forms.TextBox TextDisplay1;
        public System.Windows.Forms.Button BtnBackSpace;
        public System.Windows.Forms.Button BtnPercent;
        public System.Windows.Forms.Button BtnCE;
        public System.Windows.Forms.Button BtnC;
        public System.Windows.Forms.Button BtnDivision;
        public System.Windows.Forms.Button Btn1X;
        public System.Windows.Forms.Button BtnCos;
        public System.Windows.Forms.Button BtnSquare;
        public System.Windows.Forms.Button BtnMultiply;
        public System.Windows.Forms.Button BtnNum7;
        public System.Windows.Forms.Button BtnNum8;
        public System.Windows.Forms.Button BtnNum9;
        public System.Windows.Forms.Button BtnSubtraction;
        public System.Windows.Forms.Button BtnNum4;
        public System.Windows.Forms.Button BtnNum5;
        private System.Windows.Forms.Button BtnNum6;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnNum1;
        private System.Windows.Forms.Button BtnNum2;
        private System.Windows.Forms.Button BtnNum3;
        public System.Windows.Forms.Button BtnEquals;
        private System.Windows.Forms.Button BtnPM;
        private System.Windows.Forms.Button BtnNum0;
        private System.Windows.Forms.Button BtnDesimal;
    }
}

