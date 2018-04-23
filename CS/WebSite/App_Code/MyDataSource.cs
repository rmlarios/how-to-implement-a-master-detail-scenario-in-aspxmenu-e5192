using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
public class MyDataSource : IHierarchicalDataSource
{
    public event EventHandler DataSourceChanged; // This event is never used, but it's necessary for correct implementation of the IHierarchialDataSource interface

    public HierarchicalDataSourceView GetHierarchicalView(string viewPath)
    {
        return new MyHierarchicalView();
    }
}