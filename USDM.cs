using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USDMApp
{
    class USDM
    {
        private List<Reqire> requires = new List<Reqire>();
        private List<Specification> specifications = new List<Specification>();
        public USDM(Reqire _require)
        {
            requires.Add(_require);
        }

        public void AddRequire(Reqire _require)
        {
            requires.Add(_require);
        }

        public void AddRequireText(string _text,int i)
        {
            requires[i].text = _text;
        }

        public void AddRequireExplanation(string _explanation, int i)
        {
            requires[i].explanation = _explanation;
        }

        public void AddRequireReson(string _reason,int i)
        {
            requires[i].reason = _reason;
        }
        
    }
}
