namespace ProyectoAJ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double monto;
            int r;
            if (NombreE.Text == "")
            {   MessageBox.Show("No se acpetan Espacios, digite el nombre de la empresa");
                NombreE.Focus();
            }else if (dia.Text == "")
            {   MessageBox.Show("No se acpetan Espacios, digite el dia");
                dia.Focus();
            }else if (mes.Text == "")
            {   MessageBox.Show("No se acpetan Espacios, digite el mes");
                mes.Focus();
            }else if (año.Text == "")
            {   MessageBox.Show("No se acpetan Espacios, digite el año");
                año.Focus();
            }
            else
            {
                if (activoC.Text == "")
                {
                    MessageBox.Show("No se acpetan Espacios, digite la cuenta");
                    activoC.Focus();
                }
                else if (activoC.Text == "Caja")
                {
                    if (montoAC.Text == "")
                    { MessageBox.Show("No se acpetan Espacios, digite el monto de caja");
                        montoAC.Focus();
                    }
                    else
                    { monto = Convert.ToDouble(montoAC.Text);
                        r = data1.Rows.Add();
                        data1.Rows[r].Cells[0].Value = "Caja";
                        data1.Rows[r].Cells[1].Value = monto;
                        activoC.Text = "";
                        montoAC.Text = "";
                    }
                }
                else if (activoC.Text == "Bancos")
                {
                    if (montoAC.Text == "")
                    { MessageBox.Show("No se acpetan Espacios, digite el monto de Banco");
                        montoAC.Focus();
                    }
                    else
                    {
                        monto = Convert.ToDouble(montoAC.Text);
                        r = data1.Rows.Add();
                        data1.Rows[r].Cells[0].Value = "Bancos";
                        data1.Rows[r].Cells[1].Value = monto;
                        activoC.Text = "";
                        montoAC.Text = "";
                    }
                }
                else if (activoC.Text == "Clientes")
                {
                    if (montoAC.Text == "")
                    {
                        MessageBox.Show("No se acpetan Espacios, digite el monto de Clientes");
                        montoAC.Focus();
                    }
                    else
                    {
                        monto = Convert.ToDouble(montoAC.Text);
                        r = data1.Rows.Add();
                        data1.Rows[r].Cells[0].Value = "Clientes";
                        data1.Rows[r].Cells[1].Value = monto;
                        activoC.Text = "";
                        montoAC.Text = "";
                    }
                }
                else if (activoC.Text == "Mercancias")
                {
                    if (montoAC.Text == "")
                    {
                        MessageBox.Show("No se acpetan Espacios, digite el monto de Mercancias");
                        montoAC.Focus();
                    }
                    else
                    {
                        monto = Convert.ToDouble(montoAC.Text);
                        r = data1.Rows.Add();
                        data1.Rows[r].Cells[0].Value = "Mercancias";
                        data1.Rows[r].Cells[1].Value = monto;
                        activoC.Text = "";
                        montoAC.Text = "";
                    }
                }
            }
        }

        private void agregarAF_Click(object sender, EventArgs e)
        {
            double monto;
            int r;

            if (activoF.Text == "")
            {
                MessageBox.Show("No se acpetan Espacios, digite la cuenta");
                activoF.Focus();
            }
            else if (activoF.Text == "Terreno")
            {
                if (montoAF.Text == "")
                {
                    MessageBox.Show("No se acpetan Espacios, digite el monto de Terreno");
                    montoAF.Focus();
                }
                else
                {
                    monto = Convert.ToDouble(montoAF.Text);
                    r = data1.Rows.Add();
                    data1.Rows[r].Cells[0].Value = "Terreno";
                    data1.Rows[r].Cells[1].Value = monto;
                    activoF.Text = "";
                    montoAF.Text = "";
                }
            }
            else if (activoF.Text == "Edificio")
            {
                if (montoAF.Text == "")
                {
                    MessageBox.Show("No se acpetan Espacios, digite el monto de Edificio");
                    montoAF.Focus();
                }
                else
                {
                    monto = Convert.ToDouble(montoAF.Text);
                    r = data1.Rows.Add();
                    data1.Rows[r].Cells[0].Value = "Edificio";
                    data1.Rows[r].Cells[1].Value = monto;
                    activoF.Text = "";
                    montoAF.Text = "";
                }
            }
            else if (activoF.Text == "Mobiliario y Eq.")
            {
                if (montoAF.Text == "")
                {
                    MessageBox.Show("No se acpetan Espacios, digite el monto de Mobiliario y Eq.");
                    montoAF.Focus();
                }
                else
                {
                    monto = Convert.ToDouble(montoAF.Text);
                    r = data1.Rows.Add();
                    data1.Rows[r].Cells[0].Value = "Mobiliario y Eq.";
                    data1.Rows[r].Cells[1].Value = monto;
                    activoF.Text = "";
                    montoAF.Text = "";
                }
            }
        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            double monto;
            int r;

            if (activoO.Text == "")
            {
                MessageBox.Show("No se acpetan Espacios, digite la cuenta");
                activoO.Focus();
            }
            else if (activoO.Text == "Salarios")
            {
                if (montoAO.Text == "")
                {
                    MessageBox.Show("No se acpetan Espacios, digite el monto de Salarios");
                    montoAO.Focus();
                }
                else
                {
                    monto = Convert.ToDouble(montoAO.Text);
                    r = data1.Rows.Add();
                    data1.Rows[r].Cells[0].Value = "Salarios";
                    data1.Rows[r].Cells[1].Value = monto;
                    activoO.Text = "";
                    montoAO.Text = "";
                }
            }
            else if (activoO.Text == "Impuestos a alcaldia")
            {
                if (montoAO.Text == "")
                {
                    MessageBox.Show("No se acpetan Espacios, digite el monto de Impuestos a alcaldia");
                    montoAO.Focus();
                }
                else
                {
                    monto = Convert.ToDouble(montoAO.Text);
                    r = data1.Rows.Add();
                    data1.Rows[r].Cells[0].Value = "Impuestos a alcaldia";
                    data1.Rows[r].Cells[1].Value = monto;
                    activoO.Text = "";
                    montoAO.Text = "";
                }
            }
            else if (activoO.Text == "Propaganda y Publi.")
            {
                if (montoAO.Text == "")
                {
                    MessageBox.Show("No se acpetan Espacios, digite el monto de Propaganda y Publi.");
                    montoAO.Focus();
                }
                else
                {
                    monto = Convert.ToDouble(montoAO.Text);
                    r = data1.Rows.Add();
                    data1.Rows[r].Cells[0].Value = "Propaganda y Publi.";
                    data1.Rows[r].Cells[1].Value = monto;
                    activoO.Text = "";
                    montoAO.Text = "";
                }
            }
            else if (activoO.Text == "Gastos de Adm.")
            {
                if (montoAO.Text == "")
                {
                    MessageBox.Show("No se acpetan Espacios, digite el monto de Gastos de Adm.");
                    montoAO.Focus();
                }
                else
                {
                    monto = Convert.ToDouble(montoAO.Text);
                    r = data1.Rows.Add();
                    data1.Rows[r].Cells[0].Value = "Gastos de Adm.";
                    data1.Rows[r].Cells[1].Value = monto;
                    activoO.Text = "";
                    montoAO.Text = "";
                }
            }
            else if (activoO.Text == "Gastos de Venta")
            {
                if (montoAO.Text == "")
                {
                    MessageBox.Show("No se acpetan Espacios, digite el monto de Gastos de Venta");
                    montoAO.Focus();
                }
                else
                {
                    monto = Convert.ToDouble(montoAO.Text);
                    r = data1.Rows.Add();
                    data1.Rows[r].Cells[0].Value = "Gastos de Venta";
                    data1.Rows[r].Cells[1].Value = monto;
                    activoO.Text = "";
                    montoAO.Text = "";
                }
            }
        }
    }
}