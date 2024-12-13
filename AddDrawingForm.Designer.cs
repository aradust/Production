namespace Production
{
    partial class AddDrawingForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Очистка всех используемых ресурсов.
        /// </summary>
        /// <param name="disposing">истинно, если управляемые ресурсы должны быть удалены; иначе ложно.</param>
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
            this.Drawinglabel1 = new System.Windows.Forms.Label();
            this.Drawinglabel2 = new System.Windows.Forms.Label();
            this.Drawinglabel3 = new System.Windows.Forms.Label();
            this.DrawingtextBox1 = new System.Windows.Forms.TextBox();
            this.DrawingtextBox2 = new System.Windows.Forms.TextBox();
            this.DrawingtextBox3 = new System.Windows.Forms.TextBox();
            this.Drawingbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Drawinglabel1
            // 
            this.Drawinglabel1.AutoSize = true;
            this.Drawinglabel1.Location = new System.Drawing.Point(12, 15);
            this.Drawinglabel1.Name = "Drawinglabel1";
            this.Drawinglabel1.Size = new System.Drawing.Size(120, 13);
            this.Drawinglabel1.TabIndex = 0;
            this.Drawinglabel1.Text = "Название чертежа:";
            // 
            // Drawinglabel2
            // 
            this.Drawinglabel2.AutoSize = true;
            this.Drawinglabel2.Location = new System.Drawing.Point(12, 50);
            this.Drawinglabel2.Name = "Drawinglabel2";
            this.Drawinglabel2.Size = new System.Drawing.Size(125, 13);
            this.Drawinglabel2.TabIndex = 1;
            this.Drawinglabel2.Text = "Описание чертежа:";
            // 
            // Drawinglabel3
            // 
            this.Drawinglabel3.AutoSize = true;
            this.Drawinglabel3.Location = new System.Drawing.Point(12, 85);
            this.Drawinglabel3.Name = "Drawinglabel3";
            this.Drawinglabel3.Size = new System.Drawing.Size(130, 13);
            this.Drawinglabel3.TabIndex = 2;
            this.Drawinglabel3.Text = "Спецификация чертежа:";
            // 
            // DrawingtextBox1
            // 
            this.DrawingtextBox1.Location = new System.Drawing.Point(150, 12);
            this.DrawingtextBox1.Name = "DrawingtextBox1";
            this.DrawingtextBox1.Size = new System.Drawing.Size(200, 20);
            this.DrawingtextBox1.TabIndex = 3;
            // 
            // DrawingtextBox2
            // 
            this.DrawingtextBox2.Location = new System.Drawing.Point(150, 47);
            this.DrawingtextBox2.Name = "DrawingtextBox2";
            this.DrawingtextBox2.Size = new System.Drawing.Size(200, 20);
            this.DrawingtextBox2.TabIndex = 4;
            // 
            // DrawingtextBox3
            // 
            this.DrawingtextBox3.Location = new System.Drawing.Point(150, 82);
            this.DrawingtextBox3.Name = "DrawingtextBox3";
            this.DrawingtextBox3.Size = new System.Drawing.Size(200, 20);
            this.DrawingtextBox3.TabIndex = 5;
            // 
            // Drawingbutton
            // 
            this.Drawingbutton.Location = new System.Drawing.Point(150, 120);
            this.Drawingbutton.Name = "Drawingbutton";
            this.Drawingbutton.Size = new System.Drawing.Size(200, 23);
            this.Drawingbutton.TabIndex = 6;
            this.Drawingbutton.Text = "Добавить чертеж";
            this.Drawingbutton.UseVisualStyleBackColor = true;
            // 
            // AddDrawingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.Drawingbutton);
            this.Controls.Add(this.DrawingtextBox3);
            this.Controls.Add(this.DrawingtextBox2);
            this.Controls.Add(this.DrawingtextBox1);
            this.Controls.Add(this.Drawinglabel3);
            this.Controls.Add(this.Drawinglabel2);
            this.Controls.Add(this.Drawinglabel1);
            this.Name = "AddDrawingForm";
            this.Text = "Добавить чертёж";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label Drawinglabel1;
        private System.Windows.Forms.Label Drawinglabel2;
        private System.Windows.Forms.Label Drawinglabel3;
        private System.Windows.Forms.TextBox DrawingtextBox1;
        private System.Windows.Forms.TextBox DrawingtextBox2;
        private System.Windows.Forms.TextBox DrawingtextBox3;
        private System.Windows.Forms.Button Drawingbutton;
    }
}
