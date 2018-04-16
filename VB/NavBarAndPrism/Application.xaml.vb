Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Net
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Shapes
Imports DevExpress.Xpf.Core

Namespace NavBarAndPrism
	Partial Public Class App
		Inherits Application

		Protected Overrides Sub OnStartup(ByVal e As StartupEventArgs)
			MyBase.OnStartup(e)
			ApplicationThemeHelper.ApplicationThemeName = Theme.Office2010Black.Name
			Dim bootstrapper As New Bootstrapper()
			bootstrapper.Run()
		End Sub
	End Class
End Namespace
