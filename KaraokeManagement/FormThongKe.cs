using OxyPlot.Axes;
using OxyPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OxyPlot.Series;
using KaraokeManagement.Model;
using OxyPlot.WindowsForms;

namespace KaraokeManagement
{
    public partial class FormThongKe : Form
    {
        private OxyPlot.WindowsForms.PlotView plotView;
        public FormThongKe()
        {
            InitializeComponent();
            cbbThang.SelectedItem = DateTime.Now.Month.ToString();
            txtNam.Text = DateTime.Now.Year.ToString();
            InitializePlot();
        }
        private void InitializePlot()
        {
            int desiredMonth = Convert.ToInt32(cbbThang.SelectedItem);
            int desiredYear = Convert.ToInt32(txtNam.Text);
            using (var context = new KaraDB())
            {
                var bookings = context.Bookings
                    .Where(b => b.CheckInDate.Month == desiredMonth && b.CheckInDate.Year == desiredYear && b.Status.Equals("Đã thanh toán!"))
                    .ToList();

                // Group bookings by day and calculate the total amount for each day
                var dailyAmounts = bookings
                    .GroupBy(b => b.CheckInDate.Date)
                    .Select(group => new
                    {
                        Date = group.Key,
                        TotalAmount = group.Sum(b => b.TotalAmount)
                    })
                    .ToList();

                var dataPoints = new List<DataPoint>();
                for (int day = 1; day <= 31; day++)
                {
                    // Check if there is data for the current day
                    var dailyAmount = dailyAmounts.FirstOrDefault(da => da.Date.Day == day);

                    if (dailyAmount != null)
                    {
                        // If there is data, add it to the list
                        dataPoints.Add(new DataPoint(day, Math.Floor((double)dailyAmount.TotalAmount)));
                    }
                    else
                    {
                        // If there is no data, add a new DataPoint with TotalAmount = 0
                        dataPoints.Add(new DataPoint(day, 0));
                    }
                }
                // Tạo đối tượng PlotView
                plotView = new OxyPlot.WindowsForms.PlotView();
                plotView.Dock = DockStyle.Fill;

                // Tạo dữ liệu mẫu



                // Tạo loại biểu đồ
                var lineSeries = new LineSeries
                {
                    Title = "Doanh thu hằng ngày",
                    MarkerType = MarkerType.Circle,
                    MarkerSize = 5,
                    MarkerStroke = OxyColors.White,
                    MarkerFill = OxyColors.Blue,
                };

                // Thêm dữ liệu vào loại biểu đồ
                lineSeries.Points.AddRange(dataPoints);

                // Thêm loại biểu đồ vào PlotModel
                var plotModel = new PlotModel
                {
                    Title = "Biểu đồ Doanh thu hằng ngày trong tháng",
                    Axes =
                {
                    new LinearAxis { Position = AxisPosition.Bottom, Title = "Ngày" },
                    new LinearAxis { Position = AxisPosition.Left, Title = "Doanh thu" }
                },

                };
                plotModel.Series.Add(lineSeries);

                // Đặt PlotModel cho PlotView
                plotView = new OxyPlot.WindowsForms.PlotView
                {
                    Model = plotModel,
                    Dock = DockStyle.Top,
                    Size = new Size(800, 600)
                };
                // Thêm PlotView vào Form
                Controls.Add(plotView);

            }
        }

        private void cbbThang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
            if (plotView != null)
            {
                Controls.Remove(plotView);
            }
            InitializePlot();
        }
    }
}
