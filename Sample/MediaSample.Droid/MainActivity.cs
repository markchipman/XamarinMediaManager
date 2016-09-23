﻿using Android.App;
using Android.Widget;
using Android.OS;
using MediaManager.Sample.Core;

namespace MediaSample.Droid
{
    [Activity(Label = "MediaSample.Droid", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.myButton);

            button.Click += async delegate {
                var media = new MediaPlayerManager();
                await media.Play();

            };
        }
    }
}


