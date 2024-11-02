namespace Bucket_Sort
{
    partial class BucketSort
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BucketSort));
            this.BTNArray = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxBArray = new System.Windows.Forms.TextBox();
            this.BTNSort = new System.Windows.Forms.Button();
            this.TxBucketSort = new System.Windows.Forms.TextBox();
            this.LBSort = new System.Windows.Forms.Label();
            this.dataGridViewResults = new System.Windows.Forms.DataGridView();
            this.BTNAccept = new System.Windows.Forms.Button();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNArray
            // 
            this.BTNArray.BackColor = System.Drawing.Color.DarkTurquoise;
            this.BTNArray.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNArray.Location = new System.Drawing.Point(181, 74);
            this.BTNArray.Margin = new System.Windows.Forms.Padding(2);
            this.BTNArray.Name = "BTNArray";
            this.BTNArray.Size = new System.Drawing.Size(78, 26);
            this.BTNArray.TabIndex = 0;
            this.BTNArray.Text = "Aceptar";
            this.BTNArray.UseVisualStyleBackColor = false;
            this.BTNArray.Click += new System.EventHandler(this.BTNArray_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(32, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tamaño del arreglo:";
            // 
            // TxBArray
            // 
            this.TxBArray.Location = new System.Drawing.Point(35, 74);
            this.TxBArray.Margin = new System.Windows.Forms.Padding(2);
            this.TxBArray.Name = "TxBArray";
            this.TxBArray.Size = new System.Drawing.Size(142, 26);
            this.TxBArray.TabIndex = 2;
            // 
            // BTNSort
            // 
            this.BTNSort.BackColor = System.Drawing.Color.Gold;
            this.BTNSort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNSort.Location = new System.Drawing.Point(143, 201);
            this.BTNSort.Margin = new System.Windows.Forms.Padding(2);
            this.BTNSort.Name = "BTNSort";
            this.BTNSort.Size = new System.Drawing.Size(78, 26);
            this.BTNSort.TabIndex = 3;
            this.BTNSort.Text = "Ordenar";
            this.BTNSort.UseVisualStyleBackColor = false;
            this.BTNSort.Click += new System.EventHandler(this.BTNSort_Click);
            // 
            // TxBucketSort
            // 
            this.TxBucketSort.Location = new System.Drawing.Point(35, 151);
            this.TxBucketSort.Name = "TxBucketSort";
            this.TxBucketSort.Size = new System.Drawing.Size(224, 26);
            this.TxBucketSort.TabIndex = 5;
            // 
            // LBSort
            // 
            this.LBSort.AutoSize = true;
            this.LBSort.ForeColor = System.Drawing.SystemColors.Control;
            this.LBSort.Location = new System.Drawing.Point(32, 121);
            this.LBSort.Name = "LBSort";
            this.LBSort.Size = new System.Drawing.Size(216, 18);
            this.LBSort.TabIndex = 6;
            this.LBSort.Text = "Ingresa los datos que desees:";
            // 
            // dataGridViewResults
            // 
            this.dataGridViewResults.BackgroundColor = System.Drawing.Color.SlateBlue;
            this.dataGridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1});
            this.dataGridViewResults.Location = new System.Drawing.Point(54, 246);
            this.dataGridViewResults.Name = "dataGridViewResults";
            this.dataGridViewResults.Size = new System.Drawing.Size(244, 150);
            this.dataGridViewResults.TabIndex = 7;
            // 
            // BTNAccept
            // 
            this.BTNAccept.BackColor = System.Drawing.Color.DarkTurquoise;
            this.BTNAccept.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNAccept.ForeColor = System.Drawing.Color.Black;
            this.BTNAccept.Location = new System.Drawing.Point(265, 151);
            this.BTNAccept.Name = "BTNAccept";
            this.BTNAccept.Size = new System.Drawing.Size(75, 26);
            this.BTNAccept.TabIndex = 8;
            this.BTNAccept.Text = "Aceptar";
            this.BTNAccept.UseVisualStyleBackColor = false;
            this.BTNAccept.Click += new System.EventHandler(this.BTNAccept_Click);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Sin Ordenar";
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ordenados";
            this.Column1.Name = "Column1";
            // 
            // BucketSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(362, 423);
            this.Controls.Add(this.BTNAccept);
            this.Controls.Add(this.dataGridViewResults);
            this.Controls.Add(this.LBSort);
            this.Controls.Add(this.TxBucketSort);
            this.Controls.Add(this.BTNSort);
            this.Controls.Add(this.TxBArray);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNArray);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "BucketSort";
            this.Text = "Bucket Sort";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNArray;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxBArray;
        private System.Windows.Forms.Button BTNSort;
        private System.Windows.Forms.TextBox TxBucketSort;
        private System.Windows.Forms.Label LBSort;
        private System.Windows.Forms.DataGridView dataGridViewResults;
        private System.Windows.Forms.Button BTNAccept;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}

