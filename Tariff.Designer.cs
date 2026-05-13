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
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label isActiveLabel;
            System.Windows.Forms.Label monthlyFeeLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label speedMbpsLabel;
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
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.tariffsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.isActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.monthlyFeeTextBox = new System.Windows.Forms.TextBox();
            this.nameComboBox = new System.Windows.Forms.ComboBox();
            this.speedMbpsTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tariffsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            descriptionLabel = new System.Windows.Forms.Label();
            isActiveLabel = new System.Windows.Forms.Label();
            monthlyFeeLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            speedMbpsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tariffsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tariffsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(570, 259);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 10;
            descriptionLabel.Text = "Description:";
            // 
            // isActiveLabel
            // 
            isActiveLabel.AutoSize = true;
            isActiveLabel.Location = new System.Drawing.Point(570, 133);
            isActiveLabel.Name = "isActiveLabel";
            isActiveLabel.Size = new System.Drawing.Size(51, 13);
            isActiveLabel.TabIndex = 12;
            isActiveLabel.Text = "Is Active:";
            // 
            // monthlyFeeLabel
            // 
            monthlyFeeLabel.AutoSize = true;
            monthlyFeeLabel.Location = new System.Drawing.Point(570, 161);
            monthlyFeeLabel.Name = "monthlyFeeLabel";
            monthlyFeeLabel.Size = new System.Drawing.Size(68, 13);
            monthlyFeeLabel.TabIndex = 14;
            monthlyFeeLabel.Text = "Monthly Fee:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(570, 97);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 16;
            nameLabel.Text = "Name:";
            // 
            // speedMbpsLabel
            // 
            speedMbpsLabel.AutoSize = true;
            speedMbpsLabel.Location = new System.Drawing.Point(570, 214);
            speedMbpsLabel.Name = "speedMbpsLabel";
            speedMbpsLabel.Size = new System.Drawing.Size(70, 13);
            speedMbpsLabel.TabIndex = 18;
            speedMbpsLabel.Text = "Speed Mbps:";
            // 
            // NametextBox
            // 
            this.NametextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NametextBox.Location = new System.Drawing.Point(312, 88);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(164, 26);
            this.NametextBox.TabIndex = 0;
            this.NametextBox.TextChanged += new System.EventHandler(this.NametextBox_TextChanged);
            // 
            // FeetextBox
            // 
            this.FeetextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FeetextBox.Location = new System.Drawing.Point(312, 152);
            this.FeetextBox.Name = "FeetextBox";
            this.FeetextBox.Size = new System.Drawing.Size(164, 26);
            this.FeetextBox.TabIndex = 1;
            // 
            // SpeedtextBox
            // 
            this.SpeedtextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpeedtextBox.Location = new System.Drawing.Point(312, 218);
            this.SpeedtextBox.Name = "SpeedtextBox";
            this.SpeedtextBox.Size = new System.Drawing.Size(164, 26);
            this.SpeedtextBox.TabIndex = 2;
            // 
            // ActivetextBox
            // 
            this.ActivetextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActivetextBox.Location = new System.Drawing.Point(312, 287);
            this.ActivetextBox.Name = "ActivetextBox";
            this.ActivetextBox.Size = new System.Drawing.Size(164, 26);
            this.ActivetextBox.TabIndex = 3;
            // 
            // DestextBox
            // 
            this.DestextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DestextBox.Location = new System.Drawing.Point(312, 360);
            this.DestextBox.Name = "DestextBox";
            this.DestextBox.Size = new System.Drawing.Size(164, 26);
            this.DestextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(176, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(176, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Стоимость";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(176, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Скорость";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(176, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Активность";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(176, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Описание";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tariffsBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(646, 256);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(121, 20);
            this.descriptionTextBox.TabIndex = 11;
            this.descriptionTextBox.TextChanged += new System.EventHandler(this.descriptionTextBox_TextChanged);
            // 
            // tariffsBindingSource
            // 
            this.tariffsBindingSource.DataSource = typeof(Telecom.ModelEF.Tariffs);
            // 
            // isActiveCheckBox
            // 
            this.isActiveCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tariffsBindingSource, "IsActive", true));
            this.isActiveCheckBox.Location = new System.Drawing.Point(646, 128);
            this.isActiveCheckBox.Name = "isActiveCheckBox";
            this.isActiveCheckBox.Size = new System.Drawing.Size(121, 24);
            this.isActiveCheckBox.TabIndex = 13;
            this.isActiveCheckBox.Text = "checkBox1";
            this.isActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // monthlyFeeTextBox
            // 
            this.monthlyFeeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tariffsBindingSource, "MonthlyFee", true));
            this.monthlyFeeTextBox.Location = new System.Drawing.Point(646, 158);
            this.monthlyFeeTextBox.Name = "monthlyFeeTextBox";
            this.monthlyFeeTextBox.Size = new System.Drawing.Size(121, 20);
            this.monthlyFeeTextBox.TabIndex = 15;
            // 
            // nameComboBox
            // 
            this.nameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tariffsBindingSource, "Name", true));
            this.nameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tariffsBindingSource, "Name", true));
            this.nameComboBox.DataSource = this.tariffsBindingSource;
            this.nameComboBox.DisplayMember = "Name";
            this.nameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nameComboBox.FormattingEnabled = true;
            this.nameComboBox.Location = new System.Drawing.Point(626, 91);
            this.nameComboBox.Name = "nameComboBox";
            this.nameComboBox.Size = new System.Drawing.Size(121, 21);
            this.nameComboBox.TabIndex = 17;
            this.nameComboBox.ValueMember = "TariffID";
            // 
            // speedMbpsTextBox
            // 
            this.speedMbpsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tariffsBindingSource, "SpeedMbps", true));
            this.speedMbpsTextBox.Location = new System.Drawing.Point(646, 211);
            this.speedMbpsTextBox.Name = "speedMbpsTextBox";
            this.speedMbpsTextBox.Size = new System.Drawing.Size(121, 20);
            this.speedMbpsTextBox.TabIndex = 19;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tariffsBindingSource, "Name", true));
            this.comboBox1.DataSource = this.tariffsBindingSource;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(372, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.ValueMember = "TariffID";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tariffsBindingSource1
            // 
            this.tariffsBindingSource1.DataSource = typeof(Telecom.ModelEF.Tariffs);
            // 
            // listBox1
            // 
            this.listBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tariffsBindingSource, "Name", true));
            this.listBox1.DataSource = this.tariffsBindingSource;
            this.listBox1.DisplayMember = "Name";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(141, 56);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 21;
            this.listBox1.ValueMember = "TariffID";
            // 
            // listBox2
            // 
            this.listBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tariffsBindingSource, "TariffID", true));
            this.listBox2.DataSource = this.tariffsBindingSource;
            this.listBox2.DisplayMember = "Name";
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(39, 147);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 95);
            this.listBox2.TabIndex = 22;
            this.listBox2.ValueMember = "MonthlyFee";
            // 
            // Tariff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(807, 450);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(isActiveLabel);
            this.Controls.Add(this.isActiveCheckBox);
            this.Controls.Add(monthlyFeeLabel);
            this.Controls.Add(this.monthlyFeeTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameComboBox);
            this.Controls.Add(speedMbpsLabel);
            this.Controls.Add(this.speedMbpsTextBox);
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
            this.Text = "Tariffs";
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
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.CheckBox isActiveCheckBox;
        private System.Windows.Forms.TextBox monthlyFeeTextBox;
        private System.Windows.Forms.ComboBox nameComboBox;
        private System.Windows.Forms.TextBox speedMbpsTextBox;
        private System.Windows.Forms.BindingSource tariffsBindingSource1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
    }
}