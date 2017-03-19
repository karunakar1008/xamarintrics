using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using XamarinTrics.PhonewordApp;
using System.Threading.Tasks;
using XamarinTrics.iOS.Helpers;
using Xamarin.Forms;
using UIKit;
using Foundation;

[assembly: Dependency(typeof(PhoneDialer))]
namespace XamarinTrics.iOS.Helpers
{
    public class PhoneDialer : IDialer
    {
        public Task<bool> DialAsync(string number)
        {
            return Task.FromResult(
                UIApplication.SharedApplication.OpenUrl(
                new NSUrl("tel:" + number))
            );
        }
    }
}