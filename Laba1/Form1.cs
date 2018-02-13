using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba1
{
    public partial class Form1 : Form
    {
        DataSet Animals;
        double[,] tvoia_mamka =
       {{5.1, 3.5, 1.4, 0.2},
        {4.9, 3.0, 1.4, 0.2},
        {4.7, 3.2, 1.3, 0.2},
        {4.6, 3.1, 1.5, 0.2},
        {5.0, 3.6, 1.4, 0.2},
        {5.4, 3.9, 1.7, 0.4},
        {4.6, 3.4, 1.4, 0.3},
        {5.0, 3.4, 1.5, 0.2},
        {4.4, 2.9, 1.4, 0.2},
        {4.9, 3.1, 1.5, 0.1},
        {5.4, 3.7, 1.5, 0.2},
        {4.8, 3.4, 1.6, 0.2},
        {4.8, 3.0, 1.4, 0.1},
        {4.3, 3.0, 1.1, 0.1},
        {5.8, 4.0, 1.2, 0.2},
        {5.7, 4.4, 1.5, 0.4},
        {5.4, 3.9, 1.3, 0.4},
        {5.1, 3.5, 1.4, 0.3},
        {5.7, 3.8, 1.7, 0.3},
        {5.1, 3.8, 1.5, 0.3},
        {5.4, 3.4, 1.7, 0.2},
        {5.1, 3.7, 1.5, 0.4},
        {4.6, 3.6, 1.0, 0.2},
        {5.1, 3.3, 1.7, 0.5},
        {4.8, 3.4, 1.9, 0.2},
        {5.0, 3.0, 1.6, 0.2},
        {5.0, 3.4, 1.6, 0.4},
        {5.2, 3.5, 1.5, 0.2},
        {5.2, 3.4, 1.4, 0.2},
        {4.7, 3.2, 1.6, 0.2},
        {4.8, 3.1, 1.6, 0.2},
        {5.4, 3.4, 1.5, 0.4},
        {5.2, 4.1, 1.5, 0.1},
        {5.5, 4.2, 1.4, 0.2},
        {4.9, 3.1, 1.5, 0.1},
        {5.0, 3.2, 1.2, 0.2},
        {5.5, 3.5, 1.3, 0.2},
        {4.9, 3.1, 1.5, 0.1},
        {4.4, 3.0, 1.3, 0.2},
        {5.1, 3.4, 1.5, 0.2},
        {5.0, 3.5, 1.3, 0.3},
        {4.5, 2.3, 1.3, 0.3},
        {4.4, 3.2, 1.3, 0.2},
        {5.0, 3.5, 1.6, 0.6},
        {5.1, 3.8, 1.9, 0.4},
        {4.8, 3.0, 1.4, 0.3},
        {5.1, 3.8, 1.6, 0.2},
        {4.6, 3.2, 1.4, 0.2},
        {5.3, 3.7, 1.5, 0.2},
        {5.0, 3.3, 1.4, 0.2}};

        double[,] tvoia_mamka_takaia =
            {{7.0, 3.2,    4.7,    1.4},
        {6.4,   3.2,    4.5,    1.5},
        {6.9,   3.1,    4.9,    1.5},
        {5.5,   2.3,    4.0,    1.3},
        {6.5,   2.8,    4.6,    1.5},
        {5.7,   2.8,    4.5,    1.3},
        {6.3,   3.3,    4.7,    1.6},
        {4.9,   2.4,    3.3,    1.0},
        {6.6,   2.9,    4.6,    1.3},
        {5.2,   2.7,    3.9,    1.4},
        {5.0,   2.0,    3.5,    1.0},
        {5.9,   3.0,    4.2,    1.5},
        {6.0,   2.2,    4.0,    1.0},
        {6.1,   2.9,    4.7,    1.4},
        {5.6,   2.9,    3.6,    1.3},
        {6.7,   3.1,    4.4,    1.4},
        {5.6,   3.0,    4.5,    1.5},
        {5.8,   2.7,    4.1,    1.0},
        {6.2,   2.2,    4.5,    1.5},
        {5.6,   2.5,    3.9,    1.1},
        {5.9,   3.2,    4.8,    1.8},
        {6.1,   2.8,    4.0,    1.3},
        {6.3,   2.5,    4.9,    1.5},
        {6.1,   2.8,    4.7,    1.2},
        {6.4,   2.9,    4.3,    1.3},
        {6.6,   3.0,    4.4,    1.4},
        {6.8,   2.8,    4.8,    1.4},
        {6.7,   3.0,    5.0,    1.7},
        {6.0,   2.9,    4.5,    1.5},
        {5.7,   2.6,    3.5,    1.0},
        {5.5,   2.4,    3.8,    1.1},
        {5.5,   2.4,    3.7,    1.0},
        {5.8,   2.7,    3.9,    1.2},
        {6.0,   2.7,    5.1,    1.6},
        {5.4,   3.0,    4.5,    1.5},
        {6.0,   3.4,    4.5,    1.6},
        {6.7,   3.1,    4.7,    1.5},
        {6.3,   2.3,    4.4,    1.3},
        {5.6,   3.0,    4.1,    1.3},
        {5.5,   2.5,    4.0,    1.3},
        {5.5,   2.6,    4.4,    1.2},
        {6.1,   3.0,    4.6,    1.4},
        {5.8,   2.6,    4.0,    1.2},
        {5.0,   2.3,    3.3,    1.0},
        {5.6,   2.7,    4.2,    1.3},
        {5.7,   3.0,    4.2,    1.2},
        {5.7,   2.9,    4.2,    1.3},
        {6.2,   2.9,    4.3,    1.3},
        {5.1,   2.5,    3.0,    1.1},
        {5.7,   2.8,    4.1,    1.3}};
        double[,] tvoia_mamka_takaia_neochen =
            {
        {6.3, 3.3, 6.0, 2.5 },
        {5.8, 2.7, 5.1, 1.9 },
        {7.1, 3.0, 5.9, 2.1 },
        {6.3, 2.9, 5.6, 1.8 },
        {6.5, 3.0, 5.8, 2.2 },
        {7.6, 3.0, 6.6, 2.1 },
        {4.9, 2.5, 4.5, 1.7 },
        {7.3, 2.9, 6.3, 1.8 },
        {6.7, 2.5, 5.8, 1.8 },
        {7.2, 3.6, 6.1, 2.5 },
        {6.5, 3.2, 5.1, 2.0 },
        {6.4, 2.7, 5.3, 1.9 },
        {6.8, 3.0, 5.5, 2.1 },
        {5.7, 2.5, 5.0, 2.0 },
        {5.8, 2.8, 5.1, 2.4 },
        {6.4, 3.2, 5.3, 2.3 },
        {6.5, 3.0, 5.5, 1.8 },
        {7.7, 3.8, 6.7, 2.2 },
        {7.7, 2.6, 6.9, 2.3 },
        {6.0, 2.2, 5.0, 1.5 },
        {6.9, 3.2, 5.7, 2.3 },
        {5.6, 2.8, 4.9, 2.0 },
        {7.7, 2.8, 6.7, 2.0 },
        {6.3, 2.7, 4.9, 1.8 },
        {6.7, 3.3, 5.7, 2.1 },
        {7.2, 3.2, 6.0, 1.8 },
        {6.2, 2.8, 4.8, 1.8 },
        {6.1, 3.0, 4.9, 1.8 },
        {6.4, 2.8, 5.6, 2.1 },
        {7.2, 3.0, 5.8, 1.6 },
        {7.4, 2.8, 6.1, 1.9 },
        {7.9, 3.8, 6.4, 2.0 },
        {6.4, 2.8, 5.6, 2.2 },
        {6.3, 2.8, 5.1, 1.5 },
        {6.1, 2.6, 5.6, 1.4 },
        {7.7, 3.0, 6.1, 2.3 },
        {6.3, 3.4, 5.6, 2.4 },
        {6.4, 3.1, 5.5, 1.8 },
        {6.0, 3.0, 4.8, 1.8 },
        {6.9, 3.1, 5.4, 2.1 },
        {6.7, 3.1, 5.6, 2.4 },
        {6.9, 3.1, 5.1, 2.3 },
        {5.8, 2.7, 5.1, 1.9 },
        {6.8, 3.2, 5.9, 2.3 },
        {6.7, 3.3, 5.7, 2.5 },
        {6.7, 3.0, 5.2, 2.3 },
        {6.3, 2.5, 5.0, 1.9 },
        {6.5, 3.0, 5.2, 2.0 },
        {6.2, 3.4, 5.4, 2.3 },
        {5.9, 3.0, 5.1, 1.8 },
        };
        public void add_animal(DataTable table,double a1,double a2, double a3, double a4)
        {
            table.Rows.Add(a1, a2, a3, a4);
        }
        public double Evkl_dist(DataRow row)
        {            
            return Math.Sqrt(Math.Pow((double)row.ItemArray[0] - (double)nUD_pol.Value, 2) + Math.Pow((double)row.ItemArray[1] - (double)nUD_hight.Value, 2) + Math.Pow((double)row.ItemArray[2] - (double)nUD_long.Value, 2) + Math.Pow((double)row.ItemArray[3] - (double)nUD_her.Value, 2));
        }
        public double Hem_dist(DataRow row)
        {
            return Math.Abs((double)row.ItemArray[0] - (double)nUD_pol.Value) + Math.Abs((double)row.ItemArray[1] - (double)nUD_hight.Value) + Math.Abs((double)row.ItemArray[2] - (double)nUD_long.Value) + Math.Abs((double)row.ItemArray[3] - (double)nUD_her.Value);
        }
        public double City_kv(DataRow row)
        {
            double max = Math.Abs((double)row.ItemArray[0] - (double)nUD_pol.Value);
            if (max < Math.Abs((double)row.ItemArray[1] - (double)nUD_hight.Value)) max = Math.Abs((double)row.ItemArray[1] - (double)nUD_hight.Value);
            if (max < Math.Abs((double)row.ItemArray[2] - (double)nUD_long.Value)) max = Math.Abs((double)row.ItemArray[2] - (double)nUD_long.Value);
            if (max < Math.Abs((double)row.ItemArray[3] - (double)nUD_pol.Value)) max = Math.Abs((double)row.ItemArray[3] - (double)nUD_her.Value);
            return  max;
        }
        public void Choise()
        {
            double min_dist = Double.MaxValue, dist = 0;
            string Name = "";
            foreach(DataTable tabl in Animals.Tables)
            {
                foreach(DataRow row in tabl.Rows)
                {
                    if (cb_rast.SelectedIndex == 0)
                    {
                        dist = Evkl_dist(row);
                    }
                    else
                        if (cb_rast.SelectedIndex == 1)
                    {
                        dist = Hem_dist(row);
                    }
                    else
                        dist = City_kv(row);
                    if (dist < min_dist)
                    {
                        min_dist = dist;
                        Name = tabl.TableName;
                    }
                   
                }
            }
            l_name.Text = Name;
        }
        //table.Rows.Add(nUD_pol.Value, nUD_hight.Value, nUD_long.Value);
        public Form1()
        {
            InitializeComponent();
            cb_rast.SelectedIndex = 0;
            Animals = new DataSet("Animals");

            DataTable t_Bee = Animals.Tables.Add("Iris-setosa");
            DataColumn col_bee =
                t_Bee.Columns.Add("sepal length", typeof(double));
            t_Bee.Columns.Add("sepal width", typeof(double));
            t_Bee.Columns.Add("petal length", typeof(double));
            t_Bee.Columns.Add("petal width", typeof(double));
            for (int i = 0; i < tvoia_mamka.Length / 4; i++)
                add_animal(t_Bee, tvoia_mamka[i, 0], tvoia_mamka[i, 1], tvoia_mamka[i, 2], tvoia_mamka[i, 3]);

            DataTable t_zebra = Animals.Tables.Add("Iris-versicolor");
            DataColumn col_zebra =
                t_zebra.Columns.Add("sepal length", typeof(double));
            t_zebra.Columns.Add("sepal width", typeof(double));
            t_zebra.Columns.Add("petal length", typeof(double));
            t_zebra.Columns.Add("petal width", typeof(double));
            for (int i = 0; i < tvoia_mamka_takaia.Length / 4; i++)
                add_animal(t_zebra, tvoia_mamka_takaia[i, 0], tvoia_mamka_takaia[i, 1], tvoia_mamka_takaia[i, 2], tvoia_mamka_takaia[i, 3]);

            DataTable t_tiger = Animals.Tables.Add("Iris-virginica");
            DataColumn col_tiger =
                t_tiger.Columns.Add("sepal length", typeof(double));
            t_tiger.Columns.Add("sepal width", typeof(double));
            t_tiger.Columns.Add("petal length", typeof(double));
            t_tiger.Columns.Add("petal width", typeof(double));
            for (int i = 0; i < tvoia_mamka_takaia_neochen.Length / 4; i++)
                add_animal(t_tiger, tvoia_mamka_takaia_neochen[i, 0], tvoia_mamka_takaia_neochen[i, 1], tvoia_mamka_takaia_neochen[i, 2], tvoia_mamka_takaia_neochen[i, 3]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Choise();
        }
    }
}
