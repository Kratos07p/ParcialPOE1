using libreriaDocumentos;

namespace Parcial_1
{
    public partial class Form1 : Form
    {
        private List<InformacionDocumentos> infoDocumentos = new List<InformacionDocumentos>();
        public Form1()
        {
            InitializeComponent();
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(idTextBox.Text) && !string.IsNullOrWhiteSpace(nombreDocTextBox.Text)
        && !string.IsNullOrWhiteSpace(tipoDocTextBox.Text) && !string.IsNullOrWhiteSpace(usuarioTextBox.Text)
        && !string.IsNullOrWhiteSpace(fechaCreacionTextBox.Text))
            {
                int id = int.Parse(idTextBox.Text);

                if (id == 0)
                {
                    MessageBox.Show("El ID no puede ser 0, por favor ingrese un ID válido.");
                }
                else
                {
                    InformacionDocumentos infoDocumentacion = new InformacionDocumentos();
                    infoDocumentacion.Id = id;
                    infoDocumentacion.NombreDocumento = nombreDocTextBox.Text;
                    infoDocumentacion.TipoDocumento = tipoDocTextBox.Text;
                    infoDocumentacion.Usuarios = usuarioTextBox.Text;

                    if (DateTime.TryParse(fechaCreacionTextBox.Text, out DateTime fechaCreacion))
                    {
                        infoDocumentacion.FechaCreacion = fechaCreacion;

                        infoDocumentos.Add(infoDocumentacion);

                        idTextBox.Text = "";
                        nombreDocTextBox.Text = "";
                        tipoDocTextBox.Text = "";
                        usuarioTextBox.Text = "";
                        fechaCreacionTextBox.Text = "";

                        string documentacionInfo = $"{infoDocumentacion.Id} - {infoDocumentacion.NombreDocumento} - {infoDocumentacion.TipoDocumento} - {infoDocumentacion.Usuarios} - {infoDocumentacion.FechaCreacion.ToShortDateString()}";
                        listadoDocumentosListBox.Items.Add(documentacionInfo);

                        MessageBox.Show("El documento se agregó exitosamente.");
                    }
                    else
                    {
                        MessageBox.Show("Por favor ingrese una Fecha Válida [DD/MM/YY]");
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor llene todos los parámetros");
            }
        }

        private void editarButton_Click(object sender, EventArgs e)
        {
            if (listadoDocumentosListBox.SelectedIndex >= 0)
            {
                string elementoSeleccionado = listadoDocumentosListBox.SelectedItem.ToString();

                string[] detalles = elementoSeleccionado.Split(new string[] { " - " }, StringSplitOptions.None);

                idTextBox.Text = detalles[0];
                nombreDocTextBox.Text = detalles[1];
                tipoDocTextBox.Text = detalles[2];
                usuarioTextBox.Text = detalles[3];
                fechaCreacionTextBox.Text = detalles[4];

                listadoDocumentosListBox.Items.RemoveAt(listadoDocumentosListBox.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Por Favor seleccione un elemento que se encuentre en la lista para poder editarlo.");
            }
        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            if (listadoDocumentosListBox.SelectedIndex >= 0)
            {
                listadoDocumentosListBox.Items.RemoveAt(listadoDocumentosListBox.SelectedIndex);
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