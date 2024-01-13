namespace DZ_4_WF_FileExplorer_ex4_
{
	partial class Form1
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
			this.Back = new System.Windows.Forms.Button();
			this.Forward = new System.Windows.Forms.Button();
			this.DirectoryName = new System.Windows.Forms.TextBox();
			this.listView = new System.Windows.Forms.ListView();
			this.NameFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.LastChange = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.TypeFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.treeView = new System.Windows.Forms.TreeView();
			this.MainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.ButtonsSplitContainer = new System.Windows.Forms.SplitContainer();
			this.MainTableLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ButtonsSplitContainer)).BeginInit();
			this.ButtonsSplitContainer.Panel1.SuspendLayout();
			this.ButtonsSplitContainer.Panel2.SuspendLayout();
			this.ButtonsSplitContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// Back
			// 
			this.Back.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Back.Location = new System.Drawing.Point(0, 0);
			this.Back.Name = "Back";
			this.Back.Size = new System.Drawing.Size(128, 25);
			this.Back.TabIndex = 0;
			this.Back.Text = "<<";
			this.Back.UseVisualStyleBackColor = true;
			this.Back.Click += new System.EventHandler(this.Back_Click);
			// 
			// Forward
			// 
			this.Forward.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Forward.Location = new System.Drawing.Point(0, 0);
			this.Forward.Name = "Forward";
			this.Forward.Size = new System.Drawing.Size(160, 25);
			this.Forward.TabIndex = 1;
			this.Forward.Text = ">>";
			this.Forward.UseVisualStyleBackColor = true;
			this.Forward.Click += new System.EventHandler(this.Forward_Click);
			// 
			// DirectoryName
			// 
			this.DirectoryName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DirectoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.DirectoryName.Location = new System.Drawing.Point(301, 3);
			this.DirectoryName.Name = "DirectoryName";
			this.DirectoryName.Size = new System.Drawing.Size(518, 22);
			this.DirectoryName.TabIndex = 3;
			// 
			// listView
			// 
			this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameFile,
            this.LastChange,
            this.TypeFile});
			this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listView.HideSelection = false;
			this.listView.Location = new System.Drawing.Point(301, 34);
			this.listView.MultiSelect = false;
			this.listView.Name = "listView";
			this.listView.Size = new System.Drawing.Size(518, 474);
			this.listView.TabIndex = 0;
			this.listView.UseCompatibleStateImageBehavior = false;
			this.listView.View = System.Windows.Forms.View.Details;
			this.listView.DoubleClick += new System.EventHandler(this.listView_DoubleClick);
			// 
			// NameFile
			// 
			this.NameFile.Text = "Имя";
			this.NameFile.Width = 219;
			// 
			// LastChange
			// 
			this.LastChange.Text = "Дата изменения";
			this.LastChange.Width = 145;
			// 
			// TypeFile
			// 
			this.TypeFile.Text = "Тип";
			this.TypeFile.Width = 150;
			// 
			// treeView
			// 
			this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeView.Location = new System.Drawing.Point(3, 34);
			this.treeView.Name = "treeView";
			this.treeView.Size = new System.Drawing.Size(292, 474);
			this.treeView.TabIndex = 0;
			this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
			// 
			// MainTableLayoutPanel
			// 
			this.MainTableLayoutPanel.ColumnCount = 2;
			this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.2862F));
			this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.7138F));
			this.MainTableLayoutPanel.Controls.Add(this.treeView, 0, 1);
			this.MainTableLayoutPanel.Controls.Add(this.listView, 1, 1);
			this.MainTableLayoutPanel.Controls.Add(this.DirectoryName, 1, 0);
			this.MainTableLayoutPanel.Controls.Add(this.ButtonsSplitContainer, 0, 0);
			this.MainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.MainTableLayoutPanel.Name = "MainTableLayoutPanel";
			this.MainTableLayoutPanel.RowCount = 2;
			this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.217617F));
			this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.78239F));
			this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.MainTableLayoutPanel.Size = new System.Drawing.Size(822, 511);
			this.MainTableLayoutPanel.TabIndex = 4;
			// 
			// ButtonsSplitContainer
			// 
			this.ButtonsSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ButtonsSplitContainer.Location = new System.Drawing.Point(3, 3);
			this.ButtonsSplitContainer.Name = "ButtonsSplitContainer";
			// 
			// ButtonsSplitContainer.Panel1
			// 
			this.ButtonsSplitContainer.Panel1.Controls.Add(this.Back);
			// 
			// ButtonsSplitContainer.Panel2
			// 
			this.ButtonsSplitContainer.Panel2.Controls.Add(this.Forward);
			this.ButtonsSplitContainer.Size = new System.Drawing.Size(292, 25);
			this.ButtonsSplitContainer.SplitterDistance = 128;
			this.ButtonsSplitContainer.TabIndex = 4;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(822, 511);
			this.Controls.Add(this.MainTableLayoutPanel);
			this.Name = "Form1";
			this.Text = "Проводник";
			this.MainTableLayoutPanel.ResumeLayout(false);
			this.MainTableLayoutPanel.PerformLayout();
			this.ButtonsSplitContainer.Panel1.ResumeLayout(false);
			this.ButtonsSplitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ButtonsSplitContainer)).EndInit();
			this.ButtonsSplitContainer.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button Back;
		private System.Windows.Forms.Button Forward;
		private System.Windows.Forms.TextBox DirectoryName;
		private System.Windows.Forms.ListView listView;
		private System.Windows.Forms.ColumnHeader NameFile;
		private System.Windows.Forms.ColumnHeader LastChange;
		private System.Windows.Forms.ColumnHeader TypeFile;
		private System.Windows.Forms.TreeView treeView;
		private System.Windows.Forms.TableLayoutPanel MainTableLayoutPanel;
		private System.Windows.Forms.SplitContainer ButtonsSplitContainer;
	}
}

