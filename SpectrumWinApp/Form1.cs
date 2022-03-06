using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SpectrumWinApp
{
    public partial class Form1 : Form
    {

        #region Globals

        private List<PeakAreas> mLstPeakAreas = new List<PeakAreas>();
        private readonly Utilities mUtils = new Utilities();
        private String mLicenseFile = "";

        #endregion

        public Form1()
        {
            this.InitializeComponent();
            this.LoadAppInfo();
        }


        #region Events

        private void txtWavenumber_TextChanged(object sender, EventArgs e)
        {
            this.txtWavenumber.Text = CustomStrings.DeixaSomenteNumeros(txtWavenumber.Text);
        }

        private void txtTransmitance_TextChanged(object sender, EventArgs e)
        {
            this.txtTransmitance.Text = CustomStrings.DeixaSomenteDecimais(txtTransmitance.Text);
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                this.AddPeakArea();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocorreu um erro inesperado. Entre em contato com o administrador");
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                this.ExportCsvFile();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocorreu um erro inesperado. Entre em contato com o administrador");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = null;
            this.mLstPeakAreas.Clear();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Load app info (like version and name)
        /// </summary>
        protected private void LoadAppInfo()
        {
            mLicenseFile = Path.Combine(this.mUtils._DiretorioTemporario, "SpecutrumAppLicenseFile_20220331.lic");

            this.Text = $"Spectrum - V {Application.ProductVersion}";
            if (DateTime.Now >= new DateTime(2022, 03, 31))
            {
                if (!File.Exists(mLicenseFile)) File.Create(mLicenseFile);
                foreach (Control c in this.Controls) c.Enabled = false;
                MessageBox.Show("Licença válida até dia 31/03/2022. Contato o administrador do sistema.", "Licença expirada");
                this.Dispose();
                this.Close();
            }
            else if (File.Exists(mLicenseFile))
            {
                MessageBox.Show("Licença válida até dia 31/03/2022. Contato o administrador do sistema.", "Licença expirada");
                this.Dispose();
                this.Close();
            }

            if (this.dataGridView1.Rows.Count < 0) this.btnExport.Enabled = false;
        }

        /// <summary>
        /// Function that save the entry values inside a global list
        /// </summary>
        protected private void AddPeakArea()
        {
            Double waveNumber = Convert.ToDouble(txtWavenumber.Text);
            Double transmitance = Convert.ToDouble(txtTransmitance.Text);
            Double filterValue = this.CalculateFilter(transmitance);
            Double derivative = this.CalculateDerivative(transmitance, waveNumber);

            mLstPeakAreas.Add(new PeakAreas()
            {
                WaveNumber = waveNumber,
                Transmitance = transmitance,
                Filter = filterValue,
                Derivative = derivative
            });

            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = mLstPeakAreas;

            this.txtWavenumber.Text = "0";
            this.txtTransmitance.Text = "0.0";

            this.btnExport.Enabled = this.dataGridView1.Rows.Count > 0 && this.btnExport.Enabled;
        }

        /// <summary>
        /// Calculate filter 1 field if the global variable 'mLstPeakAreas' has more than one value.
        /// </summary>
        /// <param name="Transmitance">Value of current transmitance</param>
        /// <returns></returns>
        protected private Double CalculateFilter(Double Transmitance)
        {
            return this.mLstPeakAreas.Count() <= 0 ? 0.0 : this.mLstPeakAreas[this.mLstPeakAreas.Count() - 1].Transmitance - Transmitance;
        }

        /// <summary>
        /// Calculate derivative field if the global variable 'mLstPeakAreas' has more than one value.
        /// </summary>
        /// <param name="Transmitance">Value of current transmitance</param>
        /// <returns></returns>
        protected private Double CalculateDerivative(Double Transmitance, Double Wavenumber)
        {
            Double diffTransmitance = this.mLstPeakAreas.Count() <= 0 ? 0.0 : this.mLstPeakAreas[mLstPeakAreas.Count() - 1].Transmitance - Transmitance;
            Double diffWavenumber = this.mLstPeakAreas.Count() <= 0 ? 0.0 : this.mLstPeakAreas[mLstPeakAreas.Count() - 1].WaveNumber - Wavenumber;
            return (diffTransmitance == diffWavenumber) ? 0.0 : (diffWavenumber == 0.0 ? 0.0 : (diffTransmitance / diffWavenumber));
        }

        /// <summary>
        /// Export data grid rows to a CSV file in desktop
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private void ExportCsvFile()
        {
            String csvFileDir = Path.Combine(mUtils._DiretorioDesktop, $"Spectrum - {DateTime.Now.ToString("dd.MM.yyyy")}.csv");

            String content = "Wavenumber (cm-1);Transmitance  (%);Filter 1;Derivative\n";

            foreach (PeakAreas p in mLstPeakAreas) content += $"{p.WaveNumber};{p.Transmitance};{p.Filter};{p.Derivative}\n";

            if (!String.IsNullOrEmpty(content))
            {
                File.WriteAllText(csvFileDir, content);
                MessageBox.Show($"Arquivo exportado com êxito em '{csvFileDir}'", "Arquivo exportado com êxito");
            }
        }

        #endregion
    }
}