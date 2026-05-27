namespace Telecom
{
    partial class Tariff
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
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.FeetextBox = new System.Windows.Forms.TextBox();
            this.SpeedtextBox = new System.Windows.Forms.TextBox();
            this.ActivetextBox = new System.Windows.Forms.TextBox();
            this.DestextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tariffsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tariffsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tariffsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tariffsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // NametextBox
            // 
            this.NametextBox.Enabled = false;
            this.NametextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NametextBox.Location = new System.Drawing.Point(503, 84);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(164, 26);
            this.NametextBox.TabIndex = 0;
            this.NametextBox.TextChanged += new System.EventHandler(this.NametextBox_TextChanged);
            // 
            // FeetextBox
            // 
            this.FeetextBox.Enabled = false;
            this.FeetextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FeetextBox.Location = new System.Drawing.Point(503, 148);
            this.FeetextBox.Name = "FeetextBox";
            this.FeetextBox.Size = new System.Drawing.Size(164, 26);
            this.FeetextBox.TabIndex = 1;
            // 
            // SpeedtextBox
            // 
            this.SpeedtextBox.Enabled = false;
            this.SpeedtextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpeedtextBox.Location = new System.Drawing.Point(503, 221);
            this.SpeedtextBox.Name = "SpeedtextBox";
            this.SpeedtextBox.Size = new System.Drawing.Size(164, 26);
            this.SpeedtextBox.TabIndex = 2;
            // 
            // ActivetextBox
            // 
            this.ActivetextBox.Enabled = false;
            this.ActivetextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActivetextBox.Location = new System.Drawing.Point(503, 287);
            this.ActivetextBox.Name = "ActivetextBox";
            this.ActivetextBox.Size = new System.Drawing.Size(164, 26);
            this.ActivetextBox.TabIndex = 3;
            // 
            // DestextBox
            // 
            this.DestextBox.Enabled = false;
            this.DestextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DestextBox.Location = new System.Drawing.Point(167, 356);
            this.DestextBox.Name = "DestextBox";
            this.DestextBox.Size = new System.Drawing.Size(500, 26);
            this.DestextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(316, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(316, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Стоимость";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(318, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Скорость";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(316, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Активность";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(50, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Описание";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.DarkCyan;
            this.listBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tariffsBindingSource, "Name", true));
            this.listBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(39, 84);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(207, 175);
            this.listBox1.TabIndex = 21;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tariffsBindingSource
            // 
            this.tariffsBindingSource.DataSource = typeof(Telecom.ModelEF.Tariffs);
            // 
            // tariffsBindingSource1
            // 
            this.tariffsBindingSource1.DataSource = typeof(Telecom.ModelEF.Tariffs);
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.ForeColor = System.Drawing.Color.DarkCyan;
            this.buttonBack.Location = new System.Drawing.Point(590, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(140, 34);
            this.buttonBack.TabIndex = 22;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // Tariff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(807, 450);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DestextBox);
            this.Controls.Add(this.ActivetextBox);
            this.Controls.Add(this.SpeedtextBox);
            this.Controls.Add(this.FeetextBox);
            this.Controls.Add(this.NametextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Tariff";
            this.Text = "В";
            this.Load += new System.EventHandler(this.Tariff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tariffsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tariffsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource tariffsBindingSource;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.TextBox FeetextBox;
        private System.Windows.Forms.TextBox SpeedtextBox;
        private System.Windows.Forms.TextBox ActivetextBox;
        private System.Windows.Forms.TextBox DestextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource tariffsBindingSource1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonBack;
    }
}