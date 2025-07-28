namespace ControlesVarios
{
    partial class Form1
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
            this.lblBanda = new System.Windows.Forms.Label();
            this.txtBanda = new System.Windows.Forms.TextBox();
            this.lblCreacion = new System.Windows.Forms.Label();
            this.dtpCreacion = new System.Windows.Forms.DateTimePicker();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbRap = new System.Windows.Forms.RadioButton();
            this.rbCumbia = new System.Windows.Forms.RadioButton();
            this.rbRock = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBanda
            // 
            this.lblBanda.AutoSize = true;
            this.lblBanda.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBanda.Location = new System.Drawing.Point(31, 9);
            this.lblBanda.Name = "lblBanda";
            this.lblBanda.Size = new System.Drawing.Size(49, 14);
            this.lblBanda.TabIndex = 0;
            this.lblBanda.Text = "Banda:";
            // 
            // txtBanda
            // 
            this.txtBanda.Location = new System.Drawing.Point(86, 6);
            this.txtBanda.Name = "txtBanda";
            this.txtBanda.Size = new System.Drawing.Size(171, 20);
            this.txtBanda.TabIndex = 1;
            // 
            // lblCreacion
            // 
            this.lblCreacion.AutoSize = true;
            this.lblCreacion.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCreacion.Location = new System.Drawing.Point(10, 38);
            this.lblCreacion.Name = "lblCreacion";
            this.lblCreacion.Size = new System.Drawing.Size(70, 14);
            this.lblCreacion.TabIndex = 2;
            this.lblCreacion.Text = "Creación:";
            // 
            // dtpCreacion
            // 
            this.dtpCreacion.Location = new System.Drawing.Point(86, 32);
            this.dtpCreacion.Name = "dtpCreacion";
            this.dtpCreacion.Size = new System.Drawing.Size(200, 20);
            this.dtpCreacion.TabIndex = 3;
            // 
            // btnDetalle
            // 
            this.btnDetalle.Location = new System.Drawing.Point(17, 134);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(75, 23);
            this.btnDetalle.TabIndex = 4;
            this.btnDetalle.Text = "Detalle";
            this.btnDetalle.UseVisualStyleBackColor = true;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbRap);
            this.groupBox1.Controls.Add(this.rbCumbia);
            this.groupBox1.Controls.Add(this.rbRock);
            this.groupBox1.Location = new System.Drawing.Point(17, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 61);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Que te gusta?";
            // 
            // rbRap
            // 
            this.rbRap.AutoSize = true;
            this.rbRap.Location = new System.Drawing.Point(135, 37);
            this.rbRap.Name = "rbRap";
            this.rbRap.Size = new System.Drawing.Size(45, 17);
            this.rbRap.TabIndex = 2;
            this.rbRap.TabStop = true;
            this.rbRap.Text = "Rap";
            this.rbRap.UseVisualStyleBackColor = true;
            // 
            // rbCumbia
            // 
            this.rbCumbia.AutoSize = true;
            this.rbCumbia.Location = new System.Drawing.Point(63, 37);
            this.rbCumbia.Name = "rbCumbia";
            this.rbCumbia.Size = new System.Drawing.Size(60, 17);
            this.rbCumbia.TabIndex = 1;
            this.rbCumbia.TabStop = true;
            this.rbCumbia.Text = "Cumbia";
            this.rbCumbia.UseVisualStyleBackColor = true;
            // 
            // rbRock
            // 
            this.rbRock.AutoSize = true;
            this.rbRock.Location = new System.Drawing.Point(6, 37);
            this.rbRock.Name = "rbRock";
            this.rbRock.Size = new System.Drawing.Size(51, 17);
            this.rbRock.TabIndex = 0;
            this.rbRock.TabStop = true;
            this.rbRock.Text = "Rock";
            this.rbRock.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 168);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.dtpCreacion);
            this.Controls.Add(this.lblCreacion);
            this.Controls.Add(this.txtBanda);
            this.Controls.Add(this.lblBanda);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBanda;
        private System.Windows.Forms.TextBox txtBanda;
        private System.Windows.Forms.Label lblCreacion;
        private System.Windows.Forms.DateTimePicker dtpCreacion;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbRap;
        private System.Windows.Forms.RadioButton rbCumbia;
        private System.Windows.Forms.RadioButton rbRock;
    }
}

