using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace Anakena_2017
{
	public class FormPrincipal : Form
	{
		private IContainer components = null;

		private MenuStrip menuStrip1;

		private ToolStripMenuItem controlCalidadToolStripMenuItem;

        private ToolStripMenuItem recepcionConPelonToolStripMenuItem;

        private ToolStripMenuItem salirToolStripMenuItem;

		private ToolStripMenuItem aboutToolStripMenuItem;

		private Label label1;

		public Label lbl_poductor;

		public ToolStripMenuItem administrarToolStripMenuItem;

		public ToolStripMenuItem administrarEvaluacionToolStripMenuItem;

		public ToolStripMenuItem administrarUsuariosToolStripMenuItem;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem procesoNSCToolStripMenuItem;
        private ToolStripMenuItem partidoMecanicoToolStripMenuItem;
        private ToolStripMenuItem preselecciónToolStripMenuItem;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private ToolStripMenuItem extracciónDeDatosToolStripMenuItem;
        private ToolStripMenuItem admistrarPatidoMecanicoToolStripMenuItem;
        private ToolStripMenuItem administrarPreseleccionToolStripMenuItem;
        private ToolStripMenuItem informeProductorToolStripMenuItem;
        private ToolStripMenuItem imagenesToolStripMenuItem;
        private ToolStripMenuItem extraccionDeDatosToolStripMenuItem;
        private ToolStripMenuItem procesoDeSecadoToolStripMenuItem;
        private ToolStripMenuItem totalesToolStripMenuItem;
        private ToolStripMenuItem filtradoToolStripMenuItem;
        private ToolStripMenuItem salaProcesosToolStripMenuItem;
        private ToolStripMenuItem cToolStripMenuItem;
        private ToolStripMenuItem rToolStripMenuItem;
        private ToolStripMenuItem generalToolStripMenuItem;
        private ToolStripMenuItem inventarioBinsToolStripMenuItem;
        private ToolStripMenuItem inventarioToolStripMenuItem;
        private ToolStripMenuItem emisionDeGuiaToolStripMenuItem;
        private ToolStripMenuItem ordenDeCompraToolStripMenuItem;
        private ToolStripMenuItem ordenesDeCompraToolStripMenuItem;
        private ToolStripMenuItem proveedoresToolStripMenuItem;
        private ToolStripMenuItem administracionGuiaToolStripMenuItem;
        private ToolStripMenuItem devolucionesToolStripMenuItem;
        string nivel = "";
        public FormPrincipal(string pass)
        {
            nivel = pass;
            this.InitializeComponent();
            if (pass == "2")
            {

                administrarPreseleccionToolStripMenuItem.Enabled = false;
                admistrarPatidoMecanicoToolStripMenuItem.Enabled = false;
                openToolStripMenuItem.Enabled = false;
                saveToolStripMenuItem.Enabled = false;
                saveAsToolStripMenuItem.Enabled = false;
                extracciónDeDatosToolStripMenuItem.Enabled = false;
                informeProductorToolStripMenuItem.Enabled = false;
                totalesToolStripMenuItem.Enabled = false;
                filtradoToolStripMenuItem.Enabled = false;
                salaProcesosToolStripMenuItem.Enabled = false;


            }
            else
            if (pass == "1")
            {
                this.administrarToolStripMenuItem.Enabled = true;
                this.administrarUsuariosToolStripMenuItem.Enabled = true;
                this.administrarEvaluacionToolStripMenuItem.Enabled = true;
                this.extraccionDeDatosToolStripMenuItem.Enabled = true;
            }
            else
            if (pass == "3")
            {
                fileToolStripMenuItem.Visible = false;
                procesoNSCToolStripMenuItem.Visible = false;
                newToolStripMenuItem.Enabled = false;
                partidoMecanicoToolStripMenuItem.Enabled = false;
                preselecciónToolStripMenuItem.Enabled = false;
                totalesToolStripMenuItem.Enabled = false;
                filtradoToolStripMenuItem.Enabled = false;
                salaProcesosToolStripMenuItem.Enabled = false;

            }
            else
            if (pass == "4")
            {
                fileToolStripMenuItem.Visible = false;
                procesoNSCToolStripMenuItem.Visible = false;
                newToolStripMenuItem.Enabled = false;
                partidoMecanicoToolStripMenuItem.Enabled = false;
                preselecciónToolStripMenuItem.Enabled = false;
                totalesToolStripMenuItem.Enabled = false;
                filtradoToolStripMenuItem.Enabled = false;
                salaProcesosToolStripMenuItem.Visible = false;
                imagenesToolStripMenuItem.Visible = false;
                procesoDeSecadoToolStripMenuItem.Visible = false;
                ordenDeCompraToolStripMenuItem.Visible= false;


            }
        }

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
		}

		private void administrarEvaluacionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//(new FormEvaluacion()).ShowDialog();
		}

		private void administrarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormRecepcionMain formRecepcionMain = new FormRecepcionMain();
			formRecepcionMain.Btn_Agregar.Visible = false;
			formRecepcionMain.ShowDialog();
		}

		private void administrarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			(new FormUsuarioMain()).ShowDialog();
		}

		protected override void Dispose(bool disposing)
		{
			if ((!disposing ? false : this.components != null))
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void extraccionDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			(new FormExtraccionBDD()).ShowDialog();
		}

		private void FormPrincipal_Load(object sender, EventArgs e)
		{
		}

		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informeProductorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extracciónDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesoNSCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partidoMecanicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preselecciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.admistrarPatidoMecanicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarPreseleccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imagenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesoDeSecadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtradoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salaProcesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioBinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emisionDeGuiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administracionGuiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenDeCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenesDeCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlCalidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recepcionConPelonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarEvaluacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extraccionDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_poductor = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.devolucionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.procesoNSCToolStripMenuItem,
            this.imagenesToolStripMenuItem,
            this.procesoDeSecadoToolStripMenuItem,
            this.salaProcesosToolStripMenuItem,
            this.inventarioBinsToolStripMenuItem,
            this.ordenDeCompraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1276, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.informeProductorToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.extracciónDeDatosToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.fileToolStripMenuItem.Text = "Programa Pelon";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.newToolStripMenuItem.Text = "Recepción con pelon";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.openToolStripMenuItem.Text = "&Administrar Recepción";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // informeProductorToolStripMenuItem
            // 
            this.informeProductorToolStripMenuItem.Name = "informeProductorToolStripMenuItem";
            this.informeProductorToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.informeProductorToolStripMenuItem.Text = "Informe Productor";
            this.informeProductorToolStripMenuItem.Click += new System.EventHandler(this.informeProductorToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.saveToolStripMenuItem.Text = "Administrar Evaluación";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.saveAsToolStripMenuItem.Text = "Administrar Usuarios";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // extracciónDeDatosToolStripMenuItem
            // 
            this.extracciónDeDatosToolStripMenuItem.Name = "extracciónDeDatosToolStripMenuItem";
            this.extracciónDeDatosToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.extracciónDeDatosToolStripMenuItem.Text = "Extracción de datos";
            this.extracciónDeDatosToolStripMenuItem.Click += new System.EventHandler(this.extracciónDeDatosToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(193, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.exitToolStripMenuItem.Text = "Salir";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // procesoNSCToolStripMenuItem
            // 
            this.procesoNSCToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.partidoMecanicoToolStripMenuItem,
            this.preselecciónToolStripMenuItem,
            this.admistrarPatidoMecanicoToolStripMenuItem,
            this.administrarPreseleccionToolStripMenuItem});
            this.procesoNSCToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.procesoNSCToolStripMenuItem.Name = "procesoNSCToolStripMenuItem";
            this.procesoNSCToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.procesoNSCToolStripMenuItem.Text = "Proceso NSC";
            // 
            // partidoMecanicoToolStripMenuItem
            // 
            this.partidoMecanicoToolStripMenuItem.Name = "partidoMecanicoToolStripMenuItem";
            this.partidoMecanicoToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.partidoMecanicoToolStripMenuItem.Text = "Partido Mecanico";
            this.partidoMecanicoToolStripMenuItem.Click += new System.EventHandler(this.partidoMecanicoToolStripMenuItem_Click);
            // 
            // preselecciónToolStripMenuItem
            // 
            this.preselecciónToolStripMenuItem.Name = "preselecciónToolStripMenuItem";
            this.preselecciónToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.preselecciónToolStripMenuItem.Text = "Preselección";
            this.preselecciónToolStripMenuItem.Click += new System.EventHandler(this.preselecciónToolStripMenuItem_Click);
            // 
            // admistrarPatidoMecanicoToolStripMenuItem
            // 
            this.admistrarPatidoMecanicoToolStripMenuItem.Name = "admistrarPatidoMecanicoToolStripMenuItem";
            this.admistrarPatidoMecanicoToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.admistrarPatidoMecanicoToolStripMenuItem.Text = "Admistrar Patido Mecánico";
            this.admistrarPatidoMecanicoToolStripMenuItem.Click += new System.EventHandler(this.admistrarPatidoMecanicoToolStripMenuItem_Click);
            // 
            // administrarPreseleccionToolStripMenuItem
            // 
            this.administrarPreseleccionToolStripMenuItem.Name = "administrarPreseleccionToolStripMenuItem";
            this.administrarPreseleccionToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.administrarPreseleccionToolStripMenuItem.Text = "Administrar Preselección";
            this.administrarPreseleccionToolStripMenuItem.Click += new System.EventHandler(this.administrarPreseleccionToolStripMenuItem_Click);
            // 
            // imagenesToolStripMenuItem
            // 
            this.imagenesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.imagenesToolStripMenuItem.Name = "imagenesToolStripMenuItem";
            this.imagenesToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.imagenesToolStripMenuItem.Text = "Imagenes";
            this.imagenesToolStripMenuItem.Click += new System.EventHandler(this.imagenesToolStripMenuItem_Click);
            // 
            // procesoDeSecadoToolStripMenuItem
            // 
            this.procesoDeSecadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.totalesToolStripMenuItem,
            this.filtradoToolStripMenuItem});
            this.procesoDeSecadoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.procesoDeSecadoToolStripMenuItem.Name = "procesoDeSecadoToolStripMenuItem";
            this.procesoDeSecadoToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.procesoDeSecadoToolStripMenuItem.Text = "Proceso de secado";
            // 
            // totalesToolStripMenuItem
            // 
            this.totalesToolStripMenuItem.Name = "totalesToolStripMenuItem";
            this.totalesToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.totalesToolStripMenuItem.Text = "Totales";
            this.totalesToolStripMenuItem.Click += new System.EventHandler(this.totalesToolStripMenuItem_Click);
            // 
            // filtradoToolStripMenuItem
            // 
            this.filtradoToolStripMenuItem.Name = "filtradoToolStripMenuItem";
            this.filtradoToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.filtradoToolStripMenuItem.Text = "Filtrado";
            this.filtradoToolStripMenuItem.Click += new System.EventHandler(this.filtradoToolStripMenuItem_Click);
            // 
            // salaProcesosToolStripMenuItem
            // 
            this.salaProcesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cToolStripMenuItem});
            this.salaProcesosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.salaProcesosToolStripMenuItem.Name = "salaProcesosToolStripMenuItem";
            this.salaProcesosToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.salaProcesosToolStripMenuItem.Text = "Sala Procesos";
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rToolStripMenuItem,
            this.generalToolStripMenuItem});
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.cToolStripMenuItem.Text = "Control SP";
            // 
            // rToolStripMenuItem
            // 
            this.rToolStripMenuItem.Name = "rToolStripMenuItem";
            this.rToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.rToolStripMenuItem.Text = "Resumen Diario";
            this.rToolStripMenuItem.Click += new System.EventHandler(this.rToolStripMenuItem_Click);
            // 
            // generalToolStripMenuItem
            // 
            this.generalToolStripMenuItem.Name = "generalToolStripMenuItem";
            this.generalToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.generalToolStripMenuItem.Text = "General";
            this.generalToolStripMenuItem.Click += new System.EventHandler(this.generalToolStripMenuItem_Click);
            // 
            // inventarioBinsToolStripMenuItem
            // 
            this.inventarioBinsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventarioToolStripMenuItem,
            this.emisionDeGuiaToolStripMenuItem,
            this.administracionGuiaToolStripMenuItem,
            this.devolucionesToolStripMenuItem});
            this.inventarioBinsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.inventarioBinsToolStripMenuItem.Name = "inventarioBinsToolStripMenuItem";
            this.inventarioBinsToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.inventarioBinsToolStripMenuItem.Text = "Inventario Bins";
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            this.inventarioToolStripMenuItem.Click += new System.EventHandler(this.inventarioToolStripMenuItem_Click);
            // 
            // emisionDeGuiaToolStripMenuItem
            // 
            this.emisionDeGuiaToolStripMenuItem.Name = "emisionDeGuiaToolStripMenuItem";
            this.emisionDeGuiaToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.emisionDeGuiaToolStripMenuItem.Text = "Emision de guia";
            this.emisionDeGuiaToolStripMenuItem.Click += new System.EventHandler(this.emisionDeGuiaToolStripMenuItem_Click);
            // 
            // administracionGuiaToolStripMenuItem
            // 
            this.administracionGuiaToolStripMenuItem.Name = "administracionGuiaToolStripMenuItem";
            this.administracionGuiaToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.administracionGuiaToolStripMenuItem.Text = "Administracion guia";
            this.administracionGuiaToolStripMenuItem.Click += new System.EventHandler(this.administracionGuiaToolStripMenuItem_Click);
            // 
            // ordenDeCompraToolStripMenuItem
            // 
            this.ordenDeCompraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordenesDeCompraToolStripMenuItem,
            this.proveedoresToolStripMenuItem});
            this.ordenDeCompraToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ordenDeCompraToolStripMenuItem.Name = "ordenDeCompraToolStripMenuItem";
            this.ordenDeCompraToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.ordenDeCompraToolStripMenuItem.Text = "Orden de Compra";
            this.ordenDeCompraToolStripMenuItem.Click += new System.EventHandler(this.ordenDeCompraToolStripMenuItem_Click);
            // 
            // ordenesDeCompraToolStripMenuItem
            // 
            this.ordenesDeCompraToolStripMenuItem.Name = "ordenesDeCompraToolStripMenuItem";
            this.ordenesDeCompraToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.ordenesDeCompraToolStripMenuItem.Text = "Ordenes de compra";
            this.ordenesDeCompraToolStripMenuItem.Click += new System.EventHandler(this.ordenesDeCompraToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // controlCalidadToolStripMenuItem
            // 
            this.controlCalidadToolStripMenuItem.Name = "controlCalidadToolStripMenuItem";
            this.controlCalidadToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.controlCalidadToolStripMenuItem.Text = "Control Calidad";
            // 
            // recepcionConPelonToolStripMenuItem
            // 
            this.recepcionConPelonToolStripMenuItem.Name = "recepcionConPelonToolStripMenuItem";
            this.recepcionConPelonToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.recepcionConPelonToolStripMenuItem.Text = "Recepcion con pelon";
            this.recepcionConPelonToolStripMenuItem.Click += new System.EventHandler(this.recepcionConPelonToolStripMenuItem_Click);
            // 
            // administrarToolStripMenuItem
            // 
            this.administrarToolStripMenuItem.Name = "administrarToolStripMenuItem";
            this.administrarToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.administrarToolStripMenuItem.Text = "Administrar Recepcion";
            this.administrarToolStripMenuItem.Click += new System.EventHandler(this.administrarToolStripMenuItem_Click);
            // 
            // administrarEvaluacionToolStripMenuItem
            // 
            this.administrarEvaluacionToolStripMenuItem.Name = "administrarEvaluacionToolStripMenuItem";
            this.administrarEvaluacionToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.administrarEvaluacionToolStripMenuItem.Text = "Administrar Evaluacion";
            this.administrarEvaluacionToolStripMenuItem.Click += new System.EventHandler(this.administrarEvaluacionToolStripMenuItem_Click);
            // 
            // administrarUsuariosToolStripMenuItem
            // 
            this.administrarUsuariosToolStripMenuItem.Name = "administrarUsuariosToolStripMenuItem";
            this.administrarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.administrarUsuariosToolStripMenuItem.Text = "Administrar Usuarios";
            this.administrarUsuariosToolStripMenuItem.Click += new System.EventHandler(this.administrarUsuariosToolStripMenuItem_Click);
            // 
            // extraccionDeDatosToolStripMenuItem
            // 
            this.extraccionDeDatosToolStripMenuItem.Name = "extraccionDeDatosToolStripMenuItem";
            this.extraccionDeDatosToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.extraccionDeDatosToolStripMenuItem.Text = "Extraccion de datos";
            this.extraccionDeDatosToolStripMenuItem.Click += new System.EventHandler(this.extraccionDeDatosToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(953, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Conectado como : ";
            // 
            // lbl_poductor
            // 
            this.lbl_poductor.AutoSize = true;
            this.lbl_poductor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_poductor.Location = new System.Drawing.Point(1086, 46);
            this.lbl_poductor.Name = "lbl_poductor";
            this.lbl_poductor.Size = new System.Drawing.Size(51, 16);
            this.lbl_poductor.TabIndex = 4;
            this.lbl_poductor.Text = "label2";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 749);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1276, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(588, 292);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(121, 131);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(512, 156);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // devolucionesToolStripMenuItem
            // 
            this.devolucionesToolStripMenuItem.Name = "devolucionesToolStripMenuItem";
            this.devolucionesToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.devolucionesToolStripMenuItem.Text = "Devoluciones";
            this.devolucionesToolStripMenuItem.Click += new System.EventHandler(this.devolucionesToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1276, 773);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_poductor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private void recepcionConPelonToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormRecepcionMain formRecepcionMain = new FormRecepcionMain()
			{
				usuario = this.lbl_poductor.Text
			};
			formRecepcionMain.ShowDialog();
		}
		private void salirToolStripMenuItem_Click(object sender, EventArgs e)
		{
			System.Windows.Forms.DialogResult dialogResult = MessageBox.Show("Esta seguro que desea salir?", "Anakena", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (dialogResult != System.Windows.Forms.DialogResult.Cancel)
			{
				if (dialogResult == System.Windows.Forms.DialogResult.Yes)
				{
					base.Close();
				}
			}
		}
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRecepcionMain s = new FormRecepcionMain();
            s.usuario = lbl_poductor.Text;
            s.ShowDialog();
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUsuarioMain s = new FormUsuarioMain();
            s.ShowDialog();
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEvaluacion s = new FormEvaluacion("serr");
            s.CmbVariedad_traer();
            s.CmbVariedad.SelectedIndex = 6;
            s.ShowDialog();
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRecepcionMain formRecepcionMain = new FormRecepcionMain();
            formRecepcionMain.Btn_Agregar.Visible = false;
            formRecepcionMain.ShowDialog();
        }
        private void partidoMecanicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
          (new FormAnalisisCalidadPMM()).ShowDialog();
          
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Esta seguro que desea salir", "Anakena", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case System.Windows.Forms.DialogResult.Yes:
                    {
                        base.Close();
                        break;
                    }
            }
        }

        private void extracciónDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new FormExtraccionBDD()).ShowDialog();
        }

        private void preselecciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAnalisisCalidadPreseleccion s = new FormAnalisisCalidadPreseleccion();
            s.ShowDialog();
        }

        private void administrarPreseleccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAnalisisCalidadPreseleccion s = new FormAnalisisCalidadPreseleccion();
            s.Btn_Agregar.Visible = false;
            s.ShowDialog();
        }

        private void admistrarPatidoMecanicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAnalisisCalidadPMM s = new FormAnalisisCalidadPMM();
            s.Btn_Agregar.Visible = false;
            s.ShowDialog();
        }

        private void informeProductorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRecepcionMain s = new FormRecepcionMain();
            s.Btn_Agregar.Visible = false;
            s.acceso = 1;
           s.ShowDialog();        
        }

        private void imagenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Recepcion_Nueces.Form_Traer_Imagines s = new Recepcion_Nueces.Form_Traer_Imagines();
            if(nivel == "3")
            {
                s.button1.Visible = false;
            }
            s.ShowDialog();
        }

        private void totalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Recepcion_Nueces.FormResumen_Secado s = new Recepcion_Nueces.FormResumen_Secado();
            s.ShowDialog();
        }

        private void filtradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Recepcion_Nueces.FormFiltro_Secado s = new Recepcion_Nueces.FormFiltro_Secado();
            s.ShowDialog();
        }
        private void generalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Recepcion_Nueces.FormTurno_Seleccion_Embalaje s = new Recepcion_Nueces.FormTurno_Seleccion_Embalaje();
            s.ShowDialog();
        }

        private void rToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Recepcion_Nueces.FormResumen_Embalaje s = new Recepcion_Nueces.FormResumen_Embalaje();
            s.ShowDialog();
        }

        private void emisionDeGuiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEmisionGuia guia = new FormEmisionGuia(lbl_poductor.Text);
            guia.ShowDialog();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ordenDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void ordenesDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Recepcion_Nueces.FormTraerOrdenesCompra s = new Recepcion_Nueces.FormTraerOrdenesCompra();
            s.ShowDialog();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Recepcion_Nueces.FormProveedores s = new Recepcion_Nueces.FormProveedores();
            s.ShowDialog();
        }

        private void administracionGuiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdministracionGuia s = new FormAdministracionGuia();
            s.ShowDialog();
        }

        private void devolucionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDevoluciones d = new FormDevoluciones();
            d.ShowDialog();
        }
    }
}