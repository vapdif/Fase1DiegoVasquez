
namespace Fase1DiegoVasquez
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.rbtGenderF = new System.Windows.Forms.RadioButton();
            this.rbtGenderM = new System.Windows.Forms.RadioButton();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.btCalcularSalary = new System.Windows.Forms.Button();
            this.btNew = new System.Windows.Forms.Button();
            this.btOut = new System.Windows.Forms.Button();
            this.txtTW = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(57, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(19, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Completo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(107, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cargo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(74, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Salario Día";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(526, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Género";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(470, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Dias Laborados";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(242, 45);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(154, 23);
            this.txtID.TabIndex = 7;
            this.txtID.Validated += new System.EventHandler(this.txtID_Validated);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(242, 103);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(154, 23);
            this.txtName.TabIndex = 8;
            // 
            // cmbPosition
            // 
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Items.AddRange(new object[] {
            "Servicios Generales",
            "Administrativo",
            "Electricista",
            "Mecánico",
            "Soldador"});
            this.cmbPosition.Location = new System.Drawing.Point(242, 166);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(154, 23);
            this.cmbPosition.TabIndex = 9;
            this.cmbPosition.SelectedIndexChanged += new System.EventHandler(this.cmbPosition_SelectedIndexChanged);
            // 
            // txtSalary
            // 
            this.txtSalary.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtSalary.Location = new System.Drawing.Point(242, 233);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.ReadOnly = true;
            this.txtSalary.Size = new System.Drawing.Size(154, 23);
            this.txtSalary.TabIndex = 10;
            // 
            // rbtGenderF
            // 
            this.rbtGenderF.AutoSize = true;
            this.rbtGenderF.Location = new System.Drawing.Point(611, 30);
            this.rbtGenderF.Name = "rbtGenderF";
            this.rbtGenderF.Size = new System.Drawing.Size(78, 19);
            this.rbtGenderF.TabIndex = 11;
            this.rbtGenderF.TabStop = true;
            this.rbtGenderF.Text = "Femenino";
            this.rbtGenderF.UseVisualStyleBackColor = true;
            // 
            // rbtGenderM
            // 
            this.rbtGenderM.AutoSize = true;
            this.rbtGenderM.Location = new System.Drawing.Point(611, 70);
            this.rbtGenderM.Name = "rbtGenderM";
            this.rbtGenderM.Size = new System.Drawing.Size(80, 19);
            this.rbtGenderM.TabIndex = 12;
            this.rbtGenderM.TabStop = true;
            this.rbtGenderM.Text = "Masculino";
            this.rbtGenderM.UseVisualStyleBackColor = true;
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(611, 233);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(100, 23);
            this.txtDays.TabIndex = 13;
            this.txtDays.Validated += new System.EventHandler(this.txtDays_Validated);
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btSave.Location = new System.Drawing.Point(167, 346);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(81, 31);
            this.btSave.TabIndex = 14;
            this.btSave.Text = "Guardar";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btCalcularSalary
            // 
            this.btCalcularSalary.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btCalcularSalary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCalcularSalary.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCalcularSalary.Location = new System.Drawing.Point(286, 346);
            this.btCalcularSalary.Name = "btCalcularSalary";
            this.btCalcularSalary.Size = new System.Drawing.Size(110, 31);
            this.btCalcularSalary.TabIndex = 15;
            this.btCalcularSalary.Text = "Calcular Nomina";
            this.btCalcularSalary.UseVisualStyleBackColor = false;
            this.btCalcularSalary.Click += new System.EventHandler(this.btCalcularSalary_Click);
            // 
            // btNew
            // 
            this.btNew.BackColor = System.Drawing.SystemColors.Highlight;
            this.btNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btNew.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btNew.Location = new System.Drawing.Point(430, 346);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(146, 31);
            this.btNew.TabIndex = 16;
            this.btNew.Text = "Nuevo y/o Borrar";
            this.btNew.UseVisualStyleBackColor = false;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // btOut
            // 
            this.btOut.BackColor = System.Drawing.Color.Red;
            this.btOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btOut.Location = new System.Drawing.Point(702, 354);
            this.btOut.Name = "btOut";
            this.btOut.Size = new System.Drawing.Size(75, 23);
            this.btOut.TabIndex = 17;
            this.btOut.Text = "Salir";
            this.btOut.UseVisualStyleBackColor = false;
            this.btOut.Click += new System.EventHandler(this.btOut_Click);
            // 
            // txtTW
            // 
            this.txtTW.AutoSize = true;
            this.txtTW.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTW.Location = new System.Drawing.Point(19, 9);
            this.txtTW.Name = "txtTW";
            this.txtTW.Size = new System.Drawing.Size(189, 32);
            this.txtTW.TabIndex = 18;
            this.txtTW.Text = "Temporal Work";
            this.txtTW.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 387);
            this.Controls.Add(this.txtTW);
            this.Controls.Add(this.btOut);
            this.Controls.Add(this.btNew);
            this.Controls.Add(this.btCalcularSalary);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.rbtGenderM);
            this.Controls.Add(this.rbtGenderF);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.cmbPosition);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Registro de datos Colaborador";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btCalcularSalary;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.Button btOut;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.ComboBox cmbPosition;
        public System.Windows.Forms.TextBox txtSalary;
        public System.Windows.Forms.RadioButton rbtGenderF;
        public System.Windows.Forms.RadioButton rbtGenderM;
        public System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.Label txtTW;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}