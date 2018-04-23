using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;

public class MyHierarchicalView : HierarchicalDataSourceView
{
    public override IHierarchicalEnumerable Select()
    {
        using (DataClassesDataContext context = new DataClassesDataContext())
        {
            List<MyHierarchyData> collection = context.Categories
                .Select(Category => new MyHierarchyData(Category.CategoryID.ToString(), null, Category.CategoryName)).ToList();
            return new MyHierarchicalCollection(collection);
        }
    }
}