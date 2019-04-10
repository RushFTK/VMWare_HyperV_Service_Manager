using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceProcess;

namespace windows_gui
{
    class Service_Manager
    {
        /// <summary>
        /// 包含VMWare必要手动开启/关闭与修改手动/自动启动的服务名称
        /// </summary>
        public static string[] VMWareService_namelist =
        {
            "VMnetDHCP",
            "VMAuthdService",
            "VMware NAT Service",
            "VMUSBArbService",
            "VMwareHostd"
        };

        /// <summary>
        /// 包含HyperV必要手动开启/关闭与修改手动/自动启动的服务名称
        /// </summary>
        public static string[] HyperVService_namelist =
        {
            "HvHost",
            "vmms",
            "vmcompute"
        };

        /// <summary>
        /// 获取
        /// </summary>
        /// <returns></returns>
        public static VMS_statecode get_VMWare_current_state()
        {
            VMS_statecode result = VMS_statecode.unknow;
            bool ifSomeStatusRunning = false; 
            foreach(string scname in VMWareService_namelist)
            {
                ServiceController cur_sc = new ServiceController(scname);
                if (cur_sc.Status == ServiceControllerStatus.Running)
                {
                    ifSomeStatusRunning = true;
                }
            }
            if (ifSomeStatusRunning == true) result = VMS_statecode.running;
            else                             result = VMS_statecode.stop;
            return result;
        }
    }
}
