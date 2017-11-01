using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace C_mpilador
{
	public partial class MainForm : Form
	{
		bool txt_start_info = false;
		public MainForm()
		{
			InitializeComponent();
			cmbCantidadCodFuente.SelectedIndex = 0;
			cmbExtension.SelectedIndex = 0;
			cmbDirCSC.SelectedIndex = 0;
			txtArchivo2.Hide();
			btnBuscar2.Hide();
			txtArchivo3.Hide();
			btnBuscar3.Hide();
			txtArchivo4.Hide();
			btnBuscar4.Hide();
			txtArchivo5.Hide();
			btnBuscar5.Hide();
			txtArchivo6.Hide();
			btnBuscar6.Hide();
			txtArchivo7.Hide();
			btnBuscar7.Hide();
			txtArchivo8.Hide();
			btnBuscar8.Hide();
		}
		static string buscar(OpenFileDialog file){
			if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				return file.FileName;
			return "";
		}
		
		void BtnBuscar1Click(object sender, EventArgs e)
		{	
			txtArchivo1.Text = buscar(new OpenFileDialog());
		}
		void BtnBuscar2Click(object sender, EventArgs e)
		{
			txtArchivo2.Text = buscar(new OpenFileDialog());
		}
		void BtnBuscar3Click(object sender, EventArgs e)
		{
			txtArchivo3.Text = buscar(new OpenFileDialog());
		}
		void BtnBuscar4Click(object sender, EventArgs e)
		{
			txtArchivo4.Text = buscar(new OpenFileDialog());
		}
		void BtnBuscar5Click(object sender, EventArgs e)
		{
			txtArchivo5.Text = buscar(new OpenFileDialog());
		}
		void BtnBuscar6Click(object sender, EventArgs e)
		{
			txtArchivo6.Text = buscar(new OpenFileDialog());
		}
		void BtnBuscar7Click(object sender, EventArgs e)
		{
			txtArchivo7.Text = buscar(new OpenFileDialog());
		}
		void BtnBuscar8Click(object sender, EventArgs e)
		{
			txtArchivo8.Text = buscar(new OpenFileDialog());
		}
		void CmbCantidadCodFuenteSelectedIndexChanged(object sender, EventArgs e)
		{
			int n = cmbCantidadCodFuente.SelectedIndex;
			if (n > 6){
				txtArchivo8.Show();
				btnBuscar8.Show();
			} else {
				txtArchivo8.Hide();
				btnBuscar8.Hide();}
			if (n > 5){
				txtArchivo7.Show();
				btnBuscar7.Show();
			} else {
				txtArchivo7.Hide();
				btnBuscar7.Hide();}
			if (n > 4){
				txtArchivo6.Show();
				btnBuscar6.Show();
			} else {
				txtArchivo6.Hide();
				btnBuscar6.Hide();}
			if (n > 3){
				txtArchivo5.Show();
				btnBuscar5.Show();
			} else {
				txtArchivo5.Hide();
				btnBuscar5.Hide();}
			if (n > 2){
				txtArchivo4.Show();
				btnBuscar4.Show();
			} else {
				txtArchivo4.Hide();
				btnBuscar4.Hide();}
			if (n > 1){
				txtArchivo3.Show();
				btnBuscar3.Show();
			} else {
				txtArchivo3.Hide();
				btnBuscar3.Hide();}
			if (n > 0){
				txtArchivo2.Show();
				btnBuscar2.Show();
			} else {
				txtArchivo2.Hide();
				btnBuscar2.Hide();}
		}
		void BtnDirCarpetaClick(object sender, EventArgs e)
		{
			FolderBrowserDialog folder = new FolderBrowserDialog();
			if (folder.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				txtDirCarpeta.Text = folder.SelectedPath;
		}
		string calcular_files_cs(){
			int n = 8;
			List<string> cadena = new List<string>();
			string tempString;
			for (int i = 0; i<n; i++)
			{
				tempString = txtArchivo1.Text;
				if (i % n == 0 && tempString != ""){
					cadena.Add(tempString);
					continue;
				}
				tempString = txtArchivo2.Text;
				if (i % n == 1 &&  tempString != ""){ 
					cadena.Add(tempString);
					continue;
				}
				tempString = txtArchivo3.Text;
				if (i % n == 2 &&  tempString != ""){
					cadena.Add(tempString);
					continue;
				}
				tempString = txtArchivo4.Text;
				if (i % n == 3 &&  tempString != ""){
					cadena.Add(tempString);
					continue;
				}
				tempString = txtArchivo5.Text;
				if (i % n == 4 &&  tempString != ""){ 
					cadena.Add(tempString);
					continue;
				}
				tempString = txtArchivo6.Text;
				if (i % n == 5 &&  tempString != ""){
					cadena.Add(tempString);
					continue;
				}
				tempString = txtArchivo7.Text;
				if (i % n == 6 &&  tempString != ""){
					cadena.Add(tempString);
					continue;
				}
				tempString = txtArchivo8.Text;
				if (i % n == 7 &&  tempString != ""){ 
					cadena.Add(tempString);
					continue;
				}
			}
			return string.Join("\" \"", cadena.ToArray());
		}
		int calcular_cases(){
			int n = 8;
			if(cmbExtension.SelectedIndex == 1) return 2;
			string tempString;
			for (int i = 0; i<n; i++)
			{
				tempString = txtArchivo1.Text.ToLower();
				if (i % n == 0 &&  tempString != "" &&  tempString[tempString.Length-1] == 'l') return 1;
				tempString = txtArchivo2.Text.ToLower();
				if (i % n == 1 &&  tempString != "" &&  tempString[tempString.Length-1] == 'l') return 1;
				tempString = txtArchivo3.Text.ToLower();
				if (i % n == 2 &&  tempString != "" &&  tempString[tempString.Length-1] == 'l') return 1;
				tempString = txtArchivo4.Text.ToLower();
				if (i % n == 3 &&  tempString != "" &&  tempString[tempString.Length-1] == 'l') return 1;
				tempString = txtArchivo5.Text.ToLower();
				if (i % n == 4 &&  tempString != "" &&  tempString[tempString.Length-1] == 'l') return 1;
				tempString = txtArchivo6.Text.ToLower();
				if (i % n == 5 &&  tempString != "" &&  tempString[tempString.Length-1] == 'l') return 1;
				tempString = txtArchivo7.Text.ToLower();
				if (i % n == 6 &&  tempString != "" &&  tempString[tempString.Length-1] == 'l') return 1;
				tempString = txtArchivo8.Text.ToLower();
				if (i % n == 7 &&  tempString != "" &&  tempString[tempString.Length-1] == 'l') return 1;
			}
			return 0;
		}
		void BtnCompilarClick(object sender, EventArgs e)
		{
			string name_out = txtArchivoFinal.Text + cmbExtension.Text;
			string dir_out = txtDirCarpeta.Text + @"\" + name_out;
			string csc_dir = cmbDirCSC.Text;
			string files_cs = calcular_files_cs();
			int cases = calcular_cases();
			if(name_out != "" && csc_dir != "" && files_cs != "")
				MessageBox.Show(Compilador.compilar(dir_out, files_cs, cases, csc_dir, txt_start_info),"C#ompilador", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		void CheckBox1CheckedChanged(object sender, EventArgs e)
		{
			txt_start_info = chbMostrarStartInfo.Checked;
		}	
		void txt_drag_enter(DragEventArgs e){
			if(e.Data.GetDataPresent(DataFormats.FileDrop,false))				
				e.Effect = DragDropEffects.All;
		}
		string txt_drag_drop(DragEventArgs e){
			string[] droppedFiles = (string[])e.Data.GetData(DataFormats.FileDrop);
			return string.Join("", droppedFiles);
		}
		void TxtArchivo1DragEnter(object sender, DragEventArgs e)
		{
			txt_drag_enter(e);
		}
		void TxtArchivo1DragDrop(object sender, DragEventArgs e)
		{
			txtArchivo1.Text = txt_drag_drop(e);
		}
		void TxtArchivo2DragEnter(object sender, DragEventArgs e)
		{
			txt_drag_enter(e);
		}
		void TxtArchivo2DragDrop(object sender, DragEventArgs e)
		{
			txtArchivo2.Text = txt_drag_drop(e);
		}
		void TxtArchivo3DragEnter(object sender, DragEventArgs e)
		{
			txt_drag_enter(e);
		}
		void TxtArchivo3DragDrop(object sender, DragEventArgs e)
		{
			txtArchivo3.Text = txt_drag_drop(e);
		}
		void TxtArchivo4DragEnter(object sender, DragEventArgs e)
		{
			txt_drag_enter(e);
		}
		void TxtArchivo4DragDrop(object sender, DragEventArgs e)
		{
			txtArchivo4.Text = txt_drag_drop(e);
		}
		void TxtArchivo5DragEnter(object sender, DragEventArgs e)
		{
			txt_drag_enter(e);
		}
		void TxtArchivo5DragDrop(object sender, DragEventArgs e)
		{
			txtArchivo5.Text = txt_drag_drop(e);
		}
		void TxtArchivo6DragEnter(object sender, DragEventArgs e)
		{
			txt_drag_enter(e);
		}
		void TxtArchivo6DragDrop(object sender, DragEventArgs e)
		{
			txtArchivo6.Text = txt_drag_drop(e);
		}
		void TxtArchivo7DragEnter(object sender, DragEventArgs e)
		{
			txt_drag_enter(e);
		}
		void TxtArchivo7DragDrop(object sender, DragEventArgs e)
		{
			txtArchivo7.Text = txt_drag_drop(e);
		}
		void TxtArchivo8DragEnter(object sender, DragEventArgs e)
		{
			txt_drag_enter(e);
		}
		void TxtArchivo8DragDrop(object sender, DragEventArgs e)
		{
			txtArchivo8.Text = txt_drag_drop(e);
		}
	}
}
