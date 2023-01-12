using Infragistics.Win.UltraWinGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UltraGrid_BindingList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            BindingList<ChildClass> children1 = new BindingList<ChildClass>();
            children1.Add(new ChildClass() { ID = 100, Name = "Child 0"});
            children1.Add(new ChildClass() { ID = 101, Name = "Child 1" });

            BindingList<ChildClass> children2 = new BindingList<ChildClass>();
            children2.Add(new ChildClass() { ID = 102, Name = "Child 2" });

            BindingList<DataClass> list = new BindingList<DataClass>();
            list.Add(new DataClass() { ID = 0, Name = "テスト1", Children1 = children1 });
            list.Add(new DataClass() { ID = 1, Name = "テスト2", Children1 = children2 });

            ultraGrid1.DataSource = list;
        }
    }

    public class DataClass
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public BindingList<ChildClass> Children1 { get; set; }
    }

    public class ChildClass
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
