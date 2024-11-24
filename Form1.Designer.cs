namespace Tabla
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
            panelprincipal = new Panel();
            richTextBoxResultados = new RichTextBox();
            buttonVer = new Button();
            textBoxNum = new TextBox();
            labelNumero = new Label();
            labelTitulo = new Label();
            label1 = new Label();
            panelprincipal.SuspendLayout();
            SuspendLayout();
            // 
            // panelprincipal
            // 
            panelprincipal.BackColor = SystemColors.GradientActiveCaption;
            panelprincipal.Controls.Add(label1);
            panelprincipal.Controls.Add(richTextBoxResultados);
            panelprincipal.Controls.Add(buttonVer);
            panelprincipal.Controls.Add(textBoxNum);
            panelprincipal.Controls.Add(labelNumero);
            panelprincipal.Controls.Add(labelTitulo);
            panelprincipal.Location = new Point(12, 12);
            panelprincipal.Name = "panelprincipal";
            panelprincipal.Size = new Size(776, 426);
            panelprincipal.TabIndex = 0;
            // 
            // richTextBoxResultados
            // 
            richTextBoxResultados.Location = new Point(264, 127);
            richTextBoxResultados.Name = "richTextBoxResultados";
            richTextBoxResultados.Size = new Size(159, 188);
            richTextBoxResultados.TabIndex = 4;
            richTextBoxResultados.Text = "";
            // 
            // buttonVer
            // 
            buttonVer.Location = new Point(128, 192);
            buttonVer.Name = "buttonVer";
            buttonVer.Size = new Size(75, 23);
            buttonVer.TabIndex = 3;
            buttonVer.Text = "Ver Tabla";
            buttonVer.UseVisualStyleBackColor = true;
            buttonVer.Click += buttonVer_Click;
            // 
            // textBoxNum
            // 
            textBoxNum.Location = new Point(128, 163);
            textBoxNum.Name = "textBoxNum";
            textBoxNum.Size = new Size(100, 23);
            textBoxNum.TabIndex = 2;
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.Location = new Point(128, 145);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(106, 15);
            labelNumero.TabIndex = 1;
            labelNumero.Text = "Cual tabla quieres?";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Location = new Point(128, 130);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(110, 15);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Tabla de Multiplicar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlText;
            label1.Font = new Font("Swis721 BlkEx BT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(238, 109);
            label1.Name = "label1";
            label1.Size = new Size(205, 15);
            label1.TabIndex = 5;
            label1.Text = "Eduardo Pedroza López";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelprincipal);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panelprincipal.ResumeLayout(false);
            panelprincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelprincipal;
        private RichTextBox richTextBoxResultados;
        private Button buttonVer;
        private TextBox textBoxNum;
        private Label labelNumero;
        private Label labelTitulo;
        private Label label1;
    }
}
