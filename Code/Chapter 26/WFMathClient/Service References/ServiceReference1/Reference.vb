﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.1433
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace ServiceReference1
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute([Namespace]:="www.intertech.com", ConfigurationName:="ServiceReference1.IBasicMath")>  _
    Public Interface IBasicMath
        
        <System.ServiceModel.OperationContractAttribute(Action:="www.intertech.com/IBasicMath/Add", ReplyAction:="www.intertech.com/IBasicMath/AddResponse")>  _
        Function Add(ByVal x As Integer, ByVal y As Integer) As Integer
    End Interface
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")>  _
    Public Interface IBasicMathChannel
        Inherits ServiceReference1.IBasicMath, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")>  _
    Partial Public Class BasicMathClient
        Inherits System.ServiceModel.ClientBase(Of ServiceReference1.IBasicMath)
        Implements ServiceReference1.IBasicMath
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        Public Function Add(ByVal x As Integer, ByVal y As Integer) As Integer Implements ServiceReference1.IBasicMath.Add
            Return MyBase.Channel.Add(x, y)
        End Function
    End Class
End Namespace
