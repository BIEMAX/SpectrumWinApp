using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpectrumWinApp
{
    public partial class Form1 : Form
    {

        #region Globals

        private List<PeakAreas> mLstPeakAreas = new List<PeakAreas>();
        private DataTable mDados = new DataTable();

        #endregion

        public Form1()
        {
            InitializeComponent();
            LoadAppInfo();
        }


        #region Events

        private void txtWavenumber_TextChanged(object sender, EventArgs e)
        {
            txtWavenumber.Text = CustomStrings.DeixaSomenteNumeros(txtWavenumber.Text);
        }

        private void txtTransmitance_TextChanged(object sender, EventArgs e)
        {
            txtTransmitance.Text = CustomStrings.DeixaSomenteDecimais(txtTransmitance.Text);
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                AddPeakArea();
            }
            catch (Exception ex) { }
        }

        #endregion

        #region Methods

        protected private void LoadAppInfo()
        {
            this.Text = $"Spectrum - V {Application.ProductVersion}";
            if (DateTime.Now >= new DateTime(2022, 03, 31))
            {
                foreach(Control c in this.Controls) c.Enabled = false;
                MessageBox.Show("Licença válida até dia 31/03/2022", "Licença expirada");
                this.Dispose();
                this.Close();
            }
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

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = mLstPeakAreas;

            txtWavenumber.Text = "0";
            txtTransmitance.Text = "0.0";
        }

        /// <summary>
        /// Calculate filter 1 field if the global variable 'mLstPeakAreas' has more than one value.
        /// </summary>
        /// <param name="Transmitance">Value of current transmitance</param>
        /// <returns></returns>
        protected private Double CalculateFilter(Double Transmitance)
        {
            return mLstPeakAreas.Count() <= 0 ? 0.0 : mLstPeakAreas[mLstPeakAreas.Count() - 1].Transmitance - Transmitance;
        }

        /// <summary>
        /// Calculate derivative field if the global variable 'mLstPeakAreas' has more than one value.
        /// </summary>
        /// <param name="Transmitance">Value of current transmitance</param>
        /// <returns></returns>
        protected private Double CalculateDerivative(Double Transmitance, Double Wavenumber)
        {
            Double diffTransmitance = mLstPeakAreas.Count() <= 0 ? 0.0 : mLstPeakAreas[mLstPeakAreas.Count() - 1].Transmitance - Transmitance;
            Double diffWavenumber = mLstPeakAreas.Count() <= 0 ? 0.0 : mLstPeakAreas[mLstPeakAreas.Count() - 1].WaveNumber - Wavenumber;
            return diffTransmitance == diffWavenumber ? 0.0 : (diffTransmitance/diffWavenumber);
        }

        #endregion
    }
}