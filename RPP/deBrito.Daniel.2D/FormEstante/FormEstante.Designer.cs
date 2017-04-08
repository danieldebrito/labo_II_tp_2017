namespace FormEstante
{
    partial class FormEstante
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
            this.btnEjecutar1 = new System.Windows.Forms.Button();
            this.btnOrdenar1 = new System.Windows.Forms.Button();
            this.rtxtSalida = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnEjecutar1
            // 
            this.btnEjecutar1.Location = new System.Drawing.Point(30, 26);
            this.btnEjecutar1.Name = "btnEjecutar1";
            this.btnEjecutar1.Size = new System.Drawing.Size(75, 23);
            this.btnEjecutar1.TabIndex = 0;
            this.btnEjecutar1.Text = "Ejecutar";
            this.btnEjecutar1.UseVisualStyleBackColor = true;
            this.btnEjecutar1.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnOrdenar1
            // 
            this.btnOrdenar1.Location = new System.Drawing.Point(111, 26);
            this.btnOrdenar1.Name = "btnOrdenar1";
            this.btnOrdenar1.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenar1.TabIndex = 1;
            this.btnOrdenar1.Text = "Ordenar";
            this.btnOrdenar1.UseVisualStyleBackColor = true;
            this.btnOrdenar1.Click += new System.EventHandler(this.btnOrdenar1_Click);
            // 
            // rtxtSalida
            // 
            this.rtxtSalida.Location = new System.Drawing.Point(30, 55);
            this.rtxtSalida.Name = "rtxtSalida";
            this.rtxtSalida.Size = new System.Drawing.Size(504, 290);
            this.rtxtSalida.TabIndex = 2;
            this.rtxtSalida.Text = "";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(602, 421);
            this.Controls.Add(this.rtxtSalida);
            this.Controls.Add(this.btnOrdenar1);
            this.Controls.Add(this.btnEjecutar1);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button btnEjecutar1;
        private System.Windows.Forms.Button btnOrdenar1;
        private System.Windows.Forms.RichTextBox rtxtSalida;
    }
}

