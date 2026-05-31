using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgurWinform.Models
{
    internal class KeyValueModel
    {
        public string Key { get; set; }
        public string Value { get; set; }

        public KeyValueModel(string Key, string Value)
        {
            this.Key = Key;
            this.Value = Value;
        }
    }
}
