namespace CRMsales2
{
    partial class TypeOfOwnershipForm
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
            this.EditeCounterpartyType = new System.Windows.Forms.Button();
            this.DelleteCounterpartyType = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AddNewCouterpartyType = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // EditeCounterpartyType
            // 
            this.EditeCounterpartyType.Location = new System.Drawing.Point(28, 393);
            this.EditeCounterpartyType.Name = "EditeCounterpartyType";
            this.EditeCounterpartyType.Size = new System.Drawing.Size(135, 61);
            this.EditeCounterpartyType.TabIndex = 9;
            this.EditeCounterpartyType.Text = "Изменить";
            this.EditeCounterpartyType.UseVisualStyleBackColor = true;
            this.EditeCounterpartyType.Click += new System.EventHandler(this.EditeTypeOfOwnership_Click);
            // 
            // DelleteCounterpartyType
            // 
            this.DelleteCounterpartyType.Location = new System.Drawing.Point(170, 393);
            this.DelleteCounterpartyType.Name = "DelleteCounterpartyType";
            this.DelleteCounterpartyType.Size = new System.Drawing.Size(135, 61);
            this.DelleteCounterpartyType.TabIndex = 8;
            this.DelleteCounterpartyType.Text = "Удалить";
            this.DelleteCounterpartyType.UseVisualStyleBackColor = true;
            this.DelleteCounterpartyType.Click += new System.EventHandler(this.DelleteTypeOfOwnership_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 287);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 47);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Ввести новую форму собственности";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AddNewCouterpartyType
            // 
            this.AddNewCouterpartyType.Location = new System.Drawing.Point(28, 340);
            this.AddNewCouterpartyType.Name = "AddNewCouterpartyType";
            this.AddNewCouterpartyType.Size = new System.Drawing.Size(277, 47);
            this.AddNewCouterpartyType.TabIndex = 6;
            this.AddNewCouterpartyType.Text = "Добавить";
            this.AddNewCouterpartyType.UseVisualStyleBackColor = true;
            this.AddNewCouterpartyType.Click += new System.EventHandler(this.AddNewCouterpartyType_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 16);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(277, 265);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // TypeOfOwnershipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 471);
            this.Controls.Add(this.EditeCounterpartyType);
            this.Controls.Add(this.DelleteCounterpartyType);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.AddNewCouterpartyType);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TypeOfOwnershipForm";
            this.Text = "TypeOfOwnershipForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EditeCounterpartyType;
        private System.Windows.Forms.Button DelleteCounterpartyType;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button AddNewCouterpartyType;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}