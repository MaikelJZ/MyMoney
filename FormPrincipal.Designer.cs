namespace MyMoney
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            toolStrip1 = new ToolStrip();
            btn_organizar = new ToolStripDropDownButton();
            btn_gastos = new ToolStripMenuItem();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.SeaGreen;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btn_organizar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1165, 25);
            toolStrip1.TabIndex = 0;
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
            btn_gastos.Size = new Size(180, 22);
            btn_gastos.Text = "Gastos";
            btn_gastos.Click += btn_gastos_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fundo;
            ClientSize = new Size(1165, 699);
            Controls.Add(toolStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripDropDownButton btn_organizar;
        private ToolStripMenuItem btn_gastos;
    }
}
