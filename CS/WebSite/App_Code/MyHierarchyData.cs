using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;

public class MyHierarchyData : IHierarchyData
{
    private MyHierarchyData()
    {
    }

    public MyHierarchyData(string id, string parentID, string text)
    {
        this.ID = id;
        this.ParentID = parentID;
        this.DisplayText = text;
    }

    public object Item { get { return this; } }
    public string Path { get { return this.ID; } }
    public string Type { get { return this.GetType().ToString(); } }

    public bool HasChildren
    {
        get
        {
            MyHierarchicalCollection children = GetChildren() as MyHierarchicalCollection;
            return children.Count > 0;
        }
    }

    public string ID { get; set; }
    public string ParentID { get; set; }
    public string DisplayText { get; set; }

    public override string ToString() { return this.DisplayText; }

    public IHierarchicalEnumerable GetChildren()
    {
        if (this.ID.Contains(';')) // ';' is separator between CategoryID and ProductID
            return new MyHierarchicalCollection();
        using (DataClassesDataContext context = new DataClassesDataContext())
        {
            int categoryID = context.Categories
                .Where(category => category.CategoryID.ToString() == this.ID)
                .Select(category => category.CategoryID)
                .FirstOrDefault();
            MyHierarchyData[] collection = context.Products
                .Where(product => categoryID == product.CategoryID)
                .Select(product => new MyHierarchyData(String.Format("{0};{1}", this.ID, product.ProductID), this.ID, product.ProductName))
                .ToArray();
            return new MyHierarchicalCollection(collection);
        }
    }

    public IHierarchyData GetParent()
    {
        if (!this.ID.Contains(';'))
            return null;
        using (DataClassesDataContext context = new DataClassesDataContext())
            return context.Categories
                .Where(category => category.CategoryID.ToString() == this.ParentID)
                .Select(category => new MyHierarchyData(category.CategoryID.ToString(), null, category.CategoryName))
                .FirstOrDefault();
    }

}