REM Github���ӣ�https://github.com/RushFTK/VMWare_HyperV_Service_Manager
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
echo   ****    VMWare,Hyper-V������� v0.10    ****
echo   ****           Author:Rush_FTK          ****
echo   ****        Last_Update:2019-03-26      ****
echo   ********************************************
echo/
echo   [1] �ر�VMWare��ط���
echo   [2] ����VMWare��ط���
echo   [3] ��VMWare��ط����趨Ϊ�ֶ�����
echo   [4] ��VMWare��ط����趨Ϊ�Զ�����
echo   [5] ����Hyper-V
echo   [6] ����Hyper-V
echo   [7] �ر�Hyper-V��ط���������������
echo   [0] �˳�
echo/
echo   ��ע�⡿��������ű���Ҫ�Թ���Ա��ʽ���У�
echo           ֱ��������Ч��
echo/
set /p select= "�������ִ����Ŀǰ�������:"
if "%select%"=="1" goto stop_VMSerivice
if "%select%"=="2" goto start_VMSerivice
if "%select%"=="3" goto Set_VMSerivice_Demand
if "%select%"=="4" goto Set_VMSerivice_auto
if "%select%"=="5" goto Disable_HyperV
if "%select%"=="6" goto Enable_HyperV
if "%select%"=="7" goto stop_HyperV
if "%select%"=="0" exit
echo ������Ч����������������˵���
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
	echo �����趨����:!VMServices[%index%]!
	sc config !VMServices[%index%]! start=demand
	set /a index+=1
	GOTO Loop_SetVMSerice_demand
)
goto exit

:Set_VMSerivice_auto
set index=0
:Loop_SetVMSerice_auto
if defined VMServices[%index%] (
	echo �����趨����:!VMServices[%index%]!
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
echo ������Ŀ��������Ч��
:exit
echo ִ����ϣ���������˳���
pause
color 