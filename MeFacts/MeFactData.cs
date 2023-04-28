using System;
using System.Collections.Generic;
using System.Text;

namespace MeFacts
{
    class MeFactData
    {
        public MeFactData()
        {
        }
        public static IEnumerable<MeFactData> All { private set; get; }
        public string TheFact { get; set; }
        public string ShortFact { get; set; }
        public string ImageName { get; set; }
        static MeFactData()
        {
            List<MeFactData> all = new List<MeFactData>();
            all.Add(new MeFactData() { TheFact = "I write PL/I as my day job.", ShortFact = "Mainframe", ImageName = "mainframe.png" });
            all.Add(new MeFactData() { TheFact = "I have bowled a perfect 300 game.", ShortFact = "Bowling", ImageName = "bowling.png" });
            all.Add(new MeFactData() { TheFact = "Developing blockchain apps is a hobby of mine.", ShortFact = "Blockchain", ImageName = "blockchain.png" });
            all.Add(new MeFactData() { TheFact = "I am a certified beer judge and home brewer.", ShortFact = "Beer Guy", ImageName = "beer.png" });
            all.Add(new MeFactData() { TheFact = "I have a wife and a daughter.", ShortFact = "Family", ImageName = "family.png" });
            All = all;

        }

    }
}
