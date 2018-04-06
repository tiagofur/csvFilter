using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using ADODB;

namespace csvFilter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            populateSeparator();
        }

        string[] filterCSV;
        string[] filterExport;
        string[] columnFilter;

        string separator;
        int filterColumm;

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();

            fdlg.Title = "Select file";

            fdlg.InitialDirectory = @"c:\";

            fdlg.FileName = textBoxFileCSV.Text;

            fdlg.Filter = "Text and CSV Files(*.txt, *.csv)|*.txt;*.csv|Text Files(*.txt)|*.txt|CSV Files(*.csv)|*.csv|All Files(*.*)|*.*";

            fdlg.FilterIndex = 1;

            fdlg.RestoreDirectory = true;

            if (fdlg.ShowDialog() == DialogResult.OK)

            {

                textBoxFileCSV.Text = fdlg.FileName;

                Import();

                Application.DoEvents();

                populateColumnFilter();
            }
        }

        public static DataTable GetDataTable(string strFileName)
        {
            Connection oConn = new Connection();
            oConn.Open("Provider=Microsoft.Jet.OleDb.4.0; Data Source = " + Path.GetDirectoryName(strFileName) + "; Extended Properties = \"Text;HDR=YES;FMT=Delimited\";", "", "", 0);
            string strQuery = "SELECT * FROM [" + Path.GetFileName(strFileName) + "]";
            Recordset rs = new Recordset();
            System.Data.OleDb.OleDbDataAdapter adapter = new System.Data.OleDb.OleDbDataAdapter();
            DataTable dt = new DataTable();
            rs.Open(strQuery, "Provider=Microsoft.Jet.OleDb.4.0; Data Source = " + Path.GetDirectoryName(strFileName) + "; Extended Properties = \"Text;HDR=YES;FMT=Delimited\";",
            CursorTypeEnum.adOpenForwardOnly, LockTypeEnum.adLockReadOnly, 1);
            adapter.Fill(dt, rs);
            return dt;
        }

        private void Import()
        {
            if (textBoxFileCSV.Text.Trim() != string.Empty)
            {
                try
                {
                    DataTable dt = GetDataTable(textBoxFileCSV.Text);
                    dataGridViewDadosCSV.DataSource = dt.DefaultView;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void populateColumnFilter()
        {
            columnFilter = new string[dataGridViewDadosCSV.Columns.Count];

            for (int columns = 0; columns < dataGridViewDadosCSV.Columns.Count; columns++)
            {
                columnFilter[columns] = dataGridViewDadosCSV.Columns[columns].HeaderText;
            }

            comboBoxColum.DataSource = columnFilter;
        }

        private void populateSeparator()
        {
            String[] myArray = { ";", "," };
            comboBoxSeparador.DataSource = myArray;
            //comboBoxSeparador.SelectedValueChanged += new EventHandler(this.comboBoxSeparador_SelectedValueChanged);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            createFilterExport();

            for (int i = 0; i < filterCSV.Length-1; i++)
            {
                guardarCSVFiltrado(filterCSV[i]);
            }

            messageFinish();
        }

        private void createFilterExport()
        {
            filterExport = new string[dataGridViewDadosCSV.Rows.Count];

            for (int rows = 0; rows < dataGridViewDadosCSV.Rows.Count - 1; rows++)
            {
                filterExport[rows] = dataGridViewDadosCSV[filterColumm, rows].Value.ToString();
            }

            HashSet<string> set = new HashSet<string>(filterExport);
            filterCSV = new string[set.Count];
            set.CopyTo(filterCSV);
        }
        
        private void guardarCSVFiltrado(string filter)
        {
            string archivo = textBoxFileCSV.Text.Substring(0, textBoxFileCSV.Text.Length - 4);
            string fileExportName = archivo + "_" + filter + ".csv";

            // create one file gridview.csv in writing mode using streamwriter
            StreamWriter sw = new StreamWriter(fileExportName);
            // now add the gridview header in csv file suffix with "," delimeter except last one
            for (int i = 0; i < dataGridViewDadosCSV.Columns.Count; i++)
            {
                sw.Write(dataGridViewDadosCSV.Columns[i].HeaderText);
                if (i != dataGridViewDadosCSV.Columns.Count)
                {
                    sw.Write(separator);
                }
            }
            // add new line
            sw.Write(sw.NewLine);
            // iterate through all the rows within the gridview
            for (int i = 0; i < dataGridViewDadosCSV.Rows.Count; i++)
            {
                if (filter == filterExport[i])
                {
                    // iterate through all colums of specific row
                    for (int j = 0; j < dataGridViewDadosCSV.Columns.Count; j++)
                    {
                        // write particular cell to csv file
                        sw.Write(dataGridViewDadosCSV[j, i].Value);
                        if (j != dataGridViewDadosCSV.Columns.Count)
                        {
                            sw.Write(separator);
                        }
                    }
                }
                if (filter == filterExport[i])
                {
                    // write new line
                    sw.Write(sw.NewLine);
                }
                
            }
            // flush from the buffers.
            sw.Flush();
            // closes the file
            sw.Close();
        }

        private void messageFinish()
        {
            string message = "Archivos generados con successo!";
            string caption = "Deseas hacer el filtro de otro archivo?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);

            if (result == DialogResult.Yes)
            {
                dataGridViewDadosCSV.DataSource = null;
                dataGridViewDadosCSV.Rows.Clear();
                textBoxFileCSV.Clear();
            }
            if (result == DialogResult.No)
            {
                Application.Exit();
            }
        }

        private void comboBoxColum_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterColumm = comboBoxColum.SelectedIndex;
        }

        private void comboBoxSeparador_SelectedIndexChanged(object sender, EventArgs e)
        {
            separator = comboBoxSeparador.Text;
        }
    }
}
