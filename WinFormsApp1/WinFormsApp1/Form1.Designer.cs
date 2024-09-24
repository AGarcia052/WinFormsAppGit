namespace WinFormsApp1
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
            btAceptar = new Button();
            btdos = new Button();
            SuspendLayout();
            // 
            // btAceptar
            // 
            btAceptar.Location = new Point(222, 130);
            btAceptar.Name = "btAceptar";
            btAceptar.Size = new Size(280, 103);
            btAceptar.TabIndex = 0;
            btAceptar.Text = "Aceptar";
            btAceptar.UseVisualStyleBackColor = true;
            // 
            // btdos
            // 
            btdos.Location = new Point(518, 327);
            btdos.Name = "btdos";
            btdos.Size = new Size(94, 29);
            btdos.TabIndex = 1;
            btdos.Text = "segundo";
            btdos.UseVisualStyleBackColor = true;
            btdos.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btdos);
            Controls.Add(btAceptar);
            Name = "Form1";
            Text = "Formulario de ejemplo mod";
            ResumeLayout(false);
        }

        #endregion

        private Button btAceptar;
        private Button btdos;
    }
}
