﻿#pragma checksum "C:\Users\lezlo\source\repos\ScreenCapture\ScreenCapture\StaticSettingsCard.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "76146767A8967ADFB5AD238EEB4461F82D791E4E62CB96F5D0CAA64C2357EE1D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ScreenCapture
{
    partial class StaticSettingsCard : 
        global::Windows.UI.Xaml.Controls.UserControl, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_ContentControl_Content(global::Windows.UI.Xaml.Controls.ContentControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.Content = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_ContentControl_ContentTemplate(global::Windows.UI.Xaml.Controls.ContentControl obj, global::Windows.UI.Xaml.DataTemplate value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.DataTemplate) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.DataTemplate), targetNullValue);
                }
                obj.ContentTemplate = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_ContentControl_ContentTemplateSelector(global::Windows.UI.Xaml.Controls.ContentControl obj, global::Windows.UI.Xaml.Controls.DataTemplateSelector value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.Controls.DataTemplateSelector) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Controls.DataTemplateSelector), targetNullValue);
                }
                obj.ContentTemplateSelector = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class StaticSettingsCard_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IStaticSettingsCard_Bindings
        {
            private global::ScreenCapture.StaticSettingsCard dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.ContentControl obj2;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj2ContentDisabled = false;
            private static bool isobj2ContentTemplateDisabled = false;
            private static bool isobj2ContentTemplateSelectorDisabled = false;

            public StaticSettingsCard_obj1_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 24 && columnNumber == 13)
                {
                    isobj2ContentDisabled = true;
                }
                else if (lineNumber == 25 && columnNumber == 13)
                {
                    isobj2ContentTemplateDisabled = true;
                }
                else if (lineNumber == 26 && columnNumber == 13)
                {
                    isobj2ContentTemplateSelectorDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2: // StaticSettingsCard.xaml line 19
                        this.obj2 = (global::Windows.UI.Xaml.Controls.ContentControl)target;
                        break;
                    default:
                        break;
                }
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
            }

            public void Recycle()
            {
                return;
            }

            // IStaticSettingsCard_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::ScreenCapture.StaticSettingsCard)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::ScreenCapture.StaticSettingsCard obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Innards(obj.Innards, phase);
                        this.Update_InnardsTemplate(obj.InnardsTemplate, phase);
                        this.Update_InnardsTemplateSelector(obj.InnardsTemplateSelector, phase);
                    }
                }
            }
            private void Update_Innards(global::System.Object obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // StaticSettingsCard.xaml line 19
                    if (!isobj2ContentDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ContentControl_Content(this.obj2, obj, null);
                    }
                }
            }
            private void Update_InnardsTemplate(global::Windows.UI.Xaml.DataTemplate obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // StaticSettingsCard.xaml line 19
                    if (!isobj2ContentTemplateDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ContentControl_ContentTemplate(this.obj2, obj, null);
                    }
                }
            }
            private void Update_InnardsTemplateSelector(global::Windows.UI.Xaml.Controls.DataTemplateSelector obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // StaticSettingsCard.xaml line 19
                    if (!isobj2ContentTemplateSelectorDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ContentControl_ContentTemplateSelector(this.obj2, obj, null);
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // StaticSettingsCard.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.UserControl element1 = (global::Windows.UI.Xaml.Controls.UserControl)target;
                    StaticSettingsCard_obj1_Bindings bindings = new StaticSettingsCard_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}
