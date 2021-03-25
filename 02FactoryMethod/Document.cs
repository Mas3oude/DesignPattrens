using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._02FactoryMethod
{
    abstract class Document
    {
        private List<Page> _pages = new List<Page>();
        public Document()
        {
            this.createPages();
        }

        public List<Page> Pages
        {
            get { return this._pages; }
        }
        public abstract void createPages();
    }
}
