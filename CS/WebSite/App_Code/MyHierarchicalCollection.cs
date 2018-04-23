using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;

public class MyHierarchicalCollection : List<MyHierarchyData>, IHierarchicalEnumerable
{
    public MyHierarchicalCollection(IEnumerable<MyHierarchyData> collection)
        : base(collection)
    {
    }

    public MyHierarchicalCollection()
        : base()
    {
    }

    public IHierarchyData GetHierarchyData(object enumeratedItem)
    {
        return enumeratedItem as IHierarchyData;
    }
}