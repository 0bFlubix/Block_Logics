namespace VSIX_EventBlocks
{
    using System;
    using System.Runtime.InteropServices;
    using Microsoft.VisualStudio.Shell;

    /// <summary>
    /// This class implements the tool window exposed by this package and hosts a user control.
    /// </summary>
    /// <remarks>
    /// In Visual Studio tool windows are composed of a frame (implemented by the shell) and a pane,
    /// usually implemented by the package implementer.
    /// <para>
    /// This class derives from the ToolWindowPane class provided from the MPF in order to use its
    /// implementation of the IVsUIElementPane interface.
    /// </para>
    /// </remarks>
    [Guid("edb31a4e-511f-41ed-b807-43d5f2a35656")]
    public class Window_EventMap : ToolWindowPane
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Window_EventMap"/> class.
        /// </summary>
        public Window_EventMap() : base(null)
        {
            this.Caption = "Window_EventMap";

            // This is the user control hosted by the tool window; Note that, even if this class implements IDisposable,
            // we are not calling Dispose on this object. This is because ToolWindowPane calls Dispose on
            // the object returned by the Content property.
            this.Content = new Window_EventMapControl();
        }
    }
}
