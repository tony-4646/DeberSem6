using DeberSem6.Controllers;
using DeberSem6.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeberSem6.Views
{
    public partial class FrmUsuarios : Form
    {
        private readonly UsuarioController _usuarioController;
        public FrmUsuarios()
        {
            InitializeComponent();
            txtEdad.KeyPress += (s, e) => { e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); };
            txtCodigoPostal.KeyPress += (s, e) => { e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); };
            _usuarioController = new UsuarioController();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            llenarLista();
        }
        public void llenarLista()
        {
            lstUsuarios.DataSource = _usuarioController.todos();
            lstUsuarios.DisplayMember = "Nombres";
            lstUsuarios.ValueMember = "Id";
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            var res = "";

                if ((string.IsNullOrEmpty(txtNombres.Text) ||
                    string.IsNullOrWhiteSpace(txtApellidos.Text) ||
                    string.IsNullOrWhiteSpace(txtEdad.Text) ||
                    string.IsNullOrWhiteSpace(cmbGenero.Text)||
                    string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                    string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                    string.IsNullOrWhiteSpace(txtCodigoPostal.Text)))
                {
                    MessageBox.Show("Los campos no deben estar vacíos");
                    return;
                }
                else
                { 
                    var usuario = new UsuarioModel
                    {
                        Nombres = txtNombres.Text,
                        Apellidos = txtApellidos.Text,
                        Edad = Convert.ToInt32(txtEdad.Text),
                        Genero = cmbGenero.Text,
                        Correo = txtCorreo.Text,
                        Direccion = txtDireccion.Text,
                        CodigoPostal = txtCodigoPostal.Text
                    };
                    if (lstUsuarios.Enabled == true)
                    {
                        res = _usuarioController.insertar(usuario);
                    }
                    else
                    {
                        usuario.Id = Convert.ToInt32(lstUsuarios.SelectedValue);
                        res = _usuarioController.actualizar(usuario);
                    }
                }

            if (res == "ok")
            {
                MessageBox.Show("Se guardó con éxito");
                llenarLista();
                limpiacajas();
            }
            else
            {
                MessageBox.Show($"Error al guardar {res}");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lstUsuarios.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un usuario de la lista");
                return;
            }
            else
            {
                lstUsuarios.Enabled = false;
                btnEliminar.Enabled = false;
                var res = _usuarioController.uno(Convert.ToInt32(lstUsuarios.SelectedValue));
                txtNombres.Text = res.Nombres;
                txtApellidos.Text = res.Apellidos;
                txtEdad.Text = res.Edad.ToString();
                cmbGenero.Text = res.Genero;
                txtCorreo.Text = res.Correo;
                txtDireccion.Text = res.Direccion;
                txtCodigoPostal.Text = res.CodigoPostal;
            }
        }

        public void limpiacajas()
        {
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtEdad.Text = "";
            cmbGenero.SelectedIndex= -1;
            txtCorreo.Text = "";
            txtDireccion.Text = "";
            txtCodigoPostal.Text = "";
            lstUsuarios.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var res = "";
            if (lstUsuarios.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un usuario de la lista");
                return;
            }
            var respuesta = MessageBox.Show("¿Desea eliminar al usuario?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                res = _usuarioController.eliminar(Convert.ToInt32(lstUsuarios.SelectedValue));
            }
            if (res == "ok")
            {
                MessageBox.Show("Se eliminó con éxito");
                llenarLista();
                limpiacajas();
            }
            else
            {
                MessageBox.Show($"Error al guardar {res}");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiacajas();
            btnEliminar.Enabled = true;
        }
    }
}
