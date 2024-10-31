using ScottPlot.Plottable;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScottPlot_test
{
    public partial class Form1 : Form
    {
        /* 描画するデータの作成 */
        Random rand = new Random(0);
        double[] pointX = { 1.0, 2.0, 3.0, 4.0, 5.0 };
        double[] pointY = { 1.0, 2.0, 3.0, 4.0, 5.0 };

        public Form1()
        {
            InitializeComponent();

            /* グラフのタイトル・縦/横軸ラベルの設定 */
            formsPlot1.Plot.Title("Signal Plot サンプル");
            formsPlot1.Plot.YAxis.Label(label: "Y軸データ");
            formsPlot1.Plot.XAxis.Label(label: "X軸データ");

            /* データのセット */
            formsPlot1.Plot.AddScatter(pointX, pointY, label: "データ");

            /* 凡例を表示 */
            formsPlot1.Plot.Legend();

            /* グラフ表示の上限下限を設定 */
            formsPlot1.Plot.SetAxisLimits(xMin: 0, xMax: 6, yMin: 0, yMax: 6);
            /* ScottPlotのコントロールに描画 */
            formsPlot1.Render();

        }

        private void update_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < pointY.Length; i++)
            {
                pointY[i] = rand.Next(1, 5);
            }

            /* ScottPlotのコントロールに描画 */
            formsPlot1.Render();
        }
    }
}
