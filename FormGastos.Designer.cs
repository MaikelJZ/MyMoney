namespace MyMoney
{
    partial class FormGastos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGastos));
            toolStrip1 = new ToolStrip();
            btn_organizar = new ToolStripDropDownButton();
            btn_gastos = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cb_Pagamento = new ComboBox();
            txt_Valor = new TextBox();
            txt_Data = new TextBox();
            btn_Adicionar = new Button();
            btn_Atualizar = new Button();
            btn_Excluir = new Button();
            listGastos = new ListView();
            Valor = new ColumnHeader();
            Data = new ColumnHeader();
            Pagamento = new ColumnHeader();
            Descrição = new ColumnHeader();
            maskedTextBox1 = new MaskedTextBox();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.SeaGreen;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btn_organizar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1071, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btn_organizar
            // 
            btn_organizar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btn_organizar.DropDownItems.AddRange(new ToolStripItem[] { btn_gastos });
            btn_organizar.Image = (Image)resources.GetObject("btn_organizar.Image");
            btn_organizar.ImageTransparentColor = Color.Magenta;
            btn_organizar.Name = "btn_organizar";
            btn_organizar.Size = new Size(71, 22);
            btn_organizar.Text = "Organizar";
            // 
            // btn_gastos
            // 
            btn_gastos.Name = "btn_gastos";
            btn_gastos.Size = new Size(109, 22);
            btn_gastos.Text = "Gastos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(36, 83);
            label1.Name = "label1";
            label1.Size = new Size(52, 25);
            label1.TabIndex = 2;
            label1.Text = "Valor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(36, 134);
            label2.Name = "label2";
            label2.Size = new Size(49, 25);
            label2.TabIndex = 3;
            label2.Text = "Data";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(36, 185);
            label3.Name = "label3";
            label3.Size = new Size(158, 25);
            label3.TabIndex = 4;
            label3.Text = "Forma Pagamento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F);
            label4.Location = new Point(36, 236);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 5;
            label4.Text = "Descrição";
            // 
            // cb_Pagamento
            // 
            cb_Pagamento.Font = new Font("Segoe UI", 13F);
            cb_Pagamento.FormattingEnabled = true;
            cb_Pagamento.Items.AddRange(new object[] { "Débito", "Crédito", "Pix", "Dinheiro" });
            cb_Pagamento.Location = new Point(220, 182);
            cb_Pagamento.Name = "cb_Pagamento";
            cb_Pagamento.Size = new Size(121, 31);
            cb_Pagamento.TabIndex = 6;
            // 
            // txt_Valor
            // 
            txt_Valor.BorderStyle = BorderStyle.FixedSingle;
            txt_Valor.Font = new Font("Segoe UI", 13F);
            txt_Valor.Location = new Point(220, 80);
            txt_Valor.Name = "txt_Valor";
            txt_Valor.PlaceholderText = "R$00,00";
            txt_Valor.Size = new Size(100, 31);
            txt_Valor.TabIndex = 7;
            // 
            // txt_Data
            // 
            txt_Data.BorderStyle = BorderStyle.FixedSingle;
            txt_Data.Font = new Font("Segoe UI", 13F);
            txt_Data.Location = new Point(220, 131);
            txt_Data.Name = "txt_Data";
            txt_Data.Size = new Size(100, 31);
            txt_Data.TabIndex = 8;
            // 
            // btn_Adicionar
            // 
            btn_Adicionar.BackColor = Color.DarkSeaGreen;
            btn_Adicionar.Font = new Font("Segoe UI", 13F);
            btn_Adicionar.Location = new Point(36, 308);
            btn_Adicionar.Name = "btn_Adicionar";
            btn_Adicionar.Size = new Size(106, 38);
            btn_Adicionar.TabIndex = 10;
            btn_Adicionar.Text = "Adicionar";
            btn_Adicionar.UseVisualStyleBackColor = false;
            // 
            // btn_Atualizar
            // 
            btn_Atualizar.BackColor = SystemColors.ActiveCaption;
            btn_Atualizar.Font = new Font("Segoe UI", 13F);
            btn_Atualizar.Location = new Point(306, 308);
            btn_Atualizar.Name = "btn_Atualizar";
            btn_Atualizar.Size = new Size(106, 38);
            btn_Atualizar.TabIndex = 11;
            btn_Atualizar.Text = "Atualizar";
            btn_Atualizar.UseVisualStyleBackColor = false;
            // 
            // btn_Excluir
            // 
            btn_Excluir.BackColor = Color.IndianRed;
            btn_Excluir.Font = new Font("Segoe UI", 13F);
            btn_Excluir.Location = new Point(171, 308);
            btn_Excluir.Name = "btn_Excluir";
            btn_Excluir.Size = new Size(106, 38);
            btn_Excluir.TabIndex = 12;
            btn_Excluir.Text = "Excluir";
            btn_Excluir.UseVisualStyleBackColor = false;
            // 
            // listGastos
            // 
            listGastos.BorderStyle = BorderStyle.FixedSingle;
            listGastos.Columns.AddRange(new ColumnHeader[] { Valor, Data, Pagamento, Descrição });
            listGastos.Location = new Point(515, 50);
            listGastos.Name = "listGastos";
            listGastos.Size = new Size(392, 296);
            listGastos.TabIndex = 13;
            listGastos.UseCompatibleStateImageBehavior = false;
            listGastos.View = View.Details;
            // 
            // Valor
            // 
            Valor.Text = "Valor";
            Valor.Width = 80;
            // 
            // Data
            // 
            Data.Text = "Data";
            Data.Width = 80;
            // 
            // Pagamento
            // 
            Pagamento.Text = "Pagamento";
            Pagamento.Width = 80;
            // 
            // Descrição
            // 
            Descrição.Text = "Descrição";
            Descrição.Width = 150;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Font = new Font("Segoe UI", 13F);
            maskedTextBox1.Location = new Point(220, 236);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(100, 31);
            maskedTextBox1.TabIndex = 14;
            maskedTextBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // FormGastos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1071, 412);
            Controls.Add(maskedTextBox1);
            Controls.Add(listGastos);
            Controls.Add(btn_Excluir);
            Controls.Add(btn_Atualizar);
            Controls.Add(btn_Adicionar);
            Controls.Add(txt_Data);
            Controls.Add(txt_Valor);
            Controls.Add(cb_Pagamento);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(toolStrip1);
            Name = "FormGastos";
            Text = "FormGastos";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripDropDownButton btn_organizar;
        private ToolStripMenuItem btn_gastos;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cb_Pagamento;
        private TextBox txt_Valor;
        private TextBox txt_Data;
        private Button btn_Adicionar;
        private Button btn_Atualizar;
        private Button btn_Excluir;
        private ListView listGastos;
        private ColumnHeader Valor;
        private ColumnHeader Data;
        private ColumnHeader Pagamento;
        private ColumnHeader Descrição;
        private MaskedTextBox maskedTextBox1;
    }
}