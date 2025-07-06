namespace DeberSem6.Views
{
    partial class FrmUsuarios
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
            panel1 = new Panel();
            btnCancelar = new Button();
            txtCorreo = new TextBox();
            label8 = new Label();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnInsertar = new Button();
            txtCodigoPostal = new TextBox();
            txtDireccion = new TextBox();
            cmbGenero = new ComboBox();
            txtEdad = new TextBox();
            txtApellidos = new TextBox();
            txtNombres = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            lstUsuarios = new ListBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(txtCorreo);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnEditar);
            panel1.Controls.Add(btnInsertar);
            panel1.Controls.Add(txtCodigoPostal);
            panel1.Controls.Add(txtDireccion);
            panel1.Controls.Add(cmbGenero);
            panel1.Controls.Add(txtEdad);
            panel1.Controls.Add(txtApellidos);
            panel1.Controls.Add(txtNombres);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lstUsuarios);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(925, 539);
            panel1.TabIndex = 0;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(165, 105, 189);
            btnCancelar.Font = new Font("Microsoft YaHei UI", 8F);
            btnCancelar.ForeColor = Color.FromArgb(232, 218, 239);
            btnCancelar.Location = new Point(33, 404);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(74, 29);
            btnCancelar.TabIndex = 21;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.FromArgb(210, 180, 222);
            txtCorreo.ForeColor = Color.FromArgb(91, 44, 111);
            txtCorreo.Location = new Point(153, 265);
            txtCorreo.MaxLength = 60;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(359, 28);
            txtCorreo.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(31, 268);
            label8.Name = "label8";
            label8.Size = new Size(62, 21);
            label8.TabIndex = 19;
            label8.Text = "Correo";
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEliminar.BackColor = Color.FromArgb(165, 105, 189);
            btnEliminar.ForeColor = Color.FromArgb(232, 218, 239);
            btnEliminar.Location = new Point(363, 477);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(120, 41);
            btnEliminar.TabIndex = 17;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEditar.BackColor = Color.FromArgb(165, 105, 189);
            btnEditar.ForeColor = Color.FromArgb(232, 218, 239);
            btnEditar.Location = new Point(194, 477);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(120, 41);
            btnEditar.TabIndex = 16;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnInsertar.BackColor = Color.FromArgb(165, 105, 189);
            btnInsertar.ForeColor = Color.FromArgb(232, 218, 239);
            btnInsertar.Location = new Point(33, 477);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(120, 41);
            btnInsertar.TabIndex = 14;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = false;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // txtCodigoPostal
            // 
            txtCodigoPostal.BackColor = Color.FromArgb(210, 180, 222);
            txtCodigoPostal.ForeColor = Color.FromArgb(91, 44, 111);
            txtCodigoPostal.Location = new Point(153, 358);
            txtCodigoPostal.MaxLength = 6;
            txtCodigoPostal.Name = "txtCodigoPostal";
            txtCodigoPostal.Size = new Size(86, 28);
            txtCodigoPostal.TabIndex = 13;
            // 
            // txtDireccion
            // 
            txtDireccion.BackColor = Color.FromArgb(210, 180, 222);
            txtDireccion.ForeColor = Color.FromArgb(91, 44, 111);
            txtDireccion.Location = new Point(153, 311);
            txtDireccion.MaxLength = 60;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(359, 28);
            txtDireccion.TabIndex = 12;
            // 
            // cmbGenero
            // 
            cmbGenero.BackColor = Color.FromArgb(210, 180, 222);
            cmbGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGenero.ForeColor = Color.FromArgb(91, 44, 111);
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Items.AddRange(new object[] { "Masculino", "Femenino", "Otro..." });
            cmbGenero.Location = new Point(153, 215);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(137, 29);
            cmbGenero.TabIndex = 11;
            // 
            // txtEdad
            // 
            txtEdad.BackColor = Color.FromArgb(210, 180, 222);
            txtEdad.ForeColor = Color.FromArgb(91, 44, 111);
            txtEdad.Location = new Point(153, 170);
            txtEdad.MaxLength = 3;
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(86, 28);
            txtEdad.TabIndex = 10;
            // 
            // txtApellidos
            // 
            txtApellidos.BackColor = Color.FromArgb(210, 180, 222);
            txtApellidos.ForeColor = Color.FromArgb(91, 44, 111);
            txtApellidos.Location = new Point(153, 125);
            txtApellidos.MaxLength = 60;
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(359, 28);
            txtApellidos.TabIndex = 9;
            // 
            // txtNombres
            // 
            txtNombres.BackColor = Color.FromArgb(210, 180, 222);
            txtNombres.ForeColor = Color.FromArgb(91, 44, 111);
            txtNombres.Location = new Point(153, 76);
            txtNombres.MaxLength = 60;
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(359, 28);
            txtNombres.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 361);
            label7.Name = "label7";
            label7.Size = new Size(30, 21);
            label7.TabIndex = 7;
            label7.Text = "C.I";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 314);
            label6.Name = "label6";
            label6.Size = new Size(81, 21);
            label6.TabIndex = 6;
            label6.Text = "Dirección";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 218);
            label5.Name = "label5";
            label5.Size = new Size(66, 21);
            label5.TabIndex = 5;
            label5.Text = "Género";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 173);
            label4.Name = "label4";
            label4.Size = new Size(48, 21);
            label4.TabIndex = 4;
            label4.Text = "Edad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 128);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 3;
            label3.Text = "Apellidos";
            // 
            // lstUsuarios
            // 
            lstUsuarios.BackColor = Color.FromArgb(210, 180, 222);
            lstUsuarios.Dock = DockStyle.Right;
            lstUsuarios.ForeColor = Color.FromArgb(91, 44, 111);
            lstUsuarios.FormattingEnabled = true;
            lstUsuarios.HorizontalScrollbar = true;
            lstUsuarios.ItemHeight = 21;
            lstUsuarios.Location = new Point(581, 0);
            lstUsuarios.Name = "lstUsuarios";
            lstUsuarios.ScrollAlwaysVisible = true;
            lstUsuarios.Size = new Size(344, 539);
            lstUsuarios.Sorted = true;
            lstUsuarios.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 79);
            label2.Name = "label2";
            label2.Size = new Size(80, 21);
            label2.TabIndex = 1;
            label2.Text = "Nombres";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 16F);
            label1.Location = new Point(153, 19);
            label1.Name = "label1";
            label1.Size = new Size(249, 30);
            label1.TabIndex = 0;
            label1.Text = "Gestor de Usuarios 1.1";
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(232, 218, 239);
            ClientSize = new Size(925, 539);
            Controls.Add(panel1);
            Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(91, 44, 111);
            Margin = new Padding(4);
            Name = "FrmUsuarios";
            Text = "FrmUsuarios";
            Load += FrmUsuarios_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label3;
        private ListBox lstUsuarios;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtNombres;
        private TextBox txtApellidos;
        private TextBox txtEdad;
        private ComboBox cmbGenero;
        private TextBox txtCodigoPostal;
        private TextBox txtDireccion;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnInsertar;
        private TextBox txtCorreo;
        private Label label8;
        private Button btnCancelar;
    }
}