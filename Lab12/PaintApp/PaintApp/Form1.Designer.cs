namespace PaintApp
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnpencil = new System.Windows.Forms.Button();
            this.btnrectangle = new System.Windows.Forms.Button();
            this.btnellipse = new System.Windows.Forms.Button();
            this.btnline = new System.Windows.Forms.Button();
            this.btntriangle = new System.Windows.Forms.Button();
            this.btneraser = new System.Windows.Forms.Button();
            this.btnisotriangle = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.itemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pencilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ellipseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.triangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eraserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.isoTriangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(25, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(904, 515);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // btnpencil
            // 
            this.btnpencil.Location = new System.Drawing.Point(25, 47);
            this.btnpencil.Name = "btnpencil";
            this.btnpencil.Size = new System.Drawing.Size(75, 35);
            this.btnpencil.TabIndex = 1;
            this.btnpencil.Text = "Pencil";
            this.btnpencil.UseVisualStyleBackColor = true;
            this.btnpencil.Click += new System.EventHandler(this.tools_click);
            // 
            // btnrectangle
            // 
            this.btnrectangle.Location = new System.Drawing.Point(106, 47);
            this.btnrectangle.Name = "btnrectangle";
            this.btnrectangle.Size = new System.Drawing.Size(84, 36);
            this.btnrectangle.TabIndex = 2;
            this.btnrectangle.Text = "Rect";
            this.btnrectangle.UseVisualStyleBackColor = true;
            this.btnrectangle.Click += new System.EventHandler(this.tools_click);
            // 
            // btnellipse
            // 
            this.btnellipse.Location = new System.Drawing.Point(196, 46);
            this.btnellipse.Name = "btnellipse";
            this.btnellipse.Size = new System.Drawing.Size(85, 36);
            this.btnellipse.TabIndex = 3;
            this.btnellipse.Text = "Ellipse";
            this.btnellipse.UseVisualStyleBackColor = true;
            this.btnellipse.Click += new System.EventHandler(this.tools_click);
            // 
            // btnline
            // 
            this.btnline.Location = new System.Drawing.Point(287, 48);
            this.btnline.Name = "btnline";
            this.btnline.Size = new System.Drawing.Size(87, 35);
            this.btnline.TabIndex = 4;
            this.btnline.Text = "Line";
            this.btnline.UseVisualStyleBackColor = true;
            this.btnline.Click += new System.EventHandler(this.tools_click);
            // 
            // btntriangle
            // 
            this.btntriangle.Location = new System.Drawing.Point(380, 49);
            this.btntriangle.Name = "btntriangle";
            this.btntriangle.Size = new System.Drawing.Size(90, 33);
            this.btntriangle.TabIndex = 5;
            this.btntriangle.Text = "Triangle";
            this.btntriangle.UseVisualStyleBackColor = true;
            this.btntriangle.Click += new System.EventHandler(this.tools_click);
            // 
            // btneraser
            // 
            this.btneraser.Location = new System.Drawing.Point(574, 48);
            this.btneraser.Name = "btneraser";
            this.btneraser.Size = new System.Drawing.Size(93, 33);
            this.btneraser.TabIndex = 6;
            this.btneraser.Text = "Eraser";
            this.btneraser.UseVisualStyleBackColor = true;
            this.btneraser.Click += new System.EventHandler(this.tools_click);
            // 
            // btnisotriangle
            // 
            this.btnisotriangle.Location = new System.Drawing.Point(476, 47);
            this.btnisotriangle.Name = "btnisotriangle";
            this.btnisotriangle.Size = new System.Drawing.Size(92, 39);
            this.btnisotriangle.TabIndex = 7;
            this.btnisotriangle.Text = "IsoTriangle";
            this.btnisotriangle.UseVisualStyleBackColor = true;
            this.btnisotriangle.Click += new System.EventHandler(this.tools_click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(957, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemsToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(957, 28);
            this.menuStrip2.TabIndex = 9;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // itemsToolStripMenuItem
            // 
            this.itemsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.itemsToolStripMenuItem.Name = "itemsToolStripMenuItem";
            this.itemsToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.itemsToolStripMenuItem.Text = "File";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pencilToolStripMenuItem,
            this.rectToolStripMenuItem,
            this.ellipseToolStripMenuItem,
            this.lineToolStripMenuItem,
            this.triangleToolStripMenuItem,
            this.eraserToolStripMenuItem,
            this.isoTriangleToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(57, 24);
            this.toolStripMenuItem1.Text = "Items";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // pencilToolStripMenuItem
            // 
            this.pencilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.pencilToolStripMenuItem.Name = "pencilToolStripMenuItem";
            this.pencilToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.pencilToolStripMenuItem.Text = "Pencil";
            // 
            // rectToolStripMenuItem
            // 
            this.rectToolStripMenuItem.Name = "rectToolStripMenuItem";
            this.rectToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.rectToolStripMenuItem.Text = "Rect";
            // 
            // ellipseToolStripMenuItem
            // 
            this.ellipseToolStripMenuItem.Name = "ellipseToolStripMenuItem";
            this.ellipseToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.ellipseToolStripMenuItem.Text = "Ellipse";
            // 
            // lineToolStripMenuItem
            // 
            this.lineToolStripMenuItem.Name = "lineToolStripMenuItem";
            this.lineToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.lineToolStripMenuItem.Text = "Line";
            // 
            // triangleToolStripMenuItem
            // 
            this.triangleToolStripMenuItem.Name = "triangleToolStripMenuItem";
            this.triangleToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.triangleToolStripMenuItem.Text = "Triangle";
            // 
            // eraserToolStripMenuItem
            // 
            this.eraserToolStripMenuItem.Name = "eraserToolStripMenuItem";
            this.eraserToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.eraserToolStripMenuItem.Text = "IsoTriangle";
            // 
            // isoTriangleToolStripMenuItem
            // 
            this.isoTriangleToolStripMenuItem.Name = "isoTriangleToolStripMenuItem";
            this.isoTriangleToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.isoTriangleToolStripMenuItem.Text = "Eraser";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 28);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 628);
            this.Controls.Add(this.btnisotriangle);
            this.Controls.Add(this.btneraser);
            this.Controls.Add(this.btntriangle);
            this.Controls.Add(this.btnline);
            this.Controls.Add(this.btnellipse);
            this.Controls.Add(this.btnrectangle);
            this.Controls.Add(this.btnpencil);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnpencil;
        private System.Windows.Forms.Button btnrectangle;
        private System.Windows.Forms.Button btnellipse;
        private System.Windows.Forms.Button btnline;
        private System.Windows.Forms.Button btntriangle;
        private System.Windows.Forms.Button btneraser;
        private System.Windows.Forms.Button btnisotriangle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem itemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pencilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ellipseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem triangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eraserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem isoTriangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
    }
}

