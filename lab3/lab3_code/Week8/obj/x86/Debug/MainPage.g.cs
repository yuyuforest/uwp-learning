﻿#pragma checksum "C:\Users\yumli\Downloads\现操\16340280_余漫霖_lab3\lab3_code\Week8\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1BA925A09F8C5378A0249C17A0B6337E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Week8
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        internal class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        private class MainPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IMainPage_Bindings
        {
            private global::Week8.MainPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.TextBlock obj14;

            private MainPage_obj1_BindingsTracking bindingsTracking;

            public MainPage_obj1_Bindings()
            {
                this.bindingsTracking = new MainPage_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 14:
                        this.obj14 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            // IMainPage_Bindings

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
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            // MainPage_obj1_Bindings

            public void SetDataRoot(global::Week8.MainPage newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Week8.MainPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_volumnSlider(obj.volumnSlider, phase);
                    }
                }
            }
            private void Update_volumnSlider(global::Windows.UI.Xaml.Controls.Slider obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_volumnSlider(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_volumnSlider_Value(obj.Value, phase);
                    }
                }
            }
            private void Update_volumnSlider_Value(global::System.Double obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj14, obj.ToString(), null);
                }
            }

            private class MainPage_obj1_BindingsTracking
            {
                global::System.WeakReference<MainPage_obj1_Bindings> WeakRefToBindingObj; 

                public MainPage_obj1_BindingsTracking(MainPage_obj1_Bindings obj)
                {
                    WeakRefToBindingObj = new global::System.WeakReference<MainPage_obj1_Bindings>(obj);
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_volumnSlider(null);
                }

                public void DependencyPropertyChanged_volumnSlider_Value(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    MainPage_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        global::Windows.UI.Xaml.Controls.Slider obj = sender as global::Windows.UI.Xaml.Controls.Slider;
        if (obj != null)
        {
            bindings.Update_volumnSlider_Value(obj.Value, DATA_CHANGED);
        }
                    }
                }
                private global::Windows.UI.Xaml.Controls.Slider cache_volumnSlider = null;
                private long tokenDPC_volumnSlider_Value = 0;
                public void UpdateChildListeners_volumnSlider(global::Windows.UI.Xaml.Controls.Slider obj)
                {
                    if (obj != cache_volumnSlider)
                    {
                        if (cache_volumnSlider != null)
                        {
                            cache_volumnSlider.UnregisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.Slider.ValueProperty, tokenDPC_volumnSlider_Value);
                            cache_volumnSlider = null;
                        }
                        if (obj != null)
                        {
                            cache_volumnSlider = obj;
                            tokenDPC_volumnSlider_Value = obj.RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.Slider.ValueProperty, DependencyPropertyChanged_volumnSlider_Value);
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2:
                {
                    this.mediaPlayer = (global::Windows.UI.Xaml.Controls.MediaElement)(target);
                    #line 18 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.MediaElement)this.mediaPlayer).MediaOpened += this.mediaPlayer_Opened;
                    #line 18 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.MediaElement)this.mediaPlayer).MediaEnded += this.mediaPlayer_Ended;
                    #line default
                }
                break;
            case 3:
                {
                    this.tip = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4:
                {
                    this.ellipse = (global::Windows.UI.Xaml.Shapes.Ellipse)(target);
                }
                break;
            case 5:
                {
                    this.mediaSlider = (global::Windows.UI.Xaml.Controls.Slider)(target);
                    #line 33 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Slider)this.mediaSlider).ValueChanged += this.mediaSlider_Changed;
                    #line default
                }
                break;
            case 6:
                {
                    this.imageBrush = (global::Windows.UI.Xaml.Media.ImageBrush)(target);
                }
                break;
            case 7:
                {
                    this.storyboard = (global::Windows.UI.Xaml.Media.Animation.Storyboard)(target);
                }
                break;
            case 8:
                {
                    this.playControl = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 39 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.playControl).Click += this.playControl_Click;
                    #line default
                }
                break;
            case 9:
                {
                    this.stop = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 40 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.stop).Click += this.stop_Click;
                    #line default
                }
                break;
            case 10:
                {
                    this.volumn = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            case 11:
                {
                    this.showSlider = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 55 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.showSlider).Click += this.showSlider_Click;
                    #line default
                }
                break;
            case 12:
                {
                    this.scale = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 56 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.scale).Click += this.scale_Click;
                    #line default
                }
                break;
            case 13:
                {
                    this.open = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 57 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.open).Click += this.openMedia_Click;
                    #line default
                }
                break;
            case 14:
                {
                    this.volumnNum = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 15:
                {
                    this.volumnSlider = (global::Windows.UI.Xaml.Controls.Slider)(target);
                    #line 50 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Slider)this.volumnSlider).ValueChanged += this.volumn_Changed;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    MainPage_obj1_Bindings bindings = new MainPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}

