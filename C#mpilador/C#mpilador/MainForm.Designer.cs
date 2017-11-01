/*
 * Created by SharpDevelop.
 * User: Cristian
 * Date: 02/08/2017
 * Time: 06:13 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace C_mpilador
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txtArchivoFinal;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbExtension;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabConfigAvanzadas;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TabPage tabMenu;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cmbCantidadCodFuente;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtArchivo1;
		private System.Windows.Forms.Button btnBuscar1;
		private System.Windows.Forms.Button btnCompilar;
		private System.Windows.Forms.TextBox txtArchivo8;
		private System.Windows.Forms.Button btnBuscar8;
		private System.Windows.Forms.TextBox txtArchivo7;
		private System.Windows.Forms.Button btnBuscar7;
		private System.Windows.Forms.TextBox txtArchivo6;
		private System.Windows.Forms.Button btnBuscar6;
		private System.Windows.Forms.TextBox txtArchivo5;
		private System.Windows.Forms.Button btnBuscar5;
		private System.Windows.Forms.TextBox txtArchivo4;
		private System.Windows.Forms.Button btnBuscar4;
		private System.Windows.Forms.TextBox txtArchivo3;
		private System.Windows.Forms.Button btnBuscar3;
		private System.Windows.Forms.TextBox txtArchivo2;
		private System.Windows.Forms.Button btnBuscar2;
		private System.Windows.Forms.Button btnDirCarpeta;
		private System.Windows.Forms.TextBox txtDirCarpeta;
		private System.Windows.Forms.ComboBox cmbDirCSC;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.CheckBox chbMostrarStartInfo;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.txtArchivoFinal = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbExtension = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabMenu = new System.Windows.Forms.TabPage();
			this.label6 = new System.Windows.Forms.Label();
			this.cmbCantidadCodFuente = new System.Windows.Forms.ComboBox();
			this.txtDirCarpeta = new System.Windows.Forms.TextBox();
			this.btnDirCarpeta = new System.Windows.Forms.Button();
			this.txtArchivo8 = new System.Windows.Forms.TextBox();
			this.btnBuscar8 = new System.Windows.Forms.Button();
			this.txtArchivo7 = new System.Windows.Forms.TextBox();
			this.btnBuscar7 = new System.Windows.Forms.Button();
			this.txtArchivo6 = new System.Windows.Forms.TextBox();
			this.btnBuscar6 = new System.Windows.Forms.Button();
			this.txtArchivo5 = new System.Windows.Forms.TextBox();
			this.btnBuscar5 = new System.Windows.Forms.Button();
			this.txtArchivo4 = new System.Windows.Forms.TextBox();
			this.btnBuscar4 = new System.Windows.Forms.Button();
			this.txtArchivo3 = new System.Windows.Forms.TextBox();
			this.btnBuscar3 = new System.Windows.Forms.Button();
			this.txtArchivo2 = new System.Windows.Forms.TextBox();
			this.btnBuscar2 = new System.Windows.Forms.Button();
			this.txtArchivo1 = new System.Windows.Forms.TextBox();
			this.btnBuscar1 = new System.Windows.Forms.Button();
			this.btnCompilar = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tabConfigAvanzadas = new System.Windows.Forms.TabPage();
			this.chbMostrarStartInfo = new System.Windows.Forms.CheckBox();
			this.cmbDirCSC = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tabControl.SuspendLayout();
			this.tabMenu.SuspendLayout();
			this.tabConfigAvanzadas.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtArchivoFinal
			// 
			this.txtArchivoFinal.Location = new System.Drawing.Point(19, 34);
			this.txtArchivoFinal.Name = "txtArchivoFinal";
			this.txtArchivoFinal.Size = new System.Drawing.Size(208, 20);
			this.txtArchivoFinal.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(235, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Extensión";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cmbExtension
			// 
			this.cmbExtension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbExtension.FormattingEnabled = true;
			this.cmbExtension.Items.AddRange(new object[] {
			".exe",
			".dll"});
			this.cmbExtension.Location = new System.Drawing.Point(235, 34);
			this.cmbExtension.Name = "cmbExtension";
			this.cmbExtension.Size = new System.Drawing.Size(75, 21);
			this.cmbExtension.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(14, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(224, 45);
			this.label2.TabIndex = 3;
			this.label2.Text = "Nombre del archivo final";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabMenu);
			this.tabControl.Controls.Add(this.tabConfigAvanzadas);
			this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl.Location = new System.Drawing.Point(0, 0);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(570, 262);
			this.tabControl.TabIndex = 0;
			// 
			// tabMenu
			// 
			this.tabMenu.BackColor = System.Drawing.Color.LightSeaGreen;
			this.tabMenu.Controls.Add(this.label6);
			this.tabMenu.Controls.Add(this.cmbCantidadCodFuente);
			this.tabMenu.Controls.Add(this.txtDirCarpeta);
			this.tabMenu.Controls.Add(this.btnDirCarpeta);
			this.tabMenu.Controls.Add(this.txtArchivo8);
			this.tabMenu.Controls.Add(this.btnBuscar8);
			this.tabMenu.Controls.Add(this.txtArchivo7);
			this.tabMenu.Controls.Add(this.btnBuscar7);
			this.tabMenu.Controls.Add(this.txtArchivo6);
			this.tabMenu.Controls.Add(this.btnBuscar6);
			this.tabMenu.Controls.Add(this.txtArchivo5);
			this.tabMenu.Controls.Add(this.btnBuscar5);
			this.tabMenu.Controls.Add(this.txtArchivo4);
			this.tabMenu.Controls.Add(this.btnBuscar4);
			this.tabMenu.Controls.Add(this.txtArchivo3);
			this.tabMenu.Controls.Add(this.btnBuscar3);
			this.tabMenu.Controls.Add(this.txtArchivo2);
			this.tabMenu.Controls.Add(this.btnBuscar2);
			this.tabMenu.Controls.Add(this.txtArchivo1);
			this.tabMenu.Controls.Add(this.btnBuscar1);
			this.tabMenu.Controls.Add(this.btnCompilar);
			this.tabMenu.Controls.Add(this.txtArchivoFinal);
			this.tabMenu.Controls.Add(this.cmbExtension);
			this.tabMenu.Controls.Add(this.label2);
			this.tabMenu.Controls.Add(this.label1);
			this.tabMenu.Controls.Add(this.label5);
			this.tabMenu.Controls.Add(this.label4);
			this.tabMenu.Location = new System.Drawing.Point(4, 22);
			this.tabMenu.Name = "tabMenu";
			this.tabMenu.Padding = new System.Windows.Forms.Padding(3);
			this.tabMenu.Size = new System.Drawing.Size(562, 236);
			this.tabMenu.TabIndex = 0;
			this.tabMenu.Text = "Menú Principal";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(34, 57);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(213, 23);
			this.label6.TabIndex = 26;
			this.label6.Text = "Carpeta donde se guardará";
			// 
			// cmbCantidadCodFuente
			// 
			this.cmbCantidadCodFuente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCantidadCodFuente.FormattingEnabled = true;
			this.cmbCantidadCodFuente.Items.AddRange(new object[] {
			"1",
			"2",
			"3",
			"4",
			"5",
			"6",
			"7",
			"8"});
			this.cmbCantidadCodFuente.Location = new System.Drawing.Point(262, 120);
			this.cmbCantidadCodFuente.Name = "cmbCantidadCodFuente";
			this.cmbCantidadCodFuente.Size = new System.Drawing.Size(42, 21);
			this.cmbCantidadCodFuente.TabIndex = 4;
			this.cmbCantidadCodFuente.SelectedIndexChanged += new System.EventHandler(this.CmbCantidadCodFuenteSelectedIndexChanged);
			// 
			// txtDirCarpeta
			// 
			this.txtDirCarpeta.Location = new System.Drawing.Point(19, 81);
			this.txtDirCarpeta.Name = "txtDirCarpeta";
			this.txtDirCarpeta.Size = new System.Drawing.Size(208, 20);
			this.txtDirCarpeta.TabIndex = 2;
			// 
			// btnDirCarpeta
			// 
			this.btnDirCarpeta.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDirCarpeta.Location = new System.Drawing.Point(235, 79);
			this.btnDirCarpeta.Name = "btnDirCarpeta";
			this.btnDirCarpeta.Size = new System.Drawing.Size(75, 23);
			this.btnDirCarpeta.TabIndex = 3;
			this.btnDirCarpeta.Text = "Buscar";
			this.btnDirCarpeta.UseVisualStyleBackColor = true;
			this.btnDirCarpeta.Click += new System.EventHandler(this.BtnDirCarpetaClick);
			// 
			// txtArchivo8
			// 
			this.txtArchivo8.Location = new System.Drawing.Point(320, 208);
			this.txtArchivo8.Name = "txtArchivo8";
			this.txtArchivo8.Size = new System.Drawing.Size(142, 20);
			this.txtArchivo8.TabIndex = 19;
			this.txtArchivo8.DragDrop += new System.Windows.Forms.DragEventHandler(this.TxtArchivo8DragDrop);
			this.txtArchivo8.DragEnter += new System.Windows.Forms.DragEventHandler(this.TxtArchivo8DragEnter);
			// 
			// btnBuscar8
			// 
			this.btnBuscar8.Location = new System.Drawing.Point(468, 205);
			this.btnBuscar8.Name = "btnBuscar8";
			this.btnBuscar8.Size = new System.Drawing.Size(88, 24);
			this.btnBuscar8.TabIndex = 20;
			this.btnBuscar8.Text = "Buscar Archivo";
			this.btnBuscar8.UseVisualStyleBackColor = true;
			this.btnBuscar8.Click += new System.EventHandler(this.BtnBuscar8Click);
			// 
			// txtArchivo7
			// 
			this.txtArchivo7.Location = new System.Drawing.Point(320, 182);
			this.txtArchivo7.Name = "txtArchivo7";
			this.txtArchivo7.Size = new System.Drawing.Size(142, 20);
			this.txtArchivo7.TabIndex = 17;
			this.txtArchivo7.DragDrop += new System.Windows.Forms.DragEventHandler(this.TxtArchivo7DragDrop);
			this.txtArchivo7.DragEnter += new System.Windows.Forms.DragEventHandler(this.TxtArchivo7DragEnter);
			// 
			// btnBuscar7
			// 
			this.btnBuscar7.Location = new System.Drawing.Point(468, 179);
			this.btnBuscar7.Name = "btnBuscar7";
			this.btnBuscar7.Size = new System.Drawing.Size(88, 24);
			this.btnBuscar7.TabIndex = 18;
			this.btnBuscar7.Text = "Buscar Archivo";
			this.btnBuscar7.UseVisualStyleBackColor = true;
			this.btnBuscar7.Click += new System.EventHandler(this.BtnBuscar7Click);
			// 
			// txtArchivo6
			// 
			this.txtArchivo6.Location = new System.Drawing.Point(320, 156);
			this.txtArchivo6.Name = "txtArchivo6";
			this.txtArchivo6.Size = new System.Drawing.Size(142, 20);
			this.txtArchivo6.TabIndex = 15;
			this.txtArchivo6.DragDrop += new System.Windows.Forms.DragEventHandler(this.TxtArchivo6DragDrop);
			this.txtArchivo6.DragEnter += new System.Windows.Forms.DragEventHandler(this.TxtArchivo6DragEnter);
			// 
			// btnBuscar6
			// 
			this.btnBuscar6.Location = new System.Drawing.Point(468, 153);
			this.btnBuscar6.Name = "btnBuscar6";
			this.btnBuscar6.Size = new System.Drawing.Size(88, 24);
			this.btnBuscar6.TabIndex = 16;
			this.btnBuscar6.Text = "Buscar Archivo";
			this.btnBuscar6.UseVisualStyleBackColor = true;
			this.btnBuscar6.Click += new System.EventHandler(this.BtnBuscar6Click);
			// 
			// txtArchivo5
			// 
			this.txtArchivo5.Location = new System.Drawing.Point(320, 130);
			this.txtArchivo5.Name = "txtArchivo5";
			this.txtArchivo5.Size = new System.Drawing.Size(142, 20);
			this.txtArchivo5.TabIndex = 13;
			this.txtArchivo5.DragDrop += new System.Windows.Forms.DragEventHandler(this.TxtArchivo5DragDrop);
			this.txtArchivo5.DragEnter += new System.Windows.Forms.DragEventHandler(this.TxtArchivo5DragEnter);
			// 
			// btnBuscar5
			// 
			this.btnBuscar5.Location = new System.Drawing.Point(468, 127);
			this.btnBuscar5.Name = "btnBuscar5";
			this.btnBuscar5.Size = new System.Drawing.Size(88, 24);
			this.btnBuscar5.TabIndex = 14;
			this.btnBuscar5.Text = "Buscar Archivo";
			this.btnBuscar5.UseVisualStyleBackColor = true;
			this.btnBuscar5.Click += new System.EventHandler(this.BtnBuscar5Click);
			// 
			// txtArchivo4
			// 
			this.txtArchivo4.Location = new System.Drawing.Point(320, 104);
			this.txtArchivo4.Name = "txtArchivo4";
			this.txtArchivo4.Size = new System.Drawing.Size(142, 20);
			this.txtArchivo4.TabIndex = 11;
			this.txtArchivo4.DragDrop += new System.Windows.Forms.DragEventHandler(this.TxtArchivo4DragDrop);
			this.txtArchivo4.DragEnter += new System.Windows.Forms.DragEventHandler(this.TxtArchivo4DragEnter);
			// 
			// btnBuscar4
			// 
			this.btnBuscar4.Location = new System.Drawing.Point(468, 101);
			this.btnBuscar4.Name = "btnBuscar4";
			this.btnBuscar4.Size = new System.Drawing.Size(88, 24);
			this.btnBuscar4.TabIndex = 12;
			this.btnBuscar4.Text = "Buscar Archivo";
			this.btnBuscar4.UseVisualStyleBackColor = true;
			this.btnBuscar4.Click += new System.EventHandler(this.BtnBuscar4Click);
			// 
			// txtArchivo3
			// 
			this.txtArchivo3.Location = new System.Drawing.Point(320, 78);
			this.txtArchivo3.Name = "txtArchivo3";
			this.txtArchivo3.Size = new System.Drawing.Size(142, 20);
			this.txtArchivo3.TabIndex = 9;
			this.txtArchivo3.DragDrop += new System.Windows.Forms.DragEventHandler(this.TxtArchivo3DragDrop);
			this.txtArchivo3.DragEnter += new System.Windows.Forms.DragEventHandler(this.TxtArchivo3DragEnter);
			// 
			// btnBuscar3
			// 
			this.btnBuscar3.Location = new System.Drawing.Point(468, 76);
			this.btnBuscar3.Name = "btnBuscar3";
			this.btnBuscar3.Size = new System.Drawing.Size(89, 23);
			this.btnBuscar3.TabIndex = 10;
			this.btnBuscar3.Text = "Buscar Archivo";
			this.btnBuscar3.UseVisualStyleBackColor = true;
			this.btnBuscar3.Click += new System.EventHandler(this.BtnBuscar3Click);
			// 
			// txtArchivo2
			// 
			this.txtArchivo2.Location = new System.Drawing.Point(320, 52);
			this.txtArchivo2.Name = "txtArchivo2";
			this.txtArchivo2.Size = new System.Drawing.Size(142, 20);
			this.txtArchivo2.TabIndex = 7;
			this.txtArchivo2.DragDrop += new System.Windows.Forms.DragEventHandler(this.TxtArchivo2DragDrop);
			this.txtArchivo2.DragEnter += new System.Windows.Forms.DragEventHandler(this.TxtArchivo2DragEnter);
			// 
			// btnBuscar2
			// 
			this.btnBuscar2.Location = new System.Drawing.Point(468, 50);
			this.btnBuscar2.Name = "btnBuscar2";
			this.btnBuscar2.Size = new System.Drawing.Size(89, 23);
			this.btnBuscar2.TabIndex = 8;
			this.btnBuscar2.Text = "Buscar Archivo";
			this.btnBuscar2.UseVisualStyleBackColor = true;
			this.btnBuscar2.Click += new System.EventHandler(this.BtnBuscar2Click);
			// 
			// txtArchivo1
			// 
			this.txtArchivo1.AllowDrop = true;
			this.txtArchivo1.Location = new System.Drawing.Point(320, 26);
			this.txtArchivo1.Name = "txtArchivo1";
			this.txtArchivo1.Size = new System.Drawing.Size(142, 20);
			this.txtArchivo1.TabIndex = 5;
			this.txtArchivo1.Text = "Suelte su archivo aquí o -->";
			this.txtArchivo1.DragDrop += new System.Windows.Forms.DragEventHandler(this.TxtArchivo1DragDrop);
			this.txtArchivo1.DragEnter += new System.Windows.Forms.DragEventHandler(this.TxtArchivo1DragEnter);
			// 
			// btnBuscar1
			// 
			this.btnBuscar1.Location = new System.Drawing.Point(468, 24);
			this.btnBuscar1.Name = "btnBuscar1";
			this.btnBuscar1.Size = new System.Drawing.Size(89, 23);
			this.btnBuscar1.TabIndex = 6;
			this.btnBuscar1.Text = "Buscar Archivo";
			this.btnBuscar1.UseVisualStyleBackColor = true;
			this.btnBuscar1.Click += new System.EventHandler(this.BtnBuscar1Click);
			// 
			// btnCompilar
			// 
			this.btnCompilar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCompilar.Location = new System.Drawing.Point(8, 156);
			this.btnCompilar.Name = "btnCompilar";
			this.btnCompilar.Size = new System.Drawing.Size(296, 72);
			this.btnCompilar.TabIndex = 21;
			this.btnCompilar.Text = "Compilar";
			this.btnCompilar.UseVisualStyleBackColor = true;
			this.btnCompilar.Click += new System.EventHandler(this.BtnCompilarClick);
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(8, 120);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(248, 30);
			this.label5.TabIndex = 9;
			this.label5.Text = "Número de archivos Código Fuente a usar";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(320, 3);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(198, 23);
			this.label4.TabIndex = 7;
			this.label4.Text = "Archivos de Código Fuente";
			// 
			// tabConfigAvanzadas
			// 
			this.tabConfigAvanzadas.BackColor = System.Drawing.Color.LightSeaGreen;
			this.tabConfigAvanzadas.Controls.Add(this.chbMostrarStartInfo);
			this.tabConfigAvanzadas.Controls.Add(this.cmbDirCSC);
			this.tabConfigAvanzadas.Controls.Add(this.label3);
			this.tabConfigAvanzadas.Location = new System.Drawing.Point(4, 22);
			this.tabConfigAvanzadas.Name = "tabConfigAvanzadas";
			this.tabConfigAvanzadas.Padding = new System.Windows.Forms.Padding(3);
			this.tabConfigAvanzadas.Size = new System.Drawing.Size(562, 236);
			this.tabConfigAvanzadas.TabIndex = 1;
			this.tabConfigAvanzadas.Text = "Config. Avanzadas";
			// 
			// chbMostrarStartInfo
			// 
			this.chbMostrarStartInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chbMostrarStartInfo.Location = new System.Drawing.Point(189, 33);
			this.chbMostrarStartInfo.Name = "chbMostrarStartInfo";
			this.chbMostrarStartInfo.Size = new System.Drawing.Size(231, 24);
			this.chbMostrarStartInfo.TabIndex = 3;
			this.chbMostrarStartInfo.Text = "Mostrar StartInfo.Arguments";
			this.chbMostrarStartInfo.UseVisualStyleBackColor = true;
			this.chbMostrarStartInfo.CheckedChanged += new System.EventHandler(this.CheckBox1CheckedChanged);
			// 
			// cmbDirCSC
			// 
			this.cmbDirCSC.FormattingEnabled = true;
			this.cmbDirCSC.Items.AddRange(new object[] {
			"C:\\Windows\\Microsoft.NET\\Framework\\v4.0.30319",
			"C:\\Windows\\Microsoft.NET\\Framework\\v3.5",
			"C:\\Windows\\Microsoft.NET\\Framework\\v2.0.50727",
			"C:\\Windows\\winsxs\\x86_netfx35linq-csharp_31bf3856ad364e35_6.1.7601.17514_none_193" +
				"318f5726bf1d7",
			"C:\\Windows\\winsxs\\x86_netfx-csharp_compiler_csc_b03f5f7f11d50a3a_6.1.7600.16385_n" +
				"one_d2fff1dae966863c"});
			this.cmbDirCSC.Location = new System.Drawing.Point(189, 6);
			this.cmbDirCSC.Name = "cmbDirCSC";
			this.cmbDirCSC.Size = new System.Drawing.Size(365, 21);
			this.cmbDirCSC.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(0, 4);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(191, 23);
			this.label3.TabIndex = 0;
			this.label3.Text = "Direcciones de \"csc.exe\"";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(570, 262);
			this.Controls.Add(this.tabControl);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "C#mpilador";
			this.tabControl.ResumeLayout(false);
			this.tabMenu.ResumeLayout(false);
			this.tabMenu.PerformLayout();
			this.tabConfigAvanzadas.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
