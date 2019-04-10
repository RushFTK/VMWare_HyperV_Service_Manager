using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_gui
{
    public partial class Main_Form : Form
    {
        /// <summary>
        /// 根据获得的状态值，更新显示界面中的"服务状态一览"部分
        /// </summary>
        /// <param name="current_VMS_code"></param>
        /// <param name="current_HVS_code"></param>
        /// <returns>更新过程的状态值，0为正常</returns>
        public int update_VH_state(int current_VMS_code,int current_HVS_code)
        {
            
            return 0;
        }

        public Main_Form()
        {
            InitializeComponent();
        }

        private void button_flashstate_Click(object sender, EventArgs e)
        {
            VMS_statecode vms_result = Service_Manager.get_VMWare_current_state();
            String vms_replacetext = (vms_result == VMS_statecode.running) ? "运行中" :
                                     (vms_result == VMS_statecode.stop) ? "停止" :
                                     "未知";
            label_VMWareState.Text = vms_replacetext;
        }
    }
}
