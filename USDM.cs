using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USDMApp
{
    class USDM
    {
        private List<Require> requires = new List<Require>();//子要求リスト
        private Require require;

        private List<Specification> specifications = new List<Specification>();
        public USDM()
        {
            require = new Require();
            requires.Add(require);
        }

        public void AddRequire(Require _require)
        {
            requires.Add(_require);
        }

        public void AddRequireText(string _text,int numofreq)
        {
            requires[numofreq].text = _text;
        }

        public void AddRequireExplanation(string _explanation, int numofreq)
        {
            requires[numofreq].explanation = _explanation;
        }

        public void AddRequireReson(string _reason,int numofreq)
        {
            requires[numofreq].reason = _reason;
        }
        
        public string getRequireText(int numofreq)
        {
            return requires[numofreq].text;
        }
    }
}
