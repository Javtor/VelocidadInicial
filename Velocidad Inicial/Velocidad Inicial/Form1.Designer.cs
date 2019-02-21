namespace Velocidad_Inicial
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
            this.regListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.csvButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.avTimeLabel = new System.Windows.Forms.Label();
            this.avAngLabel = new System.Windows.Forms.Label();
            this.avDistLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // regListView
            // 
            this.regListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.regListView.FullRowSelect = true;
            this.regListView.GridLines = true;
            this.regListView.Location = new System.Drawing.Point(13, 13);
            this.regListView.Name = "regListView";
            this.regListView.Size = new System.Drawing.Size(400, 397);
            this.regListView.TabIndex = 0;
            this.regListView.UseCompatibleStateImageBehavior = false;
            this.regListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tiempo (s)";
            this.columnHeader1.Width = 133;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ángulo (°)";
            this.columnHeader2.Width = 133;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Distancia (m)";
            this.columnHeader3.Width = 133;
            // 
            // csvButton
            // 
            this.csvButton.Location = new System.Drawing.Point(419, 13);
            this.csvButton.Name = "csvButton";
            this.csvButton.Size = new System.Drawing.Size(75, 23);
            this.csvButton.TabIndex = 1;
            this.csvButton.Text = "Cargar CSV";
            this.csvButton.UseVisualStyleBackColor = true;
            this.csvButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tiempo medio:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ángulo medio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 413);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Distancia media:";
            // 
            // avTimeLabel
            // 
            this.avTimeLabel.AutoSize = true;
            this.avTimeLabel.Location = new System.Drawing.Point(94, 413);
            this.avTimeLabel.Name = "avTimeLabel";
            this.avTimeLabel.Size = new System.Drawing.Size(13, 13);
            this.avTimeLabel.TabIndex = 5;
            this.avTimeLabel.Text = "0";
            // 
            // avAngLabel
            // 
            this.avAngLabel.AutoSize = true;
            this.avAngLabel.Location = new System.Drawing.Point(228, 413);
            this.avAngLabel.Name = "avAngLabel";
            this.avAngLabel.Size = new System.Drawing.Size(13, 13);
            this.avAngLabel.TabIndex = 6;
            this.avAngLabel.Text = "0";
            // 
            // avDistLabel
            // 
            this.avDistLabel.AutoSize = true;
            this.avDistLabel.Location = new System.Drawing.Point(376, 413);
            this.avDistLabel.Name = "avDistLabel";
            this.avDistLabel.Size = new System.Drawing.Size(13, 13);
            this.avDistLabel.TabIndex = 7;
            this.avDistLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.avDistLabel);
            this.Controls.Add(this.avAngLabel);
            this.Controls.Add(this.avTimeLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.csvButton);
            this.Controls.Add(this.regListView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView regListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button csvButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label avTimeLabel;
        private System.Windows.Forms.Label avAngLabel;
        private System.Windows.Forms.Label avDistLabel;
    }
}

