namespace SpectrumWinApp
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWavenumber = new System.Windows.Forms.TextBox();
            this.txtTransmitance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.clWavenumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTransmitance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clFilter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDerivatives = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btnCalc);
            this.panel1.Controls.Add(this.txtTransmitance);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtWavenumber);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 76);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(12, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(414, 259);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wavenumber (cm-1)";
            // 
            // txtWavenumber
            // 
            this.txtWavenumber.Location = new System.Drawing.Point(17, 39);
            this.txtWavenumber.Name = "txtWavenumber";
            this.txtWavenumber.Size = new System.Drawing.Size(100, 20);
            this.txtWavenumber.TabIndex = 1;
            this.txtWavenumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWavenumber.TextChanged += new System.EventHandler(this.txtWavenumber_TextChanged);
            // 
            // txtTransmitance
            // 
            this.txtTransmitance.Location = new System.Drawing.Point(141, 39);
            this.txtTransmitance.Name = "txtTransmitance";
            this.txtTransmitance.Size = new System.Drawing.Size(100, 20);
            this.txtTransmitance.TabIndex = 3;
            this.txtTransmitance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTransmitance.TextChanged += new System.EventHandler(this.txtTransmitance_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Transmitance  (%)";
            // 
            // btnCalc
            // 
            this.btnCalc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalc.Image = global::SpectrumWinApp.Properties.Resources.icons8_check_16;
            this.btnCalc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalc.Location = new System.Drawing.Point(322, 37);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clWavenumber,
            this.clTransmitance,
            this.clFilter,
            this.clDerivatives});
            this.dataGridView1.Location = new System.Drawing.Point(17, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(380, 210);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Image = global::SpectrumWinApp.Properties.Resources.icons8_check_16;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(297, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Exportar CSV";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // clWavenumber
            // 
            this.clWavenumber.DataPropertyName = "WaveNumber";
            this.clWavenumber.HeaderText = "Wave Number";
            this.clWavenumber.Name = "clWavenumber";
            this.clWavenumber.ReadOnly = true;
            // 
            // clTransmitance
            // 
            this.clTransmitance.DataPropertyName = "Transmitance";
            this.clTransmitance.HeaderText = "Transmitance";
            this.clTransmitance.Name = "clTransmitance";
            this.clTransmitance.ReadOnly = true;
            // 
            // clFilter
            // 
            this.clFilter.DataPropertyName = "Filter";
            this.clFilter.HeaderText = "Filter";
            this.clFilter.Name = "clFilter";
            this.clFilter.ReadOnly = true;
            // 
            // clDerivatives
            // 
            this.clDerivatives.DataPropertyName = "Derivative";
            this.clDerivatives.HeaderText = "Derivative";
            this.clDerivatives.Name = "clDerivatives";
            this.clDerivatives.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(438, 365);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(454, 404);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtTransmitance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWavenumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clWavenumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTransmitance;
        private System.Windows.Forms.DataGridViewTextBoxColumn clFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDerivatives;
    }
}

