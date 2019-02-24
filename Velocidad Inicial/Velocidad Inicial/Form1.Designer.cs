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
            this.Addbt = new System.Windows.Forms.Button();
            this.Deletebt = new System.Windows.Forms.Button();
            this.Clearbt = new System.Windows.Forms.Button();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbAngle = new System.Windows.Forms.Label();
            this.lbDistance = new System.Windows.Forms.Label();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.tbAngle = new System.Windows.Forms.TextBox();
            this.tbDistance = new System.Windows.Forms.TextBox();
            this.lbURL = new System.Windows.Forms.Label();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.CBHeader = new System.Windows.Forms.CheckBox();
            this.btCalc1 = new System.Windows.Forms.Button();
            this.btCalc2 = new System.Windows.Forms.Button();
            this.btCalcAll = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.csvButton.Location = new System.Drawing.Point(531, 276);
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
            // Addbt
            // 
            this.Addbt.Location = new System.Drawing.Point(531, 140);
            this.Addbt.Name = "Addbt";
            this.Addbt.Size = new System.Drawing.Size(75, 23);
            this.Addbt.TabIndex = 8;
            this.Addbt.Text = "Agregar ";
            this.Addbt.UseVisualStyleBackColor = true;
            this.Addbt.Click += new System.EventHandler(this.Addbt_Click);
            // 
            // Deletebt
            // 
            this.Deletebt.Location = new System.Drawing.Point(647, 140);
            this.Deletebt.Name = "Deletebt";
            this.Deletebt.Size = new System.Drawing.Size(75, 23);
            this.Deletebt.TabIndex = 9;
            this.Deletebt.Text = "Eliminar";
            this.Deletebt.UseVisualStyleBackColor = true;
            this.Deletebt.Click += new System.EventHandler(this.Deletebt_Click);
            // 
            // Clearbt
            // 
            this.Clearbt.Location = new System.Drawing.Point(645, 276);
            this.Clearbt.Name = "Clearbt";
            this.Clearbt.Size = new System.Drawing.Size(75, 23);
            this.Clearbt.TabIndex = 10;
            this.Clearbt.Text = "Limpiar Lista";
            this.Clearbt.UseVisualStyleBackColor = true;
            this.Clearbt.Click += new System.EventHandler(this.Clearbt_Click);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(528, 42);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(42, 13);
            this.lbTime.TabIndex = 11;
            this.lbTime.Text = "Tiempo";
            // 
            // lbAngle
            // 
            this.lbAngle.AutoSize = true;
            this.lbAngle.Location = new System.Drawing.Point(528, 81);
            this.lbAngle.Name = "lbAngle";
            this.lbAngle.Size = new System.Drawing.Size(40, 13);
            this.lbAngle.TabIndex = 12;
            this.lbAngle.Text = "Angulo";
            // 
            // lbDistance
            // 
            this.lbDistance.AutoSize = true;
            this.lbDistance.Location = new System.Drawing.Point(528, 114);
            this.lbDistance.Name = "lbDistance";
            this.lbDistance.Size = new System.Drawing.Size(51, 13);
            this.lbDistance.TabIndex = 13;
            this.lbDistance.Text = "Distancia";
            // 
            // tbTime
            // 
            this.tbTime.Location = new System.Drawing.Point(622, 42);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(100, 20);
            this.tbTime.TabIndex = 14;
            // 
            // tbAngle
            // 
            this.tbAngle.Location = new System.Drawing.Point(622, 74);
            this.tbAngle.Name = "tbAngle";
            this.tbAngle.Size = new System.Drawing.Size(100, 20);
            this.tbAngle.TabIndex = 15;
            // 
            // tbDistance
            // 
            this.tbDistance.Location = new System.Drawing.Point(622, 107);
            this.tbDistance.Name = "tbDistance";
            this.tbDistance.Size = new System.Drawing.Size(100, 20);
            this.tbDistance.TabIndex = 16;
            // 
            // lbURL
            // 
            this.lbURL.AutoSize = true;
            this.lbURL.Location = new System.Drawing.Point(501, 211);
            this.lbURL.Name = "lbURL";
            this.lbURL.Size = new System.Drawing.Size(69, 13);
            this.lbURL.TabIndex = 17;
            this.lbURL.Text = "Ruta de CSV";
            // 
            // tbURL
            // 
            this.tbURL.Location = new System.Drawing.Point(108, 19);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(164, 20);
            this.tbURL.TabIndex = 18;
            this.tbURL.Click += new System.EventHandler(this.tbURL_TextChanged);
            this.tbURL.TextChanged += new System.EventHandler(this.tbURL_TextChanged);
            // 
            // CBHeader
            // 
            this.CBHeader.AutoSize = true;
            this.CBHeader.Location = new System.Drawing.Point(612, 244);
            this.CBHeader.Name = "CBHeader";
            this.CBHeader.Size = new System.Drawing.Size(108, 17);
            this.CBHeader.TabIndex = 19;
            this.CBHeader.Text = "Con Encabezado";
            this.CBHeader.UseVisualStyleBackColor = true;
            // 
            // btCalc1
            // 
            this.btCalc1.Location = new System.Drawing.Point(15, 19);
            this.btCalc1.Name = "btCalc1";
            this.btCalc1.Size = new System.Drawing.Size(75, 23);
            this.btCalc1.TabIndex = 20;
            this.btCalc1.Text = "Calcular V1";
            this.btCalc1.UseVisualStyleBackColor = true;
            this.btCalc1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btCalc2
            // 
            this.btCalc2.Location = new System.Drawing.Point(15, 58);
            this.btCalc2.Name = "btCalc2";
            this.btCalc2.Size = new System.Drawing.Size(75, 23);
            this.btCalc2.TabIndex = 21;
            this.btCalc2.Text = "Calcular V2";
            this.btCalc2.UseVisualStyleBackColor = true;
            this.btCalc2.Click += new System.EventHandler(this.btCalc2_Click);
            // 
            // btCalcAll
            // 
            this.btCalcAll.Location = new System.Drawing.Point(134, 19);
            this.btCalcAll.Name = "btCalcAll";
            this.btCalcAll.Size = new System.Drawing.Size(120, 23);
            this.btCalcAll.TabIndex = 22;
            this.btCalcAll.Text = "Calcular Ambas";
            this.btCalcAll.UseVisualStyleBackColor = true;
            this.btCalcAll.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(478, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 169);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manejo de Datos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbURL);
            this.groupBox2.Location = new System.Drawing.Point(478, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 133);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Manejo de Lista";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.btCalcAll);
            this.groupBox3.Controls.Add(this.btCalc1);
            this.groupBox3.Controls.Add(this.btCalc2);
            this.groupBox3.Location = new System.Drawing.Point(478, 329);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(278, 100);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Calculos";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Calcular Interseccion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CBHeader);
            this.Controls.Add(this.lbURL);
            this.Controls.Add(this.tbDistance);
            this.Controls.Add(this.tbAngle);
            this.Controls.Add(this.tbTime);
            this.Controls.Add(this.lbDistance);
            this.Controls.Add(this.lbAngle);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.Clearbt);
            this.Controls.Add(this.Deletebt);
            this.Controls.Add(this.Addbt);
            this.Controls.Add(this.avDistLabel);
            this.Controls.Add(this.avAngLabel);
            this.Controls.Add(this.avTimeLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.csvButton);
            this.Controls.Add(this.regListView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
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
        private System.Windows.Forms.Button Addbt;
        private System.Windows.Forms.Button Deletebt;
        private System.Windows.Forms.Button Clearbt;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbAngle;
        private System.Windows.Forms.Label lbDistance;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.TextBox tbAngle;
        private System.Windows.Forms.TextBox tbDistance;
        private System.Windows.Forms.Label lbURL;
        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.CheckBox CBHeader;
        private System.Windows.Forms.Button btCalc1;
        private System.Windows.Forms.Button btCalc2;
        private System.Windows.Forms.Button btCalcAll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
    }
}

