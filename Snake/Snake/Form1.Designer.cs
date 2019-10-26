namespace Snake
{
    partial class form1
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
            this.components = new System.ComponentModel.Container();
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            this.lblPuntuacio = new System.Windows.Forms.Label();
            this.lblPunts = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lbl_final = new System.Windows.Forms.Label();
            this.txt_reiniciar = new System.Windows.Forms.Label();
            this.lbl_velocitat = new System.Windows.Forms.Label();
            this.txt_velocitat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCanvas
            // 
            this.pbCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCanvas.Location = new System.Drawing.Point(20, 43);
            this.pbCanvas.Margin = new System.Windows.Forms.Padding(4);
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.Size = new System.Drawing.Size(1018, 475);
            this.pbCanvas.TabIndex = 0;
            this.pbCanvas.TabStop = false;
            this.pbCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pbCanvas_Paint);
            // 
            // lblPuntuacio
            // 
            this.lblPuntuacio.AutoSize = true;
            this.lblPuntuacio.Location = new System.Drawing.Point(68, 11);
            this.lblPuntuacio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPuntuacio.Name = "lblPuntuacio";
            this.lblPuntuacio.Size = new System.Drawing.Size(71, 17);
            this.lblPuntuacio.TabIndex = 1;
            this.lblPuntuacio.Text = "Puntuació";
            // 
            // lblPunts
            // 
            this.lblPunts.AutoSize = true;
            this.lblPunts.Location = new System.Drawing.Point(16, 11);
            this.lblPunts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPunts.Name = "lblPunts";
            this.lblPunts.Size = new System.Drawing.Size(44, 17);
            this.lblPunts.TabIndex = 2;
            this.lblPunts.Text = "Punts";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            // 
            // lbl_final
            // 
            this.lbl_final.AutoSize = true;
            this.lbl_final.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_final.Location = new System.Drawing.Point(345, 226);
            this.lbl_final.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_final.Name = "lbl_final";
            this.lbl_final.Size = new System.Drawing.Size(0, 38);
            this.lbl_final.TabIndex = 3;
            // 
            // txt_reiniciar
            // 
            this.txt_reiniciar.AutoSize = true;
            this.txt_reiniciar.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_reiniciar.Location = new System.Drawing.Point(375, 350);
            this.txt_reiniciar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_reiniciar.Name = "txt_reiniciar";
            this.txt_reiniciar.Size = new System.Drawing.Size(0, 27);
            this.txt_reiniciar.TabIndex = 4;
            // 
            // lbl_velocitat
            // 
            this.lbl_velocitat.AutoSize = true;
            this.lbl_velocitat.Location = new System.Drawing.Point(305, 11);
            this.lbl_velocitat.Name = "lbl_velocitat";
            this.lbl_velocitat.Size = new System.Drawing.Size(0, 17);
            this.lbl_velocitat.TabIndex = 5;
            // 
            // txt_velocitat
            // 
            this.txt_velocitat.AutoSize = true;
            this.txt_velocitat.Location = new System.Drawing.Point(237, 11);
            this.txt_velocitat.Name = "txt_velocitat";
            this.txt_velocitat.Size = new System.Drawing.Size(62, 17);
            this.txt_velocitat.TabIndex = 6;
            this.txt_velocitat.Text = "Velocitat";
            // 
            // form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txt_velocitat);
            this.Controls.Add(this.lbl_velocitat);
            this.Controls.Add(this.txt_reiniciar);
            this.Controls.Add(this.lbl_final);
            this.Controls.Add(this.lblPunts);
            this.Controls.Add(this.lblPuntuacio);
            this.Controls.Add(this.pbCanvas);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form1";
            this.Text = "Snake Albert Juan";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCanvas;
        private System.Windows.Forms.Label lblPuntuacio;
        private System.Windows.Forms.Label lblPunts;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label lbl_final;
        private System.Windows.Forms.Label txt_reiniciar;
        private System.Windows.Forms.Label lbl_velocitat;
        private System.Windows.Forms.Label txt_velocitat;
    }
}

