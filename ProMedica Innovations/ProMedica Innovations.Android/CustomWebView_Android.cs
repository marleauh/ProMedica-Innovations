﻿using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ProMedica_Innovations;
using ProMedica_Innovations.Droid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomWebView), typeof(CustomWebViewRenderer))]
namespace ProMedica_Innovations.Droid
{
    public class CustomWebViewRenderer : WebViewRenderer
    {

        public CustomWebViewRenderer(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<WebView> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                var customWebView = Element as CustomWebView;
                Control.Settings.AllowUniversalAccessFromFileURLs = true;
                if (!customWebView.IsPdf)
                    Control.LoadUrl(customWebView.Uri);
                else
                    Control.LoadUrl("https://drive.google.com/viewerng/viewer?embedded=true&url=" + customWebView.Uri);
            }
        }
    }
}