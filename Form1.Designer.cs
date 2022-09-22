namespace Registro_de_estudiantes
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDUI = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtAFP = new System.Windows.Forms.TextBox();
            this.btnAFP = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lbMostrar = new System.Windows.Forms.Label();
            this.btnISSS = new System.Windows.Forms.Button();
            this.txtISSS = new System.Windows.Forms.TextBox();
            this.btnSalarioNeto = new System.Windows.Forms.Button();
            this.txtSalarioNeto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "DUI\r\n\r\n";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(159, 35);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(159, 76);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtDUI
            // 
            this.txtDUI.Location = new System.Drawing.Point(159, 106);
            this.txtDUI.Name = "txtDUI";
            this.txtDUI.Size = new System.Drawing.Size(100, 20);
            this.txtDUI.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Guardar\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtAFP
            // 
            this.txtAFP.Location = new System.Drawing.Point(396, 32);
            this.txtAFP.Name = "txtAFP";
            this.txtAFP.Size = new System.Drawing.Size(100, 20);
            this.txtAFP.TabIndex = 9;
            // 
            // btnAFP
            // 
            this.btnAFP.Location = new System.Drawing.Point(315, 30);
            this.btnAFP.Name = "btnAFP";
            this.btnAFP.Size = new System.Drawing.Size(75, 23);
            this.btnAFP.TabIndex = 10;
            this.btnAFP.Text = "AFP\r\n";
            this.btnAFP.UseVisualStyleBackColor = true;
            this.btnAFP.Click += new System.EventHandler(this.btnAFP_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Salario";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(159, 139);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 12;
            // 
            // lbMostrar
            // 
            this.lbMostrar.AutoSize = true;
            this.lbMostrar.Location = new System.Drawing.Point(325, 142);
            this.lbMostrar.Name = "lbMostrar";
            this.lbMostrar.Size = new System.Drawing.Size(0, 13);
            this.lbMostrar.TabIndex = 13;
            // 
            // btnISSS
            // 
            this.btnISSS.Location = new System.Drawing.Point(315, 74);
            this.btnISSS.Name = "btnISSS";
            this.btnISSS.Size = new System.Drawing.Size(75, 23);
            this.btnISSS.TabIndex = 14;
            this.btnISSS.Text = "ISSS";
            this.btnISSS.UseVisualStyleBackColor = true;
            this.btnISSS.Click += new System.EventHandler(this.btnISSS_Click);
            // 
            // txtISSS
            // 
            this.txtISSS.Location = new System.Drawing.Point(396, 76);
            this.txtISSS.Name = "txtISSS";
            this.txtISSS.Size = new System.Drawing.Size(100, 20);
            this.txtISSS.TabIndex = 15;
            // 
            // btnSalarioNeto
            // 
            this.btnSalarioNeto.Location = new System.Drawing.Point(315, 113);
            this.btnSalarioNeto.Name = "btnSalarioNeto";
            this.btnSalarioNeto.Size = new System.Drawing.Size(75, 23);
            this.btnSalarioNeto.TabIndex = 16;
            this.btnSalarioNeto.Text = "Salario neto";
            this.btnSalarioNeto.UseVisualStyleBackColor = true;
            this.btnSalarioNeto.Click += new System.EventHandler(this.btnSalarioNeto_Click);
            // 
            // txtSalarioNeto
            // 
            this.txtSalarioNeto.Location = new System.Drawing.Point(396, 115);
            this.txtSalarioNeto.Name = "txtSalarioNeto";
            this.txtSalarioNeto.Size = new System.Drawing.Size(100, 20);
            this.txtSalarioNeto.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 342);
            this.Controls.Add(this.txtSalarioNeto);
            this.Controls.Add(this.btnSalarioNeto);
            this.Controls.Add(this.txtISSS);
            this.Controls.Add(this.btnISSS);
            this.Controls.Add(this.lbMostrar);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAFP);
            this.Controls.Add(this.txtAFP);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDUI);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Registro de empleados";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDUI;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAFP;
        private System.Windows.Forms.TextBox txtAFP;
        private System.Windows.Forms.Label lbMostrar;
        private System.Windows.Forms.TextBox txtISSS;
        private System.Windows.Forms.Button btnISSS;
        private System.Windows.Forms.TextBox txtSalarioNeto;
        private System.Windows.Forms.Button btnSalarioNeto;
    }
}

