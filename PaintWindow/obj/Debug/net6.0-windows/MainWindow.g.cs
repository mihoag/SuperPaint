﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "CE18ADF3819DD31DCB1F1093EC213018509387BF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Fluent;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Transitions;
using PaintWindow;
using PanAndZoom;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace PaintWindow {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : Fluent.RibbonWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Ribbon HeaderMenu;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.RibbonGroupBox File;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button newButton;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button openButton;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button saveButton;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.RibbonGroupBox Clipboard;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button pasteButton;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button cutButton;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button copyButton;
        
        #line default
        #line hidden
        
        
        #line 129 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button undoButton;
        
        #line default
        #line hidden
        
        
        #line 143 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button redoButton;
        
        #line default
        #line hidden
        
        
        #line 160 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.RibbonGroupBox Image;
        
        #line default
        #line hidden
        
        
        #line 164 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button Select;
        
        #line default
        #line hidden
        
        
        #line 178 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button Crop;
        
        #line default
        #line hidden
        
        
        #line 187 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button Rotate;
        
        #line default
        #line hidden
        
        
        #line 197 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.RibbonGroupBox Tools;
        
        #line default
        #line hidden
        
        
        #line 220 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button buttonPencil;
        
        #line default
        #line hidden
        
        
        #line 230 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.SplitButton buttonBucket;
        
        #line default
        #line hidden
        
        
        #line 239 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Gallery ChooseFill;
        
        #line default
        #line hidden
        
        
        #line 284 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button buttonText;
        
        #line default
        #line hidden
        
        
        #line 293 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button buttonEraser;
        
        #line default
        #line hidden
        
        
        #line 303 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button buttonEyedrop;
        
        #line default
        #line hidden
        
        
        #line 313 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button buttonZoom;
        
        #line default
        #line hidden
        
        
        #line 360 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.WrapPanel ChooseShapeWrapPanel;
        
        #line default
        #line hidden
        
        
        #line 369 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel ChooseStyleStack;
        
        #line default
        #line hidden
        
        
        #line 371 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.ComboBox OutlineCbbox;
        
        #line default
        #line hidden
        
        
        #line 399 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.SplitButton ChooseSizeButton;
        
        #line default
        #line hidden
        
        
        #line 409 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Gallery ChooseSize;
        
        #line default
        #line hidden
        
        
        #line 501 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button mainColor;
        
        #line default
        #line hidden
        
        
        #line 512 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button subColor;
        
        #line default
        #line hidden
        
        
        #line 527 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.WrapPanel colors;
        
        #line default
        #line hidden
        
        
        #line 530 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button moreColorButton;
        
        #line default
        #line hidden
        
        
        #line 565 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Coordinates;
        
        #line default
        #line hidden
        
        
        #line 574 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock CanvasSize;
        
        #line default
        #line hidden
        
        
        #line 581 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PanAndZoom.ZoomBorder paintBorder;
        
        #line default
        #line hidden
        
        
        #line 583 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid fullCanvas;
        
        #line default
        #line hidden
        
        
        #line 589 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas paintCanvas;
        
        #line default
        #line hidden
        
        
        #line 598 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border CanvasBorder;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.11.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/PaintWindow;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.11.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.11.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 20 "..\..\..\MainWindow.xaml"
            ((PaintWindow.MainWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.RibbonWindow_Loaded);
            
            #line default
            #line hidden
            
            #line 21 "..\..\..\MainWindow.xaml"
            ((PaintWindow.MainWindow)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.RibbonWindow_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 25 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.DockPanel)(target)).KeyDown += new System.Windows.Input.KeyEventHandler(this.DockPanel_KeyDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.HeaderMenu = ((Fluent.Ribbon)(target));
            return;
            case 4:
            
            #line 33 "..\..\..\MainWindow.xaml"
            ((Fluent.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.newButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 35 "..\..\..\MainWindow.xaml"
            ((Fluent.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.openButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 37 "..\..\..\MainWindow.xaml"
            ((Fluent.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.saveButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 39 "..\..\..\MainWindow.xaml"
            ((Fluent.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ExitButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.File = ((Fluent.RibbonGroupBox)(target));
            return;
            case 9:
            this.newButton = ((Fluent.Button)(target));
            
            #line 50 "..\..\..\MainWindow.xaml"
            this.newButton.Click += new System.Windows.RoutedEventHandler(this.newButton_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.openButton = ((Fluent.Button)(target));
            
            #line 58 "..\..\..\MainWindow.xaml"
            this.openButton.Click += new System.Windows.RoutedEventHandler(this.openButton_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.saveButton = ((Fluent.Button)(target));
            
            #line 66 "..\..\..\MainWindow.xaml"
            this.saveButton.Click += new System.Windows.RoutedEventHandler(this.saveButton_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.Clipboard = ((Fluent.RibbonGroupBox)(target));
            return;
            case 13:
            this.pasteButton = ((Fluent.Button)(target));
            
            #line 81 "..\..\..\MainWindow.xaml"
            this.pasteButton.Click += new System.Windows.RoutedEventHandler(this.pasteButton_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.cutButton = ((Fluent.Button)(target));
            
            #line 100 "..\..\..\MainWindow.xaml"
            this.cutButton.Click += new System.Windows.RoutedEventHandler(this.cutButton_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            this.copyButton = ((Fluent.Button)(target));
            
            #line 116 "..\..\..\MainWindow.xaml"
            this.copyButton.Click += new System.Windows.RoutedEventHandler(this.copyButton_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            this.undoButton = ((Fluent.Button)(target));
            
            #line 131 "..\..\..\MainWindow.xaml"
            this.undoButton.Click += new System.Windows.RoutedEventHandler(this.undoButton_Click);
            
            #line default
            #line hidden
            return;
            case 17:
            this.redoButton = ((Fluent.Button)(target));
            
            #line 145 "..\..\..\MainWindow.xaml"
            this.redoButton.Click += new System.Windows.RoutedEventHandler(this.redoButton_Click);
            
            #line default
            #line hidden
            return;
            case 18:
            this.Image = ((Fluent.RibbonGroupBox)(target));
            return;
            case 19:
            this.Select = ((Fluent.Button)(target));
            
            #line 169 "..\..\..\MainWindow.xaml"
            this.Select.Click += new System.Windows.RoutedEventHandler(this.selectButton_Click);
            
            #line default
            #line hidden
            return;
            case 20:
            this.Crop = ((Fluent.Button)(target));
            
            #line 181 "..\..\..\MainWindow.xaml"
            this.Crop.Click += new System.Windows.RoutedEventHandler(this.Crop_Click);
            
            #line default
            #line hidden
            return;
            case 21:
            this.Rotate = ((Fluent.Button)(target));
            return;
            case 22:
            this.Tools = ((Fluent.RibbonGroupBox)(target));
            return;
            case 23:
            this.buttonPencil = ((Fluent.Button)(target));
            
            #line 223 "..\..\..\MainWindow.xaml"
            this.buttonPencil.Click += new System.Windows.RoutedEventHandler(this.buttonPencil_Click);
            
            #line default
            #line hidden
            return;
            case 24:
            this.buttonBucket = ((Fluent.SplitButton)(target));
            return;
            case 25:
            this.ChooseFill = ((Fluent.Gallery)(target));
            
            #line 246 "..\..\..\MainWindow.xaml"
            this.ChooseFill.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ChooseFill_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 26:
            this.buttonText = ((Fluent.Button)(target));
            
            #line 286 "..\..\..\MainWindow.xaml"
            this.buttonText.Click += new System.Windows.RoutedEventHandler(this.buttonText_Click);
            
            #line default
            #line hidden
            return;
            case 27:
            this.buttonEraser = ((Fluent.Button)(target));
            
            #line 296 "..\..\..\MainWindow.xaml"
            this.buttonEraser.Click += new System.Windows.RoutedEventHandler(this.buttonEraser_Click);
            
            #line default
            #line hidden
            return;
            case 28:
            this.buttonEyedrop = ((Fluent.Button)(target));
            
            #line 306 "..\..\..\MainWindow.xaml"
            this.buttonEyedrop.Click += new System.Windows.RoutedEventHandler(this.buttonEyedrop_Click);
            
            #line default
            #line hidden
            return;
            case 29:
            this.buttonZoom = ((Fluent.Button)(target));
            return;
            case 30:
            this.ChooseShapeWrapPanel = ((System.Windows.Controls.WrapPanel)(target));
            return;
            case 31:
            this.ChooseStyleStack = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 32:
            this.OutlineCbbox = ((Fluent.ComboBox)(target));
            
            #line 377 "..\..\..\MainWindow.xaml"
            this.OutlineCbbox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Outline_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 33:
            this.ChooseSizeButton = ((Fluent.SplitButton)(target));
            return;
            case 34:
            this.ChooseSize = ((Fluent.Gallery)(target));
            
            #line 416 "..\..\..\MainWindow.xaml"
            this.ChooseSize.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ChooseSize_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 35:
            this.mainColor = ((Fluent.Button)(target));
            
            #line 507 "..\..\..\MainWindow.xaml"
            this.mainColor.Click += new System.Windows.RoutedEventHandler(this.mainColor_Click);
            
            #line default
            #line hidden
            return;
            case 36:
            this.subColor = ((Fluent.Button)(target));
            
            #line 518 "..\..\..\MainWindow.xaml"
            this.subColor.Click += new System.Windows.RoutedEventHandler(this.subColor_Click);
            
            #line default
            #line hidden
            return;
            case 37:
            this.colors = ((System.Windows.Controls.WrapPanel)(target));
            return;
            case 38:
            this.moreColorButton = ((Fluent.Button)(target));
            
            #line 534 "..\..\..\MainWindow.xaml"
            this.moreColorButton.Click += new System.Windows.RoutedEventHandler(this.moreColorButton_Click);
            
            #line default
            #line hidden
            return;
            case 39:
            this.Coordinates = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 40:
            this.CanvasSize = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 41:
            this.paintBorder = ((PanAndZoom.ZoomBorder)(target));
            return;
            case 42:
            this.fullCanvas = ((System.Windows.Controls.Grid)(target));
            
            #line 586 "..\..\..\MainWindow.xaml"
            this.fullCanvas.Drop += new System.Windows.DragEventHandler(this.fullCanvas_Drop);
            
            #line default
            #line hidden
            return;
            case 43:
            this.paintCanvas = ((System.Windows.Controls.Canvas)(target));
            
            #line 590 "..\..\..\MainWindow.xaml"
            this.paintCanvas.Loaded += new System.Windows.RoutedEventHandler(this.PaintCanvas_Loaded);
            
            #line default
            #line hidden
            
            #line 595 "..\..\..\MainWindow.xaml"
            this.paintCanvas.SizeChanged += new System.Windows.SizeChangedEventHandler(this.paintCanvas_SizeChanged);
            
            #line default
            #line hidden
            return;
            case 44:
            this.CanvasBorder = ((System.Windows.Controls.Border)(target));
            
            #line 600 "..\..\..\MainWindow.xaml"
            this.CanvasBorder.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.paint_MouseDown);
            
            #line default
            #line hidden
            
            #line 601 "..\..\..\MainWindow.xaml"
            this.CanvasBorder.MouseMove += new System.Windows.Input.MouseEventHandler(this.paint_MouseMove);
            
            #line default
            #line hidden
            
            #line 602 "..\..\..\MainWindow.xaml"
            this.CanvasBorder.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.paint_MouseUp);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
