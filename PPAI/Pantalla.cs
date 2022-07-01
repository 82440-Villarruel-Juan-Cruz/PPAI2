using PPAI.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI
{
    public partial class Registro : Form
    {
        GestorAdmMantenimiento gestor;
        List<RecursoTecnologico> listaDeRT;
        int indexSeleccionRt;

        public Registro()
        {
            InitializeComponent();

        }
        //Inicializar Ventana
        private void button1_Click(object sender, EventArgs e)
        {

            gestor = new GestorAdmMantenimiento();
            gestor.nuevoMantenimientoCorrectivo();

            nombreCientifico.Text = gestor.getPersonalCientifico().getApellido();
            nombreUsuario.Text = gestor.getUsuario().getUsuario();
            table_title.Visible = true;
            label7.Visible = true;
            label10.Visible = true;
            nombreUsuario.Visible = true;
            nombreCientifico.Visible = true;
            groupBoxRecurso.Visible = true;
            
            tablaRecursos.Visible = true;
            gestor.ObtenerDatosTurno();
            DataTable mostrar = gestor.agruparRTPorTipo();
            if ( mostrar != null)
            {
                if (mostrar.Rows.Count > 0)
                {
                    tablaRecursos.DataSource = mostrar;
                    listaDeRT = gestor.getListaRecursosTecnologicosDisponiles();    
                }
                else
                {
                    MessageBox.Show(String.Format("El Responsable tecnico,{0}, no tiene asociciado ningun Recurso Tecnologico", gestor.getPersonalCientifico().getApellido()));
                }
            }
            else
            {
                MessageBox.Show(String.Format("El Responsable tecnico,{0}, no tiene asociciado ningun Recurso Tecnologico", gestor.getPersonalCientifico().getApellido()));
            }
           

            tablaRecursos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            btn_Ingreso.Visible = false;            
        }

        //Seleccionar una Fila de la tabla
        private void tablaRecursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            DataGridViewRow filaSeleccionada = RowWithValues(e.RowIndex);
            txtTipoRecurso.Text = filaSeleccionada.Cells[0].Value.ToString();
            txtNumero.Text = filaSeleccionada.Cells[1].Value.ToString();
            txtMarca.Text = filaSeleccionada.Cells[2].Value.ToString();
            txtModelo.Text = filaSeleccionada.Cells[3].Value.ToString();
            btnSeleccion.Visible = true;
            indexSeleccionRt = e.RowIndex;
        }

        //Tomar Datos de la fecha y razon del Mantenimiento
        private void btnSeleccionadoMantenimient_Click(object sender, EventArgs e)
        {
            if (txtRazonMantenimiento.Text != "")
            {
                tablaRecursos.DataSource = null;
                DataTable mostrar = gestor.ordenarTurnosPorCientifico();
                gestor.tomarDatosMantenimientoCorrectivo(dateInHabilitacionRecurso.Value, txtRazonMantenimiento.Text);
                gestor.ObtenerDatosTurno();

                if (mostrar != null)
                {
                    if (mostrar.Rows.Count > 0)
                    {
                        tablaRecursos.DataSource = mostrar;
                        table_title.Text = "Recurso Tecnologicos";

                    }
                    else
                    {
                        MessageBox.Show(String.Format("El Recurso Tecnologico,{0}, no tiene asociado ningun Turno Reservado", gestor.getRTselecccionado().getModelo()));
                        tablaRecursos.DataSource = null;

                    }
                }
                else
                {
                    MessageBox.Show(String.Format("El Recurso Tecnologico,{0}, no tiene asociado ningun Turno Reservado", gestor.getRTselecccionado().getModelo()));
                    tablaRecursos.DataSource = null;
                }

                groupBox1.Visible = true;
                btnConfirmacion.Visible = true;
                btn_cancelar.Visible = true;
                tablaRecursos.Enabled = false;
                tablaRecursos.Refresh();
                tablaRecursos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                txtRazonMantenimiento.Focus();
            }
        }

        //Confirmar la seleccion del Recurso Tecnologico
        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            table_title.Text = "Turnos";
            groupBoxRecurso.Enabled = false;
            gbMantenimiento.Visible = true;
            gestor.tomarSeleccionRT(listaDeRT[indexSeleccionRt]);
            

        }

        //Confirmamos el ingreso a Mantenimiento Preventivo
        private void btnConfirmacion_Click(object sender, EventArgs e)
        {           
            btnConfirmacion.Enabled = false;
            tablaRecursos.DataSource = null;       
            tablaRecursos.Visible = true;
            tablaRecursos.DataSource = gestor.crearMantenimientoCorrectivo();
            tablaRecursos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (chkHumo.Checked)
            {
                Form fm = new SeñalHumo();
                fm.ShowDialog();
            //    pictureBox1.Visible = true;
            //    pictureBox1.Image = Image.FromFile(@"D:\Juan\Facultad\OneDrive\DSI\C#\PPAI\PPAI\Resources\Vsib.gif");
            //    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            if (chkEmail.Checked)
            {
                gestor.enviarNotificacionViaMail();
            }

            if (chkWhatsApp.Checked)
            {
                gestor.MandarWhats();
            }
        }

        private DataGridViewRow RowWithValues(int posicion)
        {
            if (posicion > -1)
            {
                List<string> vars = new List<string>();
                var item = (DataGridViewRow)tablaRecursos.Rows[posicion];
                foreach (DataGridViewCell b in item.Cells)
                {
                    vars.Add(b.Value.ToString());
                }
                string[] listita = vars.ToArray();
                DataGridViewRow filas = (DataGridViewRow)tablaRecursos.Rows[0].Clone();
                for (int i = 0; i < listita.Length; i++)
                {
                    filas.Cells[i].Value = listita.GetValue(i);
                }
                return filas;
            }
            else
            {               
                DataGridViewRow filas = (DataGridViewRow)tablaRecursos.Rows[0].Clone();
                for (int i = 0; i < filas.Cells.Count; i++)
                {
                    filas.Cells[i].Value = "" ;
                }
                return filas;
            }

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            btn_Ingreso.Visible = true;
            groupBoxRecurso.Visible = false;
            txtTipoRecurso.Text = null;
            txtNumero.Text = null;
            txtMarca.Text = null;
            txtModelo.Text = null;
            gbMantenimiento.Visible = false;
            groupBox1.Visible = false;
            tablaRecursos.Visible = false;
            tablaRecursos.DataSource = null;
            table_title.Visible = false;
            label7.Visible = false;
            label10.Visible = false;
            nombreCientifico.Text =null;
            nombreUsuario.Text = null;
            nombreCientifico.Visible = false;
            nombreUsuario.Visible = false;

        }
    }
}
