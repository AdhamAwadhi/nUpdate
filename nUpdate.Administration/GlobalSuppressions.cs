// Copyright © Dominic Beger 2018

using System.Diagnostics.CodeAnalysis;

[assembly:
    SuppressMessage("Microsoft.Security", "CA2100:SQL-Abfragen auf Sicherheitsrisiken überprüfen", Scope = "member",
        Target =
            "nUpdate.Administration.UI.Dialogs.ProjectDialog.#UploadPackage(nUpdate.Administration.Core.Update.UpdateVersion)"
    )]
[assembly:
    SuppressMessage("Microsoft.Security", "CA2100:SQL-Abfragen auf Sicherheitsrisiken überprüfen", Scope = "member",
        Target =
            "nUpdate.Administration.UI.Dialogs.ProjectDialog.#UndoSqlInsertion(nUpdate.Administration.Core.Update.UpdateVersion)"
    )]
[assembly:
    SuppressMessage("Microsoft.Security", "CA2100:SQL-Abfragen auf Sicherheitsrisiken überprüfen", Scope = "member",
        Target = "nUpdate.Administration.UI.Dialogs.ProjectDialog.#ProjectDialog_Load(System.Object,System.EventArgs)")]
[assembly:
    SuppressMessage("Microsoft.Security", "CA2100:SQL-Abfragen auf Sicherheitsrisiken überprüfen", Scope = "member",
        Target = "nUpdate.Administration.UI.Dialogs.PackageAddDialog.#InitializePackage()")]
[assembly:
    SuppressMessage("Microsoft.Security", "CA2111:PointersShouldNotBeVisible", Scope = "member",
        Target = "nUpdate.Administration.Core.Win32.LvGroup.#PszSubtitle")]
[assembly:
    SuppressMessage("Microsoft.Security", "CA2111:PointersShouldNotBeVisible", Scope = "member",
        Target = "nUpdate.Administration.Core.Win32.LvGroup.#CItems")]
[assembly:
    SuppressMessage("Microsoft.Security", "CA2111:PointersShouldNotBeVisible", Scope = "member",
        Target = "nUpdate.Administration.Core.Win32.LvGroup.#PszSubsetTitle")]
[assembly:
    SuppressMessage("Microsoft.Security", "CA2111:PointersShouldNotBeVisible", Scope = "member",
        Target = "nUpdate.Administration.Core.Win32.LvGroup.#CchSubsetTitle")]
[assembly:
    SuppressMessage("Microsoft.Security", "CA2111:PointersShouldNotBeVisible", Scope = "member",
        Target = "nUpdate.Administration.Core.Win32.TvItem.#hItem")]
[assembly:
    SuppressMessage("Microsoft.Portability", "CA1901:PInvokeDeclarationsShouldBePortable", MessageId = "2",
        Scope = "member",
        Target =
            "nUpdate.Administration.Core.Win32.NativeMethods.#SendMessage(System.IntPtr,System.UInt32,System.Boolean,System.IntPtr)"
    )]
[assembly:
    SuppressMessage("Microsoft.Portability", "CA1901:PInvokeDeclarationsShouldBePortable", MessageId = "3",
        Scope = "member",
        Target =
            "nUpdate.Administration.Core.Win32.NativeMethods.#SendMessage(System.Runtime.InteropServices.HandleRef,System.UInt32,System.IntPtr,System.Boolean)"
    )]
[assembly:
    SuppressMessage("Microsoft.Usage", "CA2202:Objekte nicht mehrmals verwerfen", Scope = "member",
        Target =
            "nUpdate.Administration.UI.Dialogs.NewProjectDialog.#continueButton_Click(System.Object,System.EventArgs)")]
[assembly:
    SuppressMessage("Microsoft.Usage", "CA2202:Objekte nicht mehrmals verwerfen", Scope = "member",
        Target = "nUpdate.Administration.Core.AesManager.#Decrypt(System.Byte[],System.String,System.String)")]
[assembly:
    SuppressMessage("Microsoft.Usage", "CA2202:Objekte nicht mehrmals verwerfen", Scope = "member",
        Target = "nUpdate.Administration.Core.AesManager.#Encrypt(System.String,System.String,System.String)")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member",
        Target = "nUpdate.Administration.Core.Ftp.FtpResponseCollection.#System.Collections.IEnumerable.GetEnumerator()"
    )]
[assembly:
    SuppressMessage("Microsoft.Security", "CA2100:SQL-Abfragen auf Sicherheitsrisiken überprüfen", Scope = "member",
        Target = "nUpdate.Administration.UI.Dialogs.ProjectDialog.#Reset()")]
[assembly:
    SuppressMessage("Microsoft.Security", "CA2100:SQL-Abfragen auf Sicherheitsrisiken überprüfen", Scope = "member",
        Target = "nUpdate.Administration.UI.Dialogs.ProjectDialog.#InitializeStatisticsData()")]
[assembly:
    SuppressMessage("Microsoft.Security", "CA2100:SQL-Abfragen auf Sicherheitsrisiken überprüfen", Scope = "member",
        Target =
            "nUpdate.Administration.UI.Dialogs.ProjectDialog.#UploadPackage(nUpdate.Administration.Core.UpdateVersion)")
]
[assembly:
    SuppressMessage("Microsoft.Security", "CA2100:SQL-Abfragen auf Sicherheitsrisiken überprüfen", Scope = "member",
        Target = "nUpdate.Administration.UI.Dialogs.ProjectDialog.#DeletePackage()")]
[assembly:
    SuppressMessage("Microsoft.Security", "CA2100:SQL-Abfragen auf Sicherheitsrisiken überprüfen", Scope = "member",
        Target = "nUpdate.Administration.UI.Dialogs.ProjectEditDialog.#Reset()")]
[assembly:
    SuppressMessage("Microsoft.Security", "CA2111:PointersShouldNotBeVisible", Scope = "member",
        Target = "nUpdate.Administration.UI.Controls.ExplorerTreeNode.#HItem")]
[assembly:
    SuppressMessage("Microsoft.Usage", "CA2202:Objekte nicht mehrmals verwerfen", Scope = "member",
        Target = "nUpdate.Administration.UI.Dialogs.ProjectDialog.#DeletePackage()")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member",
        Target = "nUpdate.Administration.Core.Ftp.FtpItemCollection.#System.Collections.IEnumerable.GetEnumerator()")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1063:ImplementIDisposableCorrectly", Scope = "member",
        Target = "nUpdate.Administration.Core.Proxy.HttpProxyClient.#Dispose(System.Boolean)")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1063:ImplementIDisposableCorrectly", Scope = "member",
        Target = "nUpdate.Administration.Core.Ftp.FtpClient.#Dispose()")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1063:ImplementIDisposableCorrectly", Scope = "member",
        Target = "nUpdate.Administration.Core.Ftp.FtpClient.#Finalize()")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member",
        Target =
            "nUpdate.Administration.Core.Ftp.FtpItemCollection.#System.Collections.Generic.IEnumerable`1<nUpdate.Administration.Core.Ftp.FtpItem>.GetEnumerator()"
    )]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member",
        Target =
            "nUpdate.Administration.Core.Ftp.FtpResponseCollection.#System.Collections.Generic.IEnumerable`1<nUpdate.Administration.Core.Ftp.FtpResponse>.GetEnumerator()"
    )]