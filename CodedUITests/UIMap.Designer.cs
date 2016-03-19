﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 14.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace CodedUITests
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public partial class UIMap
    {
        
        /// <summary>
        /// Make3dChartForMathieuFunction - Use 'Make3dChartForMathieuFunctionParams' to pass parameters into this method.
        /// </summary>
        public void Make3dChartForMathieuFunction()
        {
            #region Variable Declarations
            WinEdit uIExpressionTextBoxEdit = this.UIComputatorNETPawełTrWindow.UIExpressionTextBoxWindow.UIExpressionTextBoxEdit;
            WinRadioButton uIItem3DfxyRadioButton = this.UIComputatorNETPawełTrWindow.UIItem3DfxyWindow.UIItem3DfxyRadioButton;
            WinButton uIAddtochartButton = this.UIComputatorNETPawełTrWindow.UIAddtochartWindow.UIAddtochartButton;
            WinButton uICloseButton = this.UIComputatorNETPawełTrWindow.UIComputatorNETPawełTrTitleBar.UICloseButton;
            #endregion

            // Type 'MathieuCE(2,y,x)' in 'expressionTextBox' text box
            uIExpressionTextBoxEdit.Text = this.Make3dChartForMathieuFunctionParams.UIExpressionTextBoxEditText;

            // Select '3D : f(x,y)' radio button
            uIItem3DfxyRadioButton.Selected = this.Make3dChartForMathieuFunctionParams.UIItem3DfxyRadioButtonSelected;

            // Click 'Add to chart' button
            Mouse.Click(uIAddtochartButton, new Point(30, 24));

            // Click 'Close' button
            Mouse.Click(uICloseButton, new Point(33, 19));
        }
        
        /// <summary>
        /// TypeComplicatedRealExpressionAndMake2DChart - Use 'TypeComplicatedRealExpressionAndMake2DChartParams' to pass parameters into this method.
        /// </summary>
        public void TypeComplicatedRealExpressionAndMake2DChart()
        {
            #region Variable Declarations
            WinEdit uIExpressionTextBoxEdit = this.UIComputatorNETPawelTrWindow.UIExpressionTextBoxWindow.UIExpressionTextBoxEdit;
            WinControl uIXaxisMajorGridlinesImage = this.UIComputatorNETPawelTrWindow.UIChartAreaChartArea1Image.UIXaxisMajorGridlinesImage;
            WinButton uIClearchartButton = this.UIComputatorNETPawelTrWindow.UIClearchartWindow.UIClearchartButton;
            WinButton uICloseButton = this.UIComputatorNETPawelTrWindow.UIComputatorNETPawelTrTitleBar.UICloseButton;
            #endregion

            // Type '2·xˣ+x·sin(x)' in 'expressionTextBox' text box
            uIExpressionTextBoxEdit.Text = this.TypeComplicatedRealExpressionAndMake2DChartParams.UIExpressionTextBoxEditText;

            // Type '{Enter}' in 'expressionTextBox' text box
            Keyboard.SendKeys(uIExpressionTextBoxEdit, this.TypeComplicatedRealExpressionAndMake2DChartParams.UIExpressionTextBoxEditSendKeys, ModifierKeys.None);

            // Move using Right button 'X axis Major Gridlines' image
            Mouse.StartDragging(uIXaxisMajorGridlinesImage, new Point(239, 133), MouseButtons.Right, ModifierKeys.None);
            Mouse.StopDragging(uIXaxisMajorGridlinesImage, 51, 7);

            // Move using Right button 'X axis Major Gridlines' image
            Mouse.StartDragging(uIXaxisMajorGridlinesImage, new Point(276, 109), MouseButtons.Right, ModifierKeys.None);
            Mouse.StopDragging(uIXaxisMajorGridlinesImage, -9, -4);

            // Move using Right button 'X axis Major Gridlines' image
            Mouse.StartDragging(uIXaxisMajorGridlinesImage, new Point(274, 134), MouseButtons.Right, ModifierKeys.None);
            Mouse.StopDragging(uIXaxisMajorGridlinesImage, -24, -1);

            // Move using Right button 'X axis Major Gridlines' image
            Mouse.StartDragging(uIXaxisMajorGridlinesImage, new Point(254, 125), MouseButtons.Right, ModifierKeys.None);
            Mouse.StopDragging(uIXaxisMajorGridlinesImage, -18, -26);

            // Move using Right button 'X axis Major Gridlines' image
            Mouse.StartDragging(uIXaxisMajorGridlinesImage, new Point(220, 86), MouseButtons.Right, ModifierKeys.None);
            Mouse.StopDragging(uIXaxisMajorGridlinesImage, -22, 118);

            // Move using Right button 'X axis Major Gridlines' image
            Mouse.StartDragging(uIXaxisMajorGridlinesImage, new Point(198, 195), MouseButtons.Right, ModifierKeys.None);
            Mouse.StopDragging(uIXaxisMajorGridlinesImage, 26, 1);

            // Click 'Clear chart' button
            Mouse.Click(uIClearchartButton, new Point(29, 20));

            // Click 'Close' button
            Mouse.Click(uICloseButton, new Point(23, 12));
        }
        
        #region Properties
        public virtual Make3dChartForMathieuFunctionParams Make3dChartForMathieuFunctionParams
        {
            get
            {
                if ((this.mMake3dChartForMathieuFunctionParams == null))
                {
                    this.mMake3dChartForMathieuFunctionParams = new Make3dChartForMathieuFunctionParams();
                }
                return this.mMake3dChartForMathieuFunctionParams;
            }
        }
        
        public virtual TypeComplicatedRealExpressionAndMake2DChartParams TypeComplicatedRealExpressionAndMake2DChartParams
        {
            get
            {
                if ((this.mTypeComplicatedRealExpressionAndMake2DChartParams == null))
                {
                    this.mTypeComplicatedRealExpressionAndMake2DChartParams = new TypeComplicatedRealExpressionAndMake2DChartParams();
                }
                return this.mTypeComplicatedRealExpressionAndMake2DChartParams;
            }
        }
        
        public UIComputatorNETPawełTrWindow UIComputatorNETPawełTrWindow
        {
            get
            {
                if ((this.mUIComputatorNETPawełTrWindow == null))
                {
                    this.mUIComputatorNETPawełTrWindow = new UIComputatorNETPawełTrWindow();
                }
                return this.mUIComputatorNETPawełTrWindow;
            }
        }
        
        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow();
                }
                return this.mUIItemWindow;
            }
        }
        
        public UIComputatorNETPawelTrWindow UIComputatorNETPawelTrWindow
        {
            get
            {
                if ((this.mUIComputatorNETPawelTrWindow == null))
                {
                    this.mUIComputatorNETPawelTrWindow = new UIComputatorNETPawelTrWindow();
                }
                return this.mUIComputatorNETPawelTrWindow;
            }
        }
        #endregion
        
        #region Fields
        private Make3dChartForMathieuFunctionParams mMake3dChartForMathieuFunctionParams;
        
        private TypeComplicatedRealExpressionAndMake2DChartParams mTypeComplicatedRealExpressionAndMake2DChartParams;
        
        private UIComputatorNETPawełTrWindow mUIComputatorNETPawełTrWindow;
        
        private UIItemWindow mUIItemWindow;
        
        private UIComputatorNETPawelTrWindow mUIComputatorNETPawelTrWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'Make3dChartForMathieuFunction'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class Make3dChartForMathieuFunctionParams
    {
        
        #region Fields
        /// <summary>
        /// Type 'MathieuCE(2,y,x)' in 'expressionTextBox' text box
        /// </summary>
        public string UIExpressionTextBoxEditText = "MathieuCE(2,y,x)";
        
        /// <summary>
        /// Select '3D : f(x,y)' radio button
        /// </summary>
        public bool UIItem3DfxyRadioButtonSelected = true;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'TypeComplicatedRealExpressionAndMake2DChart'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class TypeComplicatedRealExpressionAndMake2DChartParams
    {
        
        #region Fields
        /// <summary>
        /// Type '2·xˣ+x·sin(x)' in 'expressionTextBox' text box
        /// </summary>
        public string UIExpressionTextBoxEditText = "2·xˣ+x·sin(x)";
        
        /// <summary>
        /// Type '{Enter}' in 'expressionTextBox' text box
        /// </summary>
        public string UIExpressionTextBoxEditSendKeys = "{Enter}";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIComputatorNETPawełTrWindow : WinWindow
    {
        
        public UIComputatorNETPawełTrWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Computator.NET © Paweł Troka";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Computator.NET © Paweł Troka");
            #endregion
        }
        
        #region Properties
        public UIExpressionTextBoxWindow UIExpressionTextBoxWindow
        {
            get
            {
                if ((this.mUIExpressionTextBoxWindow == null))
                {
                    this.mUIExpressionTextBoxWindow = new UIExpressionTextBoxWindow(this);
                }
                return this.mUIExpressionTextBoxWindow;
            }
        }
        
        public UIItem3DfxyWindow UIItem3DfxyWindow
        {
            get
            {
                if ((this.mUIItem3DfxyWindow == null))
                {
                    this.mUIItem3DfxyWindow = new UIItem3DfxyWindow(this);
                }
                return this.mUIItem3DfxyWindow;
            }
        }
        
        public UIAddtochartWindow UIAddtochartWindow
        {
            get
            {
                if ((this.mUIAddtochartWindow == null))
                {
                    this.mUIAddtochartWindow = new UIAddtochartWindow(this);
                }
                return this.mUIAddtochartWindow;
            }
        }
        
        public UIComplexfzWindow UIComplexfzWindow
        {
            get
            {
                if ((this.mUIComplexfzWindow == null))
                {
                    this.mUIComplexfzWindow = new UIComplexfzWindow(this);
                }
                return this.mUIComplexfzWindow;
            }
        }
        
        public UIComputatorNETPawełTrTitleBar UIComputatorNETPawełTrTitleBar
        {
            get
            {
                if ((this.mUIComputatorNETPawełTrTitleBar == null))
                {
                    this.mUIComputatorNETPawełTrTitleBar = new UIComputatorNETPawełTrTitleBar(this);
                }
                return this.mUIComputatorNETPawełTrTitleBar;
            }
        }
        #endregion
        
        #region Fields
        private UIExpressionTextBoxWindow mUIExpressionTextBoxWindow;
        
        private UIItem3DfxyWindow mUIItem3DfxyWindow;
        
        private UIAddtochartWindow mUIAddtochartWindow;
        
        private UIComplexfzWindow mUIComplexfzWindow;
        
        private UIComputatorNETPawełTrTitleBar mUIComputatorNETPawełTrTitleBar;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIExpressionTextBoxWindow : WinWindow
    {
        
        public UIExpressionTextBoxWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "expressionTextBox";
            this.WindowTitles.Add("Computator.NET © Paweł Troka");
            #endregion
        }
        
        #region Properties
        public WinEdit UIExpressionTextBoxEdit
        {
            get
            {
                if ((this.mUIExpressionTextBoxEdit == null))
                {
                    this.mUIExpressionTextBoxEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUIExpressionTextBoxEdit.WindowTitles.Add("Computator.NET © Paweł Troka");
                    #endregion
                }
                return this.mUIExpressionTextBoxEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUIExpressionTextBoxEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIItem3DfxyWindow : WinWindow
    {
        
        public UIItem3DfxyWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "fxyModeRadioBox";
            this.WindowTitles.Add("Computator.NET © Paweł Troka");
            #endregion
        }
        
        #region Properties
        public WinRadioButton UIItem3DfxyRadioButton
        {
            get
            {
                if ((this.mUIItem3DfxyRadioButton == null))
                {
                    this.mUIItem3DfxyRadioButton = new WinRadioButton(this);
                    #region Search Criteria
                    this.mUIItem3DfxyRadioButton.SearchProperties[WinRadioButton.PropertyNames.Name] = "3D : f(x,y)";
                    this.mUIItem3DfxyRadioButton.WindowTitles.Add("Computator.NET © Paweł Troka");
                    #endregion
                }
                return this.mUIItem3DfxyRadioButton;
            }
        }
        #endregion
        
        #region Fields
        private WinRadioButton mUIItem3DfxyRadioButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIAddtochartWindow : WinWindow
    {
        
        public UIAddtochartWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "addToChartButton";
            this.WindowTitles.Add("Computator.NET © Paweł Troka");
            #endregion
        }
        
        #region Properties
        public WinButton UIAddtochartButton
        {
            get
            {
                if ((this.mUIAddtochartButton == null))
                {
                    this.mUIAddtochartButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIAddtochartButton.SearchProperties[WinButton.PropertyNames.Name] = "Add to chart";
                    this.mUIAddtochartButton.WindowTitles.Add("Computator.NET © Paweł Troka");
                    #endregion
                }
                return this.mUIAddtochartButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIAddtochartButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIComplexfzWindow : WinWindow
    {
        
        public UIComplexfzWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "complexNumbersModeRadioBox";
            this.WindowTitles.Add("Computator.NET © Paweł Troka");
            #endregion
        }
        
        #region Properties
        public WinRadioButton UIComplexfzRadioButton
        {
            get
            {
                if ((this.mUIComplexfzRadioButton == null))
                {
                    this.mUIComplexfzRadioButton = new WinRadioButton(this);
                    #region Search Criteria
                    this.mUIComplexfzRadioButton.SearchProperties[WinRadioButton.PropertyNames.Name] = "Complex : f(z)";
                    this.mUIComplexfzRadioButton.WindowTitles.Add("Computator.NET © Paweł Troka");
                    #endregion
                }
                return this.mUIComplexfzRadioButton;
            }
        }
        #endregion
        
        #region Fields
        private WinRadioButton mUIComplexfzRadioButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIComputatorNETPawełTrTitleBar : WinTitleBar
    {
        
        public UIComputatorNETPawełTrTitleBar(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.WindowTitles.Add("Computator.NET © Paweł Troka");
            #endregion
        }
        
        #region Properties
        public WinButton UICloseButton
        {
            get
            {
                if ((this.mUICloseButton == null))
                {
                    this.mUICloseButton = new WinButton(this);
                    #region Search Criteria
                    this.mUICloseButton.SearchProperties[WinButton.PropertyNames.Name] = "Close";
                    this.mUICloseButton.WindowTitles.Add("Computator.NET © Paweł Troka");
                    #endregion
                }
                return this.mUICloseButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUICloseButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIItemWindow : WinWindow
    {
        
        public UIItemWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.AccessibleName] = "DropDown";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            #endregion
        }
        
        #region Properties
        public UIItemWindow1 UIItemWindow1
        {
            get
            {
                if ((this.mUIItemWindow1 == null))
                {
                    this.mUIItemWindow1 = new UIItemWindow1(this);
                }
                return this.mUIItemWindow1;
            }
        }
        #endregion
        
        #region Fields
        private UIItemWindow1 mUIItemWindow1;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIItemWindow1 : WinWindow
    {
        
        public UIItemWindow1(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            #endregion
        }
        
        #region Properties
        public WinClient UIDropDownClient
        {
            get
            {
                if ((this.mUIDropDownClient == null))
                {
                    this.mUIDropDownClient = new WinClient(this);
                }
                return this.mUIDropDownClient;
            }
        }
        #endregion
        
        #region Fields
        private WinClient mUIDropDownClient;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIComputatorNETPawelTrWindow : WinWindow
    {
        
        public UIComputatorNETPawelTrWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Computator.NET © Pawel Troka";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Computator.NET © Pawel Troka");
            #endregion
        }
        
        #region Properties
        public UIExpressionTextBoxWindow1 UIExpressionTextBoxWindow
        {
            get
            {
                if ((this.mUIExpressionTextBoxWindow == null))
                {
                    this.mUIExpressionTextBoxWindow = new UIExpressionTextBoxWindow1(this);
                }
                return this.mUIExpressionTextBoxWindow;
            }
        }
        
        public UIChartAreaChartArea1Image UIChartAreaChartArea1Image
        {
            get
            {
                if ((this.mUIChartAreaChartArea1Image == null))
                {
                    this.mUIChartAreaChartArea1Image = new UIChartAreaChartArea1Image(this);
                }
                return this.mUIChartAreaChartArea1Image;
            }
        }
        
        public UIClearchartWindow UIClearchartWindow
        {
            get
            {
                if ((this.mUIClearchartWindow == null))
                {
                    this.mUIClearchartWindow = new UIClearchartWindow(this);
                }
                return this.mUIClearchartWindow;
            }
        }
        
        public UIComputatorNETPawelTrTitleBar UIComputatorNETPawelTrTitleBar
        {
            get
            {
                if ((this.mUIComputatorNETPawelTrTitleBar == null))
                {
                    this.mUIComputatorNETPawelTrTitleBar = new UIComputatorNETPawelTrTitleBar(this);
                }
                return this.mUIComputatorNETPawelTrTitleBar;
            }
        }
        #endregion
        
        #region Fields
        private UIExpressionTextBoxWindow1 mUIExpressionTextBoxWindow;
        
        private UIChartAreaChartArea1Image mUIChartAreaChartArea1Image;
        
        private UIClearchartWindow mUIClearchartWindow;
        
        private UIComputatorNETPawelTrTitleBar mUIComputatorNETPawelTrTitleBar;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIExpressionTextBoxWindow1 : WinWindow
    {
        
        public UIExpressionTextBoxWindow1(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "expressionTextBox";
            this.WindowTitles.Add("Computator.NET © Pawel Troka");
            #endregion
        }
        
        #region Properties
        public WinEdit UIExpressionTextBoxEdit
        {
            get
            {
                if ((this.mUIExpressionTextBoxEdit == null))
                {
                    this.mUIExpressionTextBoxEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUIExpressionTextBoxEdit.SearchProperties[WinEdit.PropertyNames.Name] = "Expression:";
                    this.mUIExpressionTextBoxEdit.WindowTitles.Add("Computator.NET © Pawel Troka");
                    #endregion
                }
                return this.mUIExpressionTextBoxEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUIExpressionTextBoxEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIChartAreaChartArea1Image : WinControl
    {
        
        public UIChartAreaChartArea1Image(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.Name] = "Chart Area ChartArea1";
            this.SearchProperties[UITestControl.PropertyNames.ControlType] = "Image";
            this.WindowTitles.Add("Computator.NET © Pawel Troka");
            #endregion
        }
        
        #region Properties
        public WinControl UIXaxisMajorGridlinesImage
        {
            get
            {
                if ((this.mUIXaxisMajorGridlinesImage == null))
                {
                    this.mUIXaxisMajorGridlinesImage = new WinControl(this);
                    #region Search Criteria
                    this.mUIXaxisMajorGridlinesImage.SearchProperties[UITestControl.PropertyNames.Name] = "X axis Major Gridlines";
                    this.mUIXaxisMajorGridlinesImage.SearchProperties[UITestControl.PropertyNames.ControlType] = "Image";
                    this.mUIXaxisMajorGridlinesImage.WindowTitles.Add("Computator.NET © Pawel Troka");
                    #endregion
                }
                return this.mUIXaxisMajorGridlinesImage;
            }
        }
        #endregion
        
        #region Fields
        private WinControl mUIXaxisMajorGridlinesImage;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIClearchartWindow : WinWindow
    {
        
        public UIClearchartWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "clearChartButton";
            this.WindowTitles.Add("Computator.NET © Pawel Troka");
            #endregion
        }
        
        #region Properties
        public WinButton UIClearchartButton
        {
            get
            {
                if ((this.mUIClearchartButton == null))
                {
                    this.mUIClearchartButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIClearchartButton.SearchProperties[WinButton.PropertyNames.Name] = "Clear chart";
                    this.mUIClearchartButton.WindowTitles.Add("Computator.NET © Pawel Troka");
                    #endregion
                }
                return this.mUIClearchartButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIClearchartButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIComputatorNETPawelTrTitleBar : WinTitleBar
    {
        
        public UIComputatorNETPawelTrTitleBar(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.WindowTitles.Add("Computator.NET © Pawel Troka");
            #endregion
        }
        
        #region Properties
        public WinButton UICloseButton
        {
            get
            {
                if ((this.mUICloseButton == null))
                {
                    this.mUICloseButton = new WinButton(this);
                    #region Search Criteria
                    this.mUICloseButton.SearchProperties[WinButton.PropertyNames.Name] = "Close";
                    this.mUICloseButton.WindowTitles.Add("Computator.NET © Pawel Troka");
                    #endregion
                }
                return this.mUICloseButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUICloseButton;
        #endregion
    }
}