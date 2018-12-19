using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using CocosSharp;

namespace Osoba.Droid
{
    [Activity(Label = "Osoba", Icon = "@mipmap/icon", Theme = "@style/MainTheme"
        , MainLauncher = true
        , AlwaysRetainTaskState = true
        , LaunchMode = LaunchMode.SingleInstance
        , ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.Keyboard | ConfigChanges.KeyboardHidden)]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // タイトルを非表示にする
            RequestWindowFeature(WindowFeatures.NoTitle);

            var linearLayout = new LinearLayout(this)
            {
                Orientation = Orientation.Vertical
            };

            // ゲーム表示用コントロール作成
            var gameView = new CCGameView(this);

            // ゲーム起動
            if (gameView != null)
                gameView.ViewCreated += GameDelegate.LoadGame;

            linearLayout.AddView(gameView);
            SetContentView(linearLayout);
        }

    }
}