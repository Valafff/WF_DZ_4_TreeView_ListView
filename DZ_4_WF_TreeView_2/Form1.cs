using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ_4_WF_TreeView_2
{
	public partial class Form_MyTreeViewExplorer : Form
	{
		DirectoryInfo currentDirectory;
		public Form_MyTreeViewExplorer()
		{
			InitializeComponent();
			//Создаенм объект для работы с каталогами
			currentDirectory = new DirectoryInfo(@"C://");
		}
		//Form1_........Load(object sender, EventArgs e) - стандартная функция выполняющаяся при создании формы 
		private void Form_MyTreeViewExplorer_Load(object sender, EventArgs e)
		{
			//Создаю массив объектов внутренних поддиректорий и получаю данные о поддерикториях из текущего каталога
			DirectoryInfo[] subDirectories = currentDirectory.GetDirectories();
			//Добавляю в ноду treeview название директорий
			foreach (DirectoryInfo subDirectory in subDirectories)
			{
				treeView_Explorer.Nodes.Add(subDirectory.Name);
			}
		}
		void loadDirectories(object sender, TreeNodeMouseClickEventArgs e)
		{
			currentDirectory = new DirectoryInfo($"C:/{e.Node.FullPath}");
			DirectoryInfo[] subDirectories = currentDirectory.GetDirectories();
			//Очищаю данные в открываемой ноде
			e.Node.Nodes.Clear();
			foreach (var item in subDirectories)
			{
				e.Node.Nodes.Add(item.Name);
			}
		}

		//Обработка стандартного события - одинарный клик мышкой по ноде
		private void treeView_Explorer_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			try
			{
				loadDirectories(sender, e);
				//Переключает узел дерева либо в развернутое либо в свернутое состояние
				e.Node.Toggle();
			}
			catch (Exception)
			{
				MessageBox.Show($"Ошибка чтения каталога {e.Node.FullPath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}




		}
	}
}
