using System;
using CocosSharp;
using CocosDenshion;
using Xamarin.Forms;
using System.Collections.Generic;

namespace Osoba
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


            GameScene gameScene = null;
            var contentSearchPaths = new List<string>() { "Fonts", "Sounds", "Images" };
            var gameView = new CocosSharpView()
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
                ViewCreated = (sender, e) =>
                {
                    var ccgameView = sender as CCGameView;
                    ccgameView.DesignResolution = new CCSizeI(100, 100);
                    ccgameView.ContentManager.SearchPaths = contentSearchPaths;
                    gameScene = new GameScene(ccgameView);

                    gameScene.AddLayer(new GameLayer());
                    ccgameView.RunWithScene(gameScene);
                }
            };

            MyGrid.Children.Add(gameView, 0, 0);
        }
        
    }
}