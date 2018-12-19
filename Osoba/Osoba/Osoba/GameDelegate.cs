using System;
using System.Collections.Generic;
using CocosSharp;

namespace Osoba
{
    public static class GameDelegate
    {
        public static void LoadGame(object sender, EventArgs e)
        {
            var gameView = sender as CCGameView;
            if (gameView == null) { return; }

            // デザイン解像度設定
            gameView.DesignResolution = new CCSizeI(224, 380);
            gameView.ResolutionPolicy = CCViewResolutionPolicy.ShowAll;

            // コンテンツパス設定
            var contentSearchPaths = new List<string>() { "Images", "Sounds" };
            gameView.ContentManager.SearchPaths = contentSearchPaths;

            // タイトル画面のシーン作成、セット
            var gameScene = new CCScene(gameView);
            gameScene.AddLayer(new TitleLayer());

            // ゲーム開始
            gameView.RunWithScene(gameScene);
        }
    }
}