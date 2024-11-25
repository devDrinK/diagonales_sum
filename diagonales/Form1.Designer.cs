namespace diagonales
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
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtMatriz = new System.Windows.Forms.TextBox();
            this.lblDprincipal = new System.Windows.Forms.Label();
            this.lblDopuesta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNum
            // 
            this.txtNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNum.Location = new System.Drawing.Point(393, 12);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 26);
            this.txtNum.TabIndex = 0;
            this.txtNum.Click += new System.EventHandler(this.txtNum_Click);
            this.txtNum.TextChanged += new System.EventHandler(this.txtNum_TextChanged);
            // 
            // txtMatriz
            // 
            this.txtMatriz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMatriz.Location = new System.Drawing.Point(393, 44);
            this.txtMatriz.Name = "txtMatriz";
            this.txtMatriz.Size = new System.Drawing.Size(100, 26);
            this.txtMatriz.TabIndex = 1;
            this.txtMatriz.TextChanged += new System.EventHandler(this.txtMatriz_TextChanged);
            // 
            // lblDprincipal
            // 
            this.lblDprincipal.AutoSize = true;
            this.lblDprincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDprincipal.Location = new System.Drawing.Point(77, 18);
            this.lblDprincipal.Name = "lblDprincipal";
            this.lblDprincipal.Size = new System.Drawing.Size(0, 20);
            this.lblDprincipal.TabIndex = 2;
            this.lblDprincipal.Click += new System.EventHandler(this.lblDprincipal_Click);
            // 
            // lblDopuesta
            // 
            this.lblDopuesta.AutoSize = true;
            this.lblDopuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDopuesta.Location = new System.Drawing.Point(537, 18);
            this.lblDopuesta.Name = "lblDopuesta";
            this.lblDopuesta.Size = new System.Drawing.Size(0, 20);
            this.lblDopuesta.TabIndex = 3;
            this.lblDopuesta.Click += new System.EventHandler(this.lblDopuesta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.lblDopuesta);
            this.Controls.Add(this.lblDprincipal);
            this.Controls.Add(this.txtMatriz);
            this.Controls.Add(this.txtNum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtMatriz;
        private System.Windows.Forms.Label lblDprincipal;
        private System.Windows.Forms.Label lblDopuesta;
    }
}

