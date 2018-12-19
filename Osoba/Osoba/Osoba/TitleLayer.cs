using CocosSharp;

namespace Osoba
{
    public class TitleLayer : CCLayerColor
    {

        protected override void AddedToScene()
        {
            base.AddedToScene();
            // タイトル画像を配置
            var title = new CCSprite("/Assets/Images/Title/Title.png", null);
            title.Position = new CCPoint(ContentSize.Center.X, 200);
            AddChild(title);
        }

    }
}
