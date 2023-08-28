namespace Practica1
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
            btnSalir = new Button();
            botonesPanel = new Panel();
            nombreDocTextBox = new TextBox();
            tipoDocTextBox = new TextBox();
            ususarioTextBox = new TextBox();
            fechaCreacionTextBox = new TextBox();
            idTextBox = new TextBox();
            fechaLabel = new Label();
            usuarioCreadorLabel = new Label();
            tipoDocumentoLabel = new Label();
            nombreDocumentoLabel = new Label();
            idLabel = new Label();
            editarButton = new Button();
            eliminarButton = new Button();
            agregarButton = new Button();
            TopPanel = new Panel();
            administracionLabel = new Label();
            listBoxListadoDocumentos = new ListBox();
            salirButton = new Button();
            botonesPanel.SuspendLayout();
            TopPanel.SuspendLayout();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(492, 541);
            btnSalir.Margin = new Padding(4, 3, 4, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(86, 29);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // botonesPanel
            // 
            botonesPanel.BackColor = SystemColors.ActiveCaption;
            botonesPanel.Controls.Add(nombreDocTextBox);
            botonesPanel.Controls.Add(tipoDocTextBox);
            botonesPanel.Controls.Add(ususarioTextBox);
            botonesPanel.Controls.Add(fechaCreacionTextBox);
            botonesPanel.Controls.Add(idTextBox);
            botonesPanel.Controls.Add(fechaLabel);
            botonesPanel.Controls.Add(usuarioCreadorLabel);
            botonesPanel.Controls.Add(tipoDocumentoLabel);
            botonesPanel.Controls.Add(nombreDocumentoLabel);
            botonesPanel.Controls.Add(idLabel);
            botonesPanel.Controls.Add(editarButton);
            botonesPanel.Controls.Add(eliminarButton);
            botonesPanel.Controls.Add(agregarButton);
            botonesPanel.Dock = DockStyle.Left;
            botonesPanel.Location = new Point(0, 0);
            botonesPanel.Name = "botonesPanel";
            botonesPanel.Size = new Size(200, 457);
            botonesPanel.TabIndex = 1;
            // 
            // nombreDocTextBox
            // 
            nombreDocTextBox.Location = new Point(42, 114);
            nombreDocTextBox.Name = "nombreDocTextBox";
            nombreDocTextBox.Size = new Size(115, 27);
            nombreDocTextBox.TabIndex = 12;
            // 
            // tipoDocTextBox
            // 
            tipoDocTextBox.Location = new Point(42, 178);
            tipoDocTextBox.Name = "tipoDocTextBox";
            tipoDocTextBox.Size = new Size(115, 27);
            tipoDocTextBox.TabIndex = 11;
            // 
            // ususarioTextBox
            // 
            ususarioTextBox.Location = new Point(43, 230);
            ususarioTextBox.Name = "ususarioTextBox";
            ususarioTextBox.Size = new Size(115, 27);
            ususarioTextBox.TabIndex = 10;
            // 
            // fechaCreacionTextBox
            // 
            fechaCreacionTextBox.Location = new Point(42, 282);
            fechaCreacionTextBox.Name = "fechaCreacionTextBox";
            fechaCreacionTextBox.Size = new Size(115, 27);
            fechaCreacionTextBox.TabIndex = 9;
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(42, 49);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(115, 27);
            idTextBox.TabIndex = 8;
            idTextBox.KeyPress += idTextBox_KeyPress;
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new Point(42, 260);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new Size(132, 19);
            fechaLabel.TabIndex = 7;
            fechaLabel.Text = "Fecha de Creación";
            // 
            // usuarioCreadorLabel
            // 
            usuarioCreadorLabel.AutoSize = true;
            usuarioCreadorLabel.Location = new Point(31, 208);
            usuarioCreadorLabel.Name = "usuarioCreadorLabel";
            usuarioCreadorLabel.Size = new Size(147, 19);
            usuarioCreadorLabel.TabIndex = 6;
            usuarioCreadorLabel.Text = "Nombre Del Usuario";
            // 
            // tipoDocumentoLabel
            // 
            tipoDocumentoLabel.AutoSize = true;
            tipoDocumentoLabel.Location = new Point(42, 150);
            tipoDocumentoLabel.Name = "tipoDocumentoLabel";
            tipoDocumentoLabel.Size = new Size(123, 19);
            tipoDocumentoLabel.TabIndex = 5;
            tipoDocumentoLabel.Text = "Tipo Documento";
            // 
            // nombreDocumentoLabel
            // 
            nombreDocumentoLabel.AutoSize = true;
            nombreDocumentoLabel.Location = new Point(29, 92);
            nombreDocumentoLabel.Name = "nombreDocumentoLabel";
            nombreDocumentoLabel.Size = new Size(149, 19);
            nombreDocumentoLabel.TabIndex = 4;
            nombreDocumentoLabel.Text = "Nombre Documento";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(85, 27);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(23, 19);
            idLabel.TabIndex = 3;
            idLabel.Text = "ID";
            // 
            // editarButton
            // 
            editarButton.BackColor = SystemColors.ActiveCaptionText;
            editarButton.FlatStyle = FlatStyle.Flat;
            editarButton.ForeColor = SystemColors.ButtonFace;
            editarButton.Location = new Point(54, 372);
            editarButton.Name = "editarButton";
            editarButton.Size = new Size(90, 33);
            editarButton.TabIndex = 2;
            editarButton.Text = "Editar";
            editarButton.UseVisualStyleBackColor = false;
            editarButton.Click += editarButton_Click;
            // 
            // eliminarButton
            // 
            eliminarButton.BackColor = SystemColors.ActiveCaptionText;
            eliminarButton.FlatStyle = FlatStyle.Flat;
            eliminarButton.ForeColor = SystemColors.ButtonFace;
            eliminarButton.Location = new Point(54, 411);
            eliminarButton.Name = "eliminarButton";
            eliminarButton.Size = new Size(90, 33);
            eliminarButton.TabIndex = 1;
            eliminarButton.Text = "Eliminar";
            eliminarButton.UseVisualStyleBackColor = false;
            eliminarButton.Click += eliminarButton_Click;
            // 
            // agregarButton
            // 
            agregarButton.BackColor = SystemColors.ActiveCaptionText;
            agregarButton.FlatStyle = FlatStyle.Flat;
            agregarButton.ForeColor = SystemColors.ButtonFace;
            agregarButton.Location = new Point(54, 333);
            agregarButton.Name = "agregarButton";
            agregarButton.Size = new Size(90, 33);
            agregarButton.TabIndex = 0;
            agregarButton.Text = "Agregar";
            agregarButton.UseVisualStyleBackColor = false;
            agregarButton.Click += agregarButton_Click;
            // 
            // TopPanel
            // 
            TopPanel.BackColor = SystemColors.ActiveCaption;
            TopPanel.Controls.Add(administracionLabel);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(200, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(458, 100);
            TopPanel.TabIndex = 2;
            // 
            // administracionLabel
            // 
            administracionLabel.AutoSize = true;
            administracionLabel.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            administracionLabel.Location = new Point(78, 42);
            administracionLabel.Name = "administracionLabel";
            administracionLabel.Size = new Size(328, 29);
            administracionLabel.TabIndex = 0;
            administracionLabel.Text = "Administración de Documentos";
            // 
            // listBoxListadoDocumentos
            // 
            listBoxListadoDocumentos.BackColor = Color.Plum;
            listBoxListadoDocumentos.FormattingEnabled = true;
            listBoxListadoDocumentos.ItemHeight = 19;
            listBoxListadoDocumentos.Items.AddRange(new object[] { "ID: 1 - Parcial1 - PDF - Pablo Girón - 28/10/2023" });
            listBoxListadoDocumentos.Location = new Point(206, 117);
            listBoxListadoDocumentos.Name = "listBoxListadoDocumentos";
            listBoxListadoDocumentos.Size = new Size(322, 327);
            listBoxListadoDocumentos.TabIndex = 3;
            // 
            // salirButton
            // 
            salirButton.BackColor = SystemColors.ActiveCaptionText;
            salirButton.FlatStyle = FlatStyle.Flat;
            salirButton.ForeColor = SystemColors.ButtonFace;
            salirButton.Location = new Point(568, 424);
            salirButton.Name = "salirButton";
            salirButton.Size = new Size(90, 33);
            salirButton.TabIndex = 4;
            salirButton.Text = "Salir";
            salirButton.UseVisualStyleBackColor = false;
            salirButton.Click += salirButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(658, 457);
            Controls.Add(salirButton);
            Controls.Add(listBoxListadoDocumentos);
            Controls.Add(TopPanel);
            Controls.Add(botonesPanel);
            Controls.Add(btnSalir);
            Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            botonesPanel.ResumeLayout(false);
            botonesPanel.PerformLayout();
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSalir;
        private Panel botonesPanel;
        private Panel TopPanel;
        private Label administracionLabel;
        private ListBox listBoxListadoDocumentos;
        private Label nombreDocumentoLabel;
        private Label idLabel;
        private Button editarButton;
        private Button eliminarButton;
        private Button agregarButton;
        private TextBox nombreDocTextBox;
        private TextBox tipoDocTextBox;
        private TextBox ususarioTextBox;
        private TextBox fechaCreacionTextBox;
        private TextBox idTextBox;
        private Label fechaLabel;
        private Label usuarioCreadorLabel;
        private Label tipoDocumentoLabel;
        private Button salirButton;
    }
}