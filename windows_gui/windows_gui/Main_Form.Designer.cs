namespace windows_gui
{
    partial class Main_Form
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.label_HyperVName = new System.Windows.Forms.Label();
            this.label_HyperVState = new System.Windows.Forms.Label();
            this.button_changeHyperVState = new System.Windows.Forms.Button();
            this.label_VMWareName = new System.Windows.Forms.Label();
            this.label_VMWareState = new System.Windows.Forms.Label();
            this.button_changeVMWareState = new System.Windows.Forms.Button();
            this.groupBox_stateviewer = new System.Windows.Forms.GroupBox();
            this.groupBox_controller = new System.Windows.Forms.GroupBox();
            this.menuStrip_mainmenu = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenu_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_About = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_Close = new System.Windows.Forms.ToolStripMenuItem();
            this.button_flashstate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox_stateviewer.SuspendLayout();
            this.groupBox_controller.SuspendLayout();
            this.menuStrip_mainmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_HyperVName
            // 
            resources.ApplyResources(this.label_HyperVName, "label_HyperVName");
            this.label_HyperVName.Name = "label_HyperVName";
            // 
            // label_HyperVState
            // 
            resources.ApplyResources(this.label_HyperVState, "label_HyperVState");
            this.label_HyperVState.Name = "label_HyperVState";
            // 
            // button_changeHyperVState
            // 
            resources.ApplyResources(this.button_changeHyperVState, "button_changeHyperVState");
            this.button_changeHyperVState.Name = "button_changeHyperVState";
            this.button_changeHyperVState.UseVisualStyleBackColor = true;
            // 
            // label_VMWareName
            // 
            resources.ApplyResources(this.label_VMWareName, "label_VMWareName");
            this.label_VMWareName.Name = "label_VMWareName";
            // 
            // label_VMWareState
            // 
            resources.ApplyResources(this.label_VMWareState, "label_VMWareState");
            this.label_VMWareState.Name = "label_VMWareState";
            // 
            // button_changeVMWareState
            // 
            resources.ApplyResources(this.button_changeVMWareState, "button_changeVMWareState");
            this.button_changeVMWareState.Name = "button_changeVMWareState";
            this.button_changeVMWareState.UseVisualStyleBackColor = true;
            // 
            // groupBox_stateviewer
            // 
            this.groupBox_stateviewer.Controls.Add(this.label_HyperVName);
            this.groupBox_stateviewer.Controls.Add(this.label_HyperVState);
            this.groupBox_stateviewer.Controls.Add(this.label_VMWareState);
            this.groupBox_stateviewer.Controls.Add(this.label_VMWareName);
            resources.ApplyResources(this.groupBox_stateviewer, "groupBox_stateviewer");
            this.groupBox_stateviewer.Name = "groupBox_stateviewer";
            this.groupBox_stateviewer.TabStop = false;
            // 
            // groupBox_controller
            // 
            this.groupBox_controller.Controls.Add(this.button_changeHyperVState);
            this.groupBox_controller.Controls.Add(this.button_changeVMWareState);
            resources.ApplyResources(this.groupBox_controller, "groupBox_controller");
            this.groupBox_controller.Name = "groupBox_controller";
            this.groupBox_controller.TabStop = false;
            // 
            // menuStrip_mainmenu
            // 
            this.menuStrip_mainmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenu_File,
            this.ToolStripMenu_Help});
            resources.ApplyResources(this.menuStrip_mainmenu, "menuStrip_mainmenu");
            this.menuStrip_mainmenu.Name = "menuStrip_mainmenu";
            // 
            // ToolStripMenu_File
            // 
            this.ToolStripMenu_File.Name = "ToolStripMenu_File";
            resources.ApplyResources(this.ToolStripMenu_File, "ToolStripMenu_File");
            // 
            // ToolStripMenu_Help
            // 
            this.ToolStripMenu_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_About,
            this.toolStripSeparator1,
            this.ToolStripMenuItem_Close});
            this.ToolStripMenu_Help.Name = "ToolStripMenu_Help";
            resources.ApplyResources(this.ToolStripMenu_Help, "ToolStripMenu_Help");
            // 
            // ToolStripMenuItem_About
            // 
            this.ToolStripMenuItem_About.Name = "ToolStripMenuItem_About";
            resources.ApplyResources(this.ToolStripMenuItem_About, "ToolStripMenuItem_About");
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // ToolStripMenuItem_Close
            // 
            this.ToolStripMenuItem_Close.Name = "ToolStripMenuItem_Close";
            resources.ApplyResources(this.ToolStripMenuItem_Close, "ToolStripMenuItem_Close");
            // 
            // button_flashstate
            // 
            resources.ApplyResources(this.button_flashstate, "button_flashstate");
            this.button_flashstate.Name = "button_flashstate";
            this.button_flashstate.UseVisualStyleBackColor = true;
            this.button_flashstate.Click += new System.EventHandler(this.button_flashstate_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Main_Form
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_flashstate);
            this.Controls.Add(this.groupBox_controller);
            this.Controls.Add(this.groupBox_stateviewer);
            this.Controls.Add(this.menuStrip_mainmenu);
            this.MainMenuStrip = this.menuStrip_mainmenu;
            this.MaximizeBox = false;
            this.Name = "Main_Form";
            this.groupBox_stateviewer.ResumeLayout(false);
            this.groupBox_stateviewer.PerformLayout();
            this.groupBox_controller.ResumeLayout(false);
            this.menuStrip_mainmenu.ResumeLayout(false);
            this.menuStrip_mainmenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_HyperVName;
        private System.Windows.Forms.Label label_HyperVState;
        private System.Windows.Forms.Button button_changeHyperVState;
        private System.Windows.Forms.Label label_VMWareName;
        private System.Windows.Forms.Label label_VMWareState;
        private System.Windows.Forms.Button button_changeVMWareState;
        private System.Windows.Forms.GroupBox groupBox_stateviewer;
        private System.Windows.Forms.GroupBox groupBox_controller;
        private System.Windows.Forms.MenuStrip menuStrip_mainmenu;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_File;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_Help;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_About;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Close;
        private System.Windows.Forms.Button button_flashstate;
        private System.Windows.Forms.Button button1;
    }
}

