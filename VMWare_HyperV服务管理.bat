REM Github链接：https://github.com/RushFTK/VMWare_HyperV_Service_Manager
@echo off
color 0B
setlocal EnableDelayedExpansion
set VMServices[0]=VMnetDHCP 
set VMServices[1]=VMAuthdService
set VMServices[2]="VMware NAT Service"
set VMServices[3]=VMUSBArbService
set VMServices[4]=VMwareHostd
set HyperVServices[0]=HvHost
set HyperVServices[1]=vmms
set HyperVServices[2]=vmcompute

:startmenu
cls
echo/
echo   ********************************************
echo   ****    VMWare,Hyper-V服务管理 v0.10    ****
echo   ****           Author:Rush_FTK          ****
echo   ****        Last_Update:2019-03-26      ****
echo   ********************************************
echo/
echo   [1] 关闭VMWare相关服务
echo   [2] 启动VMWare相关服务
echo   [3] 将VMWare相关服务设定为手动启动
echo   [4] 将VMWare相关服务设定为自动启动
echo   [5] 禁用Hyper-V
echo   [6] 启动Hyper-V
echo   [7] 关闭Hyper-V相关服务与启动加载器
echo   [0] 退出
echo/
echo   【注意】本批处理脚本需要以管理员方式运行，
echo           直接运行无效。
echo/
set /p select= "请输入待执行项目前面的数字:"
if "%select%"=="1" goto stop_VMSerivice
if "%select%"=="2" goto start_VMSerivice
if "%select%"=="3" goto Set_VMSerivice_Demand
if "%select%"=="4" goto Set_VMSerivice_auto
if "%select%"=="5" goto Disable_HyperV
if "%select%"=="6" goto Enable_HyperV
if "%select%"=="7" goto stop_HyperV
if "%select%"=="0" exit
echo 输入无效。按任意键返回主菜单。
pause
goto startmenu

:stop_VMSerivice
set index=0
:Loop_stop_VMSerivice
if defined VMServices[%index%] (
	net stop !VMServices[%index%]!
	set /a index+=1
	GOTO Loop_stop_VMSerivice
)
goto exit

:start_VMSerivice
set index=0
:Loop_start_VMSerivice
if defined VMServices[%index%] (
	net start !VMServices[%index%]!
	set /a index+=1
	GOTO Loop_start_VMSerivice
)
goto exit

:Set_VMSerivice_Demand
set index=0
:Loop_SetVMSerice_demand
if defined VMServices[%index%] (
	echo 正在设定服务:!VMServices[%index%]!
	sc config !VMServices[%index%]! start=demand
	set /a index+=1
	GOTO Loop_SetVMSerice_demand
)
goto exit

:Set_VMSerivice_auto
set index=0
:Loop_SetVMSerice_auto
if defined VMServices[%index%] (
	echo 正在设定服务:!VMServices[%index%]!
	sc config !VMServices[%index%]! start=auto
	set /a index+=1
	GOTO Loop_SetVMSerice_auto
)
goto exit

:Disable_HyperV
DISM /Online /Disable-Feature /All /FeatureName:Microsoft-Hyper-V
goto exit_tipsrestart

:Enable_HyperV
DISM /Online /Enable-Feature /All /FeatureName:Microsoft-Hyper-V
goto exit_tipsrestart

:stop_HyperV
set index=0
:Loop_stop_HyperV
if defined HyperVServices[%index%] (
	net stop !HyperVServices[%index%]!
	set /a index+=1
	GOTO Loop_stop_HyperV
)
sc config vmms start=demand
bcdedit /set hypervisorlaunchtype off
goto exit_tipsrestart

:exit_tipsrestart
echo 部分项目须重启生效。
:exit
echo 执行完毕，按任意键退出。
pause
color 