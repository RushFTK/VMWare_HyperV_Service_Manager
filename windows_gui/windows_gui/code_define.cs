using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windows_gui
{
    /// <summary>
    /// 为程序管理的服务进行编号
    /// </summary>
    public enum ServiceOrder : int
    {
        VMWare,
        HyperV,
        unknow
    }

    /// <summary>
    /// 代表VMWare服务状态的代码
    /// </summary>
    public enum VMS_statecode : int
    {
        stop, 
        running,
        unknow
    }

    /// <summary>
    /// 代码Hyper-V服务状态的代码
    /// </summary>
    public enum HVS_statecode : int
    {
        stop,
        running,
        unknow
    }

    
}
