using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using XamarinTrics.PhonewordApp;
using System.Threading.Tasks;

using Uri = Android.Net.Uri;
using Xamarin.Forms;
using XamarinTrics.Droid.Helpers;
using Android.Telephony;

[assembly: Dependency(typeof(PhoneDialer))]
namespace XamarinTrics.Droid.Helpers
{
    public class PhoneDialer : IDialer
    {
        /// <summary>
        /// Dial the phone
        /// </summary>
        public Task<bool> DialAsync(string number)
        {
            var context = Forms.Context;
            if (context != null)
            {
                var intent = new Intent(Intent.ActionCall);
                intent.SetData(Uri.Parse("tel:" + number));

                if (IsIntentAvailable(context, intent))
                {
                    context.StartActivity(intent);
                    return Task.FromResult(true);
                }
            }

            return Task.FromResult(false);
        }

        /// <summary>
        /// Checks if an intent can be handled.
        /// </summary>
		public static bool IsIntentAvailable(Context context, Intent intent)
        {
            var packageManager = context.PackageManager;

            var list = packageManager.QueryIntentServices(intent, 0)
                .Union(packageManager.QueryIntentActivities(intent, 0));
            if (list.Any())
                return true;

            TelephonyManager mgr = TelephonyManager.FromContext(context);
            return mgr.PhoneType != PhoneType.None;
        }
    }
}