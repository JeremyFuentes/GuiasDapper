namespace DapperDemo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.btnObtenerTodos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxObtenerID = new System.Windows.Forms.TextBox();
            this.btnObtenerId = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tboxCustomerID = new System.Windows.Forms.TextBox();
            this.tboxCompanyName = new System.Windows.Forms.TextBox();
            this.tboxContactTitle = new System.Windows.Forms.TextBox();
            this.tboxContactName = new System.Windows.Forms.TextBox();
            this.tboxAddress = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(12, 12);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowHeadersWidth = 51;
            this.dgvCustomers.RowTemplate.Height = 24;
            this.dgvCustomers.Size = new System.Drawing.Size(1038, 380);
            this.dgvCustomers.TabIndex = 0;
            // 
            // btnObtenerTodos
            // 
            this.btnObtenerTodos.Location = new System.Drawing.Point(12, 407);
            this.btnObtenerTodos.Name = "btnObtenerTodos";
            this.btnObtenerTodos.Size = new System.Drawing.Size(170, 47);
            this.btnObtenerTodos.TabIndex = 1;
            this.btnObtenerTodos.Text = "Obtener Todos";
            this.btnObtenerTodos.UseVisualStyleBackColor = true;
            this.btnObtenerTodos.Click += new System.EventHandler(this.btnObtenerTodos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 486);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id Cliente";
            // 
            // tboxObtenerID
            // 
            this.tboxObtenerID.Location = new System.Drawing.Point(100, 486);
            this.tboxObtenerID.Name = "tboxObtenerID";
            this.tboxObtenerID.Size = new System.Drawing.Size(158, 22);
            this.tboxObtenerID.TabIndex = 3;
            // 
            // btnObtenerId
            // 
            this.btnObtenerId.Location = new System.Drawing.Point(281, 481);
            this.btnObtenerId.Name = "btnObtenerId";
            this.btnObtenerId.Size = new System.Drawing.Size(96, 32);
            this.btnObtenerId.TabIndex = 4;
            this.btnObtenerId.Text = "Buscar";
            this.btnObtenerId.UseVisualStyleBackColor = true;
            this.btnObtenerId.Click += new System.EventHandler(this.btnObtenerId_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(665, 438);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "CustomerID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(637, 481);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Company Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(650, 529);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Contact Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(661, 572);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Contact Title";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(684, 614);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Address";
            // 
            // tboxCustomerID
            // 
            this.tboxCustomerID.Location = new System.Drawing.Point(762, 432);
            this.tboxCustomerID.Name = "tboxCustomerID";
            this.tboxCustomerID.Size = new System.Drawing.Size(165, 22);
            this.tboxCustomerID.TabIndex = 10;
            // 
            // tboxCompanyName
            // 
            this.tboxCompanyName.Location = new System.Drawing.Point(762, 475);
            this.tboxCompanyName.Name = "tboxCompanyName";
            this.tboxCompanyName.Size = new System.Drawing.Size(165, 22);
            this.tboxCompanyName.TabIndex = 11;
            // 
            // tboxContactTitle
            // 
            this.tboxContactTitle.Location = new System.Drawing.Point(762, 566);
            this.tboxContactTitle.Name = "tboxContactTitle";
            this.tboxContactTitle.Size = new System.Drawing.Size(165, 22);
            this.tboxContactTitle.TabIndex = 13;
            // 
            // tboxContactName
            // 
            this.tboxContactName.Location = new System.Drawing.Point(762, 523);
            this.tboxContactName.Name = "tboxContactName";
            this.tboxContactName.Size = new System.Drawing.Size(165, 22);
            this.tboxContactName.TabIndex = 12;
            // 
            // tboxAddress
            // 
            this.tboxAddress.Location = new System.Drawing.Point(762, 608);
            this.tboxAddress.Name = "tboxAddress";
            this.tboxAddress.Size = new System.Drawing.Size(165, 22);
            this.tboxAddress.TabIndex = 14;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(475, 513);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(137, 48);
            this.btnInsertar.TabIndex = 15;
            this.btnInsertar.Text = "Insertar Cliente";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(475, 582);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(137, 48);
            this.btnActualizar.TabIndex = 16;
            this.btnActualizar.Text = "Actualizar Cliente";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.tboxAddress);
            this.Controls.Add(this.tboxContactTitle);
            this.Controls.Add(this.tboxContactName);
            this.Controls.Add(this.tboxCompanyName);
            this.Controls.Add(this.tboxCustomerID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnObtenerId);
            this.Controls.Add(this.tboxObtenerID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnObtenerTodos);
            this.Controls.Add(this.dgvCustomers);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Button btnObtenerTodos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxObtenerID;
        private System.Windows.Forms.Button btnObtenerId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tboxCustomerID;
        private System.Windows.Forms.TextBox tboxCompanyName;
        private System.Windows.Forms.TextBox tboxContactTitle;
        private System.Windows.Forms.TextBox tboxContactName;
        private System.Windows.Forms.TextBox tboxAddress;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnActualizar;
    }
}

