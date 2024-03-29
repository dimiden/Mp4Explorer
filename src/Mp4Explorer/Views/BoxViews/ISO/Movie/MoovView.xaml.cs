﻿//===============================================================================
// Copyright © 2009 CM Streaming Technologies.
// All rights reserved.
// http://www.cmstream.net
//===============================================================================

using System.Windows.Controls;
using CMStream.Mp4;

namespace Mp4Explorer
{
    /// <summary>
    /// 
    /// </summary>
    [BoxViewType(typeof(Mp4MoovBox))]
    public partial class MoovView : UserControl, IBoxView
    {
        #region Fields

        /// <summary>
        /// 
        /// </summary>
        private Mp4MoovBox box;

        #endregion

        #region Constructors

        /// <summary>
        /// 
        /// </summary>
        public MoovView()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        /// <summary>
        /// 
        /// </summary>
        public Mp4Box Box
        {
            get
            {
                return box;
            }
            set
            {
                box = (Mp4MoovBox)value;

                BoxViewUtil.AddHeader(grid, "Movie Box");
                BoxViewUtil.AddField(grid, "Size:", box.Size);
            }
        }

        #endregion
    }
}
