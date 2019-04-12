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
        /// 获取当前VMware服务运行的状态
        /// </summary>
        /// <returns>一个VMS_statecode枚举变量的值，表明当前服务运行的状态</returns>
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

        /// <summary>
        /// 获取当前HyperV相关服务运行的状态
        /// </summary>
        /// <returns>一个HVS枚举变量的值，表明当前服务运行的状态</returns>
        public static HVS_statecode get_HyperV_current_state()
        {
            HVS_statecode result = HVS_statecode.unknow;
            bool ifSomeStatusRunning = false;
            foreach (string scname in HyperVService_namelist)
            {
                ServiceController cur_sc = new ServiceController(scname);
                if (cur_sc.Status == ServiceControllerStatus.Running)
                {
                    ifSomeStatusRunning = true;
                }
            }
            if (ifSomeStatusRunning == true) result = HVS_statecode.running;
            else result = HVS_statecode.stop;
            return result;
        }
    }
}
