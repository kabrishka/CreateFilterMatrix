using System;
using System.Collections.Generic;
using System.ComponentModel;
using SD = System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data;

using Excel = Microsoft.Office.Interop.Excel;
using ExcelDataReader;


namespace KC_20_Gimalova_lab8.Forms
{
    public partial class Filters : Form
    {
        private string filePath;
        private DataTableCollection tableCollection = null;
        public Filters()
        {
            InitializeComponent();
        }

        private void Filters_Load(object sender, EventArgs e)
        {
            addItemsToComboBox(boxFilters);

            try
            {
                double[,] array = new double[DataBank.valueRows, DataBank.valueCols];
                for (int i = 0; i < DataBank.valueRows; i++)
                {
                    for (int j = 0; j < DataBank.valueCols; j++)
                    {
                        if (i == j)
                        {
                            array[i, j] = 0;
                        }
                        else
                        {
                            array[i, j] = DataBank.k * Math.Pow((-1), (i + j)) + (j / 10);
                        }
                    }
                }

                dataGridView1.RowCount = DataBank.valueRows;
                dataGridView1.ColumnCount = DataBank.valueCols;
                for (int i = 0; i < DataBank.valueRows; i++)
                {
                    for (int j = 0; j < DataBank.valueCols; j++)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = array[i, j];
                    }
                }

                saveTable(dataGridView1);

            }
            catch (Exception)
            {
                MessageBox.Show("Не возможно рассчитать матрицу", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void boxFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                dataGridView1.Rows.Clear();


                DataTable tb = new DataTable();

                Excel.Application ExcelApp = new Excel.Application();
                Excel._Workbook ExcelWorkBook;
                Excel.Worksheet ExcelWorkSheet;

                ExcelWorkBook = ExcelApp.Workbooks.Open(filePath, 0, true, 5, "", "", true, Excel.XlPlatform.xlWindows, "\t", false,
                    false, 0, true, 1, 0);
                ExcelWorkSheet = (Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);

                dataGridView1.RowCount = DataBank.valueRows;
                dataGridView1.ColumnCount = DataBank.valueCols;

                dataGridView1.Rows.Add(1);


                for (int i = 0; i < DataBank.valueRows; i++)
                {
                    for (int j = 0; j < DataBank.valueCols; j++)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = ExcelApp.Cells[i + 1, j + 1].Value;

                        switch (boxFilters.SelectedIndex)
                        {
                            case 0:
                                if (File.Exists(filePath))
                                {
                                    if (double.Parse(ExcelApp.Cells[i + 1, j + 1].Value.ToString()) <= 0)
                                    {
                                        dataGridView1.Rows[i].Cells[j].Value = "*";
                                    }
                                }
                                break;

                            case 1:
                                if (File.Exists(filePath))
                                {
                                    if (double.Parse(ExcelApp.Cells[i + 1, j + 1].Value.ToString()) >= 0)
                                    {
                                        dataGridView1.Rows[i].Cells[j].Value = "*";
                                    }
                                }
                                break;
                            case 2:
                                if (File.Exists(filePath))
                                {
                                    if (double.Parse(ExcelApp.Cells[i + 1, j + 1].Value.ToString()) != 0)
                                    {
                                        dataGridView1.Rows[i].Cells[j].Value = "*";
                                    }
                                }
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не возможно отфильтровать", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //экспорт из dataGridView1
        private void saveTable(DataGridView dgv)
        {
            filePath = Directory.GetCurrentDirectory() + @"\Test.xlsx";

            Excel.Application exApp = new Excel.Application();
            Excel.Workbook wb = exApp.Workbooks.Add();
            Excel.Worksheet wsh = (Excel.Worksheet)exApp.ActiveSheet;

            for (int i = 0; i <= dataGridView1.RowCount - 1; i++)
            {
                for (int j = 0; j <= dataGridView1.ColumnCount - 1; j++)
                {
                    wsh.Cells[i + 1, j + 1] = dataGridView1[j, i].Value.ToString();
                }
            }

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            exApp.AlertBeforeOverwriting = false;
            wb.SaveAs(filePath);
            exApp.Quit();

        }

        private void addItemsToComboBox(ComboBox cb)
        {
            cb.Items.Clear();
            cb.Items.Add("Считывать положительные числа");
            cb.Items.Add("Считывать отрицательные числа");
            cb.Items.Add("Считывать нулевые ячейки");
            cb.Items.Add("Удалить фильтр");
        }

        //импорт из excel файла
        private void openExcelFile(string path)
        {
            FileStream stream = File.Open(path,FileMode.Open, FileAccess.Read);

            IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream);

            DataSet db = reader.AsDataSet(new ExcelDataSetConfiguration()
            {
                ConfigureDataTable = (x) => new ExcelDataTableConfiguration()
                {
                    //для считывания верхней строки
                    UseHeaderRow = false,
                }
            });

            //для добавления всех листов
            tableCollection = db.Tables;

            /*foreach (DataTable table in tableCollection)
            {

            }
*/

        }
        
    }
}
