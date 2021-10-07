
namespace Fase1DiegoVasquez
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
            this.components = new System.ComponentModel.Container();
            this.txtAutor = new System.Windows.Forms.Label();
            this.txtTW = new System.Windows.Forms.Label();
            this.txtRegiterAndControl = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.btEntry = new System.Windows.Forms.Button();
            this.btOut = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAutor
            // 
            this.txtAutor.AutoSize = true;
            this.txtAutor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtAutor.Location = new System.Drawing.Point(84, 344);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(373, 21);
            this.txtAutor.TabIndex = 0;
            this.txtAutor.Text = "Autor: Diego Fernando Vasquez Plaza - UNAD_2021";
            // 
            // txtTW
            // 
            this.txtTW.AutoSize = true;
            this.txtTW.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTW.Location = new System.Drawing.Point(175, 41);
            this.txtTW.Name = "txtTW";
            this.txtTW.Size = new System.Drawing.Size(189, 32);
            this.txtTW.TabIndex = 1;
            this.txtTW.Text = "Temporal Work";
            this.txtTW.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtRegiterAndControl
            // 
            this.txtRegiterAndControl.AutoSize = true;
            this.txtRegiterAndControl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRegiterAndControl.Location = new System.Drawing.Point(146, 144);
            this.txtRegiterAndControl.Name = "txtRegiterAndControl";
            this.txtRegiterAndControl.Size = new System.Drawing.Size(242, 21);
            this.txtRegiterAndControl.TabIndex = 2;
            this.txtRegiterAndControl.Text = "Registro y Control Colaboradores";
            // 
            // txtPass
            // 
            this.txtPass.AutoSize = true;
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPass.Location = new System.Drawing.Point(188, 215);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(140, 21);
            this.txtPass.TabIndex = 3;
            this.txtPass.Text = "Digitar Contraseña";
            // 
            // txtLogin
            // 
            this.txtLogin.ForeColor = System.Drawing.Color.Red;
            this.txtLogin.Location = new System.Drawing.Point(212, 239);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.PasswordChar = '*';
            this.txtLogin.Size = new System.Drawing.Size(100, 23);
            this.txtLogin.TabIndex = 4;
            // 
            // btEntry
            // 
            this.btEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btEntry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEntry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btEntry.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btEntry.Location = new System.Drawing.Point(221, 290);
            this.btEntry.Name = "btEntry";
            this.btEntry.Size = new System.Drawing.Size(81, 31);
            this.btEntry.TabIndex = 15;
            this.btEntry.Text = "Ingresar";
            this.btEntry.UseVisualStyleBackColor = false;
            this.btEntry.TextChanged += new System.EventHandler(this.btEntry_TextChanged);
            this.btEntry.Click += new System.EventHandler(this.btEntry_Click);
            // 
            // btOut
            // 
            this.btOut.BackColor = System.Drawing.Color.Red;
            this.btOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btOut.Location = new System.Drawing.Point(463, 401);
            this.btOut.Name = "btOut";
            this.btOut.Size = new System.Drawing.Size(75, 23);
            this.btOut.TabIndex = 18;
            this.btOut.Text = "Salir";
            this.btOut.UseVisualStyleBackColor = false;
            this.btOut.Click += new System.EventHandler(this.btOut_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.btOut);
            this.Controls.Add(this.btEntry);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtRegiterAndControl);
            this.Controls.Add(this.txtTW);
            this.Controls.Add(this.txtAutor);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Form1";
            this.Text = "Bienvenido";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtAutor;
        private System.Windows.Forms.Label txtTW;
        private System.Windows.Forms.Label txtRegiterAndControl;
        private System.Windows.Forms.Label txtPass;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Button btEntry;
        private System.Windows.Forms.Button btOut;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

