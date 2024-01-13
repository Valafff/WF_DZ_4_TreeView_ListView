namespace DZ_4_WF_TreeView_2
{
	partial class Form_MyTreeViewExplorer
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
			this.treeView_Explorer = new System.Windows.Forms.TreeView();
			this.SuspendLayout();
			// 
			// treeView_Explorer
			// 
			this.treeView_Explorer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeView_Explorer.Location = new System.Drawing.Point(0, 0);
			this.treeView_Explorer.Name = "treeView_Explorer";
			this.treeView_Explorer.Size = new System.Drawing.Size(800, 450);
			this.treeView_Explorer.TabIndex = 0;
			this.treeView_Explorer.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_Explorer_NodeMouseClick);
			// 
			// Form_MyTreeViewExplorer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.treeView_Explorer);
			this.Name = "Form_MyTreeViewExplorer";
			this.Text = "TreeView_Проводник_2(динамическая подгрузка открываемых node)";
			this.Load += new System.EventHandler(this.Form_MyTreeViewExplorer_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TreeView treeView_Explorer;
	}
}

