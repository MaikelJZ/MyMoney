namespace MyMoney
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btn_gastos_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is FormGastos)
                {
                    frm.BringToFront();  // traz a janela para frente
                    return;              // impede abrir outra
                }
            }

            // se não existir, cria um novo
            FormGastos f = new FormGastos();
            f.Show();
        }
    }
}
