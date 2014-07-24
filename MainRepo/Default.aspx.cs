using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SharedRepo;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var rep = new SharedRepo.RepoShare();
        Label1.Text = "HELLO" +  rep.getNumber();
    }
}