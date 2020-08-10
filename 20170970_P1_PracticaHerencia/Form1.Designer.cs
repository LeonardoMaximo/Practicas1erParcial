namespace PracticaHerencia
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
            this.rbPB = new System.Windows.Forms.RadioButton();
            this.rbPP = new System.Windows.Forms.RadioButton();
            this.lblNE = new System.Windows.Forms.Label();
            this.lblBE = new System.Windows.Forms.Label();
            this.lblPE = new System.Windows.Forms.Label();
            this.lblRE = new System.Windows.Forms.Label();
            this.lblresultado = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNE = new System.Windows.Forms.MaskedTextBox();
            this.txtBE = new System.Windows.Forms.MaskedTextBox();
            this.txtPE = new System.Windows.Forms.MaskedTextBox();
            this.txtRE = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // rbPB
            // 
            this.rbPB.AutoSize = true;
            this.rbPB.Location = new System.Drawing.Point(141, 87);
            this.rbPB.Name = "rbPB";
            this.rbPB.Size = new System.Drawing.Size(99, 17);
            this.rbPB.TabIndex = 0;
            this.rbPB.TabStop = true;
            this.rbPB.Text = "Paquete basico";
            this.rbPB.UseVisualStyleBackColor = true;
            this.rbPB.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            this.rbPB.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // rbPP
            // 
            this.rbPP.AutoSize = true;
            this.rbPP.Location = new System.Drawing.Point(246, 87);
            this.rbPP.Name = "rbPP";
            this.rbPP.Size = new System.Drawing.Size(88, 17);
            this.rbPP.TabIndex = 1;
            this.rbPP.TabStop = true;
            this.rbPP.Text = "Paquete Plus";
            this.rbPP.UseVisualStyleBackColor = true;
            this.rbPP.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // lblNE
            // 
            this.lblNE.AutoSize = true;
            this.lblNE.Location = new System.Drawing.Point(63, 161);
            this.lblNE.Name = "lblNE";
            this.lblNE.Size = new System.Drawing.Size(67, 13);
            this.lblNE.TabIndex = 5;
            this.lblNE.Text = "N° de Niños:";
            // 
            // lblBE
            // 
            this.lblBE.AutoSize = true;
            this.lblBE.Location = new System.Drawing.Point(55, 216);
            this.lblBE.Name = "lblBE";
            this.lblBE.Size = new System.Drawing.Size(75, 13);
            this.lblBE.TabIndex = 6;
            this.lblBE.Text = "Botargas extra";
            // 
            // lblPE
            // 
            this.lblPE.AutoSize = true;
            this.lblPE.Location = new System.Drawing.Point(57, 270);
            this.lblPE.Name = "lblPE";
            this.lblPE.Size = new System.Drawing.Size(73, 13);
            this.lblPE.TabIndex = 7;
            this.lblPE.Text = "Payasos extra";
            // 
            // lblRE
            // 
            this.lblRE.AutoSize = true;
            this.lblRE.Location = new System.Drawing.Point(58, 321);
            this.lblRE.Name = "lblRE";
            this.lblRE.Size = new System.Drawing.Size(72, 13);
            this.lblRE.TabIndex = 9;
            this.lblRE.Text = "Regalos extra";
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(270, 198);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(55, 13);
            this.lblresultado.TabIndex = 11;
            this.lblresultado.Text = "Resultado";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(331, 195);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 10;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(315, 151);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 12;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Animación de Fiestas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Seleccione el tipo de servicio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Elementos de la fiesta";
            // 
            // txtNE
            // 
            this.txtNE.Location = new System.Drawing.Point(134, 161);
            this.txtNE.Mask = "99999";
            this.txtNE.Name = "txtNE";
            this.txtNE.PromptChar = ' ';
            this.txtNE.Size = new System.Drawing.Size(100, 20);
            this.txtNE.TabIndex = 16;
            this.txtNE.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtBE
            // 
            this.txtBE.Location = new System.Drawing.Point(134, 213);
            this.txtBE.Mask = "99999";
            this.txtBE.Name = "txtBE";
            this.txtBE.PromptChar = ' ';
            this.txtBE.Size = new System.Drawing.Size(100, 20);
            this.txtBE.TabIndex = 17;
            this.txtBE.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtPE
            // 
            this.txtPE.Location = new System.Drawing.Point(134, 267);
            this.txtPE.Mask = "99999";
            this.txtPE.Name = "txtPE";
            this.txtPE.PromptChar = ' ';
            this.txtPE.Size = new System.Drawing.Size(100, 20);
            this.txtPE.TabIndex = 18;
            this.txtPE.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtRE
            // 
            this.txtRE.Location = new System.Drawing.Point(134, 318);
            this.txtRE.Mask = "99999";
            this.txtRE.Name = "txtRE";
            this.txtRE.PromptChar = ' ';
            this.txtRE.Size = new System.Drawing.Size(100, 20);
            this.txtRE.TabIndex = 19;
            this.txtRE.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 381);
            this.Controls.Add(this.txtRE);
            this.Controls.Add(this.txtPE);
            this.Controls.Add(this.txtBE);
            this.Controls.Add(this.txtNE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblRE);
            this.Controls.Add(this.lblPE);
            this.Controls.Add(this.lblBE);
            this.Controls.Add(this.lblNE);
            this.Controls.Add(this.rbPP);
            this.Controls.Add(this.rbPB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbPB;
        private System.Windows.Forms.RadioButton rbPP;
        private System.Windows.Forms.Label lblNE;
        private System.Windows.Forms.Label lblBE;
        private System.Windows.Forms.Label lblPE;
        private System.Windows.Forms.Label lblRE;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtNE;
        private System.Windows.Forms.MaskedTextBox txtBE;
        private System.Windows.Forms.MaskedTextBox txtPE;
        private System.Windows.Forms.MaskedTextBox txtRE;
    }
}

