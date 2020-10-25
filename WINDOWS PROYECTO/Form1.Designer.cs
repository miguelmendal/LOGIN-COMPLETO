namespace WINDOWS_PROYECTO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnpresiona = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.Button();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.ingresanombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnpresiona
            // 
            this.btnpresiona.Location = new System.Drawing.Point(216, 264);
            this.btnpresiona.Name = "btnpresiona";
            this.btnpresiona.Size = new System.Drawing.Size(103, 48);
            this.btnpresiona.TabIndex = 0;
            this.btnpresiona.Text = "OK";
            this.btnpresiona.UseVisualStyleBackColor = true;
            this.btnpresiona.Click += new System.EventHandler(this.btnpresiona_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.Location = new System.Drawing.Point(362, 264);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(102, 48);
            this.btncerrar.TabIndex = 1;
            this.btncerrar.Text = "CERRAR";
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(109, 155);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(0, 15);
            this.lbl_nombre.TabIndex = 2;
            this.lbl_nombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // ingresanombre
            // 
            this.ingresanombre.Location = new System.Drawing.Point(223, 78);
            this.ingresanombre.Name = "ingresanombre";
            this.ingresanombre.Size = new System.Drawing.Size(172, 23);
            this.ingresanombre.TabIndex = 3;
            this.ingresanombre.Text = "ESCRIBE TU NOMBRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "TU NOMBRE";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 351);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ingresanombre);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btnpresiona);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnpresiona;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox ingresanombre;
        private System.Windows.Forms.Label label2;
    }
}

