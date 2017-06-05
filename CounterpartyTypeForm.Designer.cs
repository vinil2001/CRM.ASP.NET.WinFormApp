namespace CRMsales2
{
    partial class CounterpartyTypeForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddNewCouterpartyType = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DelleteCounterpartyType = new System.Windows.Forms.Button();
            this.EditeCounterpartyType = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(277, 265);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // AddNewCouterpartyType
            // 
            this.AddNewCouterpartyType.Location = new System.Drawing.Point(27, 336);
            this.AddNewCouterpartyType.Name = "AddNewCouterpartyType";
            this.AddNewCouterpartyType.Size = new System.Drawing.Size(277, 47);
            this.AddNewCouterpartyType.TabIndex = 1;
            this.AddNewCouterpartyType.Text = "Добавить";
            this.AddNewCouterpartyType.UseVisualStyleBackColor = true;
            this.AddNewCouterpartyType.Click += new System.EventHandler(this.AddNewCouterpartyType_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 283);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 47);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Ввести новый тип контрагента";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // DelleteCounterpartyType
            // 
            this.DelleteCounterpartyType.Location = new System.Drawing.Point(169, 389);
            this.DelleteCounterpartyType.Name = "DelleteCounterpartyType";
            this.DelleteCounterpartyType.Size = new System.Drawing.Size(135, 61);
            this.DelleteCounterpartyType.TabIndex = 3;
            this.DelleteCounterpartyType.Text = "Удалить";
            this.DelleteCounterpartyType.UseVisualStyleBackColor = true;
            this.DelleteCounterpartyType.Click += new System.EventHandler(this.DelleteCounterpartyType_Click);
            // 
            // EditeCounterpartyType
            // 
            this.EditeCounterpartyType.Location = new System.Drawing.Point(27, 389);
            this.EditeCounterpartyType.Name = "EditeCounterpartyType";
            this.EditeCounterpartyType.Size = new System.Drawing.Size(135, 61);
            this.EditeCounterpartyType.TabIndex = 4;
            this.EditeCounterpartyType.Text = "Изменить";
            this.EditeCounterpartyType.UseVisualStyleBackColor = true;
            this.EditeCounterpartyType.Click += new System.EventHandler(this.EditeCounterpartyType_Click);
            // 
            // CounterpartyTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 471);
            this.Controls.Add(this.EditeCounterpartyType);
            this.Controls.Add(this.DelleteCounterpartyType);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.AddNewCouterpartyType);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CounterpartyTypeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CounterpartyTypeForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddNewCouterpartyType;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button DelleteCounterpartyType;
        private System.Windows.Forms.Button EditeCounterpartyType;
    }
}