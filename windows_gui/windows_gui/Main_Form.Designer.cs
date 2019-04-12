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
            this.label_HyperVStateName = new System.Windows.Forms.Label();
            this.label_HyperVState = new System.Windows.Forms.Label();
            this.button_StartHyperVService = new System.Windows.Forms.Button();
            this.label_VMWareStateName = new System.Windows.Forms.Label();
            this.label_VMWareState = new System.Windows.Forms.Label();
            this.button_StartVMWareService = new System.Windows.Forms.Button();
            this.groupBox_stateviewer = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_VMWareStart = new System.Windows.Forms.Label();
            this.label_VMWareStartName = new System.Windows.Forms.Label();
            this.label_HyperVStart = new System.Windows.Forms.Label();
            this.label_HyperVStartName = new System.Windows.Forms.Label();
            this.groupBox_controller = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_operatorlist = new System.Windows.Forms.TableLayoutPanel();
            this.button_ActiveVMWare = new System.Windows.Forms.Button();
            this.button_ActiveHyperV = new System.Windows.Forms.Button();
            this.menuStrip_mainmenu = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenu_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_About = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_Close = new System.Windows.Forms.ToolStripMenuItem();
            this.button_flashstate = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.groupBox_stateviewer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox_controller.SuspendLayout();
            this.tableLayoutPanel_operatorlist.SuspendLayout();
            this.menuStrip_mainmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_HyperVStateName
            // 
            resources.ApplyResources(this.label_HyperVStateName, "label_HyperVStateName");
            this.label_HyperVStateName.Name = "label_HyperVStateName";
            // 
            // label_HyperVState
            // 
            resources.ApplyResources(this.label_HyperVState, "label_HyperVState");
            this.label_HyperVState.Name = "label_HyperVState";
            // 
            // button_StartHyperVService
            // 
            resources.ApplyResources(this.button_StartHyperVService, "button_StartHyperVService");
            this.button_StartHyperVService.Name = "button_StartHyperVService";
            this.button_StartHyperVService.UseVisualStyleBackColor = true;
            // 
            // label_VMWareStateName
            // 
            resources.ApplyResources(this.label_VMWareStateName, "label_VMWareStateName");
            this.label_VMWareStateName.Name = "label_VMWareStateName";
            // 
            // label_VMWareState
            // 
            resources.ApplyResources(this.label_VMWareState, "label_VMWareState");
            this.label_VMWareState.Name = "label_VMWareState";
            // 
            // button_StartVMWareService
            // 
            resources.ApplyResources(this.button_StartVMWareService, "button_StartVMWareService");
            this.button_StartVMWareService.Name = "button_StartVMWareService";
            this.button_StartVMWareService.UseVisualStyleBackColor = true;
            // 
            // groupBox_stateviewer
            // 
            this.groupBox_stateviewer.Controls.Add(this.tableLayoutPanel1);
            resources.ApplyResources(this.groupBox_stateviewer, "groupBox_stateviewer");
            this.groupBox_stateviewer.Name = "groupBox_stateviewer";
            this.groupBox_stateviewer.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.label_VMWareStateName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_VMWareStart, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label_VMWareStartName, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_HyperVStart, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_HyperVStartName, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label_VMWareState, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_HyperVState, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_HyperVStateName, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // label_VMWareStart
            // 
            resources.ApplyResources(this.label_VMWareStart, "label_VMWareStart");
            this.label_VMWareStart.Name = "label_VMWareStart";
            // 
            // label_VMWareStartName
            // 
            resources.ApplyResources(this.label_VMWareStartName, "label_VMWareStartName");
            this.label_VMWareStartName.Name = "label_VMWareStartName";
            // 
            // label_HyperVStart
            // 
            resources.ApplyResources(this.label_HyperVStart, "label_HyperVStart");
            this.label_HyperVStart.Name = "label_HyperVStart";
            // 
            // label_HyperVStartName
            // 
            resources.ApplyResources(this.label_HyperVStartName, "label_HyperVStartName");
            this.label_HyperVStartName.Name = "label_HyperVStartName";
            // 
            // groupBox_controller
            // 
            this.groupBox_controller.Controls.Add(this.tableLayoutPanel_operatorlist);
            resources.ApplyResources(this.groupBox_controller, "groupBox_controller");
            this.groupBox_controller.Name = "groupBox_controller";
            this.groupBox_controller.TabStop = false;
            // 
            // tableLayoutPanel_operatorlist
            // 
            resources.ApplyResources(this.tableLayoutPanel_operatorlist, "tableLayoutPanel_operatorlist");
            this.tableLayoutPanel_operatorlist.Controls.Add(this.button_ActiveVMWare, 0, 3);
            this.tableLayoutPanel_operatorlist.Controls.Add(this.button_StartHyperVService, 0, 0);
            this.tableLayoutPanel_operatorlist.Controls.Add(this.button_StartVMWareService, 0, 2);
            this.tableLayoutPanel_operatorlist.Controls.Add(this.button_ActiveHyperV, 0, 1);
            this.tableLayoutPanel_operatorlist.Name = "tableLayoutPanel_operatorlist";
            // 
            // button_ActiveVMWare
            // 
            resources.ApplyResources(this.button_ActiveVMWare, "button_ActiveVMWare");
            this.button_ActiveVMWare.Name = "button_ActiveVMWare";
            this.button_ActiveVMWare.UseVisualStyleBackColor = true;
            // 
            // button_ActiveHyperV
            // 
            resources.ApplyResources(this.button_ActiveHyperV, "button_ActiveHyperV");
            this.button_ActiveHyperV.Name = "button_ActiveHyperV";
            this.button_ActiveHyperV.UseVisualStyleBackColor = true;
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
            // button_exit
            // 
            resources.ApplyResources(this.button_exit, "button_exit");
            this.button_exit.Name = "button_exit";
            this.button_exit.UseVisualStyleBackColor = true;
            // 
            // Main_Form
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_flashstate);
            this.Controls.Add(this.groupBox_controller);
            this.Controls.Add(this.groupBox_stateviewer);
            this.Controls.Add(this.menuStrip_mainmenu);
            this.MainMenuStrip = this.menuStrip_mainmenu;
            this.MaximizeBox = false;
            this.Name = "Main_Form";
            this.groupBox_stateviewer.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox_controller.ResumeLayout(false);
            this.tableLayoutPanel_operatorlist.ResumeLayout(false);
            this.menuStrip_mainmenu.ResumeLayout(false);
            this.menuStrip_mainmenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_HyperVStateName;
        private System.Windows.Forms.Label label_HyperVState;
        private System.Windows.Forms.Button button_StartHyperVService;
        private System.Windows.Forms.Label label_VMWareStateName;
        private System.Windows.Forms.Label label_VMWareState;
        private System.Windows.Forms.Button button_StartVMWareService;
        private System.Windows.Forms.GroupBox groupBox_stateviewer;
        private System.Windows.Forms.GroupBox groupBox_controller;
        private System.Windows.Forms.MenuStrip menuStrip_mainmenu;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_File;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_Help;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_About;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Close;
        private System.Windows.Forms.Button button_flashstate;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Label label_HyperVStartName;
        private System.Windows.Forms.Label label_VMWareStartName;
        private System.Windows.Forms.Label label_HyperVStart;
        private System.Windows.Forms.Label label_VMWareStart;
        private System.Windows.Forms.Button button_ActiveVMWare;
        private System.Windows.Forms.Button button_ActiveHyperV;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_operatorlist;
    }
}

