﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class xiangqing : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            dbind();
        }
    }
    public void dbind()
    {
        string lb = Request.QueryString["id"];
        SqlConnection conn = new SqlConnection("server=.;database=keti;uid=liubin;pwd=123;");
        conn.Open();
        SqlDataAdapter adapter = new SqlDataAdapter("select * from tupian1 where xinghao='"+lb+"'", conn);
        DataTable dt = new DataTable();
        adapter.Fill(dt);
        this.GridView1.DataSource = dt;
        this.GridView1.DataKeyNames = new string[] { "xinghao" };
        this.GridView1.DataBind();
        conn.Close();
    }
}