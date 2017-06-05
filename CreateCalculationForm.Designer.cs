namespace CRMsales2.DLL
{
    partial class CreateCalculationForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Lenght = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Width = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Height = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nomination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lenght1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Width1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Width2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Consumption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceForCalculationWithoutVAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1902, 1012);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView3);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(4, 743);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1387, 257);
            this.panel4.TabIndex = 0;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(0, 20);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 28;
            this.dataGridView3.Size = new System.Drawing.Size(1387, 237);
            this.dataGridView3.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Параметры расчета";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(1397, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(512, 947);
            this.panel3.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(512, 44);
            this.label2.TabIndex = 23;
            this.label2.Text = "Груповой расчет однотипных изделий отличающихся только габаритными размерами";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Lenght,
            this.Width,
            this.Height,
            this.Column1});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(512, 901);
            this.dataGridView1.TabIndex = 22;
            // 
            // Lenght
            // 
            this.Lenght.HeaderText = "Длинна";
            this.Lenght.Name = "Lenght";
            // 
            // Width
            // 
            this.Width.HeaderText = "Ширина";
            this.Width.Name = "Width";
            // 
            // Height
            // 
            this.Height.HeaderText = "Высота";
            this.Height.Name = "Height";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Стоимость с НДС";
            this.Column1.Name = "Column1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Location = new System.Drawing.Point(3, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1388, 685);
            this.panel2.TabIndex = 16;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(715, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(206, 37);
            this.button4.TabIndex = 27;
            this.button4.Text = "Выполнить расчет";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(492, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(206, 37);
            this.button3.TabIndex = 26;
            this.button3.Text = "Удалить деталь";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(267, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 37);
            this.button2.TabIndex = 25;
            this.button2.Text = "Добавить деталь";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1173, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 37);
            this.button1.TabIndex = 24;
            this.button1.Text = "Сохранить расчет";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1388, 44);
            this.label3.TabIndex = 23;
            this.label3.Text = "Лист расчета";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Designation,
            this.Nomination,
            this.Amount,
            this.Lenght1,
            this.Width1,
            this.Width2,
            this.Consumption,
            this.PriceForCalculationWithoutVAT});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView2.Location = new System.Drawing.Point(0, 47);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(1388, 638);
            this.dataGridView2.TabIndex = 22;
            // 
            // Designation
            // 
            this.Designation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Designation.HeaderText = "Обозначение детали на чертеже";
            this.Designation.Name = "Designation";
            this.Designation.Width = 193;
            // 
            // Nomination
            // 
            this.Nomination.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Nomination.HeaderText = "Наименование детали";
            this.Nomination.Name = "Nomination";
            this.Nomination.ReadOnly = true;
            this.Nomination.Width = 200;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Кол-во";
            this.Amount.Name = "Amount";
            // 
            // Lenght1
            // 
            this.Lenght1.HeaderText = "Длинна";
            this.Lenght1.Name = "Lenght1";
            // 
            // Width1
            // 
            this.Width1.HeaderText = "Ширина";
            this.Width1.Name = "Width1";
            // 
            // Width2
            // 
            this.Width2.HeaderText = "Высота";
            this.Width2.Name = "Width2";
            // 
            // Consumption
            // 
            this.Consumption.HeaderText = "Расход";
            this.Consumption.Name = "Consumption";
            // 
            // PriceForCalculationWithoutVAT
            // 
            this.PriceForCalculationWithoutVAT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PriceForCalculationWithoutVAT.HeaderText = "Цена без НДС";
            this.PriceForCalculationWithoutVAT.Name = "PriceForCalculationWithoutVAT";
            this.PriceForCalculationWithoutVAT.Width = 141;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Location = new System.Drawing.Point(0, 20);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1902, 26);
            this.textBox1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Название/модель";
            // 
            // CreateCalculationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1902, 1012);
            this.Controls.Add(this.panel1);
            this.Name = "CreateCalculationForm";
            this.Text = "CalculationForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lenght;
        private System.Windows.Forms.DataGridViewTextBoxColumn Width;
        private System.Windows.Forms.DataGridViewTextBoxColumn Height;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nomination;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lenght1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Width1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Width2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Consumption;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceForCalculationWithoutVAT;
    }
}