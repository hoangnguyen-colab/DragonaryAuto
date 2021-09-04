using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonaryAuto
{
    public class Constants
    {
        public bool isDev = true;
        public string publicAppVersion = "1.0.0";
        public string devAppVersion = "1.0.1";

        public List<string> storyImgs = new List<string>{
            "network-error.png",
            "exit.png",
            "play.png",
            "mission-8.png",
            "continue.png",
            "claim.png",
            "1x-speed-2.png",
            "manual.png",
            "play-ing.png",
            "story-big.png",
            "mission-new.png",
        };

        public List<string> storyMenuImgs = new List<string>{
            "mission-8.png",
            "story-big.png",
            "mission-new.png",
            "play.png",
        };

        public List<string> storyIngameImgs = new List<string>{
            "network-error.png",
            "exit.png",
            "continue.png",
            "claim.png",
            "1x-speed-2.png",
            "manual.png",
            "play-ing.png",
        };
    }
}
