; �ű��� Inno Setup �ű��� ���ɣ�
; �йش��� Inno Setup �ű��ļ�����ϸ��������İ����ĵ���

#define MyAppName "SPC"
#define MyAppVersion "1.0.0"
#define MyAppPublisher "���������Ӿ��Ƽ����޹�˾"
#define MyAppURL "http://www.qtingvision.com/"
#define MyAppExeName "spc-client.exe"

[Setup]
; ע: AppId��ֵΪ������ʶ��Ӧ�ó���
; ��ҪΪ������װ����ʹ����ͬ��AppIdֵ��
; (��Ҫ�����µ� GUID�����ڲ˵��е�� "����|���� GUID"��)
AppId={{55CF48C3-BC2A-4796-846E-D4810772AD60}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={autopf}\{#MyAppName}
DisableProgramGroupPage=yes
; [Icons] �ġ�quicklaunchicon����Ŀʹ�� {userappdata}������ [Tasks] ��Ŀ�����ʺ� IsAdminInstallMode �ļ�顣
UsedUserAreasWarning=no
; ������ȡ��ע�ͣ����ڷǹ���װģʽ�����У���Ϊ��ǰ�û���װ����
;PrivilegesRequired=lowest
PrivilegesRequiredOverridesAllowed=dialog
OutputDir=C:\Users\Administrator\Desktop\suomi-project\spc
OutputBaseFilename=mysetup
Compression=lzma
SolidCompression=yes
WizardStyle=modern

[Languages]
Name: "chinesesimp"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked; OnlyBelowVersion: 6.1; Check: not IsAdminInstallMode

[Files]
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\spc-client.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\BouncyCastle.Crypto.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\Cyotek.Windows.Forms.ImageBox.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\Cyotek.Windows.Forms.ImageBox.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\DevExpress.BonusSkins.v20.1.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\DevExpress.Data.Desktop.v20.1.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\DevExpress.Data.Desktop.v20.1.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\DevExpress.Data.v20.1.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\DevExpress.Data.v20.1.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\DevExpress.Mvvm.v20.1.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\DevExpress.Mvvm.v20.1.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\DevExpress.Office.v20.1.Core.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\DevExpress.Office.v20.1.Core.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\DevExpress.Pdf.v20.1.Core.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\DevExpress.Pdf.v20.1.Core.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\DevExpress.Pdf.v20.1.Drawing.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\DevExpress.Pdf.v20.1.Drawing.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\DevExpress.Printing.v20.1.Core.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\DevExpress.Printing.v20.1.Core.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\DevExpress.RichEdit.v20.1.Core.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\DevExpress.RichEdit.v20.1.Core.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\DevExpress.Sparkline.v20.1.Core.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\DevExpress.Sparkline.v20.1.Core.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\DevExpress.Utils.v20.1.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\DevExpress.Utils.v20.1.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\DevExpress.XtraBars.v20.1.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\DevExpress.XtraBars.v20.1.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\DevExpress.XtraEditors.v20.1.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\DevExpress.XtraEditors.v20.1.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\DevExpress.XtraGrid.v20.1.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\DevExpress.XtraGrid.v20.1.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\DevExpress.XtraLayout.v20.1.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\DevExpress.XtraLayout.v20.1.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\DevExpress.XtraPrinting.v20.1.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\DevExpress.XtraPrinting.v20.1.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\DevExpress.XtraTreeList.v20.1.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\DevExpress.XtraTreeList.v20.1.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\EntityFramework.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\EntityFramework.SqlServer.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\EntityFramework.SqlServer.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\EntityFramework.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\Google.Protobuf.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\Google.Protobuf.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\K4os.Compression.LZ4.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\K4os.Compression.LZ4.Streams.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\K4os.Compression.LZ4.Streams.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\K4os.Compression.LZ4.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\K4os.Hash.xxHash.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\K4os.Hash.xxHash.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\MySql.Data.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\MySql.Data.Entity.EF6.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\MySql.Data.Entity.EF6.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\MySql.Data.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\Renci.SshNet.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\Renci.SshNet.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\SlimDX.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\SmartThreadPool.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\spc-client.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\spc-client.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\spc-client.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\System.Buffers.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\System.Buffers.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\System.Memory.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\System.Memory.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\System.Numerics.Vectors.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\System.Numerics.Vectors.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\System.Runtime.CompilerServices.Unsafe.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc\spc-client\bin\Debug\System.Runtime.CompilerServices.Unsafe.xml"; DestDir: "{app}"; Flags: ignoreversion
; ע��: ��Ҫ���κι���ϵͳ�ļ���ʹ�á�Flags: ignoreversion��

[Icons]
Name: "{autoprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: quicklaunchicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

