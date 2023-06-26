namespace Sincronico_3
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
            label1 = new Label();
            txtnom = new TextBox();
            btn_iniciar = new Button();
            btn_cancelar = new Button();
            gift = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)gift).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(259, 93);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txtnom
            // 
            txtnom.Location = new Point(347, 90);
            txtnom.Name = "txtnom";
            txtnom.Size = new Size(189, 23);
            txtnom.TabIndex = 1;
            // 
            // btn_iniciar
            // 
            btn_iniciar.Location = new Point(237, 165);
            btn_iniciar.Name = "btn_iniciar";
            btn_iniciar.Size = new Size(117, 23);
            btn_iniciar.TabIndex = 2;
            btn_iniciar.Text = "Iniciar Proceso";
            btn_iniciar.UseVisualStyleBackColor = true;
            btn_iniciar.Click += btn_iniciar_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(431, 165);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(117, 23);
            btn_cancelar.TabIndex = 3;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // gift
            // 
            gift.Image = Properties.Resources.gift;
            gift.Location = new Point(268, 203);
            gift.Name = "gift";
            gift.Size = new Size(253, 215);
            gift.TabIndex = 4;
            gift.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gift);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_iniciar);
            Controls.Add(txtnom);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)gift).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtnom;
        private Button btn_iniciar;
        private Button btn_cancelar;
        private PictureBox gift;
    }
}