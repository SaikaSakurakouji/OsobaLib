using System;
using System.Reflection;
using System.Collections.Generic;
using CocosSharp;

namespace Osoba
{
    public class GameScene : CCScene
    {
        public GameScene(CCGameView gameView) : base(gameView)
        {
            base.AddedToScene();
            GameView.Stats.Enabled = true;
            
            // このアセンブリのすべてのリソースIDを取得
            var assembly = typeof(GameScene).GetTypeInfo().Assembly;
            string[] FileNames = assembly.GetManifestResourceNames();
        }
    }
}
