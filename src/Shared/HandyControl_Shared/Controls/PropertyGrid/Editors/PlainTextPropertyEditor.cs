﻿using System.Windows;
using System.Windows.Data;

namespace HandyControl.Controls
{
    public class PlainTextPropertyEditor : PropertyEditorBase
    {
        public override FrameworkElement CreateElement(PropertyItem propertyItem) => new System.Windows.Controls.TextBox
        {
            IsReadOnly = propertyItem.IsReadOnly
        };

        public override DependencyProperty GetDependencyProperty() => System.Windows.Controls.TextBox.TextProperty;

        public override BindingMode GetBindingMode(PropertyItem propertyItem) => BindingMode.OneWay;
    }
}