using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinTrics.FormsGallery
{
    public class MasterPageItem
    {
        public string Title { get; set; }

        public string IconSource { get; set; }

        public Type TargetType { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }
}
