using KAutoHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonaryAuto
{
    public class StoryStart
    {
        Util util = new Util();

        public void GameStory()
        {
            bool stop = false;
            while (stop == false)
            {
                bool result = util.handleMouseArray("story");
                Console.WriteLine(result);
                //if (resul)
                //{
                //    break;
                //}

            }
        }

        public void handleStoryStart()
        {
            bool stop = false;
            while (stop == false)
            {
                bool resul = util.handleMouseClickPoint("story.png");
                if (resul)
                {
                    GameStory();
                    stop = true;
                }
            }
        }
    }
}
