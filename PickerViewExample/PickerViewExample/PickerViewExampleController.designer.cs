// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace ExampleControls
{
    [Register ("PickerViewExampleController")]
    partial class PickerViewExampleController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIPickerView StatusPickerView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (StatusPickerView != null) {
                StatusPickerView.Dispose ();
                StatusPickerView = null;
            }
        }
    }
}