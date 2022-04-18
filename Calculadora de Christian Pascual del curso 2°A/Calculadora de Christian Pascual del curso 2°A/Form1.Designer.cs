
namespace Calculadora_de_Christian_Pascual_del_curso_2_A
{
    partial class FormCalculadora
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
            this.BtnOperar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnConvertirABinario = new System.Windows.Forms.Button();
            this.BtnConvertirADecimal = new System.Windows.Forms.Button();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.lstOperaciones = new System.Windows.Forms.ListBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnOperar
            // 
            this.BtnOperar.Location = new System.Drawing.Point(28, 132);
            this.BtnOperar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnOperar.Name = "BtnOperar";
            this.BtnOperar.Size = new System.Drawing.Size(121, 46);
            this.BtnOperar.TabIndex = 0;
            this.BtnOperar.Text = "Operar";
            this.BtnOperar.UseVisualStyleBackColor = true;
            this.BtnOperar.Click += new System.EventHandler(this.BtnOperar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(175, 132);
            this.BtnLimpiar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(120, 46);
            this.BtnLimpiar.TabIndex = 1;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCerrar.Location = new System.Drawing.Point(319, 132);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(121, 46);
            this.BtnCerrar.TabIndex = 2;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnConvertirABinario
            // 
            this.BtnConvertirABinario.Location = new System.Drawing.Point(28, 184);
            this.BtnConvertirABinario.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnConvertirABinario.Name = "BtnConvertirABinario";
            this.BtnConvertirABinario.Size = new System.Drawing.Size(204, 46);
            this.BtnConvertirABinario.TabIndex = 3;
            this.BtnConvertirABinario.Text = "Convertir a Binario";
            this.BtnConvertirABinario.UseVisualStyleBackColor = true;
            this.BtnConvertirABinario.Click += new System.EventHandler(this.BtnConvertirABinario_Click);
            // 
            // BtnConvertirADecimal
            // 
            this.BtnConvertirADecimal.Location = new System.Drawing.Point(236, 184);
            this.BtnConvertirADecimal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnConvertirADecimal.Name = "BtnConvertirADecimal";
            this.BtnConvertirADecimal.Size = new System.Drawing.Size(204, 46);
            this.BtnConvertirADecimal.TabIndex = 4;
            this.BtnConvertirADecimal.Text = "Convertir a Decimal";
            this.BtnConvertirADecimal.UseVisualStyleBackColor = true;
            this.BtnConvertirADecimal.Click += new System.EventHandler(this.BtnConvertirADecimal_Click);
            // 
            // txtNumero1
            // 
            this.txtNumero1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumero1.Location = new System.Drawing.Point(28, 55);
            this.txtNumero1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(117, 43);
            this.txtNumero1.TabIndex = 6;
            // 
            // txtNumero2
            // 
            this.txtNumero2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumero2.Location = new System.Drawing.Point(323, 57);
            this.txtNumero2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(117, 43);
            this.txtNumero2.TabIndex = 7;
            // 
            // comboBox
            // 
            this.comboBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "+",
            "-",
            "/",
            "*"});
            this.comboBox.Location = new System.Drawing.Point(173, 55);
            this.comboBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(122, 45);
            this.comboBox.TabIndex = 8;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lstOperaciones
            // 
            this.lstOperaciones.FormattingEnabled = true;
            this.lstOperaciones.ItemHeight = 15;
            this.lstOperaciones.Location = new System.Drawing.Point(456, 1);
            this.lstOperaciones.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lstOperaciones.Name = "lstOperaciones";
            this.lstOperaciones.Size = new System.Drawing.Size(181, 304);
            this.lstOperaciones.TabIndex = 9;
           // this.lstOperaciones.SelectedIndexChanged += new System.EventHandler(this.lstOperaciones_SelectedIndexChanged);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.Location = new System.Drawing.Point(393, 9);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(32, 37);
            this.lblResultado.TabIndex = 10;
            this.lblResultado.Text = "0";
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 304);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lstOperaciones);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.BtnConvertirADecimal);
            this.Controls.Add(this.BtnConvertirABinario);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnOperar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Christian Pascual del curso 2°A";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOperar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnConvertirABinario;
        private System.Windows.Forms.Button BtnConvertirADecimal;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.ListBox lstOperaciones;
        private System.Windows.Forms.Label lblResultado;
    }
}

