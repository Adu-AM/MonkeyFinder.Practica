using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyFinder.Core
{
    public class Monkey
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Details { get; set; }
        public string _image;
        public string Image { set { _image = value; } }
        public Uri ImageUri { get { return new Uri(_image); } }
        public long Population { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

    }
}
