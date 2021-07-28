using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsvViewer
{
    class ComboBoxItem
    {
        private string id;
        private string name;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public override string ToString()
        {
            return name;
        }
    }
}
