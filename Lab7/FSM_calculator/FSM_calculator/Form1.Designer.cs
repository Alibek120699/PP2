namespace FSM_calculator
{
    partial class FSMcalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSMcalculator));
            this.currentop = new System.Windows.Forms.Label();
            this.currentoperation = new System.Windows.Forms.Label();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.ms = new System.Windows.Forms.Button();
            this.mmns = new System.Windows.Forms.Button();
            this.mpls = new System.Windows.Forms.Button();
            this.mr = new System.Windows.Forms.Button();
            this.mc = new System.Windows.Forms.Button();
            this.btninverse = new System.Windows.Forms.Button();
            this.btnsqr = new System.Windows.Forms.Button();
            this.btnsqrt = new System.Windows.Forms.Button();
            this.btnprsnt = new System.Windows.Forms.Button();
            this.btndvsn = new System.Windows.Forms.Button();
            this.btnbckspc = new System.Windows.Forms.Button();
            this.btnc = new System.Windows.Forms.Button();
            this.btnce = new System.Windows.Forms.Button();
            this.btnmltpl = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnmns = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnpls = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnequal = new System.Windows.Forms.Button();
            this.btndot = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnplsmns = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // currentop
            // 
            this.currentop.AutoSize = true;
            this.currentop.BackColor = System.Drawing.SystemColors.ControlDark;
            this.currentop.Location = new System.Drawing.Point(41, 101);
            this.currentop.MinimumSize = new System.Drawing.Size(300, 25);
            this.currentop.Name = "currentop";
            this.currentop.Size = new System.Drawing.Size(300, 25);
            this.currentop.TabIndex = 65;
            this.currentop.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // currentoperation
            // 
            this.currentoperation.AutoSize = true;
            this.currentoperation.Location = new System.Drawing.Point(41, 101);
            this.currentoperation.MinimumSize = new System.Drawing.Size(300, 35);
            this.currentoperation.Name = "currentoperation";
            this.currentoperation.Size = new System.Drawing.Size(300, 35);
            this.currentoperation.TabIndex = 64;
            this.currentoperation.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox_result
            // 
            this.textBox_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_result.Location = new System.Drawing.Point(-2, 139);
            this.textBox_result.MinimumSize = new System.Drawing.Size(343, 50);
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.Size = new System.Drawing.Size(343, 45);
            this.textBox_result.TabIndex = 62;
            this.textBox_result.Text = "0";
            this.textBox_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ms
            // 
            this.ms.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ms.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ms.FlatAppearance.BorderSize = 0;
            this.ms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ms.Location = new System.Drawing.Point(286, 216);
            this.ms.Name = "ms";
            this.ms.Size = new System.Drawing.Size(45, 40);
            this.ms.TabIndex = 61;
            this.ms.Text = "MS";
            this.ms.UseVisualStyleBackColor = false;
            this.ms.Click += new System.EventHandler(this.BtnClick);
            // 
            // mmns
            // 
            this.mmns.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mmns.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.mmns.FlatAppearance.BorderSize = 0;
            this.mmns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mmns.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mmns.Location = new System.Drawing.Point(212, 216);
            this.mmns.Name = "mmns";
            this.mmns.Size = new System.Drawing.Size(45, 40);
            this.mmns.TabIndex = 60;
            this.mmns.Text = "M-";
            this.mmns.UseVisualStyleBackColor = false;
            this.mmns.Click += new System.EventHandler(this.BtnClick);
            // 
            // mpls
            // 
            this.mpls.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mpls.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.mpls.FlatAppearance.BorderSize = 0;
            this.mpls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mpls.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mpls.Location = new System.Drawing.Point(146, 216);
            this.mpls.Name = "mpls";
            this.mpls.Size = new System.Drawing.Size(45, 40);
            this.mpls.TabIndex = 59;
            this.mpls.Text = "M+";
            this.mpls.UseVisualStyleBackColor = false;
            this.mpls.Click += new System.EventHandler(this.BtnClick);
            // 
            // mr
            // 
            this.mr.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mr.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.mr.FlatAppearance.BorderSize = 0;
            this.mr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mr.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mr.Location = new System.Drawing.Point(79, 216);
            this.mr.Name = "mr";
            this.mr.Size = new System.Drawing.Size(45, 40);
            this.mr.TabIndex = 58;
            this.mr.Text = "MR";
            this.mr.UseVisualStyleBackColor = false;
            this.mr.Click += new System.EventHandler(this.BtnClick);
            // 
            // mc
            // 
            this.mc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mc.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.mc.FlatAppearance.BorderSize = 0;
            this.mc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mc.Location = new System.Drawing.Point(12, 216);
            this.mc.Name = "mc";
            this.mc.Size = new System.Drawing.Size(45, 40);
            this.mc.TabIndex = 57;
            this.mc.Text = "MC";
            this.mc.UseVisualStyleBackColor = false;
            this.mc.Click += new System.EventHandler(this.BtnClick);
            // 
            // btninverse
            // 
            this.btninverse.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btninverse.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btninverse.FlatAppearance.BorderSize = 0;
            this.btninverse.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btninverse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btninverse.Location = new System.Drawing.Point(256, 276);
            this.btninverse.Name = "btninverse";
            this.btninverse.Size = new System.Drawing.Size(90, 44);
            this.btninverse.TabIndex = 56;
            this.btninverse.Text = "1/x";
            this.btninverse.UseVisualStyleBackColor = false;
            this.btninverse.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnsqr
            // 
            this.btnsqr.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsqr.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnsqr.FlatAppearance.BorderSize = 0;
            this.btnsqr.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnsqr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsqr.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnsqr.Location = new System.Drawing.Point(167, 276);
            this.btnsqr.Name = "btnsqr";
            this.btnsqr.Size = new System.Drawing.Size(90, 44);
            this.btnsqr.TabIndex = 55;
            this.btnsqr.Text = "x²";
            this.btnsqr.UseVisualStyleBackColor = false;
            this.btnsqr.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnsqrt
            // 
            this.btnsqrt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsqrt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnsqrt.FlatAppearance.BorderSize = 0;
            this.btnsqrt.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnsqrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnsqrt.Location = new System.Drawing.Point(79, 276);
            this.btnsqrt.Name = "btnsqrt";
            this.btnsqrt.Size = new System.Drawing.Size(90, 44);
            this.btnsqrt.TabIndex = 54;
            this.btnsqrt.Text = "√";
            this.btnsqrt.UseVisualStyleBackColor = false;
            this.btnsqrt.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnprsnt
            // 
            this.btnprsnt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnprsnt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnprsnt.FlatAppearance.BorderSize = 0;
            this.btnprsnt.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnprsnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprsnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnprsnt.Location = new System.Drawing.Point(-2, 276);
            this.btnprsnt.Name = "btnprsnt";
            this.btnprsnt.Size = new System.Drawing.Size(90, 44);
            this.btnprsnt.TabIndex = 53;
            this.btnprsnt.Text = "%";
            this.btnprsnt.UseVisualStyleBackColor = false;
            this.btnprsnt.Click += new System.EventHandler(this.BtnClick);
            // 
            // btndvsn
            // 
            this.btndvsn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btndvsn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btndvsn.FlatAppearance.BorderSize = 0;
            this.btndvsn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btndvsn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndvsn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btndvsn.Location = new System.Drawing.Point(256, 316);
            this.btndvsn.Name = "btndvsn";
            this.btndvsn.Size = new System.Drawing.Size(90, 52);
            this.btndvsn.TabIndex = 52;
            this.btndvsn.Text = "÷";
            this.btndvsn.UseVisualStyleBackColor = false;
            this.btndvsn.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnbckspc
            // 
            this.btnbckspc.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnbckspc.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnbckspc.FlatAppearance.BorderSize = 0;
            this.btnbckspc.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnbckspc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbckspc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnbckspc.Location = new System.Drawing.Point(167, 316);
            this.btnbckspc.Name = "btnbckspc";
            this.btnbckspc.Size = new System.Drawing.Size(90, 52);
            this.btnbckspc.TabIndex = 51;
            this.btnbckspc.Text = "⌫";
            this.btnbckspc.UseVisualStyleBackColor = false;
            this.btnbckspc.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnc
            // 
            this.btnc.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnc.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnc.FlatAppearance.BorderSize = 0;
            this.btnc.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnc.Location = new System.Drawing.Point(79, 316);
            this.btnc.Name = "btnc";
            this.btnc.Size = new System.Drawing.Size(90, 52);
            this.btnc.TabIndex = 50;
            this.btnc.Text = "C";
            this.btnc.UseVisualStyleBackColor = false;
            this.btnc.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnce
            // 
            this.btnce.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnce.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnce.FlatAppearance.BorderSize = 0;
            this.btnce.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnce.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnce.Location = new System.Drawing.Point(-2, 316);
            this.btnce.Name = "btnce";
            this.btnce.Size = new System.Drawing.Size(90, 52);
            this.btnce.TabIndex = 49;
            this.btnce.Text = "CE";
            this.btnce.UseVisualStyleBackColor = false;
            this.btnce.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnmltpl
            // 
            this.btnmltpl.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnmltpl.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnmltpl.FlatAppearance.BorderSize = 0;
            this.btnmltpl.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnmltpl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmltpl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnmltpl.Location = new System.Drawing.Point(256, 366);
            this.btnmltpl.Name = "btnmltpl";
            this.btnmltpl.Size = new System.Drawing.Size(90, 52);
            this.btnmltpl.TabIndex = 48;
            this.btnmltpl.Text = "×";
            this.btnmltpl.UseVisualStyleBackColor = false;
            this.btnmltpl.Click += new System.EventHandler(this.BtnClick);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn9.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn9.Location = new System.Drawing.Point(167, 366);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(90, 52);
            this.btn9.TabIndex = 47;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.BtnClick);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn8.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn8.Location = new System.Drawing.Point(79, 366);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(90, 52);
            this.btn8.TabIndex = 46;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.BtnClick);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn7.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn7.Location = new System.Drawing.Point(-2, 366);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(90, 52);
            this.btn7.TabIndex = 45;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnmns
            // 
            this.btnmns.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnmns.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnmns.FlatAppearance.BorderSize = 0;
            this.btnmns.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnmns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmns.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnmns.Location = new System.Drawing.Point(256, 416);
            this.btnmns.Name = "btnmns";
            this.btnmns.Size = new System.Drawing.Size(90, 52);
            this.btnmns.TabIndex = 44;
            this.btnmns.Text = "-";
            this.btnmns.UseVisualStyleBackColor = false;
            this.btnmns.Click += new System.EventHandler(this.BtnClick);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn6.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn6.Location = new System.Drawing.Point(167, 416);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(90, 52);
            this.btn6.TabIndex = 43;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.BtnClick);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn5.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn5.Location = new System.Drawing.Point(79, 416);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(90, 52);
            this.btn5.TabIndex = 42;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.BtnClick);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn4.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn4.Location = new System.Drawing.Point(-2, 416);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(90, 52);
            this.btn4.TabIndex = 41;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnpls
            // 
            this.btnpls.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnpls.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnpls.FlatAppearance.BorderSize = 0;
            this.btnpls.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnpls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpls.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnpls.Location = new System.Drawing.Point(256, 466);
            this.btnpls.Name = "btnpls";
            this.btnpls.Size = new System.Drawing.Size(90, 52);
            this.btnpls.TabIndex = 40;
            this.btnpls.Text = "+";
            this.btnpls.UseVisualStyleBackColor = false;
            this.btnpls.Click += new System.EventHandler(this.BtnClick);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn3.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn3.Location = new System.Drawing.Point(167, 466);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(90, 52);
            this.btn3.TabIndex = 39;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.BtnClick);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn2.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn2.Location = new System.Drawing.Point(79, 466);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(90, 52);
            this.btn2.TabIndex = 38;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.BtnClick);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn1.Location = new System.Drawing.Point(-2, 466);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(90, 52);
            this.btn1.TabIndex = 37;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnequal
            // 
            this.btnequal.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnequal.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnequal.FlatAppearance.BorderSize = 0;
            this.btnequal.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnequal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnequal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnequal.Location = new System.Drawing.Point(256, 516);
            this.btnequal.Name = "btnequal";
            this.btnequal.Size = new System.Drawing.Size(90, 52);
            this.btnequal.TabIndex = 36;
            this.btnequal.Text = "=";
            this.btnequal.UseVisualStyleBackColor = false;
            this.btnequal.Click += new System.EventHandler(this.BtnClick);
            // 
            // btndot
            // 
            this.btndot.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btndot.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btndot.FlatAppearance.BorderSize = 0;
            this.btndot.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btndot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndot.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btndot.Location = new System.Drawing.Point(167, 516);
            this.btndot.Name = "btndot";
            this.btndot.Size = new System.Drawing.Size(90, 52);
            this.btndot.TabIndex = 35;
            this.btndot.Text = ",";
            this.btndot.UseVisualStyleBackColor = false;
            this.btndot.Click += new System.EventHandler(this.BtnClick);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn0.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn0.FlatAppearance.BorderSize = 0;
            this.btn0.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn0.Location = new System.Drawing.Point(79, 516);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(90, 52);
            this.btn0.TabIndex = 34;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnplsmns
            // 
            this.btnplsmns.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnplsmns.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnplsmns.FlatAppearance.BorderSize = 0;
            this.btnplsmns.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnplsmns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnplsmns.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnplsmns.Location = new System.Drawing.Point(-2, 516);
            this.btnplsmns.Name = "btnplsmns";
            this.btnplsmns.Size = new System.Drawing.Size(90, 52);
            this.btnplsmns.TabIndex = 33;
            this.btnplsmns.Text = "±";
            this.btnplsmns.UseVisualStyleBackColor = false;
            this.btnplsmns.Click += new System.EventHandler(this.BtnClick);
            // 
            // FSMcalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 565);
            this.Controls.Add(this.currentop);
            this.Controls.Add(this.currentoperation);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.ms);
            this.Controls.Add(this.mmns);
            this.Controls.Add(this.mpls);
            this.Controls.Add(this.mr);
            this.Controls.Add(this.mc);
            this.Controls.Add(this.btninverse);
            this.Controls.Add(this.btnsqr);
            this.Controls.Add(this.btnsqrt);
            this.Controls.Add(this.btnprsnt);
            this.Controls.Add(this.btndvsn);
            this.Controls.Add(this.btnbckspc);
            this.Controls.Add(this.btnc);
            this.Controls.Add(this.btnce);
            this.Controls.Add(this.btnmltpl);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnmns);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnpls);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnequal);
            this.Controls.Add(this.btndot);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnplsmns);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FSMcalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currentop;
        private System.Windows.Forms.Label currentoperation;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Button ms;
        private System.Windows.Forms.Button mmns;
        private System.Windows.Forms.Button mpls;
        private System.Windows.Forms.Button mr;
        private System.Windows.Forms.Button mc;
        private System.Windows.Forms.Button btninverse;
        private System.Windows.Forms.Button btnsqr;
        private System.Windows.Forms.Button btnsqrt;
        private System.Windows.Forms.Button btnprsnt;
        private System.Windows.Forms.Button btndvsn;
        private System.Windows.Forms.Button btnbckspc;
        private System.Windows.Forms.Button btnc;
        private System.Windows.Forms.Button btnce;
        private System.Windows.Forms.Button btnmltpl;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnmns;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnpls;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnequal;
        private System.Windows.Forms.Button btndot;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnplsmns;
    }
}

