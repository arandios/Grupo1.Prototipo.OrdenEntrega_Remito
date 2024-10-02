namespace Grupo1.Prototipo.OrdenEntrega_Remito
{
    partial class MenuOrdenEntrega
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
            ConfirmarOEBTN = new Button();
            GenerarOEBTN = new Button();
            SuspendLayout();
            // 
            // ConfirmarOEBTN
            // 
            ConfirmarOEBTN.Location = new Point(51, 48);
            ConfirmarOEBTN.Margin = new Padding(3, 4, 3, 4);
            ConfirmarOEBTN.Name = "ConfirmarOEBTN";
            ConfirmarOEBTN.Size = new Size(240, 31);
            ConfirmarOEBTN.TabIndex = 0;
            ConfirmarOEBTN.Text = "Confirmar Orden de Entrega";
            ConfirmarOEBTN.UseVisualStyleBackColor = true;
            // 
            // GenerarOEBTN
            // 
            GenerarOEBTN.Location = new Point(51, 87);
            GenerarOEBTN.Margin = new Padding(3, 4, 3, 4);
            GenerarOEBTN.Name = "GenerarOEBTN";
            GenerarOEBTN.Size = new Size(240, 31);
            GenerarOEBTN.TabIndex = 1;
            GenerarOEBTN.Text = "Generar Orden de Entrega";
            GenerarOEBTN.UseVisualStyleBackColor = true;
            // 
            // MenuOrdenEntrega
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 160);
            Controls.Add(GenerarOEBTN);
            Controls.Add(ConfirmarOEBTN);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MenuOrdenEntrega";
            Text = "MenuOrdenEntrega";
            ResumeLayout(false);
        }

        #endregion

        private Button ConfirmarOEBTN;
        private Button GenerarOEBTN;
    }
}