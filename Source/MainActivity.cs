using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace Oakay;

[Activity(Label = "@string/app_name", MainLauncher = true)]
public class MainActivity : AppCompatActivity
{
    private Button _openButton = null!;
    
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
        
        SetContentView(Resource.Layout.activity_main);
        InitializeViews();
        WireEvents();
    }
    
    private void InitializeViews()
    {
        _openButton = FindViewById<Button>(Resource.Id.open_button) ?? throw new Exception();
    }

    private void WireEvents()
    {
        _openButton.Click += OnOpenButtonClick;
    }

    private void OnOpenButtonClick(object? sender, EventArgs e)
    {
        var intent = new Intent(this, typeof(OpenActivity));
        StartActivity(intent);
    }
}