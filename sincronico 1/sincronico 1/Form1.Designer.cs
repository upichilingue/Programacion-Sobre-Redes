namespace sincronico_1
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
            txt_iniciar = new Button();
            txt_cancelar = new Button();
            gif = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)gif).BeginInit();
            SuspendLayout();
            // 
            // txt_iniciar
            // 
            txt_iniciar.Location = new Point(216, 122);
            txt_iniciar.Name = "txt_iniciar";
            txt_iniciar.Size = new Size(94, 23);
            txt_iniciar.TabIndex = 0;
            txt_iniciar.Text = "Iniciar Proceso";
            txt_iniciar.UseVisualStyleBackColor = true;
            txt_iniciar.Click += txt_iniciar_Click;
            // 
            // txt_cancelar
            // 
            txt_cancelar.Location = new Point(416, 122);
            txt_cancelar.Name = "txt_cancelar";
            txt_cancelar.Size = new Size(94, 23);
            txt_cancelar.TabIndex = 1;
            txt_cancelar.Text = "Cancelar";
            txt_cancelar.UseVisualStyleBackColor = true;
            txt_cancelar.Click += txt_cancelar_Click;
            // 
            // gif
            // 
            gif.Image = Properties.Resources.gift1;
            gif.Location = new Point(238, 165);
            gif.Name = "gif";
            gif.Size = new Size(254, 215);
            gif.TabIndex = 2;
            gif.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gif);
            Controls.Add(txt_cancelar);
            Controls.Add(txt_iniciar);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)gif).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button txt_iniciar;
        private Button txt_cancelar;
        private PictureBox gif;
    }
}