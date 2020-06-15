using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HW_7
{
    public partial class Form1 : Form
    {
        Service service = new Service();
        Queue <Female> signalWomen = new Queue<Female>();
        public Form1()
        {
            InitializeComponent();

            service.AddSignalMen(); //insert men to the list from men.txt
            service.AddSignalWomen();//insert women to queue from women.txt

            ShowSaveBotunns(false);

            PrintWomenNameChart();
        }

        private void lblTitleCouplesChart_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void PrintWomenNameChart()
        {
            foreach (Female female in service.females)
                lstbxWomenNameChart.Items.Add(female.GetFirstAndLast());
        }

        private void btnFindMatch_Click(object sender, EventArgs e) //button FIND A MATCH
        {
            if (service.females.Count == 0) //if the q of the females is empty
            {
                btnFindMatch.Visible = false; //hide bottun Find Match

                //show and sort couples:
                lstbxCouplesChart.Items.Clear();
                service.couples.Sort();
                foreach (Couple couple in service.couples)
                    lstbxCouplesChart.Items.Add(couple.ToString());

                //show signal males:
                foreach (Male male in service.males)
                    lstbxSignalMenChart.Items.Add(male.GetLnFNameAndDis());

                ShowSaveBotunns(true);//show save buttons


            }
            else
            {
                if (service.FindAMatch())
                {
                    lstbxCouplesChart.Items.Add(service.couples[service.couples.Count - 1].ToString());
                    service.females.Dequeue();
                }
                else
                {
                    MessageBox.Show("No match found for " + service.females.Peek().GetFirstAndLast());
                    signalWomen.Enqueue(service.females.Peek());
                    lstbxSignalWomenChart.Items.Add(service.females.Dequeue().GetFnLNameAndKids());
                }
            }
        }

        public void ShowSaveBotunns(bool bool1)
        {
            rdbtnCouples.Visible = bool1;
            rdbtnSignalMen.Visible = bool1;
            rdbtnSignalWomen.Visible = bool1;
            btnSave.Visible = bool1;
            lblTitleSaveTofile.Visible = bool1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!rdbtnSignalMen.Checked && !rdbtnSignalWomen.Checked && !rdbtnCouples.Checked)//user push to save but didnt choose file
            {
                MessageBox.Show("Please choose an option- save men,women,couples to file");
            }
            else
            {
                if (rdbtnSignalMen.Checked) // signal men button
                {
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(@"C:\Users\kfirg\OneDrive - Ruppin Academic Center\מונחה עצמים C#\מטלות בית\מטלה 7 עד 26.6\HW_7\HW_7\signal_men.txt"))
                        {
                            foreach (Male male in service.males)
                                sw.WriteLine(male.ToString());
                        }
                    }
                    catch (Exception e1)
                    {
                        Console.WriteLine("Could NOT find the file" + e1.Message);
                    }
                    rdbtnSignalMen.Checked = false;
                    rdbtnSignalMen.Visible = false;
                }
                if (rdbtnSignalWomen.Checked) //signal women button
                {
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(@"C:\Users\kfirg\OneDrive - Ruppin Academic Center\מונחה עצמים C#\מטלות בית\מטלה 7 עד 26.6\HW_7\HW_7\signal_women.txt"))
                        {
                            foreach (Female female in signalWomen)
                                sw.WriteLine(female.ToString());
                        }
                    }
                    catch (Exception e2)
                    {
                        Console.WriteLine("Could NOT find the file" + e2.Message);
                    }
                    rdbtnSignalWomen.Checked = false;
                    rdbtnSignalWomen.Visible = false;
                }
                if (rdbtnCouples.Checked) //couples button
                {
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(@"C:\Users\kfirg\OneDrive - Ruppin Academic Center\מונחה עצמים C#\מטלות בית\מטלה 7 עד 26.6\HW_7\HW_7\couples.txt"))
                        {
                            foreach (Couple couple in service.couples)
                                sw.WriteLine(couple.ToString());
                        }
                    }
                    catch (Exception e3)
                    {
                        Console.WriteLine("Could NOT find the file" + e3.Message);
                    }
                    rdbtnCouples.Checked = false;
                    rdbtnCouples.Visible = false;
                }
            }
        }
    }
}
