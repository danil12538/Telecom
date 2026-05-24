namespace Telecom
{
    partial class Main
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
            this.Clientbutton = new System.Windows.Forms.Button();
            this.Ticketbutton = new System.Windows.Forms.Button();
            this.Subbutton = new System.Windows.Forms.Button();
            this.Tariffbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Clientbutton
            // 
            this.Clientbutton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clientbutton.ForeColor = System.Drawing.Color.DarkCyan;
            this.Clientbutton.Location = new System.Drawing.Point(300, 98);
            this.Clientbutton.Name = "Clientbutton";
            this.Clientbutton.Size = new System.Drawing.Size(192, 39);
            this.Clientbutton.TabIndex = 0;
            this.Clientbutton.Text = "Абоненты";
            this.Clientbutton.UseVisualStyleBackColor = true;
            this.Clientbutton.Click += new System.EventHandler(this.Clientbutton_Click);
            // 
            // Ticketbutton
            // 
            this.Ticketbutton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ticketbutton.ForeColor = System.Drawing.Color.DarkCyan;
            this.Ticketbutton.Location = new System.Drawing.Point(300, 171);
            this.Ticketbutton.Name = "Ticketbutton";
            this.Ticketbutton.Size = new System.Drawing.Size(192, 39);
            this.Ticketbutton.TabIndex = 1;
            this.Ticketbutton.Text = "Заявки";
            this.Ticketbutton.UseVisualStyleBackColor = true;
            this.Ticketbutton.Click += new System.EventHandler(this.Ticketbutton_Click);
            // 
            // Subbutton
            // 
            this.Subbutton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Subbutton.ForeColor = System.Drawing.Color.DarkCyan;
            this.Subbutton.Location = new System.Drawing.Point(300, 246);
            this.Subbutton.Name = "Subbutton";
            this.Subbutton.Size = new System.Drawing.Size(192, 39);
            this.Subbutton.TabIndex = 2;
            this.Subbutton.Text = "Подписки";
            this.Subbutton.UseVisualStyleBackColor = true;
            this.Subbutton.Click += new System.EventHandler(this.Subbutton_Click);
            // 
            // Tariffbutton
            // 
            this.Tariffbutton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tariffbutton.ForeColor = System.Drawing.Color.DarkCyan;
            this.Tariffbutton.Location = new System.Drawing.Point(300, 328);
            this.Tariffbutton.Name = "Tariffbutton";
            this.Tariffbutton.Size = new System.Drawing.Size(192, 39);
            this.Tariffbutton.TabIndex = 3;
            this.Tariffbutton.Text = "Тарифы";
            this.Tariffbutton.UseVisualStyleBackColor = true;
            this.Tariffbutton.Click += new System.EventHandler(this.Tariffbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(350, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Telecom";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tariffbutton);
            this.Controls.Add(this.Subbutton);
            this.Controls.Add(this.Ticketbutton);
            this.Controls.Add(this.Clientbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Clientbutton;
        private System.Windows.Forms.Button Ticketbutton;
        private System.Windows.Forms.Button Subbutton;
        private System.Windows.Forms.Button Tariffbutton;
        private System.Windows.Forms.Label label1;
    }
}

