using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;

namespace WorkFlowDesigner.Forms
{
    public partial class AddCondition : DevExpress.XtraEditors.XtraForm
    {
        List<string[]> a = new List<string[]>();
        Step step;
        IList<Attributes> listAtributes;
        List<SingleCondition> listCondition = new List<SingleCondition>();
        int selected = -1;
        List<Label> label = new List<Label>();
        List<Operator> logic = new List<Operator>();
        
        public AddCondition()
        {
            InitializeComponent();
        }
        public AddCondition(Step s,IList<Attributes>a)
        {
            InitializeComponent();
            step = s;
            tbLogic.KeyDown += TbLogic_KeyDown;
            listAtributes = a;
        }

        private void TbLogic_KeyDown(object sender, KeyEventArgs e)
        {
            if (tbLogic.Focused && e.KeyCode == Keys.Enter)
            {
                TbLogic_LostFocus(null, null);
            }
        }
        public List<string[]> Condition()
        {
            List<string[]> a = new List<string[]>();
            foreach(var item in listCondition)
            {
                if (logic.Count==0||logic.First()._index_start > listCondition.IndexOf(item)
                   ||logic.First()._index_end < listCondition.IndexOf(item))
                {
                    if (listCondition.IndexOf(item) != 0) a.Add(new string[] { "&", "" });
                    a.Add(new string[]{ item.Condition()[0,0], item.Condition()[0, 1]});
                    a.Add(new string[] { item.Condition()[1, 0], item.Condition()[1, 1] });
                }
                else
                {
                    if((listCondition.IndexOf(item) != 0)&&(listCondition.IndexOf(item)==logic.First()._index_start))
                        a.Add(new string[] { "&", "" });
                    else if (listCondition.IndexOf(item) != 0) a.Add(new string[] { logic.First()._operator, "" });

                  if
                        (listCondition.IndexOf(item)==logic.First()._index_start)  a.Add(new string[] {"(", item.Condition()[0, 1] });
                  else
                        a.Add(new string[] { listCondition.IndexOf(item) == logic.First()._index_end ? ")" : item.Condition()[0, 0], item.Condition()[0, 1] });
                        a.Add(new string[] {item.Condition()[1, 0], item.Condition()[1, 1] });
                        if (listCondition.IndexOf(item) == logic.First()._index_end) logic.RemoveAt(0);
                }
            }
            return a;
        }
 

        private void button1_Click(object sender, EventArgs e)
        {
            listCondition.Add(new SingleCondition(lcLayout, listAtributes));
            listCondition.Last().lci[0].MouseDown += AddCondition_MouseDown;
            
        }

        private void AddCondition_MouseDown(object sender, MouseEventArgs e)
        {
            
             if (e.Button == MouseButtons.Right)
             {
                if (selected == -1)
                {
                    foreach (var cond in listCondition)
                    {
                        if (sender as LayoutControlItem == cond.lci[0])
                        {
                            selected = listCondition.IndexOf(cond);
                            cond.lci[0].Control.BackColor = Color.HotPink;
                            cond.lci[1].Control.BackColor = Color.HotPink;
                            cond.lci[2].Control.BackColor = Color.HotPink;
                            logic.Add(new Operator());
                            logic.Last()._index_start = selected;

                        }
                    }
                    return;
                }
                else
                {
                    foreach (var cond in listCondition)
                    {
                        if (sender as LayoutControlItem == cond.lci[0])
                        {
                            label.Add(new Label());
                            this.Controls.Add(label.Last());
                            label.Last().Location = new Point(7, 46+25*selected);
                            label.Last().Text = "[";
                            tbLogic.Location =new Point (325, 48+25*listCondition.IndexOf(cond));
                            tbLogic.Text = "";
                            tbLogic.Visible = true;
                            tbLogic.LostFocus += TbLogic_LostFocus;
                            logic.Last()._index_end = listCondition.IndexOf(cond);

;                        }
                    }
                }
             }
            
        }

        private void TbLogic_LostFocus(object sender, EventArgs e)
        {
            if (selected == -1) return;
            label.Add(new Label());
            this.Controls.Add(label.Last());
            label.Last().Text = "] "+tbLogic.Text;
            label.Last().Location=tbLogic.Location;
            listCondition.ElementAt(selected).lci[0].Control.BackColor = Color.White;
            listCondition.ElementAt(selected).lci[1].Control.BackColor = Color.White;
            listCondition.ElementAt(selected).lci[2].Control.BackColor = Color.White;
            selected = -1;
            tbLogic.Visible = false;
            logic.Last()._operator = tbLogic.Text;

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
        }
      

        private void button2_Click(object sender, EventArgs e)
        {
            string b = "";
            a = Condition();
            foreach(var item in a)
            {
                b += item[0];
                b += item[1];                                   
            }
            MessageBox.Show(b);
            Parser parser = new Parser();
            List<string[]> ac = parser.Condition(b);
            string d="";
            foreach (var item in ac)
            {
                d += item[0];
                d += item[1];
            }
            MessageBox.Show(d);

        }
    }
    public class Operator
    {
        public int _index_start;
        public int _index_end;
        public string _operator;
        public Operator(int index_start,int index_end,string op)
        {
            _index_start = index_start;
            _index_end = index_end;
            _operator = op;
        }
        public Operator() { }
    }
    public class SingleCondition
    {
        
