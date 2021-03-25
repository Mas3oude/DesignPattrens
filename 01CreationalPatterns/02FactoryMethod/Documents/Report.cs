using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._02FactoryMethod.Documents
{
    class Report : Document
    {
        public override void createPages()
        {
            Pages.Add(new IntroductionPage());
            Pages.Add(new ResultsPage());
            Pages.Add(new ConculusionPage());
            Pages.Add(new SummaryPage());
        }
    }
}
