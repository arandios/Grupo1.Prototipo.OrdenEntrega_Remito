namespace Grupo1.Prototipo.OrdenEntrega_Remito
{
    partial class CornfirmarOE
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
            ConfirmarBTN = new Button();
            ReportarBTN = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            listBox1 = new ListBox();
            OrdenesEntregaLTV = new ListView();
            NroOrdenColumna = new ColumnHeader();
            listView2 = new ListView();
            ClienteColumna = new ColumnHeader();
            TransportistaColumna = new ColumnHeader();
            NroClienteBuscarTxt = new TextBox();
            DatosClienteLtv = new ListView();
            TransportistasAutorizadosColumna = new ColumnHeader();
            BuscarBtn = new Button();
            nroClienteLbl = new Label();
            label3 = new Label();
            SalirBtn = new Button();
            SuspendLayout();
            // 
            // ConfirmarBTN
            // 
            ConfirmarBTN.Location = new Point(196, 338);
            ConfirmarBTN.Name = "ConfirmarBTN";
            ConfirmarBTN.Size = new Size(123, 23);
            ConfirmarBTN.TabIndex = 0;
            ConfirmarBTN.Text = "Confirmar orden";
            ConfirmarBTN.UseMnemonic = false;
            ConfirmarBTN.UseVisualStyleBackColor = true;
            // 
            // ReportarBTN
            // 
            ReportarBTN.Location = new Point(325, 338);
            ReportarBTN.Name = "ReportarBTN";
            ReportarBTN.Size = new Size(75, 23);
            ReportarBTN.TabIndex = 1;
            ReportarBTN.Text = "Reportar";
            ReportarBTN.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(457, 309);
            button3.Name = "button3";
            button3.Size = new Size(179, 23);
            button3.TabIndex = 2;
            button3.Text = "Generar remito";
            button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 24);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 3;
            label1.Text = "Ordenes de entrega";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(457, 24);
            label2.Name = "label2";
            label2.Size = new Size(179, 15);
            label2.TabIndex = 4;
            label2.Text = "Ordenes de entrega confirmadas";
            label2.Click += label2_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(457, 53);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(179, 244);
            listBox1.TabIndex = 5;
            // 
            // OrdenesEntregaLTV
            // 
            OrdenesEntregaLTV.BorderStyle = BorderStyle.FixedSingle;
            OrdenesEntregaLTV.Columns.AddRange(new ColumnHeader[] { NroOrdenColumna });
            OrdenesEntregaLTV.Location = new Point(27, 53);
            OrdenesEntregaLTV.Name = "OrdenesEntregaLTV";
            OrdenesEntregaLTV.Size = new Size(134, 141);
            OrdenesEntregaLTV.TabIndex = 6;
            OrdenesEntregaLTV.UseCompatibleStateImageBehavior = false;
            OrdenesEntregaLTV.View = View.Details;
            // 
            // NroOrdenColumna
            // 
            NroOrdenColumna.Text = "Nro. Orden";
            NroOrdenColumna.Width = 130;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { ClienteColumna, TransportistaColumna });
            listView2.Location = new Point(196, 53);
            listView2.Name = "listView2";
            listView2.Size = new Size(204, 141);
            listView2.TabIndex = 7;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // ClienteColumna
            // 
            ClienteColumna.Text = "Cliente";
            ClienteColumna.Width = 100;
            // 
            // TransportistaColumna
            // 
            TransportistaColumna.Text = "Transportista";
            TransportistaColumna.Width = 100;
            // 
            // NroClienteBuscarTxt
            // 
            NroClienteBuscarTxt.Location = new Point(26, 235);
            NroClienteBuscarTxt.Name = "NroClienteBuscarTxt";
            NroClienteBuscarTxt.Size = new Size(134, 23);
            NroClienteBuscarTxt.TabIndex = 8;
            // 
            // DatosClienteLtv
            // 
            DatosClienteLtv.Columns.AddRange(new ColumnHeader[] { TransportistasAutorizadosColumna });
            DatosClienteLtv.Location = new Point(196, 200);
            DatosClienteLtv.Name = "DatosClienteLtv";
            DatosClienteLtv.Size = new Size(204, 132);
            DatosClienteLtv.TabIndex = 9;
            DatosClienteLtv.UseCompatibleStateImageBehavior = false;
            DatosClienteLtv.View = View.Details;
            // 
            // TransportistasAutorizadosColumna
            // 
            TransportistasAutorizadosColumna.Text = "Transportistas Autorizados";
            TransportistasAutorizadosColumna.Width = 200;
            // 
            // BuscarBtn
            // 
            BuscarBtn.Location = new Point(26, 264);
            BuscarBtn.Name = "BuscarBtn";
            BuscarBtn.Size = new Size(117, 23);
            BuscarBtn.TabIndex = 10;
            BuscarBtn.Text = "Buscar";
            BuscarBtn.UseVisualStyleBackColor = true;
            // 
            // nroClienteLbl
            // 
            nroClienteLbl.AutoSize = true;
            nroClienteLbl.Location = new Point(26, 217);
            nroClienteLbl.Name = "nroClienteLbl";
            nroClienteLbl.Size = new Size(91, 15);
            nroClienteLbl.TabIndex = 11;
            nroClienteLbl.Text = "Numero Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(196, 24);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 12;
            label3.Text = "Detalle de orden";
            // 
            // SalirBtn
            // 
            SalirBtn.Location = new Point(457, 338);
            SalirBtn.Name = "SalirBtn";
            SalirBtn.Size = new Size(179, 23);
            SalirBtn.TabIndex = 13;
            SalirBtn.Text = "Salir";
            SalirBtn.UseVisualStyleBackColor = true;
            // 
            // CornfirmarOE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 370);
            Controls.Add(SalirBtn);
            Controls.Add(label3);
            Controls.Add(nroClienteLbl);
            Controls.Add(BuscarBtn);
            Controls.Add(DatosClienteLtv);
            Controls.Add(NroClienteBuscarTxt);
            Controls.Add(listView2);
            Controls.Add(OrdenesEntregaLTV);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(ReportarBTN);
            Controls.Add(ConfirmarBTN);
            Name = "CornfirmarOE";
            Text = "CONFIRMAR ORDEN DE ENTREGA";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ConfirmarBTN;
        private Button ReportarBTN;
        private Button button3;
        private Label label1;
        private Label label2;
        private ListBox listBox1;
        private ListView OrdenesEntregaLTV;
        private ListView listView2;
        private ColumnHeader NroOrdenColumna;
        private ColumnHeader ClienteColumna;
        private TextBox NroClienteBuscarTxt;
        private ListView DatosClienteLtv;
        private ColumnHeader TransportistasAutorizadosColumna;
        private Button BuscarBtn;
        private Label nroClienteLbl;
        private ColumnHeader TransportistaColumna;
        private Label label3;
        private Button SalirBtn;
    }
}
