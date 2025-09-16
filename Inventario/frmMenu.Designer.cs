namespace Inventario
{
    partial class frmMenu
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
            this.btnfechar = new System.Windows.Forms.Button();
            this.btnMobiliza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnfechar
            // 
            this.btnfechar.BackColor = System.Drawing.Color.IndianRed;
            this.btnfechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfechar.ForeColor = System.Drawing.Color.White;
            this.btnfechar.Location = new System.Drawing.Point(653, 396);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(118, 42);
            this.btnfechar.TabIndex = 0;
            this.btnfechar.Text = "Fechar";
            this.btnfechar.UseVisualStyleBackColor = false;
            this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // btnMobiliza
            // 
            this.btnMobiliza.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMobiliza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMobiliza.ForeColor = System.Drawing.Color.Black;
            this.btnMobiliza.Location = new System.Drawing.Point(12, 12);
            this.btnMobiliza.Name = "btnMobiliza";
            this.btnMobiliza.Size = new System.Drawing.Size(165, 205);
            this.btnMobiliza.TabIndex = 1;
            this.btnMobiliza.Text = "Cadastrar um Mobilizado";
            this.btnMobiliza.UseVisualStyleBackColor = false;
            this.btnMobiliza.Click += new System.EventHandler(this.btnMobiliza_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 450);
            this.Controls.Add(this.btnMobiliza);
            this.Controls.Add(this.btnfechar);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnfechar;
        private System.Windows.Forms.Button btnMobiliza;
    }
}