; 脚本由 Inno Setup 脚本向导 生成！
; 有关创建 Inno Setup 脚本文件的详细资料请查阅帮助文档！

#define MyAppName "SPC_x64"
#define MyAppVersion "1.0.4"
#define MyAppPublisher "宁波轻蜓视觉科技有限公司"
#define MyAppURL "http://www.qtingvision.com/"
#define MyAppExeName "spc-client.exe"

[Setup]
; 注: AppId的值为单独标识该应用程序。
; 不要为其他安装程序使用相同的AppId值。
; (若要生成新的 GUID，可在菜单中点击 "工具|生成 GUID"。)
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
; [Icons] 的“quicklaunchicon”条目使用 {userappdata}，而其 [Tasks] 条目具有适合 IsAdminInstallMode 的检查。
UsedUserAreasWarning=no
; 以下行取消注释，以在非管理安装模式下运行（仅为当前用户安装）。
;PrivilegesRequired=lowest
PrivilegesRequiredOverridesAllowed=dialog
OutputDir=C:\Users\Administrator\Desktop\suomi-project\spc2
OutputBaseFilename={#MyAppName}_{#MyAppVersion}_SETUP
Compression=lzma
SolidCompression=yes
WizardStyle=modern

[Languages]
Name: "chinesesimp"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked; OnlyBelowVersion: 6.1; Check: not IsAdminInstallMode

[Files]
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\spc-client.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\BouncyCastle.Crypto.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\Cyotek.Windows.Forms.ImageBox.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\Cyotek.Windows.Forms.ImageBox.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\DevExpress.BonusSkins.v20.1.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\DevExpress.Data.Desktop.v20.1.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\DevExpress.Data.Desktop.v20.1.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\DevExpress.Data.v20.1.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\DevExpress.Data.v20.1.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\DevExpress.Mvvm.v20.1.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\DevExpress.Mvvm.v20.1.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\DevExpress.Office.v20.1.Core.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\DevExpress.Office.v20.1.Core.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\DevExpress.Pdf.v20.1.Core.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\DevExpress.Pdf.v20.1.Core.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\DevExpress.Pdf.v20.1.Drawing.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\DevExpress.Pdf.v20.1.Drawing.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\DevExpress.Printing.v20.1.Core.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\DevExpress.Printing.v20.1.Core.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\DevExpress.RichEdit.v20.1.Core.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\DevExpress.RichEdit.v20.1.Core.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\DevExpress.Sparkline.v20.1.Core.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\DevExpress.Sparkline.v20.1.Core.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\DevExpress.Utils.v20.1.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\DevExpress.Utils.v20.1.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\DevExpress.XtraBars.v20.1.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\DevExpress.XtraBars.v20.1.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\DevExpress.XtraEditors.v20.1.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\DevExpress.XtraEditors.v20.1.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\DevExpress.XtraGrid.v20.1.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\DevExpress.XtraGrid.v20.1.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\DevExpress.XtraLayout.v20.1.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\DevExpress.XtraLayout.v20.1.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\DevExpress.XtraPrinting.v20.1.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\DevExpress.XtraPrinting.v20.1.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\DevExpress.XtraTreeList.v20.1.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\DevExpress.XtraTreeList.v20.1.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\EntityFramework.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\EntityFramework.SqlServer.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\EntityFramework.SqlServer.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\EntityFramework.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\Google.Protobuf.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\Google.Protobuf.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\K4os.Compression.LZ4.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\K4os.Compression.LZ4.Streams.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\K4os.Compression.LZ4.Streams.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\K4os.Compression.LZ4.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\K4os.Hash.xxHash.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\K4os.Hash.xxHash.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\MySql.Data.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\MySql.Data.Entity.EF6.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\MySql.Data.Entity.EF6.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\MySql.Data.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\Renci.SshNet.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\Renci.SshNet.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\SlimDX.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\SmartThreadPool.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\spc-client.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\spc-client.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\spc-client.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\System.Buffers.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\System.Buffers.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\System.Memory.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\System.Memory.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\System.Numerics.Vectors.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\System.Numerics.Vectors.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\System.Runtime.CompilerServices.Unsafe.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Administrator\Desktop\suomi-project\spc2\spc-client\bin\x64\Debug\System.Runtime.CompilerServices.Unsafe.xml"; DestDir: "{app}"; Flags: ignoreversion
; 注意: 不要在任何共享系统文件上使用“Flags: ignoreversion”

[Icons]
Name: "{autoprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: quicklaunchicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

