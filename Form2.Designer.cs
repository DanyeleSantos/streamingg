
namespace Aula05Streaming
{
    partial class Form2
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
            this.imgfundo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAssistit = new System.Windows.Forms.Button();
            this.llblDescrição = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.imgfundo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // imgfundo
            // 
            this.imgfundo.Location = new System.Drawing.Point(46, 41);
            this.imgfundo.Name = "imgfundo";
            this.imgfundo.Size = new System.Drawing.Size(702, 397);
            this.imgfundo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgfundo.TabIndex = 0;
            this.imgfundo.TabStop = false;
            this.imgfundo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // btnAssistit
            // 
            this.btnAssistit.Location = new System.Drawing.Point(146, 205);
            this.btnAssistit.Name = "btnAssistit";
            this.btnAssistit.Size = new System.Drawing.Size(75, 23);
            this.btnAssistit.TabIndex = 2;
            this.btnAssistit.Text = "Assistir";
            this.btnAssistit.UseVisualStyleBackColor = true;
            this.btnAssistit.Click += new System.EventHandler(this.btnAssistit_Click);
            // 
            // llblDescrição
            // 
            this.llblDescrição.AutoSize = true;
            this.llblDescrição.Location = new System.Drawing.Point(143, 259);
            this.llblDescrição.MaximumSize = new System.Drawing.Size(350, 0);
            this.llblDescrição.Name = "llblDescrição";
            this.llblDescrição.Size = new System.Drawing.Size(55, 13);
            this.llblDescrição.TabIndex = 3;
            this.llblDescrição.Text = "Descrição";
            this.llblDescrição.Click += new System.EventHandler(this.llblDescrição_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(143, 164);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(46, 13);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "TITÚLO";
            this.lblTitulo.Click += new System.EventHandler(this.label3_Click);
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(-7, -6);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(805, 466);
            this.webView21.TabIndex = 5;
            this.webView21.ZoomFactor = 1D;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.llblDescrição);
            this.Controls.Add(this.btnAssistit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgfundo);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgfundo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgfundo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAssistit;
        private System.Windows.Forms.Label llblDescrição;
        private System.Windows.Forms.Label lblTitulo;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
    }
}