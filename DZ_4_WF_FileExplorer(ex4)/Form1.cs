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

namespace DZ_4_WF_FileExplorer_ex4_
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			addDirsToTree();
		}

		//Первоначальная инициализация директорий
		private void addDirsToTree()
		{
			try
			{
				int index = 0;
				foreach (DriveInfo drive in DriveInfo.GetDrives())
				{
					treeView.Nodes.Add(drive.Name);
					//Проверяю готовность устройств
					try
					{
						string[] directories = Directory.GetDirectories(drive.Name);
						//foreach (string dir in dirs) { Console.WriteLine(dir); }
						foreach (string dir in directories)
						{
							treeView.Nodes[index].Nodes.Add(Path.GetFileName(dir));
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message, $"{drive.Name}");
					}
					index++;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, Text);
			}
		}

		//заполнение ListView
		List<string> fullName = new List<string>();
		private void AddDirectorisToListView(string str)
		{
			fullName.Clear();
			try
			{
				string[] dirs = Directory.GetDirectories(str);
				string[] df = Directory.GetFiles(str);
				int ind = 0;
				foreach (string s in dirs)
				{
					listView.Items.Add(Path.GetFileName(s)).SubItems.Add(Convert.ToString(Directory.GetLastWriteTime(s)));
					listView.Items[ind].SubItems.Add("Папка с файлами");
					fullName.Add(s);
					ind++;
				}
				foreach (string s in df)
				{
					listView.Items.Add(Path.GetFileName(s)).SubItems.Add(Convert.ToString(Directory.GetLastWriteTime(s)));
					listView.Items[ind].SubItems.Add("Файл");
					fullName.Add(s);
					ind++;
				}
			}
			catch
			{
				Exception exception = new Exception();//вылетает при обращении к определенным папкам
			}
		}

		private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
		{
			if (listView.Items.Count > 0)
			{
				listView.Items.Clear();
			}
			//Добавляю в текстовое поле название текущей выбранной ноды
			DirectoryName.Text = treeView.SelectedNode.Text;

			string str = treeView.SelectedNode.FullPath;
			AddDirectorisToListView(str);
		}

		private void listView_DoubleClick(object sender, EventArgs e)
		{
			int index = (sender as System.Windows.Forms.ListView).SelectedItems[0].Index;
			string str = (sender as System.Windows.Forms.ListView).SelectedItems[0].Text;
			DirectoryName.Text = Path.GetFileName(str);
			if (listView.Items.Count > 0)
			{
				listView.Items.Clear();
				AddDirectorisToListView(fullName[index]);

			}
		}

		private void Back_Click(object sender, EventArgs e)
		{
			try
			{
				if (listView.Items.Count > 0) { listView.Items.Clear(); }
				string str = Directory.GetDirectoryRoot(DirectoryName.Text);
				DirectoryName.Text = str;
				AddDirectorisToListView(str);
			}
			catch (Exception ex) { }
		}

		private void Forward_Click(object sender, EventArgs e)
		{
			try
			{
				if (listView.Items.Count > 0) { listView.Items.Clear(); }
				AddDirectorisToListView(DirectoryName.Text);
			}
			catch (Exception ex) { }
		}
	}
}
