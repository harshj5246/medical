// Updated by XamlIntelliSenseFileGenerator 30-10-2022 01:32:21
#pragma checksum "..\..\..\Detail.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7F53C0F6E0B7B45CD4E3AD89989ACBC63746EB0C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using test_A;


namespace test_A
{


    /// <summary>
    /// Detail
    /// </summary>
    public partial class Detail : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 13 "..\..\..\Detail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dtg_Grddetail;

#line default
#line hidden


#line 26 "..\..\..\Detail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblPatientId;

#line default
#line hidden


#line 27 "..\..\..\Detail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblPatientName;

#line default
#line hidden


#line 28 "..\..\..\Detail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblPatientRegistration;

#line default
#line hidden


#line 30 "..\..\..\Detail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtPatientID;

#line default
#line hidden


#line 31 "..\..\..\Detail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtPatientName;

#line default
#line hidden


#line 32 "..\..\..\Detail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtPatientRegistration;

#line default
#line hidden


#line 34 "..\..\..\Detail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnSave;

#line default
#line hidden


#line 43 "..\..\..\Detail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnLoad;

#line default
#line hidden


#line 52 "..\..\..\Detail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnEdit;

#line default
#line hidden


#line 61 "..\..\..\Detail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnDelete;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.10.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/test_A;component/detail.xaml", System.UriKind.Relative);

#line 1 "..\..\..\Detail.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.10.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.dtg_Grddetail = ((System.Windows.Controls.DataGrid)(target));
                    return;
                case 2:
                    this.LblPatientId = ((System.Windows.Controls.Label)(target));
                    return;
                case 3:
                    this.LblPatientName = ((System.Windows.Controls.Label)(target));
                    return;
                case 4:
                    this.LblPatientRegistration = ((System.Windows.Controls.Label)(target));
                    return;
                case 5:
                    this.TxtPatientID = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 6:
                    this.TxtPatientName = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 7:
                    this.TxtPatientRegistration = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 8:
                    this.BtnSave = ((System.Windows.Controls.Button)(target));

#line 34 "..\..\..\Detail.xaml"
                    this.BtnSave.Click += new System.Windows.RoutedEventHandler(this.BtnSave_Click);

#line default
#line hidden
                    return;
                case 9:
                    this.BtnLoad = ((System.Windows.Controls.Button)(target));

#line 43 "..\..\..\Detail.xaml"
                    this.BtnLoad.Click += new System.Windows.RoutedEventHandler(this.BtnLoad_Click);

#line default
#line hidden
                    return;
                case 10:
                    this.BtnEdit = ((System.Windows.Controls.Button)(target));

#line 52 "..\..\..\Detail.xaml"
                    this.BtnEdit.Click += new System.Windows.RoutedEventHandler(this.BtnEdit_Click);

#line default
#line hidden
                    return;
                case 11:
                    this.BtnDelete = ((System.Windows.Controls.Button)(target));

#line 61 "..\..\..\Detail.xaml"
                    this.BtnDelete.Click += new System.Windows.RoutedEventHandler(this.BtnDelete_Click);

#line default
#line hidden
                    return;
                case 12:
                    this.name = ((System.Windows.Controls.ComboBox)(target));

#line 69 "..\..\..\Detail.xaml"
                    this.name.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.name_SelectionChanged);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }
    }
}

