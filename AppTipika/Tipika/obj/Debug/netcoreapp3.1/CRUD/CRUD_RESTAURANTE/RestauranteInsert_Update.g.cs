﻿#pragma checksum "..\..\..\..\..\CRUD\CRUD_RESTAURANTE\RestauranteInsert_Update.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9985A1885A9AB9B908F7980449F027A143B38DFD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AppTipika.Presentation.CRUD.CRUD_RESTAURANTE;
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


namespace AppTipika.Presentation.CRUD.CRUD_RESTAURANTE {
    
    
    /// <summary>
    /// RestauranteInsert_Update
    /// </summary>
    public partial class RestauranteInsert_Update : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\..\..\CRUD\CRUD_RESTAURANTE\RestauranteInsert_Update.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtId;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\..\CRUD\CRUD_RESTAURANTE\RestauranteInsert_Update.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNombreRestaurante;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\..\CRUD\CRUD_RESTAURANTE\RestauranteInsert_Update.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDireccion;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\..\CRUD\CRUD_RESTAURANTE\RestauranteInsert_Update.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnInsertar;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\..\CRUD\CRUD_RESTAURANTE\RestauranteInsert_Update.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnActualizar;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/AppTipika.Presentation;component/crud/crud_restaurante/restauranteinsert_update." +
                    "xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\CRUD\CRUD_RESTAURANTE\RestauranteInsert_Update.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.txtId = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtNombreRestaurante = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtDireccion = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.btnInsertar = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\..\..\CRUD\CRUD_RESTAURANTE\RestauranteInsert_Update.xaml"
            this.btnInsertar.Click += new System.Windows.RoutedEventHandler(this.BtnInsertar_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnActualizar = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