        System.Windows.Forms.ComboBox atributes;
        System.Windows.Forms.ComboBox operators;
        string [] operators1 = new string[] { ">", ">=", "=", "<", "<=", "!=" };
        string[] operators2 = new string[] { "true", "false" };
        string[] operators3 = new string[] { "=", "!=", };
        public LayoutControlItem[] lci = new LayoutControlItem[3];
        LayoutControl lay;

        TextBox condition;
        System.Windows.Forms.ComboBox cbCondition;
        IList<Attributes> list;
        public SingleCondition(LayoutControl lay, IList<Attributes> list)
        {
            lci[0] = new LayoutControlItem();
            lci[0].Text = " ";

            lci[1] = new LayoutControlItem();
            lci[1].Text = " ";
            lci[2] = new LayoutControlItem();
            lci[2].Text = " ";
            condition = new TextBox();
            condition.Enabled = true;
            condition.ReadOnly = false;
            condition.Visible = false;
            atributes = new System.Windows.Forms.ComboBox();
            operators = new System.Windows.Forms.ComboBox();
            operators.Items.AddRange(operators1);
            cbCondition = new System.Windows.Forms.ComboBox();
            this.lay = lay;
            cbCondition.Visible = false;
            this.list = list;
            foreach (var item in list)
            {
                atributes.Items.Add(item.Name);
            }

            lay.AddItem(lci[0]);

            atributes.SelectedIndexChanged += Atributes_SelectedIndexChanged;


            lci[0].Control = atributes;

            lay.AddItem(lci[1]);
         
            lci[1].Control = operators;
            lci[1].Move(lci[0], DevExpress.XtraLayout.Utils.InsertType.Right);

            lay.AddItem(lci[2]);
            lci[2].Control = condition;

            lay.Items.Last().Move(lci[1], DevExpress.XtraLayout.Utils.InsertType.Right);
        }
        public string[,] Condition()
        {
            string[,] cond = new string[2,2];
            // if (condition.Text=="") cond[1,1] = condition.Text;
            // else
            cond[1,1] = cbCondition.SelectedItem.ToString();
            cond[1,0] = operators.SelectedItem.ToString();
            cond[0,1] = check_type(atributes.SelectedItem.ToString()).Name;
            cond[0, 0] = "";
           
            return cond;

        }
      private void Atributes_SelectedIndexChanged(object sender, EventArgs e)
      {
            
            
            if (atributes.SelectedItem.ToString() != null && atributes.SelectedItem.ToString() != "")
            {
                
                switch (check_type(atributes.SelectedItem.ToString()).Type)
                {
                    case "int":
                        {
                            lay.BeginUpdate();
                            operators.Items.Clear();
                            operators.Items.AddRange(operators1);
                            lci[2].BeginInit();
                            Control tempC = lci[2].Control;
                            cbCondition.Visible = false;
                            condition.Visible = true;
                            lci[2].Control = condition;
                            if (tempC.GetType() != typeof(TextBox)) tempC.Parent = null;
                            lci[2].EndInit();
                            lay.EndUpdate();
                            break;
                           
                        }
                    case "text":
                        {
                            lay.BeginUpdate();
                            operators.Items.Clear();
                            operators.Items.AddRange(operators3);
                            lci[2].BeginInit();
                            Control tempC = lci[2].Control; 
                            cbCondition.Visible = false;
                            condition.Visible = true;
                            lci[2].Control = condition;
                            
                            if(tempC.GetType()!=typeof(TextBox)) tempC.Parent = null;
                            lci[2].EndInit();
                            lay.EndUpdate();
                            break;
                            

                        }
                    case "checkbox":
                        {
                            lay.BeginUpdate();
                            cbCondition.Visible = true;
                            cbCondition.Items.Clear();
                            cbCondition.Items.AddRange(operators2);
                            operators.Items.Clear();
                            operators.Items.AddRange(operators3);
                            lci[2].BeginInit();
                            Control tempC = lci[2].Control;
                            cbCondition.Visible = true;
                            condition.Visible = false;
                            lci[2].Control = cbCondition;

                            if (tempC.GetType() != typeof(System.Windows.Forms.ComboBox)) tempC.Parent = null;
                            lci[2].EndInit();
                            lay.EndUpdate();
                            break;
                        }
                    case "list":
                        {
                            lay.BeginUpdate();
                           
                            operators.Items.Clear();
                            operators.Items.AddRange(operators3);
                            lci[2].BeginInit();
                            Control tempC = lci[2].Control;
                            cbCondition.Items.Clear();
                            foreach (var item in check_type(atributes.SelectedItem.ToString()).List)
                            {
                                cbCondition.Items.Add(item.Name);
                            }
                            cbCondition.Visible = true;
                            condition.Visible = false;
                            lci[2].Control = cbCondition;
  
                            if (tempC.GetType() != typeof(System.Windows.Forms.ComboBox)) tempC.Parent = null;
                            lci[2].EndInit();
                            lay.EndUpdate();
                            break;
                        }
                }
            }
        }
        public Attributes check_type(string name)
        {
            foreach(var item in list)
            {
                if (item.Name == name)
                    return item;
            }
            return null;
        }
    }
}