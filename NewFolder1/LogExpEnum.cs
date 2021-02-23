using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace laba4
{
    public class LogExpEnum
    {
        public List<Filter> filters;

    public void AddFilter(Filter new_filter)
    {
        filters.Add(new_filter);
    }

    public LogExpEnum()
    {
        filters = new List<Filter>();
    }
}
}