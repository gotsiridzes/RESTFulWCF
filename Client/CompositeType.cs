using System;
using System.Collections.Generic;
using System.Text;

namespace Client
{
    public class CompositeType
    {
        private bool _boolValue;
        private string _stringValue;

        public bool BoolValue
        {
            get { return _boolValue; }
            set { _boolValue = value; }
        }

        public string StringValue
        {
            get { return _stringValue; }
            set { _stringValue = value; }
        }
    }
}
