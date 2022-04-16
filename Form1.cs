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
    public partial class Flight : Form
    {

        String sql;
        SQLConnect r = new SQLConnect();
        public Flight()
        {
            InitializeComponent();
        }

        private void viewresuls_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sql = @"Select Top 1
            (Select Count(*) from survey where Gender='M') as [Male],
            (Select Count(*) from survey where Gender='F') as [Female],
            (Select Count(*) from survey where Age between 18 and 24) as [18-24],
            (Select Count(*) from survey where Age between 25 and 39) as [25-39],
            (Select Count(*) from survey where Age between 40 and 59) as [40-59],
            (Select Count(*) from survey where Age >=60) as [60+],
            (Select Count(*) from survey where CabinID=1) as [Economy],
            (Select Count(*) from survey where CabinID=2) as [Business],
            (Select Count(*) from survey where CabinID=3) as [First Class],
            (Select Count(*) from survey where ArrivalID=1) as [AUH],
            (Select Count(*) from survey where ArrivalID=3) as [BAH],
            (Select Count(*) from survey where ArrivalID=5) as [DOH],
            (Select Count(*) from survey where ArrivalID=6) as [RYU],
            (Select Count(*) from survey where ArrivalID=2) as [CAI]
            from survey 
            inner join Airports on survey.ArrivalID=Airports.ID 
            inner join Month on survey.MonthID=Month.ID
            where MonthID between 5 and 7";
            dataGridView1.DataSource = r.MultipleData(sql).Tables["tbl"];
        }

        private void Flight_Load(object sender, EventArgs e)
        {
            sql = @"Select Top 1 Name from Month
                where ID Between 5 and 7 order by Name asc";
            r.DisplaySingle(sql);
            lblMonth2.Text = r.getf1();
            sql = @"Select Top 1 Name from Month
                where ID Between 5 and 7 order by Name desc";
            r.DisplaySingle(sql);
           
            lblmont1.Text = r.getf1();

            sql = "Select count(ID) from Survey";
            r.DisplaySingle(sql);
            size.Text = r.getf1();
        }

        private void Exit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Detailed a = new Detailed();
            a.Show();
            this.Hide();
        }
    }
}
