namespace gfx
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
            this.drawer = new System.Windows.Forms.Button();
            this.eraser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // drawer
            // 
            this.drawer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.drawer.Location = new System.Drawing.Point(28, 527);
            this.drawer.Name = "drawer";
            this.drawer.Size = new System.Drawing.Size(251, 54);
            this.drawer.TabIndex = 1;
            this.drawer.Text = "draw";
            this.drawer.UseVisualStyleBackColor = true;
            this.drawer.Click += new System.EventHandler(this.draw_click);
            // 
            // eraser
            // 
            this.eraser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eraser.Location = new System.Drawing.Point(547, 527);
            this.eraser.Name = "eraser";
            this.eraser.Size = new System.Drawing.Size(289, 54);
            this.eraser.TabIndex = 2;
            this.eraser.Text = "erase";
            this.eraser.UseVisualStyleBackColor = true;
            this.eraser.Click += new System.EventHandler(this.erase_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 621);
            this.Controls.Add(this.eraser);
            this.Controls.Add(this.drawer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button drawer;
        private System.Windows.Forms.Button eraser;
    }
}

