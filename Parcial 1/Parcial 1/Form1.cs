using InformacionDocumentos;

namespace Practica1
{
    public partial class Form1 : Form
    {
        List<InformacionDocumento> infoDocumento = new List<InformacionDocumento>();
        public Form1()
        {
            InitializeComponent();
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(idTextBox.Text) && !string.IsNullOrWhiteSpace(nombreDocTextBox.Text)
                && !string.IsNullOrWhiteSpace(tipoDocTextBox.Text) && !string.IsNullOrWhiteSpace(ususarioTextBox.Text)
                && !string.IsNullOrWhiteSpace(fechaCreacionTextBox.Text))
            {
                InformacionDocumento infoDocumentacion = new InformacionDocumento();
                infoDocumentacion.id = int.Parse(idTextBox.Text);
                infoDocumentacion.NombreDoc = nombreDocTextBox.Text;
                infoDocumentacion.TipoDoc = tipoDocTextBox.Text;
                infoDocumentacion.Usuarios = ususarioTextBox.Text;
                if (DateTime.TryParse(fechaCreacionTextBox.Text, out DateTime fechaCreacion))
                {
                    infoDocumentacion.FechaCreacion = fechaCreacion;

                    infoDocumento.Add(infoDocumentacion);

                    idTextBox.Text = "";
                    nombreDocTextBox.Text = "";
                    tipoDocTextBox.Text = "";
                    ususarioTextBox.Text = "";
                    fechaCreacionTextBox.Text = "";

                    string documentacionInfo = $"ID: {infoDocumentacion.id} - {infoDocumentacion.NombreDoc} - {infoDocumentacion.TipoDoc} - {infoDocumentacion.Usuarios} - {infoDocumentacion.FechaCreacion.ToShortDateString()}";
                    listBoxListadoDocumentos.Items.Add(documentacionInfo);

                    MessageBox.Show("El documento se agregó exitosamente.");
                }
                else
                {
                    MessageBox.Show("Por Favor ingrese una Fecha Valida [DD/MM/YY]");
                }
            }
            else
            {
                MessageBox.Show("Por Favor llene todos los parametros");
            }
        }

        private void editarButton_Click(object sender, EventArgs e)
        {
            if (listBoxListadoDocumentos.SelectedIndex >= 0)
            {
                string elementoSeleccionado = listBoxListadoDocumentos.SelectedItem.ToString();

                string[] detalles = elementoSeleccionado.Split(new string[] { " - " }, StringSplitOptions.None);

                idTextBox.Text = detalles[0];
                nombreDocTextBox.Text = detalles[1];
                tipoDocTextBox.Text = detalles[2];
                ususarioTextBox.Text = detalles[3];
                fechaCreacionTextBox.Text = detalles[4];

                listBoxListadoDocumentos.Items.RemoveAt(listBoxListadoDocumentos.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Por Favor seleccione un elemento que se encuentre en la lista para poder editarlo.");
            }
        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            if (listBoxListadoDocumentos.SelectedIndex >= 0)
            {
                listBoxListadoDocumentos.Items.RemoveAt(listBoxListadoDocumentos.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Por favor seleccione un elemento de la lista antes de eliminar");
            }
        }

        private void salirButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void idTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}