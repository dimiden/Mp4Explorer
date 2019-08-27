//===============================================================================
// Copyright © 2009 CM Streaming Technologies.
// All rights reserved.
// http://www.cmstream.net
//===============================================================================

using Microsoft.Practices.Composite.Presentation.Commands;

namespace Mp4Explorer
{
    /// <summary>
    /// 
    /// </summary>
    public class GlobalCommandsProxy
    {
        /// <summary>
        /// 
        /// </summary>
        public virtual CompositeCommand OpenCommand
        {
            get
            {
                return GlobalCommands.OpenCommand;
            }
        }

		public virtual CompositeCommand RefreshCommand
		{
			get
			{
				return GlobalCommands.RefreshCommand;
			}
		}

		public virtual CompositeCommand ExpandAllCommand
		{
			get
			{
				return GlobalCommands.ExpandAllCommand;
			}
		}
    }
}
