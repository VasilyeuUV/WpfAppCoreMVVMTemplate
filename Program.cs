using System;
using System.Collections.Generic;
using System.Text;

namespace WpfAppCoreMVVMTemplate
{
    public static class Program
    {
        /// <summary>
        /// Application Entry Point.
        /// </summary>        
        //[System.Diagnostics.DebuggerNonUserCodeAttribute()]
        //[System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.STAThreadAttribute()]
        public static void Main()
        {
            var app = new App();
            app.InitializeComponent();
            app.Run();
        }
    }
}
