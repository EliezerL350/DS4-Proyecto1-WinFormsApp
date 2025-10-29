using System;

namespace WinFormAppCalculadora
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
            this.btnMostrarCalculos = new System.Windows.Forms.Button();
            this.btnSumar = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.btnPorcentaje = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnRestar = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnModulo = new System.Windows.Forms.Button();
            this.tbxResultados = new System.Windows.Forms.TextBox();
            this.tbxOperacion = new System.Windows.Forms.TextBox();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.btnPotencia = new System.Windows.Forms.Button();
            this.tbxHistorial = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMostrarCalculos
            // 
            this.btnMostrarCalculos.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarCalculos.Location = new System.Drawing.Point(254, 140);
            this.btnMostrarCalculos.Name = "btnMostrarCalculos";
            this.btnMostrarCalculos.Size = new System.Drawing.Size(205, 43);
            this.btnMostrarCalculos.TabIndex = 1;
            this.btnMostrarCalculos.Text = "Mostrar Calculos";
            this.btnMostrarCalculos.UseVisualStyleBackColor = true;
            this.btnMostrarCalculos.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // btnSumar
            // 
            this.btnSumar.Font = new System.Drawing.Font("MV Boli", 25F, System.Drawing.FontStyle.Bold);
            this.btnSumar.Location = new System.Drawing.Point(374, 205);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(85, 76);
            this.btnSumar.TabIndex = 2;
            this.btnSumar.Text = "+";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(283, 205);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(85, 76);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(103, 205);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(85, 76);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(12, 205);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(85, 76);
            this.btnC.TabIndex = 2;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(193, 205);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(85, 76);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(283, 287);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(85, 76);
            this.btn6.TabIndex = 2;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(103, 287);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(85, 76);
            this.btn4.TabIndex = 2;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btnCE
            // 
            this.btnCE.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCE.Location = new System.Drawing.Point(12, 287);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(85, 76);
            this.btnCE.TabIndex = 2;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(193, 287);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(85, 76);
            this.btn5.TabIndex = 2;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(283, 369);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(85, 76);
            this.btn9.TabIndex = 2;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(103, 369);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(85, 76);
            this.btn7.TabIndex = 2;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(12, 369);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(85, 76);
            this.btnBorrar.TabIndex = 2;
            this.btnBorrar.Text = "<x";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.button15_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(193, 369);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(85, 76);
            this.btn8.TabIndex = 2;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btnPunto
            // 
            this.btnPunto.Font = new System.Drawing.Font("MV Boli", 25F, System.Drawing.FontStyle.Bold);
            this.btnPunto.Location = new System.Drawing.Point(283, 451);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(85, 76);
            this.btnPunto.TabIndex = 2;
            this.btnPunto.Text = ".";
            this.btnPunto.UseVisualStyleBackColor = true;
            this.btnPunto.Click += new System.EventHandler(this.btnPunto_Click);
            // 
            // btnPorcentaje
            // 
            this.btnPorcentaje.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPorcentaje.Location = new System.Drawing.Point(103, 534);
            this.btnPorcentaje.Name = "btnPorcentaje";
            this.btnPorcentaje.Size = new System.Drawing.Size(85, 76);
            this.btnPorcentaje.TabIndex = 2;
            this.btnPorcentaje.Text = "%";
            this.btnPorcentaje.UseVisualStyleBackColor = true;
            this.btnPorcentaje.Click += new System.EventHandler(this.btnPorcentaje_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.Font = new System.Drawing.Font("MV Boli", 30F, System.Drawing.FontStyle.Bold);
            this.btnIgual.Location = new System.Drawing.Point(283, 533);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(176, 76);
            this.btnIgual.TabIndex = 2;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(193, 451);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(85, 76);
            this.btn0.TabIndex = 2;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnRestar
            // 
            this.btnRestar.Font = new System.Drawing.Font("MV Boli", 25F, System.Drawing.FontStyle.Bold);
            this.btnRestar.Location = new System.Drawing.Point(374, 287);
            this.btnRestar.Name = "btnRestar";
            this.btnRestar.Size = new System.Drawing.Size(85, 76);
            this.btnRestar.TabIndex = 2;
            this.btnRestar.Text = "-";
            this.btnRestar.UseVisualStyleBackColor = true;
            this.btnRestar.Click += new System.EventHandler(this.btnRestar_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Font = new System.Drawing.Font("MV Boli", 25F, System.Drawing.FontStyle.Bold);
            this.btnMultiplicar.Location = new System.Drawing.Point(374, 369);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(85, 76);
            this.btnMultiplicar.TabIndex = 2;
            this.btnMultiplicar.Text = "*";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.Font = new System.Drawing.Font("MV Boli", 25F, System.Drawing.FontStyle.Bold);
            this.btnDividir.Location = new System.Drawing.Point(374, 451);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(85, 76);
            this.btnDividir.TabIndex = 2;
            this.btnDividir.Text = "/";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // btnModulo
            // 
            this.btnModulo.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold);
            this.btnModulo.Location = new System.Drawing.Point(12, 534);
            this.btnModulo.Name = "btnModulo";
            this.btnModulo.Size = new System.Drawing.Size(85, 76);
            this.btnModulo.TabIndex = 2;
            this.btnModulo.Text = "Modulo";
            this.btnModulo.UseVisualStyleBackColor = true;
            this.btnModulo.Click += new System.EventHandler(this.btn_Click);
            // 
            // tbxResultados
            // 
            this.tbxResultados.Font = new System.Drawing.Font("MV Boli", 25F, System.Drawing.FontStyle.Bold);
            this.tbxResultados.Location = new System.Drawing.Point(193, 12);
            this.tbxResultados.Multiline = true;
            this.tbxResultados.Name = "tbxResultados";
            this.tbxResultados.Size = new System.Drawing.Size(266, 122);
            this.tbxResultados.TabIndex = 3;
            this.tbxResultados.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbxResultados.TextChanged += new System.EventHandler(this.tbxResultados_TextChanged);
            // 
            // tbxOperacion
            // 
            this.tbxOperacion.Font = new System.Drawing.Font("MV Boli", 25F, System.Drawing.FontStyle.Bold);
            this.tbxOperacion.Location = new System.Drawing.Point(12, 12);
            this.tbxOperacion.Multiline = true;
            this.tbxOperacion.Name = "tbxOperacion";
            this.tbxOperacion.Size = new System.Drawing.Size(175, 122);
            this.tbxOperacion.TabIndex = 4;
            this.tbxOperacion.TextChanged += new System.EventHandler(this.tbxOperacion_TextChanged);
            // 
            // btnRaiz
            // 
            this.btnRaiz.Font = new System.Drawing.Font("MV Boli", 25F, System.Drawing.FontStyle.Bold);
            this.btnRaiz.Location = new System.Drawing.Point(12, 451);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(85, 76);
            this.btnRaiz.TabIndex = 5;
            this.btnRaiz.Text = "√";
            this.btnRaiz.UseVisualStyleBackColor = true;
            this.btnRaiz.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPotencia
            // 
            this.btnPotencia.Font = new System.Drawing.Font("MV Boli", 25F, System.Drawing.FontStyle.Bold);
            this.btnPotencia.Location = new System.Drawing.Point(103, 451);
            this.btnPotencia.Name = "btnPotencia";
            this.btnPotencia.Size = new System.Drawing.Size(85, 76);
            this.btnPotencia.TabIndex = 6;
            this.btnPotencia.Text = "^";
            this.btnPotencia.UseVisualStyleBackColor = true;
            this.btnPotencia.Click += new System.EventHandler(this.btnPotencia_Click);
            // 
            // tbxHistorial
            // 
            this.tbxHistorial.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxHistorial.Location = new System.Drawing.Point(481, 12);
            this.tbxHistorial.Multiline = true;
            this.tbxHistorial.Name = "tbxHistorial";
            this.tbxHistorial.Size = new System.Drawing.Size(405, 596);
            this.tbxHistorial.TabIndex = 7;
            this.tbxHistorial.TextChanged += new System.EventHandler(this.tbxHistorial_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 627);
            this.Controls.Add(this.tbxHistorial);
            this.Controls.Add(this.btnPotencia);
            this.Controls.Add(this.btnRaiz);
            this.Controls.Add(this.tbxOperacion);
            this.Controls.Add(this.tbxResultados);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btnModulo);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnPorcentaje);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnPunto);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnRestar);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.btnMostrarCalculos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnElevar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Button btnMostrarCalculos;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btnPunto;
        private System.Windows.Forms.Button btnPorcentaje;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnRestar;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnModulo;
        private System.Windows.Forms.TextBox tbxResultados;
        private System.Windows.Forms.TextBox tbxOperacion;
        private System.Windows.Forms.Button btnRaiz;
        private System.Windows.Forms.Button btnPotencia;
        private System.Windows.Forms.TextBox tbxHistorial;
    }
}

