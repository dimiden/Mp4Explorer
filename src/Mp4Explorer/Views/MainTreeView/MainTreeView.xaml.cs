//===============================================================================
// Copyright © 2009 CM Streaming Technologies.
// All rights reserved.
// http://www.cmstream.net
//===============================================================================

using System;
using System.Windows;
using System.Windows.Controls;
using System.Linq;
using Microsoft.Practices.Composite.Events;
using System.IO;
using System.Windows.Input;

namespace Mp4Explorer
{
    /// <summary>
    /// 
    /// </summary>
    public partial class MainTreeView : UserControl, IMainTreeView
    {
        #region Fields

        /// <summary>
        /// 
        /// </summary>
        private TreeViewItem rootNode;

		private MainTreePresenter presenter;

        #endregion

        #region Constructors

        /// <summary>
        /// 
        /// </summary>
        public MainTreeView()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        /// <summary>
        /// 
        /// </summary>
        public TreeViewItem RootNode
        {
            get
            {
                return this.rootNode;
            }
            set
            {
                treeView.Items.Clear();

                this.rootNode = value;

                if (this.rootNode != null)
                {
                    treeView.Items.Add(this.rootNode);
                }
            }
        }

		public TreeView TreeView
		{
			get
			{
				return this.treeView;
			}
		}

		public MainTreePresenter Presenter
		{
			get
			{
				return this.presenter;
			}
			set
			{
				this.presenter = value;
			}
		}

        #endregion

        #region Events

        /// <summary>
        /// 
        /// </summary>
        public event EventHandler<DataEventArgs<TreeViewItem>> NodeSelected = delegate { };

        #endregion

        #region Private methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView_Selected(object sender, RoutedEventArgs e)
        {
            NodeSelected(this, new DataEventArgs<TreeViewItem>(e.Source as TreeViewItem));
        }

        #endregion

		#region Drop & Drop

		private void treeView_DragOver(object sender, DragEventArgs e)
		{
			string[] formats = e.Data.GetFormats();

			if (formats.Contains("FileName") == true)
			{
				e.Effects = DragDropEffects.All;
			}
		}

		private void treeView_Drop(object sender, DragEventArgs e)
		{
			string[] fileNames = (string[])e.Data.GetData(DataFormats.FileDrop, false);

			if (fileNames.Length > 0)
			{
				presenter.OpenFile(fileNames[0]);
			}
		}

		#endregion
	}
}
