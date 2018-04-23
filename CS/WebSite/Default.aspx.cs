using DevExpress.Web.ASPxMenu;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.UI;

public partial class _Default : Page
{
    protected void Page_Init(object sender, EventArgs e)
    {
        CreateMenuItems();
    }

    private void CreateMenuItems()
    {
        MyDataSource data = new MyDataSource();        
        Menu.DataSource = data;
        Menu.DataBind();
    }
}
