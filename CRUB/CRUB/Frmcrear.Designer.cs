namespace CRUB
{
    partial class frmempleado
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
            this.lblid = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.f = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtpellido = new System.Windows.Forms.TextBox();
            this.txtcedula = new System.Windows.Forms.TextBox();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.txtsexo = new System.Windows.Forms.TextBox();
            this.txtsalario = new System.Windows.Forms.TextBox();
            this.btncrear = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btncerar = new System.Windows.Forms.Button();
            this.btnborar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(12, 9);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(15, 13);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "id";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(3, 37);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(42, 13);
            this.lblnombre.TabIndex = 1;
            this.lblnombre.Text = "nombre";
            // 
            // f
            // 
            this.f.AutoSize = true;
            this.f.Location = new System.Drawing.Point(3, 62);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(43, 13);
            this.f.TabIndex = 2;
            this.f.Text = "apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "cedula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "fecha de nacimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "edad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "sexo ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "salario";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(43, 6);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 8;
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(51, 34);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 9;
            // 
            // txtpellido
            // 
            this.txtpellido.Location = new System.Drawing.Point(52, 62);
            this.txtpellido.Name = "txtpellido";
            this.txtpellido.Size = new System.Drawing.Size(100, 20);
            this.txtpellido.TabIndex = 10;
            // 
            // txtcedula
            // 
            this.txtcedula.Location = new System.Drawing.Point(43, 91);
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(100, 20);
            this.txtcedula.TabIndex = 11;
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(112, 138);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(100, 20);
            this.txtfecha.TabIndex = 12;
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(80, 171);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(100, 20);
            this.txtedad.TabIndex = 13;
            // 
            // txtsexo
            // 
            this.txtsexo.Location = new System.Drawing.Point(80, 204);
            this.txtsexo.Name = "txtsexo";
            this.txtsexo.Size = new System.Drawing.Size(100, 20);
            this.txtsexo.TabIndex = 14;
            // 
            // txtsalario
            // 
            this.txtsalario.Location = new System.Drawing.Point(80, 236);
            this.txtsalario.Name = "txtsalario";
            this.txtsalario.Size = new System.Drawing.Size(100, 20);
            this.txtsalario.TabIndex = 15;
            // 
            // btncrear
            // 
            this.btncrear.Location = new System.Drawing.Point(6, 274);
            this.btncrear.Name = "btncrear";
            this.btncrear.Size = new System.Drawing.Size(75, 23);
            this.btncrear.TabIndex = 16;
            this.btncrear.Text = "crear";
            this.btncrear.UseVisualStyleBackColor = true;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(87, 274);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 17;
            this.btnguardar.Text = "guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btncerar
            // 
            this.btncerar.Location = new System.Drawing.Point(168, 274);
            this.btncerar.Name = "btncerar";
            this.btncerar.Size = new System.Drawing.Size(75, 23);
            this.btncerar.TabIndex = 18;
            this.btncerar.Text = "cerar";
            this.btncerar.UseVisualStyleBackColor = true;
            // 
            // btnborar
            // 
            this.btnborar.Location = new System.Drawing.Point(259, 274);
            this.btnborar.Name = "btnborar";
            this.btnborar.Size = new System.Drawing.Size(75, 23);
            this.btnborar.TabIndex = 19;
            this.btnborar.Text = "borar";
            this.btnborar.UseVisualStyleBackColor = true;
            // 
            // frmempleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 300);
            this.Controls.Add(this.btnborar);
            this.Controls.Add(this.btncerar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btncrear);
            this.Controls.Add(this.txtsalario);
            this.Controls.Add(this.txtsexo);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.txtcedula);
            this.Controls.Add(this.txtpellido);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.f);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lblid);
            this.Name = "frmempleado";
            this.Text = "empelado";
            this.Load += new System.EventHandler(this.Frmcrear_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label f;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtpellido;
        private System.Windows.Forms.TextBox txtcedula;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.TextBox txtsexo;
        private System.Windows.Forms.TextBox txtsalario;
        private System.Windows.Forms.Button btncrear;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btncerar;
        private System.Windows.Forms.Button btnborar;
    }
}