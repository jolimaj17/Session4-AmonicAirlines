using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session4
{
    public partial class Detailed : Form
    {

        SQLConnect r = new SQLConnect();
        String sql;
        public Detailed()
        {
            InitializeComponent();
        }

        private void Detailed_Load(object sender, EventArgs e)
        {
            Q1();
            Q2();
            Q3();
           Q4();
            Graph();
        }

        private void Graph()
        {
            sql = @"select Q1, cast(sum(Q4)as float)/100 as total from survey where Q1<>0 group by Q1 order by Q1 asc";
            q1.DataSource = r.MultipleData(sql).Tables["tbl"];
            q1.Series[0].XValueMember = "Q1";
            q1.Series[0].YValueMembers = "total";

            q1.DataBind();

            q1.Series[0].Points[0].Color = ColorTranslator.FromHtml("#F79420");
            q1.Series[0].Points[1].Color = ColorTranslator.FromHtml("#064B66");
            q1.Series[0].Points[2].Color = ColorTranslator.FromHtml("#132B4F");
            q1.Series[0].Points[3].Color = ColorTranslator.FromHtml("#00A0BB");
            q1.Series[0].Points[4].Color = ColorTranslator.FromHtml("#c2912e");
            q1.Series[0].Points[5].Color = ColorTranslator.FromHtml("#fac826");
            q1.Series[0].Points[0].Color = ColorTranslator.FromHtml("#fffacb");

            sql = @"select Q2, cast(sum(Q4)as float)/100 as total from survey where Q2<>0 group by Q2 order by Q2 asc";
            q2.DataSource = r.MultipleData(sql).Tables["tbl"];
            q2.Series[0].XValueMember = "Q2";
            q2.Series[0].YValueMembers = "total";

            q2.DataBind();

            q2.Series[0].Points[0].Color = ColorTranslator.FromHtml("#F79420");
            q2.Series[0].Points[1].Color = ColorTranslator.FromHtml("#064B66");
            q2.Series[0].Points[2].Color = ColorTranslator.FromHtml("#132B4F");
            q2.Series[0].Points[3].Color = ColorTranslator.FromHtml("#00A0BB");
            q2.Series[0].Points[4].Color = ColorTranslator.FromHtml("#c2912e");
            q2.Series[0].Points[5].Color = ColorTranslator.FromHtml("#fac826");
            q2.Series[0].Points[0].Color = ColorTranslator.FromHtml("#fffacb");

            sql = @"select Q3, cast(sum(Q4)as float)/100 as total from survey where Q3<>0 group by Q3 order by Q3 asc";
            q3.DataSource = r.MultipleData(sql).Tables["tbl"];
            q3.Series[0].XValueMember = "Q3";
            q3.Series[0].YValueMembers = "total";

            q3.DataBind();

            q3.Series[0].Points[0].Color = ColorTranslator.FromHtml("#F79420");
            q3.Series[0].Points[1].Color = ColorTranslator.FromHtml("#064B66");
            q3.Series[0].Points[2].Color = ColorTranslator.FromHtml("#132B4F");
            q3.Series[0].Points[3].Color = ColorTranslator.FromHtml("#00A0BB");
            q3.Series[0].Points[4].Color = ColorTranslator.FromHtml("#c2912e");
            q3.Series[0].Points[5].Color = ColorTranslator.FromHtml("#fac826");
            q3.Series[0].Points[0].Color = ColorTranslator.FromHtml("#fffacb");

            sql = @"select Q4, cast(sum(Q4)as float)/100 as total from survey where Q4<>0 group by Q4 order by Q4 asc";
            q4.DataSource = r.MultipleData(sql).Tables["tbl"];
            q4.Series[0].XValueMember = "Q4";
            q4.Series[0].YValueMembers = "total";

            q4.DataBind();

            q4.Series[0].Points[0].Color = ColorTranslator.FromHtml("#F79420");
            q4.Series[0].Points[1].Color = ColorTranslator.FromHtml("#064B66");
            q4.Series[0].Points[2].Color = ColorTranslator.FromHtml("#132B4F");
            q4.Series[0].Points[3].Color = ColorTranslator.FromHtml("#00A0BB");
            q4.Series[0].Points[4].Color = ColorTranslator.FromHtml("#c2912e");
            q4.Series[0].Points[5].Color = ColorTranslator.FromHtml("#fac826");
            q4.Series[0].Points[0].Color = ColorTranslator.FromHtml("#fffacb");

        }
        private void Q1()
        {
            sql = "Select Count(*) from survey where Gender='M' and Q1<>0 group by Q1 order by Q1 asc ";
            q1male.DataSource = r.MultipleData(sql).Tables["tbl"];
            sql = "Select Count(*) from survey where Gender='F' and Q1<>0 group by Q1 order by Q1 asc ";
            q1fem.DataSource = r.MultipleData(sql).Tables["tbl"];
            sql = "Select Count(*) from survey where Age between 18 and 24 and Q1<>0 group by Q1 order by Q1 asc ";
            q118.DataSource = r.MultipleData(sql).Tables["tbl"];
            sql = "Select Count(*) from survey where Age between 25 and 39 and Q1<>0 group by Q1 order by Q1 asc ";
            q125.DataSource = r.MultipleData(sql).Tables["tbl"];
            sql = "Select Count(*) from survey where Age between 40 and 59 and Q1<>0 group by Q1 order by Q1 asc ";
            q140.DataSource = r.MultipleData(sql).Tables["tbl"];
            sql = "Select Count(*) from survey where Age >=60 and Q1<>0 group by Q1 order by Q1 asc ";
            q160.DataSource = r.MultipleData(sql).Tables["tbl"];
            sql = "Select Count(*) from survey where CabinID =1 and Q1<>0 group by Q1 order by Q1 asc ";
            q1eco.DataSource = r.MultipleData(sql).Tables["tbl"];
            sql = "Select Count(*) from survey where CabinID =2 and Q1<>0 group by Q1 order by Q1 asc ";
            q1busin.DataSource = r.MultipleData(sql).Tables["tbl"];
            sql = "Select Count(*) from survey where CabinID =3 and Q1<>0 group by Q1 order by Q1 asc ";
            q1fc.DataSource = r.MultipleData(sql).Tables["tbl"];
            sql = "Select Count(*) from survey where ArrivalID=1 and Q1<>0 group by Q1 order by Q1 asc ";
            q1auh.DataSource = r.MultipleData(sql).Tables["tbl"];
            sql = "Select Count(*) from survey where ArrivalID=3 and Q1<>0 group by Q1 order by Q1 asc ";
            q1bah.DataSource = r.MultipleData(sql).Tables["tbl"];
            sql = "Select Count(*) from survey where ArrivalID=5 and Q1<>0 group by Q1 order by Q1 asc ";
            q1doh.DataSource = r.MultipleData(sql).Tables["tbl"];
            sql = "Select Count(*) from survey where ArrivalID=6 and Q1<>0 group by Q1 order by Q1 asc ";
            q1ryu.DataSource = r.MultipleData(sql).Tables["tbl"];
            sql = "Select Count(*) from survey where ArrivalID=2 and Q1<>0 group by Q1 order by Q1 asc ";
            q1cai.DataSource = r.MultipleData(sql).Tables["tbl"];

        }
        private void Q2()
        {
            sql = "Select Count(*) from survey where Gender='M' and Q2<>0 group by Q2 order by Q2 asc ";
            q2male.DataSource = r.MultipleData(sql).Tables["tbl"];
            sql = "Select Count(*) from survey where Gender='F' and Q2<>0 group by Q2 order by Q2 asc ";
            q2fem.DataSource = r.MultipleData(sql).Tables["tbl"];
            sql = "Select Count(*) from survey where Age between 18 and 24 and Q2<>0 group by Q2 order by Q2 asc ";
            q2188.DataSource = r.MultipleData(sql).Tables["tbl"];
            sql = "Select Count(*) from survey where Age between 25 and 39 and Q2<>0 group by Q2 order by Q2 asc ";
            q225.DataSource = r.MultipleData(sql).Tables["tbl"];
            sql = "Select Count(*) from survey where Age between 40 and 59 and Q2<>0 group by Q2 order by Q2 asc ";
            q240.DataSource = r.MultipleData(sql).Tables["tbl"];
            sql = "Select Count(*) from survey where Age >=60 and Q2<>0 group by Q2 order by Q2 asc ";
            q260.DataSource = r.MultipleData(sql).Tables["tbl"];
            sql = "Select Count(*) from survey where CabinID =1 and Q2<>0 group by Q2 order by Q2 asc ";
            q2eco.DataSource = r.MultipleData(sql).Tables["tbl"];
            sql = "Select Count(*) from survey where CabinID =2 and Q2<>0 group by Q2 order by Q2 asc ";
            q2business.DataSource = r.MultipleData(sql).Tables["tbl"];
            sql = "Select Count(*) from survey where CabinID =3 and Q2<>0 group by Q2 order by Q2 asc ";
            q2fc.DataSource = r.MultipleData(sql).Tables["tbl"];
            sql = "Select Count(*) from survey where ArrivalID=1 and Q2<>0 group by Q2 order by Q2 asc ";
            q2auh.DataSource = r.MultipleData(sql).Tables["tbl"];
            sql = "Select Count(*) from survey where ArrivalID=3 and Q2<>0 group by Q2 order by Q2 asc ";
            q2bah.DataSource = r.MultipleData(sql).Tables["tbl"];
            sql = "Select Count(*) from survey where ArrivalID=5 and Q2<>0 group by Q2 order by Q2 asc ";
            q2doh.DataSource = r.MultipleData(sql).Tables["tbl"];
            sql = "Select Count(*) from survey where ArrivalID=6 and Q2<>0 group by Q2 order by Q2 asc ";
            q2ryu.DataSource = r.MultipleData(sql).Tables["tbl"];
            sql = "Select Count(*) from survey where ArrivalID=2 and Q2<>0 group by Q2 order by Q2 asc ";
            q2caii.DataSource = r.MultipleData(sql).Tables["tbl"];

        }
        private void Q3()
        {
            sql = "Select Count(*) from survey where Gender='M' and Q3<>0 group by Q3 order by Q3 asc ";
            q4male.DataSource = r.MultipleData(sql).Tables["tbl"];
            sql = "Select Count(*) from survey where Gender='F' and Q3<>0 group by Q3 order by Q3 asc ";
            q4femmm.DataSource = r.MultipleData(sql).Tables["tbl"];
            sql = "Select Count(*) from survey where Age between 18 and 24 and Q3<>0 group by Q3 order by Q3 asc ";
            q4188.DataSource = r.MultipleData(sql).Tables["tbl"];
            sql = "Select Count(*) from survey where Age between 25 and 39 and Q3<>0 group by Q3 order by Q3 asc ";
            q424.DataSource = r.MultipleData(sql).Tables["tbl"];
            sql = "Select Count(*) from survey where Age between 40 and 59 and Q3<>0 group by Q3 order by Q3 asc ";
            q4400.DataSource = r.MultipleData(sql).Tables["tbl"];
            sql = "Select Count(*) from survey where Age >=60 and Q3<>0 group by Q3 order by Q3 asc ";
            q4600.DataSource = r.MultipleData(sql).Tables["tbl"];
            sql = "Select Count(*) from survey where CabinID =1 and Q3<>0 group by Q3 order by Q3 asc ";
            q4ecoo.DataSource = r.MultipleData(sql).Tables["tbl"];
            sql = "Select Count(*) from survey where CabinID =2 and Q3<>0 group by Q3 order by Q3 asc ";
            q4bui.DataSource = r.MultipleData(sql).Tables["tbl"];
            sql = "Select Count(*) from survey where CabinID =3 and Q3<>0 group by Q3 order by Q3 asc ";
            q4fc.DataSource = r.MultipleData(sql).Tables["tbl"];
            sql = "Select Count(*) from survey where ArrivalID=1 and Q3<>0 group by Q3 order by Q3 asc ";
            q4auhs.DataSource = r.MultipleData(sql).Tables["tbl"];
            sql = "Select Count(*) from survey where ArrivalID=3 and Q3<>0 group by Q3 order by Q3 asc ";
            q4bahh.DataSource = r.MultipleData(sql).Tables["tbl"];
            sql = "Select Count(*) from survey where ArrivalID=5 and Q3<>0 group by Q3 order by Q3 asc ";
            q4doh.DataSource = r.MultipleData(sql).Tables["tbl"];
            sql = "Select Count(*) from survey where ArrivalID=6 and Q3<>0 group by Q3 order by Q3 asc ";
            q4ryu.DataSource = r.MultipleData(sql).Tables["tbl"];
            sql = "Select Count(*) from survey where ArrivalID=2 and Q3<>0 group by Q3 order by Q3 asc ";
            q4cai.DataSource = r.MultipleData(sql).Tables["tbl"];

        }
        private void Q4()
        {
            sql = "Select Count(*) from survey where Gender='M' and Q4<>0 group by Q4 order by Q4 asc ";
            q3male.DataSource = r.MultipleData(sql).Tables["tbl"];
            sql = "Select Count(*) from survey where Gender='F' and Q4<>0 group by Q4 order by Q4 asc ";
            q3fem.DataSource = r.MultipleData(sql).Tables["tbl"];
            sql = "Select Count(*) from survey where Age between 18 and 24 and Q4<>0 group by Q4 order by Q4 asc ";
            q3188.DataSource = r.MultipleData(sql).Tables["tbl"];
            sql = "Select Count(*) from survey where Age between 25 and 39 and Q4<>0 group by Q4 order by Q4 asc ";
            q3244.DataSource = r.MultipleData(sql).Tables["tbl"];
            sql = "Select Count(*) from survey where Age between 40 and 59 and Q4<>0 group by Q4 order by Q4 asc ";
            q3400.DataSource = r.MultipleData(sql).Tables["tbl"];
            sql = "Select Count(*) from survey where Age >=60 and Q4<>0 group by Q4 order by Q4 asc ";
            q3600.DataSource = r.MultipleData(sql).Tables["tbl"];
            sql = "Select Count(*) from survey where CabinID =1 and Q4<>0 group by Q4 order by Q4 asc ";
            q3eco.DataSource = r.MultipleData(sql).Tables["tbl"];
            sql = "Select Count(*) from survey where CabinID =2 and Q4<>0 group by Q4 order by Q4 asc ";
            q3busi.DataSource = r.MultipleData(sql).Tables["tbl"];
            sql = "Select Count(*) from survey where CabinID =3 and Q4<>0 group by Q4 order by Q4 asc ";
            q3first.DataSource = r.MultipleData(sql).Tables["tbl"];
            sql = "Select Count(*) from survey where ArrivalID=1 and Q4<>0 group by Q4 order by Q4 asc ";
            q3auh.DataSource = r.MultipleData(sql).Tables["tbl"];
            sql = "Select Count(*) from survey where ArrivalID=3 and Q4<>0 group by Q4 order by Q4 asc ";
            q3bah.DataSource = r.MultipleData(sql).Tables["tbl"];
            sql = "Select Count(*) from survey where ArrivalID=5 and Q4<>0 group by Q4 order by Q4 asc ";
            q3doh.DataSource = r.MultipleData(sql).Tables["tbl"];
            sql = "Select Count(*) from survey where ArrivalID=6 and Q4<>0 group by Q4 order by Q4 asc ";
            q3ryu.DataSource = r.MultipleData(sql).Tables["tbl"];
            sql = "Select Count(*) from survey where ArrivalID=2 and Q4<>0 group by Q4 order by Q4 asc ";
            q3cai.DataSource = r.MultipleData(sql).Tables["tbl"];

        }
    }
}