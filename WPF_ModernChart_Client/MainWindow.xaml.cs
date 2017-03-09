using System.Windows;
using System.Windows.Controls;
using WPF_ModernChart_Client.ChartControls;
using WPF_ModernChart_Client.HelperClasses;
using WPF_ModernChart_Client.ViewModelsRepository;

// http://www.dotnetcurry.com/wpf/1027/wpf-charts-using-modern-chart-library


namespace WPF_ModernChart_Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// The Constructor set the DataContext of the Window to an object of the ViewModel class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            var vm = new ChartsViewModel();
            DataContext = vm;
        }

        /// <summary>
        /// The method gets executed when the chart is selected from the ComboBox. The method add the
        /// UserControl in the Grid of name grdChartContainer based upon the chart name selected from
        /// the ComboBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstcharttype_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GrdChartContainer.Children.Clear();

            var chartType = Lstcharttype.SelectedItem as ChartNameStore;

            switch (chartType?.Name)
            {
                case "PieChart":
                    var pie = new PieChartUserControl { DataContext = GrdChartContainer.DataContext };
                    GrdChartContainer.Children.Add(pie);
                    break;

                case "ClusteredColumnChart":
                    var ccchart = new ClusteredColumnChartUserControl { DataContext = GrdChartContainer.DataContext };
                    GrdChartContainer.Children.Add(ccchart);
                    break;

                case "ClusteredBarChart":
                    var cbchart = new ClusteredBarChartUserControl { DataContext = GrdChartContainer.DataContext };
                    GrdChartContainer.Children.Add(cbchart);
                    break;

                case "DoughnutChart":
                    var dnchart = new DoughnutChartUserControl { DataContext = GrdChartContainer.DataContext };
                    GrdChartContainer.Children.Add(dnchart);
                    break;

                case "StackedColumnChart":
                    var stcchart = new StackedColumnChartUserControl { DataContext = GrdChartContainer.DataContext };
                    GrdChartContainer.Children.Add(stcchart);
                    break;

                case "StackedBarChart":
                    var stbchart = new StackedBarChartUserControl { DataContext = GrdChartContainer.DataContext };
                    GrdChartContainer.Children.Add(stbchart);
                    break;

                case "RadialGaugeChart":
                    var rgchart = new RadialGaugeChartUserControl { DataContext = GrdChartContainer.DataContext };
                    GrdChartContainer.Children.Add(rgchart);
                    break;
            }
        }
    }
}