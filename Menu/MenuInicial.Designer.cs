namespace Grupo1.Prototipo.OrdenEntrega_Remito
{
    partial class MenuInicial
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
            button1 = new Button();
            TituloMenuPrincipal = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(223, 70);
            button1.Name = "button1";
            button1.Size = new Size(327, 40);
            button1.TabIndex = 0;
            button1.Text = "1. Cargar Órden de Preparación";
            button1.UseVisualStyleBackColor = true;
            // 
            // TituloMenuPrincipal
            // 
            TituloMenuPrincipal.AutoSize = true;
            TituloMenuPrincipal.Location = new Point(287, 38);
            TituloMenuPrincipal.Name = "TituloMenuPrincipal";
            TituloMenuPrincipal.Size = new Size(193, 20);
            TituloMenuPrincipal.TabIndex = 1;
            TituloMenuPrincipal.Text = "Menú inicial: Pampazón S.A.";
            // 
            // button2
            // 
            button2.Location = new Point(223, 186);
            button2.Name = "button2";
            button2.Size = new Size(327, 40);
            button2.TabIndex = 2;
            button2.Text = "3. Confirmar Órden de Selección";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(223, 138);
            button3.Name = "button3";
            button3.Size = new Size(327, 40);
            button3.TabIndex = 3;
            button3.Text = "2. Generar Órden de Selección";
            button3.UseVisualStyleBackColor = true;
            button3.Click += this.button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(223, 307);
            button4.Name = "button4";
            button4.Size = new Size(327, 40);
            button4.TabIndex = 6;
            button4.Text = "5. ";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(223, 376);
            button5.Name = "button5";
            button5.Size = new Size(327, 40);
            button5.TabIndex = 5;
            button5.Text = "6. ";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(223, 239);
            button6.Name = "button6";
            button6.Size = new Size(327, 40);
            button6.TabIndex = 4;
            button6.Text = "4. ";
            button6.UseVisualStyleBackColor = true;
            // 
            // MenuInicial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(TituloMenuPrincipal);
            Controls.Add(button1);
            Name = "MenuInicial";
            Text = "MenuInicial";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label TituloMenuPrincipal;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}