namespace MiCalculadora
{
    partial class FormCalculadora
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
            this.cb_Operador = new System.Windows.Forms.ComboBox();
            this.btn_Operar = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Decimal = new System.Windows.Forms.Button();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.btn_Binario = new System.Windows.Forms.Button();
            this.tb_Numero2 = new System.Windows.Forms.TextBox();
            this.tb_Numero1 = new System.Windows.Forms.TextBox();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_Operador
            // 
            this.cb_Operador.FormattingEnabled = true;
            this.cb_Operador.Items.AddRange(new object[] {
            "+",
            "-",
            "/",
            "*"});
            this.cb_Operador.Location = new System.Drawing.Point(185, 79);
            this.cb_Operador.Name = "cb_Operador";
            this.cb_Operador.Size = new System.Drawing.Size(157, 21);
            this.cb_Operador.TabIndex = 2;
            // 
            // btn_Operar
            // 
            this.btn_Operar.Location = new System.Drawing.Point(12, 194);
            this.btn_Operar.Name = "btn_Operar";
            this.btn_Operar.Size = new System.Drawing.Size(157, 49);
            this.btn_Operar.TabIndex = 4;
            this.btn_Operar.Text = "Operar";
            this.btn_Operar.UseVisualStyleBackColor = true;
            this.btn_Operar.Click += new System.EventHandler(this.btn_Operar_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(185, 194);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(157, 49);
            this.btn_Limpiar.TabIndex = 5;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_Decimal
            // 
            this.btn_Decimal.Location = new System.Drawing.Point(265, 273);
            this.btn_Decimal.Name = "btn_Decimal";
            this.btn_Decimal.Size = new System.Drawing.Size(249, 49);
            this.btn_Decimal.TabIndex = 8;
            this.btn_Decimal.Text = "Convertir a Decimal";
            this.btn_Decimal.UseVisualStyleBackColor = true;
            this.btn_Decimal.Click += new System.EventHandler(this.btn_Decimal_Click);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Location = new System.Drawing.Point(357, 194);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(157, 49);
            this.btn_Cerrar.TabIndex = 6;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // btn_Binario
            // 
            this.btn_Binario.Location = new System.Drawing.Point(12, 273);
            this.btn_Binario.Name = "btn_Binario";
            this.btn_Binario.Size = new System.Drawing.Size(249, 49);
            this.btn_Binario.TabIndex = 7;
            this.btn_Binario.Text = "Convertir a Binario";
            this.btn_Binario.UseVisualStyleBackColor = true;
            this.btn_Binario.Click += new System.EventHandler(this.btn_Binario_Click);
            // 
            // tb_Numero2
            // 
            this.tb_Numero2.Location = new System.Drawing.Point(357, 79);
            this.tb_Numero2.Name = "tb_Numero2";
            this.tb_Numero2.Size = new System.Drawing.Size(157, 20);
            this.tb_Numero2.TabIndex = 3;
            // 
            // tb_Numero1
            // 
            this.tb_Numero1.Location = new System.Drawing.Point(12, 79);
            this.tb_Numero1.Name = "tb_Numero1";
            this.tb_Numero1.Size = new System.Drawing.Size(157, 20);
            this.tb_Numero1.TabIndex = 1;
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.AutoSize = true;
            this.lbl_Resultado.Location = new System.Drawing.Point(424, 19);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(61, 13);
            this.lbl_Resultado.TabIndex = 0;
            this.lbl_Resultado.Text = "Resultado: ";
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 375);
            this.Controls.Add(this.lbl_Resultado);
            this.Controls.Add(this.tb_Numero1);
            this.Controls.Add(this.tb_Numero2);
            this.Controls.Add(this.btn_Binario);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.btn_Decimal);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btn_Operar);
            this.Controls.Add(this.cb_Operador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Agustin Fernandez 2D";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Operador;
        private System.Windows.Forms.Button btn_Operar;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_Decimal;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Button btn_Binario;
        private System.Windows.Forms.TextBox tb_Numero2;
        private System.Windows.Forms.TextBox tb_Numero1;
        private System.Windows.Forms.Label lbl_Resultado;
    }
}

