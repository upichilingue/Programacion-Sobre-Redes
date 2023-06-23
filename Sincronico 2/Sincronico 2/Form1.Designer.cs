namespace Sincronico_2
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
            btn_iniciar = new Button();
            btn_cancelar = new Button();
            gift = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)gift).BeginInit();
            SuspendLayout();
            // 
            // btn_iniciar
            // 
            btn_iniciar.Location = new Point(264, 129);
            btn_iniciar.Name = "btn_iniciar";
            btn_iniciar.Size = new Size(107, 23);
            btn_iniciar.TabIndex = 0;
            btn_iniciar.Text = "Iniciar Proceso";
            btn_iniciar.UseVisualStyleBackColor = true;
            btn_iniciar.Click += btn_iniciar_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(428, 129);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(107, 23);
            btn_cancelar.TabIndex = 1;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // gift
            // 
            gift.Image = Properties.Resources.gift;
            gift.Location = new Point(279, 178);
            gift.Name = "gift";
            gift.Size = new Size(243, 213);
            gift.TabIndex = 2;
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
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)gift).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_iniciar;
        private Button btn_cancelar;
        private PictureBox gift;
    }
}