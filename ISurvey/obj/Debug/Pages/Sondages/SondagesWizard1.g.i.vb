﻿#ExternalChecksum("..\..\..\..\Pages\Sondages\SondagesWizard1.xaml","{ff1816ec-aa5e-4d10-87f7-6f4963833460}","6EE0A8735F03454BE1E61AB5405DAEEB46A578E9")
'------------------------------------------------------------------------------
' <auto-generated>
'     Ce code a été généré par un outil.
'     Version du runtime :4.0.30319.42000
'
'     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
'     le code est régénéré.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports FontAwesome.WPF
Imports FontAwesome.WPF.Converters
Imports ISurvey
Imports System
Imports System.Diagnostics
Imports System.Windows
Imports System.Windows.Automation
Imports System.Windows.Controls
Imports System.Windows.Controls.Primitives
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Ink
Imports System.Windows.Input
Imports System.Windows.Markup
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Media.Effects
Imports System.Windows.Media.Imaging
Imports System.Windows.Media.Media3D
Imports System.Windows.Media.TextFormatting
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports System.Windows.Shell


'''<summary>
'''SondagesWizard1
'''</summary>
<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
Partial Public Class SondagesWizard1
    Inherits System.Windows.Controls.Page
    Implements System.Windows.Markup.IComponentConnector
    
    
    #ExternalSource("..\..\..\..\Pages\Sondages\SondagesWizard1.xaml",23)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents ButtonNext As System.Windows.Controls.Button
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Pages\Sondages\SondagesWizard1.xaml",28)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents ButtonCreateNew As System.Windows.Controls.Button
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Pages\Sondages\SondagesWizard1.xaml",31)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents ButtonCreateNewFA As FontAwesome.WPF.ImageAwesome
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Pages\Sondages\SondagesWizard1.xaml",33)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents ButtonCreateNewTB As System.Windows.Controls.TextBlock
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Pages\Sondages\SondagesWizard1.xaml",36)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents ButtonCreateFromModel As System.Windows.Controls.Button
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Pages\Sondages\SondagesWizard1.xaml",39)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents ButtonCreateFromModelFA As FontAwesome.WPF.ImageAwesome
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Pages\Sondages\SondagesWizard1.xaml",41)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents ButtonCreateFromModelTB As System.Windows.Controls.TextBlock
    
    #End ExternalSource
    
    Private _contentLoaded As Boolean
    
    '''<summary>
    '''InitializeComponent
    '''</summary>
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")>  _
    Public Sub InitializeComponent() Implements System.Windows.Markup.IComponentConnector.InitializeComponent
        If _contentLoaded Then
            Return
        End If
        _contentLoaded = true
        Dim resourceLocater As System.Uri = New System.Uri("/ISurvey;component/pages/sondages/sondageswizard1.xaml", System.UriKind.Relative)
        
        #ExternalSource("..\..\..\..\Pages\Sondages\SondagesWizard1.xaml",1)
        System.Windows.Application.LoadComponent(Me, resourceLocater)
        
        #End ExternalSource
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes"),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity"),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")>  _
    Sub System_Windows_Markup_IComponentConnector_Connect(ByVal connectionId As Integer, ByVal target As Object) Implements System.Windows.Markup.IComponentConnector.Connect
        If (connectionId = 1) Then
            Me.ButtonNext = CType(target,System.Windows.Controls.Button)
            
            #ExternalSource("..\..\..\..\Pages\Sondages\SondagesWizard1.xaml",23)
            AddHandler Me.ButtonNext.Click, New System.Windows.RoutedEventHandler(AddressOf Me.ButtonNext_Click)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 2) Then
            Me.ButtonCreateNew = CType(target,System.Windows.Controls.Button)
            
            #ExternalSource("..\..\..\..\Pages\Sondages\SondagesWizard1.xaml",28)
            AddHandler Me.ButtonCreateNew.Click, New System.Windows.RoutedEventHandler(AddressOf Me.ButtonCreateNew_Click)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 3) Then
            Me.ButtonCreateNewFA = CType(target,FontAwesome.WPF.ImageAwesome)
            Return
        End If
        If (connectionId = 4) Then
            Me.ButtonCreateNewTB = CType(target,System.Windows.Controls.TextBlock)
            Return
        End If
        If (connectionId = 5) Then
            Me.ButtonCreateFromModel = CType(target,System.Windows.Controls.Button)
            
            #ExternalSource("..\..\..\..\Pages\Sondages\SondagesWizard1.xaml",36)
            AddHandler Me.ButtonCreateFromModel.Click, New System.Windows.RoutedEventHandler(AddressOf Me.ButtonCreateFromModel_Click)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 6) Then
            Me.ButtonCreateFromModelFA = CType(target,FontAwesome.WPF.ImageAwesome)
            Return
        End If
        If (connectionId = 7) Then
            Me.ButtonCreateFromModelTB = CType(target,System.Windows.Controls.TextBlock)
            Return
        End If
        Me._contentLoaded = true
    End Sub
End Class

