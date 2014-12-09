Imports System.ComponentModel.Composition
Imports DevExpress.CodeRush.Common

<Export(GetType(IVsixPluginExtension))> _
  Public Class CR_PromoteExpressionToParameterExtension
    Implements IVsixPluginExtension
End Class
